using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSalida
{
    internal class Admin : User
    {
        //Constructor
        public Admin(string name, string username, string password) : base(name, username, password)
        {

        }

        //Metodos
        public new bool IsAdmin()
        {
            return true;
        }
    }
}
