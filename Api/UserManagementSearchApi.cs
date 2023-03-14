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

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserManagementSearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search User Information
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>UmsV1UsersGet200Response</returns>
        UmsV1UsersGet200Response SearchUsers (SearchRequest searchRequest);

        /// <summary>
        /// Search User Information
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        ApiResponse<UmsV1UsersGet200Response> SearchUsersWithHttpInfo (SearchRequest searchRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Search User Information
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        System.Threading.Tasks.Task<UmsV1UsersGet200Response> SearchUsersAsync (SearchRequest searchRequest);

        /// <summary>
        /// Search User Information
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UmsV1UsersGet200Response>> SearchUsersAsyncWithHttpInfo (SearchRequest searchRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserManagementSearchApi : IUserManagementSearchApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementSearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserManagementSearchApi(string basePath)
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
        /// Initializes a new instance of the <see cref="UserManagementSearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserManagementSearchApi(Configuration configuration = null)
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
            return Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
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
        /// Search User Information This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>UmsV1UsersGet200Response</returns>
        public UmsV1UsersGet200Response SearchUsers (SearchRequest searchRequest)
        {
            logger.Debug("CALLING API \"SearchUsers\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<UmsV1UsersGet200Response> localVarResponse = SearchUsersWithHttpInfo(searchRequest);
            logger.Debug("CALLING API \"SearchUsers\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search User Information This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        public ApiResponse< UmsV1UsersGet200Response > SearchUsersWithHttpInfo (SearchRequest searchRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'searchRequest' is set
            if (searchRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'searchRequest' when calling UserManagementSearchApi->SearchUsers");
                throw new ApiException(400, "Missing required parameter 'searchRequest' when calling UserManagementSearchApi->SearchUsers");
            }

            var localVarPath = $"/ums/v1/users/search";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
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

            if (searchRequest != null && searchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(searchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchUsers", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<UmsV1UsersGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UmsV1UsersGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UmsV1UsersGet200Response))); // Return statement
        }

        /// <summary>
        /// Search User Information This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        public async System.Threading.Tasks.Task<UmsV1UsersGet200Response> SearchUsersAsync (SearchRequest searchRequest)
        {
            logger.Debug("CALLING API \"SearchUsersAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<UmsV1UsersGet200Response> localVarResponse = await SearchUsersAsyncWithHttpInfo(searchRequest);
            logger.Debug("CALLING API \"SearchUsersAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Search User Information This endpoint is to get all the user information depending on the filter criteria passed in request body.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UmsV1UsersGet200Response>> SearchUsersAsyncWithHttpInfo (SearchRequest searchRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'searchRequest' is set
            if (searchRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'searchRequest' when calling UserManagementSearchApi->SearchUsers");
                throw new ApiException(400, "Missing required parameter 'searchRequest' when calling UserManagementSearchApi->SearchUsers");
            }

            var localVarPath = $"/ums/v1/users/search";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
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

            if (searchRequest != null && searchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(searchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchUsers", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<UmsV1UsersGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UmsV1UsersGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UmsV1UsersGet200Response))); // Return statement
        }
    }
}
