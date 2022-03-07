using Newtonsoft.Json;
using RoboModels.RoboModels;
using RoboServices.RoboInterfaces;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;

namespace RoboServices.RoboServices
{
    public class RoboService<T> : IRoboService<T>
    {
        HttpClient roboClient;

        public RoboService()
        {
            if (roboClient == null)
                roboClient = new HttpClient() { BaseAddress = new Uri($"{ConfigurationManager.AppSettings["urlRoboApi"]}") };
        }

        public RoboApiModel GetApiRobo(string servicoApiRobo)
        {
            var responseRobo = roboClient.GetAsync(servicoApiRobo).Result;
            var stringDataRobo = responseRobo.Content.ReadAsStringAsync().Result;
            var robo = JsonConvert.DeserializeObject<RoboApiModel>(stringDataRobo);

            return robo;
        }

        public RoboApiModel PutApiRobo(string servicoApiRobo, T put)
        {
            var jsonRoboPut = JsonConvert.SerializeObject(put);
            var contentRobo = new StringContent(jsonRoboPut.ToString(), Encoding.UTF8, "application/json");
            var responseRobo = roboClient.PutAsync(servicoApiRobo, contentRobo).Result;
            var stringDataRobo = responseRobo.Content.ReadAsStringAsync().Result;
            var robo = JsonConvert.DeserializeObject<RoboApiModel>(stringDataRobo);

            return robo;
        }
    }
}
 