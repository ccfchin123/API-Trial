using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using DigitalIntergrationModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace API_Trial.Controllers
{
    public class MemberController : ApiController
    {
        readonly string ConnectionString = (ConfigurationManager.ConnectionStrings["AMSConnectionString"]).ToString();
        
        [HttpPost]
        public LoginResult LoginFunction([FromBody] User user)
        {
            try
            {
                //LoginResult login = JsonConvert.DeserializeObject<LoginResult>(jObject.ToString());
                bool result = false;
                Guid token = Guid.NewGuid();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("Select [UserName],[Password] FROM [Member] Where [UserName] = @username AND [Password] = @password", connection))
                {
                    command.Parameters.AddWithValue("username", user.Username);
                    command.Parameters.AddWithValue("password", user.Password);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        result = true;
                        using (SqlCommand command2 = new SqlCommand("Update [Token] = @token FROM [Member] Where [UserName] = @username AND [Password] = @password", connection))
                        {
                            command2.Parameters.AddWithValue("username", user.Username);
                            command2.Parameters.AddWithValue("password", user.Password);
                            command2.Parameters.AddWithValue("Token", token);
                            command2.ExecuteNonQuery();
                        }
                    }
                    connection.Close();

                }


                if (result)
                    return new LoginResult(){
                        LoginToken = token.ToString(),
                        LoginSuccess = true,
                        Message = "Login Success",
                        ObjectType = "LoginResult",
                        Status = Status.Ok
                    };
                else
                    return new LoginResult()
                    {
                        LoginToken = "",
                        LoginSuccess = false,
                        Message = "Username or password not validate",
                        ObjectType = "LoginResult",
                        Status = Status.InvalidInfo
                    };
            }
            catch
            {
                return new LoginResult()
                {
                    LoginToken = "",
                    LoginSuccess = false,
                    Message = "Some error occur",
                    ObjectType = "LoginResult",
                    Status = Status.Error
                };
            }
        }

    }
}