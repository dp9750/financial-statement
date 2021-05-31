using System;

namespace Financial_statement_v1._2
{
    public class Flow : Element
    {

        public Flow(string name, double cashflow, Config.Flow flow) : base(name, cashflow)
        {
            this.flow = flow;
        }

        public new static string ToString()
        {
            return "Flow";
        }

        #region Getters

        public override Config.Balance GetBalance()
        {
            throw new NotImplementedException();
        }

        public override double GetValue()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
