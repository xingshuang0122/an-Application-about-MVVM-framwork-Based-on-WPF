using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main( string[] args )
        {
            using (SqlConnection conn = new SqlConnection( ))
            {
                conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;
                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";                
                SqlCommand cmd = new SqlCommand( );
                cmd.Connection = conn;
                cmd.CommandText = "select * from dbo.Person";
                conn.Open( );
                SqlDataReader str = cmd.ExecuteReader( );                
                while (str.Read( ))
                {
                    Console.WriteLine( str[0] );
                }
            }
            Console.WriteLine( "My Database is good!" );
            Console.ReadLine( );
        }
    }
}
