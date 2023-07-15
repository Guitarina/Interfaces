using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
        public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal depositAmount, int depositPeriod) : base(depositAmount,depositPeriod)
        {
            
        }
        public override decimal Income()
        {
            decimal currentSum = Amount;
            for (int i = 0; i < Period; i++)
            {
                currentSum *= 1.05M;   
            }
            return currentSum-Amount;
        }
    }
}
