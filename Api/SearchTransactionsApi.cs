/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchTransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        TssV2TransactionsPost201Response CreateSearch (CreateSearchRequest createSearchRequest);

        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        ApiResponse<TssV2TransactionsPost201Response> CreateSearchWithHttpInfo (CreateSearchRequest createSearchRequest);
        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        TssV2TransactionsPost201Response GetSearch (string searchId);

        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        ApiResponse<TssV2TransactionsPost201Response> GetSearchWithHttpInfo (string searchId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        System.Threading.Tasks.Task<TssV2TransactionsPost201Response> CreateSearchAsync (CreateSearchRequest createSearchRequest);

        /// <summary>
        /// Create a search request
        /// </summary>
        /// <remarks>
        /// Create a search request. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> CreateSearchAsyncWithHttpInfo (CreateSearchRequest createSearchRequest);
        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        System.Threading.Tasks.Task<TssV2TransactionsPost201Response> GetSearchAsync (string searchId);

        /// <summary>
        /// Get Search results
        /// </summary>
        /// <remarks>
        /// Include the Search ID in the GET request to retrieve the search results.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> GetSearchAsyncWithHttpInfo (string searchId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchTransactionsApi : ISearchTransactionsApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchTransactionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchTransactionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create a search request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        public TssV2TransactionsPost201Response CreateSearch (CreateSearchRequest createSearchRequest)
        {
             ApiResponse<TssV2TransactionsPost201Response> localVarResponse = CreateSearchWithHttpInfo(createSearchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a search request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        public ApiResponse< TssV2TransactionsPost201Response > CreateSearchWithHttpInfo (CreateSearchRequest createSearchRequest)
        {
            // verify the required parameter 'createSearchRequest' is set
            if (createSearchRequest == null)
                throw new ApiException(400, "Missing required parameter 'createSearchRequest' when calling SearchTransactionsApi->CreateSearch");

            var localVarPath = $"/tss/v2/searches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createSearchRequest != null && createSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createSearchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response)));
        }

        /// <summary>
        /// Create a search request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        public async System.Threading.Tasks.Task<TssV2TransactionsPost201Response> CreateSearchAsync (CreateSearchRequest createSearchRequest)
        {
             ApiResponse<TssV2TransactionsPost201Response> localVarResponse = await CreateSearchAsyncWithHttpInfo(createSearchRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a search request Create a search request. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createSearchRequest"></param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> CreateSearchAsyncWithHttpInfo (CreateSearchRequest createSearchRequest)
        {
            // verify the required parameter 'createSearchRequest' is set
            if (createSearchRequest == null)
                throw new ApiException(400, "Missing required parameter 'createSearchRequest' when calling SearchTransactionsApi->CreateSearch");

            var localVarPath = $"/tss/v2/searches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createSearchRequest != null && createSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createSearchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response)));
        }

        /// <summary>
        /// Get Search results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>TssV2TransactionsPost201Response</returns>
        public TssV2TransactionsPost201Response GetSearch (string searchId)
        {
             ApiResponse<TssV2TransactionsPost201Response> localVarResponse = GetSearchWithHttpInfo(searchId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Search results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>ApiResponse of TssV2TransactionsPost201Response</returns>
        public ApiResponse< TssV2TransactionsPost201Response > GetSearchWithHttpInfo (string searchId)
        {
            // verify the required parameter 'searchId' is set
            if (searchId == null)
                throw new ApiException(400, "Missing required parameter 'searchId' when calling SearchTransactionsApi->GetSearch");

            var localVarPath = $"/tss/v2/searches/{searchId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchId != null) localVarPathParams.Add("searchId", Configuration.ApiClient.ParameterToString(searchId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response)));
        }

        /// <summary>
        /// Get Search results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of TssV2TransactionsPost201Response</returns>
        public async System.Threading.Tasks.Task<TssV2TransactionsPost201Response> GetSearchAsync (string searchId)
        {
             ApiResponse<TssV2TransactionsPost201Response> localVarResponse = await GetSearchAsyncWithHttpInfo(searchId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Search results Include the Search ID in the GET request to retrieve the search results.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchId">Search ID.</param>
        /// <returns>Task of ApiResponse (TssV2TransactionsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TssV2TransactionsPost201Response>> GetSearchAsyncWithHttpInfo (string searchId)
        {
            // verify the required parameter 'searchId' is set
            if (searchId == null)
                throw new ApiException(400, "Missing required parameter 'searchId' when calling SearchTransactionsApi->GetSearch");

            var localVarPath = $"/tss/v2/searches/{searchId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchId != null) localVarPathParams.Add("searchId", Configuration.ApiClient.ParameterToString(searchId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TssV2TransactionsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TssV2TransactionsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TssV2TransactionsPost201Response)));
        }

    }
}
