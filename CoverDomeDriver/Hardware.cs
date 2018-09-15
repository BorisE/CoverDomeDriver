using LoggingLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using AsrtoUtils.Conversion;

namespace ASCOM.ObjectiveCover
{
    class Hardware
    {
        /// <summary>
        /// Serial Port name
        /// </summary>        
        public string PortName = "COM5";
        /// <summary>
        /// The SerialPort object, which is used for communicating through the RS-232 port
        /// </summary>        
        public SerialPort comport = new SerialPort();

        /// <summary>
        /// Buffer with data
        /// </summary>        
        public string SerialBuffer = "";
        public UInt32 MAX_BUFFER_LEN = 10000;

        //Protocol delimeters
        #region Protocol delimeters
        const string DATAPROTOCOL_START = "[!";
        const string DATAPROTOCOL_END = "]";
        const string DATAPROTOCOL_SEPARATOR = ":";
        #endregion

        /// <summary>
        /// Last time data was read (WATCHDOG)
        /// </summary>        
        #region Internal WATCHDOG
        public bool WatchDog = true;
        public UInt32 MAX_WAIT_DATA_INTERVAL = 100; //how long to wait before restart
        public DateTime LastTimeDataRead;
        #endregion




        /// <summary>
        /// Constructor 
        /// </summary>        
        public Hardware()
        {

        }




        /// <summary>
        /// Attach event handler to serial port object
        /// </summary>        
        public void eventHandler()
        {
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);
            Logging.AddLog("Comport DataReceived event handler was set", LogLevel.Activity);
        }

        /// <summary>
        /// Setting port settings
        /// </summary>        
        private void setPortSettings()
        {
            // Set the port's settings
            comport.BaudRate = int.Parse("9600");
            comport.DataBits = int.Parse("8");
            comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            comport.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            comport.Handshake = Handshake.None;
            comport.PortName = PortName;
            comport.DtrEnable = true; //to reset Arduino on connect

            LastTimeDataRead = DateTime.Now;

            Logging.AddLog("Comport settings were set", LogLevel.Activity);

        }

