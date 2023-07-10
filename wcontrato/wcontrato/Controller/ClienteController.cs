using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcontrato.Controller
{
    public class ClienteController
    {

        public static async Task<Model.Cliente> obtemDadosCliente(int codigoCliente)
        {

            Model.Cliente cliente = new Model.Cliente();

            string apiURL = "https://www.servicoweber.com.br/api/wcontrato/obtemDadosCliente.php";
            string apiToken = "2d6abb08-f568-446b-XAS2d-cc9658f8c8123";


            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromMinutes(2);
            client.BaseAddress = new Uri(apiURL);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();


            Model.Geolocalizacao geolocalizacao = Controller.GeolocalizacaoController.ObtemGeolocalizacaoAtual();


            string chaveMaquina = Utilitarios.Util.ObtemEnderecoMAC();

            List<string> parametros = new List<string>();
            parametros.Add(apiToken);
            parametros.Add(chaveMaquina.ToString());
            parametros.Add(Controller.AplicacaoController.ObtemCompilacaoApp().ToString("yyyy-MM-dd HH:mm:ss"));
            parametros.Add(geolocalizacao.Latitude.ToString());
            parametros.Add(geolocalizacao.Longitude.ToString());
            parametros.Add(codigoCliente.ToString());

            string parametrosJson = JsonConvert.SerializeObject(parametros);

            Dictionary<string, string> values = new Dictionary<string, string>
                    {
                        { "dado1", parametrosJson  },
                        { "token", "0" },
                        { "comando", "obtemDadosClienteWeber" },
                        { "apiViaPost", "1" }
                    };

            FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(values);

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpResponseMessage httpResponseMessage = await client.PostAsync(apiURL, formUrlEncodedContent);
            string jsonResult = await httpResponseMessage.Content.ReadAsStringAsync();
           

            //Caso tenha erro maximiza o form caso esteja minimizado
            bool erroNaExecucao = false;

            if (jsonResult != null)
            {
                Model.ApiResponse resultado = JsonConvert.DeserializeObject<Model.ApiResponse>(jsonResult);
                if (resultado.status == 1)
                {

                    if (resultado.data != null)
                    {

                        cliente = JsonConvert.DeserializeObject<Model.Cliente>(resultado.data.ToString().Substring(1, resultado.data.ToString().Length - 2));


                    } else
                    {
                        throw new Exception("Nenhum cliente localizado com código informado");
                    }

                }
                else
                {
                    erroNaExecucao = true;
                    throw new Exception("Erro na renovação: " + resultado.msg);
                }

            }
            else
            {
                erroNaExecucao = true;
                throw new Exception("Retorno da API nulo");
            }


            return cliente;

        }

    }

}
