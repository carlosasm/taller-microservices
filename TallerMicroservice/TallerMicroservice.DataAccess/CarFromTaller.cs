using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TallerMicroservice.DataAccess.Interface;
using TallerMicroservice.Model;

namespace TallerMicroservice.DataAccess
{
    public class CarFromTaller : ICarFromTaller
    {
        private readonly IConfiguration _configuration;

        public CarFromTaller(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> CreateCarFromTaller(Car car)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(Utils.Constants.UriCarCreateCar);
            string json = JsonConvert.SerializeObject(car);
            HttpContent content = new StringContent(json, Encoding.UTF8, Utils.Constants.MediaTipe);
            client.DefaultRequestHeaders.Add(Utils.Constants.ApiKeyHeaderName, Utils.Constants.ApiKey);

            HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                if (responseBody.Equals(Utils.Constants.True))
                {
                    return true;
                }
                return false;
            }
            else
            {
                throw new Exception("Error getting CreateTaller: " + response.StatusCode);
            }
        }

        public async Task<bool> DeleteCarFromTaller(Car car)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("Car/DeleteCar");
            string json = JsonConvert.SerializeObject(car);
            HttpContent content = new StringContent(json, Encoding.UTF8, Utils.Constants.MediaTipe);
            client.DefaultRequestHeaders.Add(Utils.Constants.ApiKeyHeaderName, Utils.Constants.ApiKey);

            HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                if (responseBody.Equals(Utils.Constants.True))
                {
                    return true;
                }
                return false;
            }
            else
            {
                throw new Exception("Error getting DeleteTaller: " + response.StatusCode);
            }
        }

        public async Task<List<Car>> GetAllCarFromTaller()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Utils.Constants.UriCarGetAllCars);
            HttpContent content = new StringContent("", Encoding.UTF8, Utils.Constants.MediaTipe);
            client.DefaultRequestHeaders.Add(Utils.Constants.ApiKeyHeaderName, Utils.Constants.ApiKey);

            HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Model.Car> newCarFromTaller = JsonConvert.DeserializeObject<List<Model.Car>>(responseBody);

                return newCarFromTaller;
            }
            else
            {
                throw new Exception("Error getting GetAllTaller: " + response.StatusCode);
            }
        }

        public async Task<List<Car>> GetCarFromTallerById(Car car)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Utils.Constants.UriCarGetCarById);
            string json = JsonConvert.SerializeObject(car);
            HttpContent content = new StringContent(json, Encoding.UTF8, Utils.Constants.MediaTipe);
            client.DefaultRequestHeaders.Add(Utils.Constants.ApiKeyHeaderName, Utils.Constants.ApiKey);

            HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Model.Car> newCarFromTaller = JsonConvert.DeserializeObject<List<Model.Car>>(responseBody);

                return newCarFromTaller;
            }
            else
            {
                throw new Exception("Error getting GetTallerById: " + response.StatusCode);
            }
        }

        public async Task<bool> UpdateCarFromTaller(Car car)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Utils.Constants.UriCarUpdateCar);
            string json = JsonConvert.SerializeObject(car);
            HttpContent content = new StringContent(json, Encoding.UTF8, Utils.Constants.MediaTipe);
            client.DefaultRequestHeaders.Add(Utils.Constants.ApiKeyHeaderName, Utils.Constants.ApiKey);

            HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody.Equals(Utils.Constants.True))
                {
                    return true;
                }
                return false;
            }
            else
            {
                throw new Exception("Error getting UpdateTaller: " + response.StatusCode);
            }
        }
    }
}
