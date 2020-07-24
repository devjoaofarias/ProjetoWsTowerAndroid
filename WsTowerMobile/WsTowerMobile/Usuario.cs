using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WsTowerMobile
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
