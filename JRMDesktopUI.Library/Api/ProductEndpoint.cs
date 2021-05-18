﻿using JRMDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JRMDesktopUI.Library.Api
{
    public class ProductEndpoint : IProductEndpoint
    {
        private IAPIHelper _apiHelper;
        public ProductEndpoint(IAPIHelper apiHelper, ProductModel productModel)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<ProductModel>> GetAll()
        {
            var products = new List<ProductModel>();
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Product"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<ProductModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
