using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_statement_v1._2
{
    public abstract class Element
    {
        protected int ID { set; get; }
        protected string name { set; get; }
        protected double cashflow { set; get; }

        protected Config.Flow flow { set; get; }

        private Random rnd;

        public Element(string name, double cashflow)
        {
            rnd = new Random();
            this.name = name;
            this.cashflow = cashflow;

            this.SetID();
        }

        #region Getters

        public int GetID()
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

        public void SetID()
        {
            this.ID = rnd.Next(1000) + 1;

            while (Main.GetInstance().ExistsID(ID))
                this.ID = rnd.Next(1000) + 1;
        }

        public void SetID(int ID)
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
