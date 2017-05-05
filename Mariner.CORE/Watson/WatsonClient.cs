using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mariner.DOMAIN.GaiaCORE;
using RestSharp;
using RestSharp.Deserializers;

namespace Mariner.CORE.Watson
{
    public class WatsonClient
    {

        public ResultWatson ListarClassificadores(string fileName, Byte[] dataFile)
        {
            RestClient restClient = new RestClient("https://gateway-a.watsonplatform.net/visual-recognition/api/v3/classify?api_key=286a7d8afb972dc3a13daaba059444a5e206379e&version=2016-05-20");
            RestRequest restRequest = new RestRequest()
            {
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };

            restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            restRequest.AddFileBytes("images_file", dataFile, fileName, "image/png");

            var response = restClient.Execute<ResultWatson>(restRequest);           
            return response.Data; 
        }
    }
}
