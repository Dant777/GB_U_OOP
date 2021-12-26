using System;

namespace GB_U_OOP
{
    public class BankАccountType1
    {
        private int _id;
        private decimal _moneyInAcc;
        private TypeAccount _typeAccount;

        public BankАccountType1():this(1)
        {
            
        }

        public BankАccountType1(int id):this(id, 0)
        {
            
        }

        public BankАccountType1(int id, decimal moneyInAcc):this(id, moneyInAcc, TypeAccount.Normal)
        {
            
        }
        public BankАccountType1(int id, decimal moneyInAcc, TypeAccount typeAccount)
        {
            _id = id;
            _moneyInAcc = moneyInAcc;
            _typeAccount = typeAccount;
        }

        public void SetId(int id)
        {
            _id = id;
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
    }
}
