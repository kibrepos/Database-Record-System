using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\8th Gen\\Downloads\\WINDOWS DATABASE\\WinFormVersion4\\WinFormVersion5Francia\\WinFormVersion5Francia\\Database1.mdf\";Integrated Security=True";
        SqlConnection ConnectDstring = new SqlConnection(connectionString);
    }
}
