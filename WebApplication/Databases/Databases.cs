using MySql.Data.MySqlClient;

namespace WebApplication.Databases
{
    public class Databases
    {
        public static MySqlConnection  GetConnetion()
        {
            return new MySqlConnection("Server=localhost;port=3306;Database=dialogue;Uid=root;Pwd=;");
        }
    }
}