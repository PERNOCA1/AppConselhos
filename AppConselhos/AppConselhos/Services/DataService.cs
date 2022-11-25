using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselhos.Model;
using Microsoft.CSharp;

namespace AppConselhos.Services
{
    public class DataService
    {
        public static async Task<Conselho> GetAdviceRamdom()
        {
            string url = "https://api.adviceslip.com/advice";
            dynamic result = await getDataFromService(url).ConfigureAwait(false);

            if (result["slip"] != null)
            {
                Conselho advices = new Conselho();
                advices.Id = (string)result["slip"]["id"];
                advices.DicaDoDia = (string)result["slip"]["advice"];
                return advices;
            }
            else
            {
              return null;
            }
        }

        public static async Task<dynamic> getDataFromService(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            dynamic data = null;

            if(response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
                return data;
            
        }

        public static async Task<dynamic> GetAdviceByNum(string Num)
        {
            string url = "https://api.adviceslip.com/advice/" + Num;
            dynamic result = await getDataFromService(url).ConfigureAwait(false);

            //Console.WriteLine(result["slip"]);

            if (result["slip"] != null)
            {
                Conselho advices = new Conselho();
                advices.Id = (string)result["slip"]["id"];
                advices.DicaDoDia = (string)result["slip"]["advice"];

                return advices;
            }
            else
            { 
                return null;
            }
        }

        public static async Task<dynamic> getDataFromServiceByNum(string url)
        {



            Console.WriteLine(url);


            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            dynamic data = null;

            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    }
}
    

