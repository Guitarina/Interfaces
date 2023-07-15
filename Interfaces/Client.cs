using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Client : IEnumerable<Deposit>
    {
        private  readonly Deposit[] deposits;

        public Client()
        {
            deposits= new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }

        public decimal TotalIncome()
        {
            decimal total = 0;

            foreach(var deposit in deposits) {
                if (deposit == null) continue;
                total += deposit.Income() ;
            }
            return total;
        }

        public decimal MaxIncome()
        {
            decimal max = decimal.MinValue;

            foreach(var deposit in deposits)
            {
                if (deposit == null) continue;
                if(deposit.Income()>max)
                    max = deposit.Income();
            }
            return max;
        }

        public decimal GetIncomeByNumber(int index)
        {
            if (deposits[index - 1] == null) return 0M;
            return deposits[index-1].Income();
        }

        public IEnumerator<Deposit> GetEnumerator()
        {
            return ((IEnumerable<Deposit>)deposits).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return deposits.GetEnumerator();
        }

        public void SortDeposits()
        {
            Array.Sort(deposits);
            Array.Reverse(deposits);
            
        }

        public int CountPossibleToProlongDeposit()
        {
            int count = 0;

            foreach(var deposit in deposits)
            {
                if ((deposit is LongDeposit dep)&&dep.CanToProlong())
                    count++;
                else if((deposit is SpecialDeposit depos) && depos.CanToProlong() )
                    count++;
            }
            return count;
        }
    }

}
