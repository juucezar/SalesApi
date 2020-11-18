using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SalesApp.Models;

namespace SalesApp.Services
{
    class DataService
    {
        HttpClient client = new HttpClient();

        /// <summary>
        /// Obtém os itens de produtos
        /// </summary>
        public async Task<List<Product>> GetProdutosAsync()
        {
            var response = await client.GetStringAsync("https://localhost:44363/api/Product/1");
            var produtos = JsonConvert.DeserializeObject<List<Product>>(response);
            return produtos;
        }
        /// <summary>
        /// Adiciona um item de produto
        /// </summary>
        /// <param name="itemToAdd">Item a adicionar.</param>
        public async Task<int> AddProdutoAsync(Product itemToAdd)
        {
            var data = JsonConvert.SerializeObject(itemToAdd);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44363/api/Product", content);
            var result = JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
            return result;
        }
        /// <summary>
        /// Atualiza um item
        /// </summary>
        /// <param name="itemIndex">indice do Item.</param>
        /// <param name="itemToUpdate">Item a atualizar.</param>
        public async Task<int> UpdateProdutoAsync(int itemIndex, Product itemToUpdate)
        {
            var data = JsonConvert.SerializeObject(itemToUpdate);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(string.Concat("https://localhost:44363/api/Product",
 itemIndex), content);
            return JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
        }
        /// <summary>
        /// Deleta um item 
        /// </summary>
        /// <returns>O id do item a deletar.</returns>
        /// <param name="itemIndex">indice do item.</param>
        public async Task DeleteProdutoAsync(int itemIndex)
        {
            await client.DeleteAsync(string.Concat("https://localhost:44363/api/Product", itemIndex));
        }
    }
}