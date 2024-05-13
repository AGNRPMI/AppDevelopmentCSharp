using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar02
{
    internal class Bits
    {
        private readonly byte value_b;
        private readonly int value_i;
        private readonly long value_l;

        
        public Bits(byte value_b)
        {
            if (value_b < byte.MinValue || value_b > byte.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value_b), $"введи число от {byte.MinValue,30} до {byte.MaxValue,30}");
            }
            this.value_b = value_b;            
        }

        public static implicit operator byte(Bits b) => b.value_b;
        public static explicit operator Bits(byte d) => new Bits(d);
        
        public Bits(int value_i)
        {
            if (value_i < int.MinValue || value_i > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value_i), $"введи число от {int.MinValue,30} до {int.MaxValue,30}");
            }
            this.value_i = value_i;
        }

        public static implicit operator int(Bits i) => i.value_i;
        public static explicit operator Bits(int j) => new Bits(j);

        
        public Bits(long value_l)
        {
            if (value_l < long.MinValue || value_l > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value_l), $"введи число от {long.MinValue,30} до {long.MaxValue,30}");
            }
            this.value_l = value_l;
        }

        public static implicit operator long(Bits l) => l.value_l;
        public static explicit operator Bits(long k) => new Bits(k);

        
    }
}
