using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreEvent
{
    internal class Transactions
    {
        public delegate void HandlerNotification();
        public event HandlerNotification TransactionStart;
        public event HandlerNotification TransactionCommit;
        public event HandlerNotification TransactionEnd;
       

        public void TransactionCheck()
        {
            Console.WriteLine("Transaction Check in progress");
            OnIllegalTransaction();

        }

        /// <summary>
        /// Event publisher method.
        /// </summary>
        protected virtual void OnIllegalTransaction()
        {
            TransactionStart?.Invoke();

        }
        protected virtual void OnWrongPinInput()
        {
            TransactionEnd.Invoke();

        }

    }

    /// <summary>
    /// Suscriber class
    /// </summary>
    public class Admin
    {
        public void ActionTaken()
        {
            var trans = new Transactions();
            trans.TransactionStart += () => Console.WriteLine("Go further and account will be Blocked");
            Console.ReadLine();
        }

        public void WarrantedPenalty()
        {
            var trans = new Transactions();
            trans.TransactionCommit += () => Console.WriteLine("Fee of 1000 deducted");
        }
    }
}
