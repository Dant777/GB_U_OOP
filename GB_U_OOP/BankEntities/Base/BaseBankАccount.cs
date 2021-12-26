namespace GB_U_OOP.BankEntities.Base
{
    public abstract class BaseBankАccount
    {
        protected static int _idCounter;
        protected int _id;
        protected decimal _moneyInAcc;
        protected TypeAccount _typeAccount;

        public int Id => _id;

        public decimal MoneyInAcc
        {
            get => _moneyInAcc;
            set => _moneyInAcc = value;
        }

        public TypeAccount TypeAccount
        {
            get => _typeAccount;
            set => _typeAccount = value;
        }


        protected void SetId()
        {
            _idCounter++;
            _id = _idCounter;
        }

        public bool MoneyToAnotherAcc(BaseBankАccount accTo, decimal moneyTransfer)
        {
            if (!IsCorrectMoneyTransfer(MoneyInAcc, moneyTransfer))
            {
                return false;
            }

            MoneyInAcc = MoneyInAcc - moneyTransfer;
            accTo.MoneyInAcc = accTo.MoneyInAcc + moneyTransfer;

            return true;
        }

        private bool IsCorrectMoneyTransfer(decimal accMoney, decimal transferMoney)
        {
            if (transferMoney == 0)
            {
                return false;
            }

            if(accMoney < transferMoney)
            {
                return false;
            }

            return true;
        }


    }
}
