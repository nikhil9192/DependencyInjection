using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitlyCouple
{
   public class Account
    {
        SavingAccount sv=new SavingAccount();
        BankDeatail bd=new BankDeatail();
        
        public void printDetailAccount_all()
        {
            sv.printdetail();
            bd.printDetail();
        }
       
    }
}
