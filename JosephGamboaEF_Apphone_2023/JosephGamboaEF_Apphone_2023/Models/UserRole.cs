using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JosephGamboaEF_Apphone_2023.Models
{
    public class UserRole
    {
        public RestRequest Request { get; set; }
        
        public int UserRoleId { get; set; }
        public string UserRole1 { get; set; } = null!;
        public bool IsUserSelectable { get; set; }

        public async Task<List<UserRole>> GetAllUserRolesAsync()
        {
            try
            {
                string RouteSufix = string.Format("UserRoles");
                string URL = Services.APIConnection.ProductionPrefixURL + RouteSufix;
                RestClient client = new RestClient(URL);
                Request = new RestRequest(URL, Method.Get);
                Request.AddHeader(Services.APIConnection.ApikeyName, Services.APIConnection.ApikeyValue);
                
                RestResponse response = await client.ExecuteAsync(Request);
                
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);
                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }
    }
}
