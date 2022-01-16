using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public partial class BankAccount
    {
        private readonly string _id;
        private decimal _money;


        public BankAccount(decimal money)
        {
            _id = Guid.NewGuid().ToString();
            Money = money;
        }

        public decimal Money
        {
            get => _money;
            set => _money = value;
        }

        public string Id => _id;


        public override string ToString()
        {
            return $"ID:{_id}; Money: {_money}";
        }


        public static bool operator ==(BankAccount n1, BankAccount n2)
        {
            return (n1.Money == n2.Money);
        }

        public static bool operator !=(BankAccount n1, BankAccount n2)
        {
            return (n1.Money != n2.Money);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            BankAccount n1 = (BankAccount) obj;


            return (n1.Money == Money);
        }

        public override int GetHashCode()
        {
            int hash = Guid.Parse(_id).GetHashCode();
            return hash;
        }

    }
}