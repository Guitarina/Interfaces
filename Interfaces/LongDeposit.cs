using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
        public class LongDeposit : Deposit, IProlongable
    {
        public LongDeposit(decimal depositAmount, int depositPeriod):base(depositAmount, depositPeriod)
        {

        }

        public bool CanToProlong()
        {
            return Period <=36;
        }

        public override decimal Income()
        {
            decimal currentSum = Amount;

            for (int i = 6; i < Period; i++)
            {
                currentSum *= 1.15M;
            }
            return currentSum - Amount;
        }
    }

}
