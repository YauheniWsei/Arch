using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3Arch
{

    //********************************************************

    //  The `Test1_Reg` class defines a set of registers including
    // AH, BH, CH, DH, AL, BL, CL, and DL, each represented by
    // a `long` value. It provides methods to clear all register
    // values, retrieve the value of a specific register by name,
    // and set the value of a specific register by name. The class
    // ensures that register names are case-insensitive and throws
    // an exception for invalid register names.

    //********************************************************
    internal class Test1_Reg
    {
        private long _AH;
        private long _BH;
        private long _CH;
        private long _DH;
        private long _AL;
        private long _BL;
        private long _CL;
        private long _DL;

        public long AH
        {
            get => _AH;
            set => _AH = value;
        }

        public long BH
        {
            get => _BH;
            set => _BH = value;
        }

        public long CH
        {
            get => _CH;
            set => _CH = value;
        }

        public long DH
        {
            get => _DH;
            set => _DH = value;
        }

        public long AL
        {
            get => _AL;
            set => _AL = value;
        }

        public long BL
        {
            get => _BL;
            set => _BL = value;
        }

        public long CL
        {
            get => _CL;
            set => _CL = value;
        }

        public long DL
        {
            get => _DL;
            set => _DL = value;
        }

        public void Clear()
        {
            _AH = 0;
            _BH = 0;
            _CH = 0;
            _DH = 0;
            _AL = 0;
            _BL = 0;
            _CL = 0;
            _DL = 0;
        }

        public long GetRegisterValue(string registerName)
        {
            switch (registerName.ToUpper())
            {
                case "AH":
                    return AH;
                case "BH":
                    return BH;
                case "CH":
                    return CH;
                case "DH":
                    return DH;
                case "AL":
                    return AL;
                case "BL":
                    return BL;
                case "CL":
                    return CL;
                case "DL":
                    return DL;
                default:
                    throw new ArgumentException("Invalid register name");
            }
        }

        public void SetRegisterValue(string registerName, long value)
        {
            switch (registerName.ToUpper())
            {
                case "AH":
                    AH = value;
                    break;
                case "BH":
                    BH = value;
                    break;
                case "CH":
                    CH = value;
                    break;
                case "DH":
                    DH = value;
                    break;
                case "AL":
                    AL = value;
                    break;
                case "BL":
                    BL = value;
                    break;
                case "CL":
                    CL = value;
                    break;
                case "DL":
                    DL = value;
                    break;
                default:
                    MessageBox.Show("Invalid register name");
                    break;
            }
        }
    }
}
