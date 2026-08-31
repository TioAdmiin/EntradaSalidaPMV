using System;
using System.Collections.Generic;

namespace EntradaSalida
{
    internal class User
    {
        //Informacion Personal
        private string name;
        private string username;
        private string password;

        //Entradas y Salidas
        private TimeSpan joinTime;
        private TimeSpan leaveTime;
        private List<DayOfWeek> workDays;

        //Ctor
        public User(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        //Metodos
        public bool IsAdmin() { return false; }
    }
}