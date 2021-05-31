using System;

namespace Financial_statement_v1._2
{
    public class Config
    {
        // flow types
        public enum Flow { Income, Expense };

        // balance types
        public enum Balance { Asset, Liability };

        #region Parsers

        // get Flow from given string
        public static Flow GetFlow(string flow)
        {
            if (flow == Flow.Income.ToString())
                return Flow.Income;
            return Flow.Expense;
        }

        // get Balance from given string
        public static Balance GetBalance(string balance)
        {
            if (balance == Balance.Asset.ToString())
                return Balance.Asset;
            return Balance.Liability;

        }

        // return type of flow based on given balance
        public static Flow FlowOfBalance(Balance flow)
        {
            if (flow == Balance.Asset)
                return Flow.Income;
            return Flow.Expense;
        }

        #endregion

        #region Validators

        // is given string a Flow element
        public static bool IsFlow(string s)
        {
            foreach (Flow flow in Enum.GetValues(typeof(Flow)))
                if (flow.ToString() == s)
                    return true;
            return false;
        }

        // is given string a Balance element
        public static bool IsBalance(string s)
        {
            foreach (Balance balance in Enum.GetValues(typeof(Balance)))
                if (balance.ToString() == s)
                    return true;
            return false;
        }

        // check if given string is a valid flow or balance type
        public static bool ValidType(string type)
        {
            if (IsFlow(type))
                return true;
            return IsBalance(type);
        }

        #endregion

    }
}
