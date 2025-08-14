using BSEB_MVC.Models;
using Newtonsoft.Json;

public class LoginApiResponse
{
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("data")]
    public List<CollegeMaster> Data { get; set; }
}
