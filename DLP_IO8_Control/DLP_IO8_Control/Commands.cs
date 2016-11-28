using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLP_IO8_Control
{
    
    class Commands
    {
        // Channel 1
        const uint DIGITAL_OUT_HIGH_1 = 0x31;
        const uint DIGITAL_OUT_LOW_1  = 0x51;
        const uint DIGITAL_IN_1       = 0x41;
        const uint ANALOG_IN_1        = 0x5A;
        const uint TEMP_1             = 0x39;

        // Cannel 2
        const uint DIGITAL_OUT_HIGH_2 = 0x32;
        const uint DIGITAL_OUT_LOW_2  = 0x57;
        const uint DIGITAL_IN_2       = 0x53;
        const uint ANALOG_IN_2        = 0x58;
        const uint TEMP_2             = 0x30;

        // Cannel 3
        const uint DIGITAL_OUT_HIGH_3 = 0x33;
        const uint DIGITAL_OUT_LOW_3  = 0x45;
        const uint DIGITAL_IN_3       = 0x44;
        const uint ANALOG_IN_3        = 0x43;
        const uint TEMP_3             = 0x2D;

        // Cannel 4
        const uint DIGITAL_OUT_HIGH_4 = 0x34;
        const uint DIGITAL_OUT_LOW_4  = 0x52;
        const uint DIGITAL_IN_4       = 0x46;
        const uint ANALOG_IN_4        = 0x56;
        const uint TEMP_4             = 0x3D;

        // Cannel 5
        const uint DIGITAL_OUT_HIGH_5 = 0x35;
        const uint DIGITAL_OUT_LOW_5  = 0x54;
        const uint DIGITAL_IN_5       = 0x47;
        const uint ANALOG_IN_5        = 0x42;
        const uint TEMP_5             = 0x4F;

        // Cannel 6
        const uint DIGITAL_OUT_HIGH_6 = 0x36;
        const uint DIGITAL_OUT_LOW_6  = 0x59;
        const uint DIGITAL_IN_6       = 0x48;
        const uint ANALOG_IN_6        = 0x4E;
        const uint TEMP_6             = 0x50;

        // Cannel 7
        const uint DIGITAL_OUT_HIGH_7 = 0x37;
        const uint DIGITAL_OUT_LOW_7  = 0x55;
        const uint DIGITAL_IN_7       = 0x4A;
        const uint ANALOG_IN_7        = 0x4D;
        const uint TEMP_7             = 0x5B;

        // Cannel 8
        const uint DIGITAL_OUT_HIGH_8 = 0x38;
        const uint DIGITAL_OUT_LOW_8  = 0x49;
        const uint DIGITAL_IN_8       = 0x4B;
        const uint ANALOG_IN_8        = 0x2C;
        const uint TEMP_8             = 0x5C;

        // Setup Comands
        const uint RETURN_ASCCII      = 0x60;
        const uint RETURN_BINARY      = 0x5C;
        const uint SET_FARENHEIT      = 0x4C;
        const uint SET_CELSIUS        = 0x3B;

        // Ping Comand
        const uint ISSUE_PING         = 0x27;


       
        private uint SetDigitalOutput(uint channel)
        {
            uint tempComand = 0x00;

            switch (channel)
            {
                case 1:
                    {
                        tempComand = DIGITAL_OUT_HIGH_1;
                        break;
                    }
                case 2:
                    {
                        tempComand = DIGITAL_OUT_HIGH_2;
                        break;
                    }
                case 3:
                    {
                        tempComand = DIGITAL_OUT_HIGH_3;
                        break;
                    }
                case 4:
                    {
                        tempComand = DIGITAL_OUT_HIGH_4;
                        break;
                    }
                case 5:
                    {
                        tempComand = DIGITAL_OUT_HIGH_5;
                        break;
                    }
                case 6:
                    {
                        tempComand = DIGITAL_OUT_HIGH_6;
                        break;
                    }
                case 7:
                    {
                        tempComand = DIGITAL_OUT_HIGH_7;
                        break;
                    }
                case 8:
                    {
                        tempComand = DIGITAL_OUT_HIGH_8;
                        break;
                    }
            }
            return tempComand;
        }

        
        private uint ReSetDigitalOutput(uint channel)
        {
            uint tempComand = 0x00;

            switch (channel)
            {
                case 1:
                    {
                        tempComand = DIGITAL_OUT_LOW_1;
                        break;
                    }
                case 2:
                    {
                        tempComand = DIGITAL_OUT_LOW_2;
                        break;
                    }
                case 3:
                    {
                        tempComand = DIGITAL_OUT_LOW_3;
                        break;
                    }
                case 4:
                    {
                        tempComand = DIGITAL_OUT_LOW_4;
                        break;
                    }
                case 5:
                    {
                        tempComand = DIGITAL_OUT_LOW_5;
                        break;
                    }
                case 6:
                    {
                        tempComand = DIGITAL_OUT_LOW_6;
                        break;
                    }
                case 7:
                    {
                        tempComand = DIGITAL_OUT_LOW_7;
                        break;
                    }
                case 8:
                    {
                        tempComand = DIGITAL_OUT_LOW_8;
                        break;
                    }
            }


            return tempComand;
        }

       
        private uint ReadDigitalInput(uint channel)
        {
            uint tempComand = 0x00;

            switch (channel)
            {
                case 1:
                    {
                        tempComand = DIGITAL_IN_1;
                        break;
                    }
                case 2:
                    {
                        tempComand = DIGITAL_IN_2;
                        break;
                    }
                case 3:
                    {
                        tempComand = DIGITAL_IN_3;
                        break;
                    }
                case 4:
                    {
                        tempComand = DIGITAL_IN_4;
                        break;
                    }
                case 5:
                    {
                        tempComand = DIGITAL_IN_5;
                        break;
                    }
                case 6:
                    {
                        tempComand = DIGITAL_IN_6;
                        break;
                    }
                case 7:
                    {
                        tempComand = DIGITAL_IN_7;
                        break;
                    }
                case 8:
                    {
                        tempComand = DIGITAL_IN_8;
                        break;
                    }
            }


            return tempComand;
        }

        private uint ReadAnalogInput(uint channel)
        {
            uint tempComand = 0x00;

            switch (channel)
            {
                case 1:
                    {
                        tempComand = ANALOG_IN_1;
                        break;
                    }
                case 2:
                    {
                        tempComand = ANALOG_IN_2;
                        break;
                    }
                case 3:
                    {
                        tempComand = ANALOG_IN_3;
                        break;
                    }
                case 4:
                    {
                        tempComand = ANALOG_IN_4;
                        break;
                    }
                case 5:
                    {
                        tempComand = ANALOG_IN_5;
                        break;
                    }
                case 6:
                    {
                        tempComand = ANALOG_IN_6;
                        break;
                    }
                case 7:
                    {
                        tempComand = ANALOG_IN_7;
                        break;
                    }
                case 8:
                    {
                        tempComand = ANALOG_IN_8;
                        break;
                    }
            }


            return tempComand;
        }

        private uint ReadTemp(uint channel)
        {
            uint tempComand = 0x00;

            switch (channel)
            {
                case 1:
                    {
                        tempComand = TEMP_1;
                        break;
                    }
                case 2:
                    {
                        tempComand = TEMP_2;
                        break;
                    }
                case 3:
                    {
                        tempComand = TEMP_3;
                        break;
                    }
                case 4:
                    {
                        tempComand = TEMP_4;
                        break;
                    }
                case 5:
                    {
                        tempComand = TEMP_5;
                        break;
                    }
                case 6:
                    {
                        tempComand = TEMP_6;
                        break;
                    }
                case 7:
                    {
                        tempComand = TEMP_7;
                        break;
                    }
                case 8:
                    {
                        tempComand = TEMP_8;
                        break;
                    }
            }


            return tempComand;
        }

    }
}
