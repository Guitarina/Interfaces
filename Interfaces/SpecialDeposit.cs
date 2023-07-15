using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
        public class SpecialDeposit: Deposit, IProlongable
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod):base(depositAmount, depositPeriod)
        {

        }

        public bool CanToProlong()
        {
            return Amount > 1000;
        }

        public override decimal Income()
        {
            decimal currentSum = Amount; 
            for (decimal i = 1; i <= Period; i++)
            {
                currentSum += (currentSum * (i / 100M)); 
            }
            return currentSum - Amount;
        }
    }

}
