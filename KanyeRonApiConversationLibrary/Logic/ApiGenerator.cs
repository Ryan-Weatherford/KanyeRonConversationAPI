using KanyeRonApiConversationLibrary.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace KanyeRonApiConversationLibrary.Logic
{
    public static class ApiGenerator
    {
        public static ApiModel CreateApiConnection(string apiUrl, string apiValue)
        {
            ApiModel newApiModel = new ApiModel();
            newApiModel.ApiUrl = apiUrl;
            newApiModel.JsonString = newApiModel.NewHttpClient.GetStringAsync(apiUrl).Result;
            newApiModel.NewJToken = JObject.Parse(newApiModel.JsonString).GetValue(apiValue).ToString().
                Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();
            return newApiModel;
        }

        public static ApiModel CreateApiConnection(string apiUrl)
        {
            ApiModel newApiModel = new ApiModel();
            newApiModel.ApiUrl = apiUrl;
            newApiModel.JsonString = newApiModel.NewHttpClient.GetStringAsync(apiUrl).Result;
            newApiModel.NewJToken = JArray.Parse(newApiModel.JsonString).ToString().
                Replace('[', ' ').Replace(']', ' ').Replace('"', ' ').Trim();
            return newApiModel;
        }
    }
}
