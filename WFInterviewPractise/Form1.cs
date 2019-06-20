using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WFInterviewPractise.Models;

namespace WFInterviewPractise
{
    public partial class Pokedex : Form
    {
        public Pokedex()
        {
            InitializeComponent();
        }

        private async void btn_randm_Click(object sender, EventArgs e)
        {
            PokemonEntity result = await GetPokemon();
            PokemonEntity pokemonEntity = Newtonsoft.Json.JsonConvert.DeserializeObject<PokemonEntity>(result.result);
            lbl_name_resp.Text = pokemonEntity.name;
            lbl_id_resp.Text = pokemonEntity.id.ToString();
            lbl_capture_rate_resp.Text = pokemonEntity.capture_rate.ToString();
        }

        static HttpClient client = new HttpClient();
        static async Task<PokemonEntity> GetPokemon()
        {
            var result = new PokemonEntity();
            try
            {
                Random rnd = new Random();
                int rndId = rnd.Next(1, 151); // creates a number between 1 and 151

                using (HttpResponseMessage response = await client.GetAsync(new Uri("https://pokeapi.co/api/v2/pokemon-species/" + rndId)))
                {
                    using (HttpContent content = response.Content)
                    {
                        string resultString = await content.ReadAsStringAsync();
                        string reasonPhrase = response.ReasonPhrase;
                        HttpResponseHeaders headers = response.Headers;
                        HttpStatusCode code = response.StatusCode;

                        result.result = resultString;
                        result.reasonPhrase = reasonPhrase;
                        result.headers = headers;
                        result.code = code;


                    }
                }
            } catch (Exception e)
            {
                result.errorMessage = e.Message;
            }
            return result;
        }
    }
}