        /// <summary>
        /// This method is called to start reading data
        /// </summary>        
        public bool startReadData()
        {
            bool error = false;
            Logging.AddLog("startReadData command issued", LogLevel.Activity);

            // If the port is not open
            if (!comport.IsOpen)
            {

                try
                {
                    setPortSettings();
                    eventHandler();

                    // Open the port
                    comport.Open();
                    Logging.Log("Comport was opened", 2);

                    sendParametersToSerial();
                    queryParametersFromSerial();
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }
            }
            if (error)
            {
                Logging.AddLog("Couldn't open comport", LogLevel.Activity);
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
        public bool stopReadData()
        {
            bool error = false;
            Logging.AddLog("stopReadData command issued", LogLevel.Activity);

            // If the port is open, close it.
            if (comport.IsOpen)
            {
                try
                {
                    // Close the port
                    comport.Close();
                    Logging.AddLog("Comport was closed", LogLevel.Activity);
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }
            }

            if (error)
            {
                Logging.AddLog("Couldn't close comport", LogLevel.Activity);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Event handler for DataReceived event
        /// </summary>        
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!comport.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Read all the data waiting in the buffer
            string data = comport.ReadExisting();

            SerialBuffer += data;
            //string[] lines = SerialBuffer.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            /// if using with VISUAL INTERFACE
            //if (ParentMainForm!=null) ParentMainForm.LogForm.AppendLogText(data);

            //Log serial data if needed
            //if (Logging.SerialLogFileFlag) Logging.LogSerial(data);

            if (SerialBuffer.Length > MAX_BUFFER_LEN)
            {
                SerialBuffer = SerialBuffer.Substring((Int16)(SerialBuffer.Length - MAX_BUFFER_LEN));
                Logging.AddLog("SerialBuffer was cut to " + MAX_BUFFER_LEN,LogLevel.Trace );
            }

            Logging.AddLog("SerialBuffer data was received", LogLevel.Trace);
            LastTimeDataRead = DateTime.Now;
        }
        /// <summary>
        /// Wrapper for writing data to serial port
        /// </summary>
        /// <param name="CommandSt">string with command, which should be sent to Arduino</param>
        public bool WriteSerialData(string CommandSt)
        {
            string FullCommandSt = "(" + CommandSt + ")";
            bool error = false;

            try
            {
                comport.WriteLine(FullCommandSt);
                Logging.AddLog("Command to serial sent: " + FullCommandSt, LogLevel.Important, Highlight.Error);
                return true;
            }
            catch
            {
                Logging.AddLog("Error writing command " + FullCommandSt + " to serial", LogLevel.Important, Highlight.Error);
                return false;
            }
        }

        /// <summary>
        /// Send current settings to Arduino. Overload with returning sent command string
        /// </summary>
        /// <returns>true - if all data was sent</returns>
        public bool sendParametersToSerial(out string CommandStr)
        {
            Logging.Log("sendParametersToSerial(overload) enter", 3);

            ArduinoSettingsClass El1 = new ArduinoSettingsClass();
            ArduinoSettingsClass El2 = new ArduinoSettingsClass();
            ArduinoSettingsClass El3 = new ArduinoSettingsClass();
            String St = ""; CommandStr = "";

            St = "!TD:" + Convert.ToString(HEATER_MAX_TEMPERATURE_DELTA);
            CommandStr += "out: " + St;
            El1.Value = HEATER_MAX_TEMPERATURE_DELTA.ToString();
            El1.ReadTime = new DateTime(2010, 01, 01);
            ArduinoSettings["TD"] = El1;
            bool retval1 = WriteSerialData(St);

            St = "!WT:" + Convert.ToString(HEATER_WET_START_THRESHOLD);
            CommandStr += "out: " + St;
            El2.Value = HEATER_WET_START_THRESHOLD.ToString();
            El2.ReadTime = new DateTime(2010, 01, 01);
            ArduinoSettings["WT"] = El2;
            bool retval2 = WriteSerialData(St);

            St = "!RT:" + Convert.ToString(HEATER_MAX_DURATION);
            CommandStr += "out: " + St;
            El3.Value = HEATER_MAX_DURATION.ToString();
            El3.ReadTime = new DateTime(2010, 01, 01);
            ArduinoSettings["RT"] = El3;

            bool retval3 = WriteSerialData(St);

            Logging.Log("sendParametersToSerial (overload) was sent", 3);

            return (retval1 && retval2 && retval3);
        }
        /// <summary>
        /// Send command to Arduino to print current settings 
        /// </summary>
        /// <returns></returns>
        public bool queryParametersFromSerial()
        {
            bool retval1 = WriteSerialData("!?S");

            Logging.AddLog("getParametersToSerial command was sent", LogLevel.Trace);

            return retval1;
        }

        /// <summary>
        /// External method to check when was the last communication
        /// </summary>        
        public UInt32 SinceLastDataReceived()
        {
            UInt32 SinceLastRead_sec = UInt32.MaxValue;

            TimeSpan SinceLastRead = DateTime.Now.Subtract(LastTimeDataRead);
            SinceLastRead_sec = (UInt32)Math.Round(SinceLastRead.TotalSeconds, 0);

            return SinceLastRead_sec;
        }

        /// <summary>
        /// External method to check when was last data received and restart communication (a la watchdog)
        /// </summary>        
        public void CheckIfDataReceiving()
        {
            uint PassedSinceReceiving = SinceLastDataReceived();
            if (PassedSinceReceiving > MAX_WAIT_DATA_INTERVAL)
            {
                //restart connection
                Logging.AddLog("Waiting too long for data (" + PassedSinceReceiving + "). Restarting connection to COM port...", LogLevel.Important, Highlight.Error);
                stopReadData();
                System.Threading.Thread.Sleep(2000);
                startReadData();
            }
            else
            {
                Logging.AddLog("CheckIfDataReceiving is ok. Passed since last receive: " + PassedSinceReceiving + "", LogLevel.Trace);
            }
        }

        /// <summary>
        /// External interface to check if communication was started
        /// </summary>        
        public bool IsOpened()
        {
            bool ret = false;

            ret = comport.IsOpen;

            return ret;

        }

        /// <summary>
        /// Method to stop communications
        /// </summary>        
        public void Close()
        {
            comport.Close();
        }

        /// <summary>
        /// External method for parsing buffer data and then make all needed calculations
        /// </summary>        
        public void LOOP_CYCLE(out string curSerBuffer)
        {
             //1. PARSE BUFFER
            ParseBufferData();

            //Get out and clear buffer after parsing
            curSerBuffer = SerialBuffer;
            SerialBuffer = "";

            //2. MAKE CALCULATIONS
            //MakeSensorsCalculations();
        }

        /// <summary>
        /// Upgraded main method to parse received data
        /// Based on SensorArray
        /// Mast be called from external. Working asynchronously with data reading
        /// </summary>        
        internal void ParseBufferData()
        {
            string aLine = null;
            StringReader strReader = new StringReader(SerialBuffer);
            while (true)
            {
                aLine = strReader.ReadLine();
                if (aLine != null)
                {
                    //IS THIS DATA PROTOCOL LINE?
                    if (aLine.Trim().StartsWith(DATAPROTOCOL_START))
                    {

                        int tagStartPosition = DATAPROTOCOL_START.Length;
                        int tagEndPosition = aLine.IndexOf(DATAPROTOCOL_SEPARATOR);
                        int valEndPosition = aLine.IndexOf(DATAPROTOCOL_END);

                        // IS THIS A FULL LINE (WITH TAG AND DATA)?
                        if (tagEndPosition >= 0 && valEndPosition >= 0)
                        {
                            //0. PREPARE VALUES
                            string tagName = aLine.Substring(tagStartPosition, tagEndPosition - tagStartPosition);
                            string tagValue_raw = aLine.Substring(tagEndPosition + 1, valEndPosition - tagEndPosition - 1);

                            //0.1. Automatic decimal point correction
                            char Separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                            char BadSeparator = '.';

                            if (Separator == '.') { BadSeparator = ','; }
                            if (Separator == ',') { BadSeparator = '.'; }

                            string tagValue_st = tagValue_raw.Replace(BadSeparator, Separator);

                            //0.2. Try to convert to double. 
                            double tagValue_dbl = -100.0;
                            try
                            {
                                tagValue_dbl = DoubleConversionUtils.ConvertToDouble(tagValue_st);
                            }
                            catch (Exception Ex)
                            {
                                //Note, that exception is not always an error - some values should state in string format, i.e. version info
                            }

                            //LINE PARSED TO tagName AND tagValue

                            //1. WRITE IT TO SENSOR VALUE
                            int SensIdx = -1;
                            foreach (SensorElement DataSensor in SensorsList.Values)
                            {
                                SensIdx++;
                                if (DataSensor != null)
                                {
                                    if (DataSensor.SensorArduinoField == tagName)
                                    {
                                        try
                                        {
                                            //Trim value if it is too lengthy (in case of Arduino malfunction)
                                            if (tagValue_st.Length > 20)
                                            {
                                                tagValue_st = tagValue_st.Substring(0, 20) + "[...]";
                                                Logging.AddLog("TagValue is too long in ParseBufferData for pair [" + tagName + "][" + tagValue_st + "]", 2);
                                            }

                                            //Convert to Double
                                            if (CheckData(tagValue_dbl, DataSensor.SensorType))
                                            {
                                                SensorsList[DataSensor.SensorName].AddValue(tagValue_dbl);
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            StackTrace st = new StackTrace(ex, true);
                                            StackFrame[] frames = st.GetFrames();
                                            string messstr = "";

                                            // Iterate over the frames extracting the information you need
                                            foreach (StackFrame frame in frames)
                                            {
                                                messstr += String.Format("{0}:{1}({2},{3})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber());
                                            }

                                            string FullMessage = "Error loading settings. ";
                                            FullMessage += "IOException source: " + ex.Data + " | " + ex.Message + " | " + messstr;

                                            Logging.Log(FullMessage);
                                            Logging.AddLog("Exception in ParseBufferData for pair [" + tagName + "][" + tagValue_st + "], message: " + ex.Message + ". " + ex.ToString(), 1);
                                        }
                                    }
                                }
                            }

                            //2. PARSING PARTICULAR CASES
                            if (tagName == "Obj")
                            {
                            }
                            else if (tagName == "RL1")
                            {
                                int Relay1_n = Convert.ToInt16(tagValue_dbl);
                                if (Relay1 == 0 && Relay1_n == 1)
                                {
                                    LastHeating1SwitchOn = DateTime.Now;
                                }
                                else if (Relay1 == 1 && Relay1_n == 0)
                                {
                                    LastHeating1SwitchOff = DateTime.Now;
                                }
                                Relay1 = Relay1_n;
                            }
                            else if (tagName == "RL2")
                            {
                                int Relay2_n = Convert.ToInt16(tagValue_dbl);
                                if (Relay2 == 0 && Relay2_n == 1)
                                {
                                    LastHeating2SwitchOn = DateTime.Now;
                                }
                                else if (Relay2 == 1 && Relay2_n == 0)
                                {
                                    LastHeating2SwitchOff = DateTime.Now;
                                }
                                Relay2 = Relay2_n;
                            }
                            else if (tagName == "WnV")
                            {
                                WindSensorVal = Convert.ToInt16(tagValue_dbl);

                                //autocalibrate min speed
                                if (WS_AutoCalibrateFlag)
                                {
                                    AutoCalibrateWindSpeed();
                                }
                                WindSpeedVal = calcWindSpeed(WindSensorVal);
                            }
                            else if (tagName == "Lur")
                            {
                                LumRes = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "Lus")
                            {
                                LumSens = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "Luw")
                            {
                                LumWTime = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "!r")
                            {
                                MeasureCycleLen = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "!be")
                            {
                            }
                            else if (tagName == "Pre")
                            {
                                PressureVal = tagValue_dbl;
                                PressureNormalVal = CalcNormalPressure();
                            }
                            else if (tagName == "ver")
                            {
                                SketchVersion = tagValue_st;
                                VersionData.HardwareVersionSt = SketchVersion;
                            }
                            else if (tagName == "ved")
                            {
                                SketchVersionDate = tagValue_st;
                                VersionData.HardwareCompileTimeSt = SketchVersionDate;
                            }
                            else if (tagName == "!en")
                            {

                            }
                            else if (tagName == "?TD")
                            {
                                ArduinoSettingsClass El = new ArduinoSettingsClass();
                                El.Value = tagValue_st;
                                El.ReadTime = DateTime.Now;
                                ArduinoSettings["TD"] = El;
                            }
                            else if (tagName == "?WT")
                            {
                                ArduinoSettingsClass El = new ArduinoSettingsClass();
                                El.Value = tagValue_st;
                                El.ReadTime = DateTime.Now;
                                ArduinoSettings["WT"] = El;
                            }
                            else if (tagName == "?RT")
                            {
                                ArduinoSettingsClass El = new ArduinoSettingsClass();
                                El.Value = tagValue_st;
                                El.ReadTime = DateTime.Now;
                                ArduinoSettings["RT"] = El;
                            }
                        }
                        else
                        //THE LINE IS INCOMPLETE
                        {
                            //write error log
                            Logging.Log("Incomplete protocol line: " + aLine, 2);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

    }
}
