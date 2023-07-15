using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfaces
{
    public abstract class Deposit : IComparable<Deposit>
    {
        public decimal Amount { get; }
        public int Period { get; }

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            this.Amount = depositAmount;
            this.Period = depositPeriod;
        }

        public abstract decimal Income();

        public int CompareTo( Deposit other)
        {
            decimal total = this.Amount + this.Income();
            decimal totalOther = other.Amount + other.Income();
            if (total < totalOther)
            {
                return -1;
            }
            else if (total > totalOther)
            { return 1; }
            else return 0;
        }

    }


  
}
