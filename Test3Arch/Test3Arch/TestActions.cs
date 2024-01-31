using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3Arch
{
    //Class with actions
    internal class TestActions
    {
        // ADD
        public long ADD(long a, long b)
        {
            a += b;
            return a;
        }

        // SUB
        public long SUB(long a, long b)
        {
            a -= b;
            return a;
        }

        // MUL
        public long MUL(long a, long b)
        {
            a *= b;
            return a;
        }

        // DIV
        public long DIV(long a, long b)
        {
            a /= b;
            return a;
        }

        // AND
        public long AND(long a, long b)
        {
            a &= b;
            return a;
        }

        // OR
        public long OR(long a, long b)
        {
            a |= b;
            return a;
        }

        // XOR
        public long XOR(long a, long b)
        {
            a ^= b;
            return a;
        }

        // INC
        public long INC(long a)
        {
            a++;
            return a;
        }

        // DEC
        public long DEC( long a)
        {
            a--;
            return a;
        }

        // NOT
        public long NOT(long a)
        {
            a = ~a;
            return a;
        }

        // NEG
        public long NEG( long a)
        {
            a = -a;
            return a;
        }

        // MOV
        public long MOV(long a, long b)
        {
            a = b;
            return a;
        }
    }
}

