using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    internal class PayRoll
    {
        //Atributes in this PayRoll Class
        
         // Use list in C#
        List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        

        public void PayAll()
        {
            
            // USing foreach instead of the previous manual way of calling Pay()
            foreach (IPayee payee in payees)
            {
                payee.Pay();
            }

        }

    }
}
