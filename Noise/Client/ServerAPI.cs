﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Noise.Client
{
    public class ServerAPI
    {
        public class ServerResponse
        {
            public int statusCode {  get; set; }
            public string response { get; set; }
        }

        private static readonly HttpClient client = new HttpClient();
        public static async Task<ServerResponse> authUser(string username, string password)
        {            
            var userData = new Dictionary<string, string>
            {
                { "login", username },
                { "password", password },
            };

            var data = new FormUrlEncodedContent(userData);
            var response = await client.PostAsync(Config.apiURL + "user/authorize", data);
            var responseString = await response.Content.ReadAsStringAsync();

            ServerResponse serverResponse = new ServerResponse() {
                statusCode = (int)response.StatusCode,
                response = responseString,
            };

            return serverResponse;
        }

        public static async Task<ServerResponse> registerUser(string username, string email, string password)
        {
            var userData = new Dictionary<string, string>
            {
                { "login", username },
                { "email", email },
                { "password", password },
            };

            var data = new FormUrlEncodedContent(userData);
            var response = await client.PostAsync(Config.apiURL + "user/register", data);
            var responseString = await response.Content.ReadAsStringAsync();

            ServerResponse serverResponse = new ServerResponse()
            {
                statusCode = (int)response.StatusCode,
                response = responseString,
            };

            return serverResponse;
        }
    }
}