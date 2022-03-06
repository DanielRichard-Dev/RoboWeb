﻿using Newtonsoft.Json;
using RoboServices.RoboInterfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RoboServices.RoboServices
{
    public class RoboService : IRoboService
    {
        HttpClient roboClient;

        public RoboService()
        {
            if (roboClient == null)
                roboClient = new HttpClient() { BaseAddress = new Uri($"{ConfigurationManager.AppSettings["urlRoboApi"]}") };

        }

        public void GetApiRobo(string servicoApiRobo)
        {
            var responseRobo = roboClient.GetAsync(servicoApiRobo).Result;
            var stringDataRobo = responseRobo.Content.ReadAsStringAsync().Result;
            var dataRobo = JsonConvert.DeserializeObject<object>(stringDataRobo);    
        }
    }
}
 