using LoggingLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCoverControl
{
    public class DataParseClass
    {
        /// <summary>
        /// Parent object
        /// </summary>
        Communications ComObj;

        //Protocol delimeters
        #region Protocol delimeters
        const string DATAPROTOCOL_START = "[!";
        const string DATAPROTOCOL_END = "]";
        const string DATAPROTOCOL_SEPARATOR = ":";
        #endregion


        public DataParseClass(Communications extComObj)
        {
            ComObj = extComObj;
        }


        /// <summary>
        /// External method for parsing buffer data and then make all needed calculations
        /// </summary>        
        public void LOOP_CYCLE(out string curSerBuffer)
        {
            //1. PARSE BUFFER
            ParseBufferData();

            //Get out and clear buffer after parsing
            curSerBuffer = ComObj.SerialBuffer;
            ComObj.SerialBuffer = "";

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
            StringReader strReader = new StringReader(ComObj.SerialBuffer);
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
                            if (!Double.TryParse(tagValue_st, out tagValue_dbl))
                            {
                                tagValue_dbl = -100.0;
                            }

                            //LINE PARSED TO tagName AND tagValue

                            //2. PARSING PARTICULAR CASES
                            if (tagName == "POS")
                            {
                                ComObj.sensorPOS = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "SPD")
                            {
                                ComObj.sensorSPD = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "SPC")
                            {
                                ComObj.sensorSPC = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "ACL")
                            {
                                ComObj.sensorACL = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "CLN")
                            {
                                ComObj.sensorCLN = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "MVE")
                            {
                                ComObj.sensorMVE = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "OPN")
                            {
                                ComObj.sensorOpened = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "CLS")
                            {
                                ComObj.sensorClosed = Convert.ToInt16(tagValue_dbl);
                            }
                            else if (tagName == "!r")
                            {
                                ComObj.MeasureCycleLen = Convert.ToInt32(tagValue_dbl);
                            }
                            else if (tagName == "!be")
                            {
                            }
                            else if (tagName == "ver")
                            {
                                ComObj.SketchVersion = tagValue_st;
                            }
                            else if (tagName == "ved")
                            {
                                ComObj.SketchVersionDate = tagValue_st;
                            }
                            else if (tagName == "!en")
                            {

                            }
                        }
                        else
                        //THE LINE IS INCOMPLETE
                        {
                            //write error log
                            Logging.AddLog("Incomplete protocol line: " + aLine, LogLevel.Trace);
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
