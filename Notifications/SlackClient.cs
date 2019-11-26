using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Notifications
{
    public class SlackClient : IDisposable
    {
        private readonly Uri _uri;
        private readonly Encoding _encoding = new UTF8Encoding();
        string urlWithAccessToken = "https://slack.com";
        string token = "xoxp-776136247109-763416065042-776222015621-5148c2dfed24d834f2a4c87d23d805cd";

        public SlackClient()
        {
            _uri = new Uri(urlWithAccessToken);
        }

        public void Dispose()
        {
         
        }

        //Post a message using simple strings  
        public string PostMessage(string text, string username = null, string channel = null)
        {
            Payload payload = new Payload()
            {
                Channel = channel,
                Username = username,
                Text = text
            };

          return   PostMessage(payload);
        }
        public string PostMessage(Payload payload)
        {
            string payloadJson = JsonConvert.SerializeObject(payload);
           
           
            using (var client = new HttpClient())
            {            
                client.BaseAddress = _uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("channel", payload.Channel),
                    new KeyValuePair<string, string>("text", payload.Text)
                };

                var content = new FormUrlEncodedContent(pairs);
                var response = client.PostAsync("/api/chat.postMessage", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return "Mensaje enviado";
                }
                else
                {
                    return response.IsSuccessStatusCode.ToString();
                }
            }

             

        }
    }

    public class Payload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
   
