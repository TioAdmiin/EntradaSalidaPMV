using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSalida
{
    public class Connection
    {
        private static Connection instance;

        private Connection()
        {
            instance = this;
        }

        public Connection GetInstance()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;
        }
    }
}
