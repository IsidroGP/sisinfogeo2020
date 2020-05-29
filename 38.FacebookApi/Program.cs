using System;
using Newtonsoft.Json;

namespace _38.FacebookApi{
    class Program{
        static void Main(string[] args){
            string fbtoken = "EAANbKGYQrhkBABT5KZCPmuSPU2aoqvDKuGYEnPejB4ZAFnejnjWKMcaBgjomZBzwtnxwSL3QXQOXZBHEJ0RWofN29WkAVAY3MNScGp5WZBCZBA9qpirmXiufp4LAjm0qV2uMZAHGbztkBbydQPIFHaVL0USZCPPKPwsynsnuU5Wz6nsTvKLhZCb7ZBxn2SgjwHBDODQZCtbcSIBJpVHnImkfQH4";
            string fbfields = "id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb = new FacebookApi(fbtoken);

            string resultado = fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);

            Console.WriteLine(resultado);
        }
    }
}
