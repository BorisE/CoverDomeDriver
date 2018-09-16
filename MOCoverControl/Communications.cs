using LoggingLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCoverControl
{
    public class Communications
    {

        public DataReadClass DataReadObj;
        public DataParseClass DataParseObj;


        /// <summary>
        /// Buffer with data
        /// </summary>        
        public string SerialBuffer = "";
        public UInt32 MAX_BUFFER_LEN = 10000;



        /// <summary>
        /// Callback function at end of processing
        /// ---------------------------------------------------
        /// set CallBackFunction CallBackFunction_Outputreslut to be run at the end of processing of each file (to publish data in caller)
        /// </summary>
        /// <param name="FileResObj"></param>
        public CallBackOutputFunction CallBackFunction_Outputreslut; //store delegate
        public delegate void CallBackOutputFunction(string stOutput); //declare delegate type


        public Int32 sensorPOS;
        public Int32 sensorSPD;
        public Int32 sensorSPC;
        public Int32 sensorACL;
        public Int32 sensorCLN;
        public Int16 sensorOpened;
        public Int16 sensorClosed;
        public Int16 sensorMVE;

        public Int32 MeasureCycleLen;
        public string SketchVersion;
        public string SketchVersionDate;

        public Communications(CallBackOutputFunction PublishData)
        {
            DataReadObj = new DataReadClass(this);
            DataParseObj = new DataParseClass(this);

            CallBackFunction_Outputreslut = PublishData; //save call back function
        }
        public void AddOutput(string st, LogLevel loglev = LogLevel.Activity)
        {
            Logging.AddLog(st, loglev);
            CallBackFunction_Outputreslut?.Invoke(st + Environment.NewLine);
        }


        public void OpenCover()
        {
            DataReadObj.WriteSerialData("OPEN");
        }
        public void CloseCover()
        {
            DataReadObj.WriteSerialData("CLOSE");
        }
        internal void StopCover()
        {
            DataReadObj.WriteSerialData("STOP");
        }
        internal void MoveCoverInc(int v)
        {
            DataReadObj.WriteSerialData("MOV:" + v);
        }

        public void setCylceLength(Int32 CycleLen)
        {
            DataReadObj.WriteSerialData("CLN:" + CycleLen);
        }

        public void setPos(Int32 v)
        {
            DataReadObj.WriteSerialData("SET:" + v);
        }

        internal void setAcceleration(int v)
        {
            DataReadObj.WriteSerialData("ACL:" + v);
        }

        internal void setMaxSpeed(int v)
        {
            DataReadObj.WriteSerialData("SPD:" + v);
        }


    }

}
