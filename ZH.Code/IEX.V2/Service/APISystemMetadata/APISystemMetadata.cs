﻿using System.Net.Http;
using System.Threading.Tasks;
using ZH.Code.IEX.V2.Helper;
using ZH.Code.IEX.V2.Model.APISystemMetadata.Response;

namespace ZH.Code.IEX.V2.Service.APISystemMetadata
{
    internal class APISystemMetadata : IAPISystemMetadataService
    {
        private readonly string _pk;
        private readonly Executor _executor;

        public APISystemMetadata(HttpClient client, string pk)
        {
            _pk = pk;
            _executor = new Executor(client);
        }

        public async Task<StatusResponse> StatusAsync() => await _executor.NoParamExecute<StatusResponse>("status", _pk);
    }
}