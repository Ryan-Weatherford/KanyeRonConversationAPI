using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeRonApiConversationLibrary.Model
{
    public class ApiModel
    {
        public string ApiUrl { get; set; }
        public HttpClient NewHttpClient = new HttpClient();
        public string JsonString { get; set; }
        public JToken NewJToken { get; set; }
    }
}
