using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    class Class1
    {
        static public void insert(string command)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = "Server = 172.20.8.6;Port=5432;User Id=st0901;Password=pwd0901;Database=st0901_08";
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = command;
            con.Open();
            cmd.ExecuteReader();
        }
    }
}
