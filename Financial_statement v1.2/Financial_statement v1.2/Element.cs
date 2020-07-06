using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_statement_v1._2
{
    public abstract class Element
    {
        protected string ID { set; get; }
        protected string name { set; get; }
        protected double cashflow { set; get; }

        protected Config.Flow flow { set; get; }

        public Element(string ID, string name, double cashflow)
        {
            this.ID = ID;
            this.name = name;
            this.cashflow = cashflow;
        }

        #region Getters

        public string GetID()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetCashflow()
        {
            return this.cashflow;
        }

        public Config.Flow GetFlow()
        {
            return this.flow;
        }

        public abstract Config.Balance GetBalance();

        public abstract double GetValue();

        #endregion

        #region Setters

        public void SetID(string ID)
        {
            this.ID = ID;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetCashflow(double cashflow)
        {
            this.cashflow = cashflow;
        }

        public void SetFlow(Config.Flow flow)
        {
            this.flow = flow;
        }

        #endregion

    }
}
