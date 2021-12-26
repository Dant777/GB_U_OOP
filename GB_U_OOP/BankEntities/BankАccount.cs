using GB_U_OOP.BankEntities.Base;

namespace GB_U_OOP.BankEntities
{
    public class BankАccount : BaseBankАccount
    {
        public BankАccount() : this(0)
        {
        }

        public BankАccount(decimal moneyInAcc) : this(moneyInAcc, TypeAccount.Normal)
        {
        }

        public BankАccount(decimal moneyInAcc, TypeAccount typeAccount)
        {
            SetId();
            _moneyInAcc = moneyInAcc;
            _typeAccount = typeAccount;
        }

    }
}