using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_statement_v1._2
{
    public class Balance : Element
    {
        private Config.Balance balance { set; get; }
        private double value { set; get; }

        public Balance(string ID, string name, double cashflow, Config.Balance balance, double value) : base(ID, name, cashflow)
        {
            this.balance = balance;
            this.flow = Config.FlowOfBalance(balance);
            this.value = value;
        }

        public new static string ToString()
        {
            return "Balance";
        }

        #region Getters

        public override Config.Balance GetBalance()
        {
            return this.balance;
        }

        public override double GetValue()
        {
            return this.value;
        }

        #endregion

        #region Setters

        public void SetBalance(Config.Balance balance)
        {
            this.balance = balance;
        }

        public void SetValue(double value)
        {
            this.value = value;
        }

        #endregion

    }
}
