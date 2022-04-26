using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookServiceAdo.net
{
    public class ContactDetails
    {
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog =AddressBookServiceDB; Integrated Security = True;";
        static SqlConnection connection = new SqlConnection(connectionString);
        public void EstablishConnection()
        {
            if (connection != null && connection.State.Equals(ConnectionState.Closed))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    throw new AddressException(AddressException.ExceptionType.Connection_Failed, "connection failed");

                }

            }
        }
        public void CloseConnection()
        {
            if (connection != null && connection.State.Equals(ConnectionState.Open))
            {
                try
                {
                    connection.Close();
                }
                catch (Exception)
                {
                    throw new AddressException(AddressException.ExceptionType.Connection_Failed, "connection failed");
                }
            }
        }

        
    }
}
