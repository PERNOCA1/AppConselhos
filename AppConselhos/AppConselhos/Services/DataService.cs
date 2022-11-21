using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselhos.Model;

namespace AppConselhos.Services
{
    class DataService
    {
        public static async Task<Conselho> GetAdviceRamdom()
        {
            string url = "https://api.adviceslip.com/advice";
            dynamic result = await 

            return null;
        }

        public static async Task<Conselho> getDataFromService() {
            return null; }
    }
}
