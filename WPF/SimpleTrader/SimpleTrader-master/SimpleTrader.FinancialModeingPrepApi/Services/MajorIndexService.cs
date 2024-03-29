﻿using Newtonsoft.Json;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleTrader.FinancialModeingPrepApi.Services
{
    public class MajorIndexService : IMajorIndexService
    {
        private readonly FinancialModelingPrepHttpClientFactory _httpClientFactory;

        public MajorIndexService(FinancialModelingPrepHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
        {
            string uri = $"majors-indexes/{GetUriSuffix(indexType)}";
            using FinancialModelingPrepHttpClient client = _httpClientFactory.CreateHttpClient();

            MajorIndex majorIndex = await client.GetAsync<MajorIndex>(uri);
            majorIndex.Type = indexType;

            return majorIndex;
        }

        private string GetUriSuffix(MajorIndexType indexType)
        {
            switch (indexType)
            {
                case MajorIndexType.DowJones:
                    return ".DJI";

                case MajorIndexType.Nasdaq:
                    return ".IXIC";

                case MajorIndexType.SP500:
                    return ".INX";
                default:
                    throw new Exception($"MajorIndexType {indexType} Suffix Not Available!!");
            }

        }
    }
}
