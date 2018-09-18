using LoggingLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoHatControl
{
    public class DataReadClass
    {

        private Communications ComObj;

        public string PortName = "COM4";

        public SerialPort ComPortObj = new SerialPort();

        /// <summary>
        /// Last time data was read (WATCHDOG)
        /// </summary>        
        #region Internal WATCHDOG
        public bool WatchDog = true;
        public UInt32 MAX_WAIT_DATA_INTERVAL = 100; //how long to wait before restart
        public DateTime LastTimeDataRead;
        #endregion


        public DataReadClass(Communications extComObj)
        {
            ComObj = extComObj;
        }


        /// <summary>
        /// This method is called to start reading data
        /// </summary>        
        public bool StartReadData()
        {
            bool error = false;
            Logging.AddLog("startReadData command issued", LogLevel.Trace);

            // If the port is not open
            if (!ComPortObj.IsOpen)
            {

                try
                {
                    setPortSettings();
                    eventHandler();

                    // Open the port
                    ComPortObj.Open();

                    ComObj.AddOutput("Comport was opened");
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }
            }
            if (error)
            {
                ComObj.AddOutput("Couldn't open comport");
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// This method is called to stop reading data
        /// </summary>  
        public bool StopReadData()
        {
            bool error = false;
            Logging.AddLog("stopReadData command issued", LogLevel.Trace);

            if (ComPortObj.IsOpen)
            {
                try
                {
                    // Close the port
                    ComPortObj.Close();
                    ComObj.AddOutput("Comport was closed");
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }
            }
            if (error)
            {
                ComObj.AddOutput("Couldn't close comport");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Setting port settings
        /// </summary>        
        private void setPortSettings()
        {
            // Set the port's settings
            ComPortObj.BaudRate = int.Parse("9600");
            ComPortObj.DataBits = int.Parse("8");
            ComPortObj.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            ComPortObj.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            ComPortObj.Handshake = Handshake.None;
            ComPortObj.PortName = PortName;
            ComPortObj.DtrEnable = true; //to reset Arduino on connect

            LastTimeDataRead = DateTime.Now;

            Logging.AddLog("Comport settings were set", LogLevel.Trace);

        }

        /// <summary>
        /// Attach event handler to serial port object
        /// </summary>        
        public void eventHandler()
        {
            ComPortObj.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);
            Logging.AddLog("Comport DataReceived event handler was set", LogLevel.Trace);
        }


        /// <summary>
        /// Event handler for DataReceived event
        /// This method will be called when there is data waiting in the port's buffer
        /// </summary>        
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!ComPortObj.IsOpen) return;

            // Read all the data waiting in the buffer
            string data = ComPortObj.ReadExisting();

            ComObj.SerialBuffer += data;
            //string[] lines = SerialBuffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            /// if using with VISUAL INTERFACE
            //if (ParentMainForm!=null) ParentMainForm.LogForm.AppendLogText(data);

            //Log serial data if needed
            //if (Logging.SerialLogFileFlag) Logging.LogSerial(data);

            if (ComObj.SerialBuffer.Length > ComObj.MAX_BUFFER_LEN)
            {
                ComObj.SerialBuffer = ComObj.SerialBuffer.Substring((Int16)(ComObj.SerialBuffer.Length - ComObj.MAX_BUFFER_LEN));
                Logging.AddLog("SerialBuffer was cut to " + ComObj.MAX_BUFFER_LEN, LogLevel.Trace);
            }

            ComObj.CallBackFunction_Outputreslut?.Invoke(data);

            Logging.AddLog("SerialBuffer data was received", LogLevel.Trace);
            LastTimeDataRead = DateTime.Now;
        }



        /// <summary>
        /// Wrapper for writing data to serial port
        /// </summary>
        /// <param name="CommandSt">string with command, which should be sent to Arduino</param>
        public bool WriteSerialData(string CommandSt)
        {
            string FullCommandSt = "(#" + CommandSt + ")";

            try
            {
                ComPortObj.WriteLine(FullCommandSt);
                ComObj.AddOutput("Command to serial sent: " + FullCommandSt);

                return true;
            }
            catch
            {
                ComObj.AddOutput("Error writing command " + FullCommandSt + " to serial");
                return false;
            }
        }
    }
}
