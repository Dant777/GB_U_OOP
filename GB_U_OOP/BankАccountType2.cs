using System;

namespace GB_U_OOP
{
    public class BankАccountType2
    {
        private static int _idCounter;
        private int _id;
        private decimal _moneyInAcc;
        private TypeAccount _typeAccount;

        public BankАccountType2():this(0)
        {
            
        }

        public BankАccountType2( decimal moneyInAcc):this( moneyInAcc, TypeAccount.Normal)
        {
            
        }
        public BankАccountType2( decimal moneyInAcc, TypeAccount typeAccount)
        {
            SetId();
            _moneyInAcc = moneyInAcc;
            _typeAccount = typeAccount;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetMoneyInAcc(decimal money)
        {
            _moneyInAcc = money;
        }
        public decimal GetMoneyInAcc()
        {
            return _moneyInAcc;
        }

        public void SetTypeAccount(TypeAccount type)
        {
            _typeAccount = type;
        }
        public TypeAccount GetTypeAccount()
        {
            return _typeAccount;
        }
        private void SetId()
        {
            _idCounter++;
            _id = _idCounter;
        }
    }
}
