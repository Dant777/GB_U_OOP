using System;

namespace GB_U_OOP
{
    public class BankАccountType3
    {
        private static int _idCounter;
        private int _id;
        private decimal _moneyInAcc;
        private TypeAccount _typeAccount;

        public BankАccountType3():this(0)
        {
            
        }

        public BankАccountType3( decimal moneyInAcc):this( moneyInAcc, TypeAccount.Normal)
        {
            
        }
        public BankАccountType3( decimal moneyInAcc, TypeAccount typeAccount)
        {
            SetId();
            _moneyInAcc = moneyInAcc;
            _typeAccount = typeAccount;
        }

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


        private void SetId()
        {
            _idCounter++;
            _id = _idCounter;
        }
    }
}
