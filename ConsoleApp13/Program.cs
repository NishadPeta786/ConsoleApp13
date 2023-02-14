using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosePrinciple
{//without implementing open-close principle
    /*internal class Invoice
      {
    public double GetInvoiceDiscount(double amount,Invoice Type invoice Type)
    {
    double finalAmount=0*/
      
    public class Invoice
    {
        public virtual double GetInvoiceAmount(double amount)
        {
            return amount - 10;

        }
    }
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceAmount(double amount)
        {
            
           
                return base.GetInvoiceAmount(amount) - 50;
            }
        }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceAmount(double amount)
        {
            return base.GetInvoiceAmount(amount) - 40;
        }
    }
    }

}