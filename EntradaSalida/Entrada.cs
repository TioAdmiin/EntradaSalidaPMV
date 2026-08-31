using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSalida
{
    internal class Entrada
    {
        //Atributos
        private DateTime joinDate;

        //Constructo

        //Metodos
        public DayOfWeek GetDayOfWeek()
        {
            return joinDate.DayOfWeek;
        }
    }
}
