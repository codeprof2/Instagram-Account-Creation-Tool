using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class Instagram
{
    private async Task<bool> checkUsername(string username)
    {
        /// <summary>Setup the HttpClient, HttpHandler and CookieContainer</summary>
        CookieContainer instaCookies = new CookieContainer();
        using (HttpClientHandler Handler = new HttpClientHandler() { CookieContainer = instaCookies, UseCookies = true, AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip })
        using (HttpClient Client = new HttpClient(Handler))
        {
            /// <summary>Set the referer header for our requests as Instragram checks to see if it exists</summary>
            Client.DefaultRequestHeaders.Add("referer", "https://www.instagram.com/");

            /// <summary>Set up the post data for when we send the account creation dry run to instagram</summary>
            Dictionary<string, string> instagramPostData = new Dictionary<string, string>
            {
                { "email", "testemail@testemail.test" },
                { "password", "testpassword" },
                { "username", username },
                { "first_name", "testname" }
            };

            /// <summary>Make a GET request to Instagrams login page to set the site cookies inside our cookie container</summary>
            HttpRequestMessage getInstaMsg = new HttpRequestMessage() { Method = HttpMethod.Get, RequestUri = new Uri("https://www.instagram.com/accounts/login/") };
            HttpResponseMessage getInstaResponse = await Client.SendAsync(getInstaMsg);
            string instaResponseString = await getInstaResponse.Content.ReadAsStringAsync();

            /// <summary>Retrieve the csrftoken cookie from the cookie container and set it as a header as Instragram checks this too</summary>
            IEnumerable<Cookie> responseCookies = Handler.CookieContainer.GetCookies(new Uri("https://www.instagram.com")).Cast<Cookie>();
            Client.DefaultRequestHeaders.Add("x-csrftoken", responseCookies.FirstOrDefault(x => x.Name == "csrftoken").Value);

            /// <summary>Make a POST request to Instagrams dry run account creation endpoint</summary>
            HttpRequestMessage postInstaCheck = new HttpRequestMessage() { Method = HttpMethod.Post, RequestUri = new Uri("https://www.instagram.com/accounts/web_create_ajax/attempt/"), Content = new FormUrlEncodedContent(instagramPostData) };
            getInstaResponse = await Client.SendAsync(postInstaCheck);

            /// <summary>Deserialze the JSON response from Instragram in to a Object</summary>
            instagramRootObject instagramResponse = JsonConvert.DeserializeObject<instagramRootObject>(await getInstaResponse.Content.ReadAsStringAsync());

            /// <summary>Return a valid response if the dry run passed else return a invalid response</summary>
            if (instagramResponse.dryrun_passed)
            {
                /// <summary>Now we set the 'seamless login' parameter for the actual account creation request</summary>
                instagramPostData.Add("seamless_login_enabled", "0");

                /// <summary>Make a POST request to Instagrams account creation endpoint</summary>
                HttpRequestMessage postInstaCheck = new HttpRequestMessage() { Method = HttpMethod.Post, RequestUri = new Uri("https://www.instagram.com/accounts/web_create_ajax/"), Content = new FormUrlEncodedContent(instagramPostData) };
                getInstaResponse = await Client.SendAsync(postInstaCheck);
                string resString = await getInstaResponse.Content.ReadAsStringAsync();
            }
            else
                return false;
        }
    }
}
public class Email
{
    public string message { get; set; }
    public string code { get; set; }
}

public class Username
{
    public string message { get; set; }
    public string code { get; set; }
}

public class Password
{
    public string message { get; set; }
    public string code { get; set; }
}

public class Errors
{
    public List<Email> email { get; set; }
    public List<Username> username { get; set; }
    public List<Password> password { get; set; }
}

public class instagramRootObject
{
    public bool account_created { get; set; }
    public Errors errors { get; set; }
    public bool dryrun_passed { get; set; }
    public List<object> username_suggestions { get; set; }
    public string status { get; set; }
    public string error_type { get; set; }
}