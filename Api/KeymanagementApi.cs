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
using NLog;
using AuthenticationSdk.util;
using CyberSource.Utilities.Tracking;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKeymanagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search Keys
        /// </summary>
        /// <remarks>
        /// Search one or more Keys
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 SearchKeys (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null);

        /// <summary>
        /// Search Keys
        /// </summary>
        /// <remarks>
        /// Search one or more Keys
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        ApiResponse<InlineResponse20011> SearchKeysWithHttpInfo (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Search Keys
        /// </summary>
        /// <remarks>
        /// Search one or more Keys
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>Task of InlineResponse20011</returns>
        System.Threading.Tasks.Task<InlineResponse20011> SearchKeysAsync (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null);

        /// <summary>
        /// Search Keys
        /// </summary>
        /// <remarks>
        /// Search one or more Keys
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> SearchKeysAsyncWithHttpInfo (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KeymanagementApi : IKeymanagementApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeymanagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KeymanagementApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeymanagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KeymanagementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
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
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
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
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode == null ? 0 : (int) this._statusCode;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }

        /// <summary>
        /// Search Keys Search one or more Keys
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>InlineResponse20011</returns>
        public InlineResponse20011 SearchKeys (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null)
        {
            logger.Debug("CALLING API \"SearchKeys\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<InlineResponse20011> localVarResponse = SearchKeysWithHttpInfo(offset, limit, sort, organizationIds, keyIds, keyTypes, expirationStartDate, expirationEndDate);
            logger.Debug("CALLING API \"SearchKeys\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search Keys Search one or more Keys
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        public ApiResponse< InlineResponse20011 > SearchKeysWithHttpInfo (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null)
        {
            LogUtility logUtility = new LogUtility();


            var localVarPath = $"/kms/v2/keys";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (offset != null)
            {
                localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            }
            if (limit != null)
            {
                localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            }
            if (sort != null)
            {
                localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            }
            if (organizationIds != null)
            {
                localVarQueryParams.Add("organizationIds", Configuration.ApiClient.ParameterToString(organizationIds)); // query parameter
            }
            if (keyIds != null)
            {
                localVarQueryParams.Add("keyIds", Configuration.ApiClient.ParameterToString(keyIds)); // query parameter
            }
            if (keyTypes != null)
            {
                localVarQueryParams.Add("keyTypes", Configuration.ApiClient.ParameterToString(keyTypes)); // query parameter
            }
            if (expirationStartDate != null)
            {
                localVarQueryParams.Add("expirationStartDate", Configuration.ApiClient.ParameterToString(expirationStartDate)); // query parameter
            }
            if (expirationEndDate != null)
            {
                localVarQueryParams.Add("expirationEndDate", Configuration.ApiClient.ParameterToString(expirationEndDate)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.GET == Method.POST)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchKeys", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InlineResponse20011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20011))); // Return statement
        }

        /// <summary>
        /// Search Keys Search one or more Keys
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>Task of InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<InlineResponse20011> SearchKeysAsync (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null)
        {
            logger.Debug("CALLING API \"SearchKeysAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<InlineResponse20011> localVarResponse = await SearchKeysAsyncWithHttpInfo(offset, limit, sort, organizationIds, keyIds, keyTypes, expirationStartDate, expirationEndDate);
            logger.Debug("CALLING API \"SearchKeysAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Search Keys Search one or more Keys
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">This allows you to specify the page offset from the resulting list resultset you want the records to be returned (optional)</param>
        /// <param name="limit">This allows you to specify the total number of records to be returned off the resulting list resultset (optional)</param>
        /// <param name="sort">This allows you to specify a comma separated list of fields in the order which the resulting list resultset must be sorted. (optional)</param>
        /// <param name="organizationIds">List of Orgaization Ids to search. The maximum size of the organization Ids list is 1. The maximum length of Organization Id is 30. (optional)</param>
        /// <param name="keyIds">List of Key Ids to search. The maximum size of the Key Ids list is 1 (optional)</param>
        /// <param name="keyTypes">Key Type, Possible values -  certificate, password, pgp and scmp_api. When Key Type is provided atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationStartDate">Expiry Filter Start Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <param name="expirationEndDate">Expiry Filter End Date. When Expiration Date filter is provided, atleast one more filter needs to be provided (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> SearchKeysAsyncWithHttpInfo (int? offset = null, int? limit = null, string sort = null, List<string> organizationIds = null, List<string> keyIds = null, List<string> keyTypes = null, DateTime? expirationStartDate = null, DateTime? expirationEndDate = null)
        {
            LogUtility logUtility = new LogUtility();


            var localVarPath = $"/kms/v2/keys";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (offset != null)
            {
                localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            }
            if (limit != null)
            {
                localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            }
            if (sort != null)
            {
                localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            }
            if (organizationIds != null)
            {
                localVarQueryParams.Add("organizationIds", Configuration.ApiClient.ParameterToString(organizationIds)); // query parameter
            }
            if (keyIds != null)
            {
                localVarQueryParams.Add("keyIds", Configuration.ApiClient.ParameterToString(keyIds)); // query parameter
            }
            if (keyTypes != null)
            {
                localVarQueryParams.Add("keyTypes", Configuration.ApiClient.ParameterToString(keyTypes)); // query parameter
            }
            if (expirationStartDate != null)
            {
                localVarQueryParams.Add("expirationStartDate", Configuration.ApiClient.ParameterToString(expirationStartDate)); // query parameter
            }
            if (expirationEndDate != null)
            {
                localVarQueryParams.Add("expirationEndDate", Configuration.ApiClient.ParameterToString(expirationEndDate)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.GET == Method.POST)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchKeys", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InlineResponse20011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20011))); // Return statement
        }
    }
}
