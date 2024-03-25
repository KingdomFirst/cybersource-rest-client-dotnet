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
using NLog;
using AuthenticationSdk.util;
using CyberSource.Utilities.Tracking;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransientTokenDataApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Payment Credentials
        /// </summary>
        /// <remarks>
        /// Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>string</returns>
        string GetPaymentCredentialsForTransientToken (string jti);

        /// <summary>
        /// Get Payment Credentials
        /// </summary>
        /// <remarks>
        /// Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetPaymentCredentialsForTransientTokenWithHttpInfo (string jti);
        /// <summary>
        /// Get Transient Token Data
        /// </summary>
        /// <remarks>
        /// Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns></returns>
        void GetTransactionForTransientToken (string transientToken);

        /// <summary>
        /// Get Transient Token Data
        /// </summary>
        /// <remarks>
        /// Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetTransactionForTransientTokenWithHttpInfo (string transientToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Payment Credentials
        /// </summary>
        /// <remarks>
        /// Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetPaymentCredentialsForTransientTokenAsync (string jti);

        /// <summary>
        /// Get Payment Credentials
        /// </summary>
        /// <remarks>
        /// Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetPaymentCredentialsForTransientTokenAsyncWithHttpInfo (string jti);
        /// <summary>
        /// Get Transient Token Data
        /// </summary>
        /// <remarks>
        /// Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetTransactionForTransientTokenAsync (string transientToken);

        /// <summary>
        /// Get Transient Token Data
        /// </summary>
        /// <remarks>
        /// Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetTransactionForTransientTokenAsyncWithHttpInfo (string transientToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransientTokenDataApi : ITransientTokenDataApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransientTokenDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransientTokenDataApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TransientTokenDataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransientTokenDataApi(Configuration configuration = null)
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
        /// Get Payment Credentials Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>string</returns>
        public string GetPaymentCredentialsForTransientToken (string jti)
        {
            logger.Debug("CALLING API \"GetPaymentCredentialsForTransientToken\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<string> localVarResponse = GetPaymentCredentialsForTransientTokenWithHttpInfo(jti);
            logger.Debug("CALLING API \"GetPaymentCredentialsForTransientToken\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Payment Credentials Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetPaymentCredentialsForTransientTokenWithHttpInfo (string jti)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'jti' is set
            if (jti == null)
            {
                logger.Error("ApiException : Missing required parameter 'jti' when calling TransientTokenDataApi->GetPaymentCredentialsForTransientToken");
                throw new ApiException(400, "Missing required parameter 'jti' when calling TransientTokenDataApi->GetPaymentCredentialsForTransientToken");
            }

            var localVarPath = $"/up/v1/payment-credentials/{jti}";
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
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (jti != null)
            {
                localVarPathParams.Add("jti", Configuration.ApiClient.ParameterToString(jti)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPaymentCredentialsForTransientToken", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string))); // Return statement
        }

        /// <summary>
        /// Get Payment Credentials Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetPaymentCredentialsForTransientTokenAsync (string jti)
        {
            logger.Debug("CALLING API \"GetPaymentCredentialsForTransientTokenAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<string> localVarResponse = await GetPaymentCredentialsForTransientTokenAsyncWithHttpInfo(jti);
            logger.Debug("CALLING API \"GetPaymentCredentialsForTransientTokenAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get Payment Credentials Retrieve the Payment data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will return PCI payment data captured by the Unified Checkout platform.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jti">The jti field contained within the Transient token returned from a successful Unified Checkout transaction </param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetPaymentCredentialsForTransientTokenAsyncWithHttpInfo (string jti)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'jti' is set
            if (jti == null)
            {
                logger.Error("ApiException : Missing required parameter 'jti' when calling TransientTokenDataApi->GetPaymentCredentialsForTransientToken");
                throw new ApiException(400, "Missing required parameter 'jti' when calling TransientTokenDataApi->GetPaymentCredentialsForTransientToken");
            }

            var localVarPath = $"/up/v1/payment-credentials/{jti}";
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
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (jti != null)
            {
                localVarPathParams.Add("jti", Configuration.ApiClient.ParameterToString(jti)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPaymentCredentialsForTransientToken", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string))); // Return statement
        }
        /// <summary>
        /// Get Transient Token Data Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns></returns>
        public void GetTransactionForTransientToken (string transientToken)
        {
            logger.Debug("CALLING API \"GetTransactionForTransientToken\" STARTED");
            this.SetStatusCode(null);
            GetTransactionForTransientTokenWithHttpInfo(transientToken);
        }

        /// <summary>
        /// Get Transient Token Data Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetTransactionForTransientTokenWithHttpInfo (string transientToken)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'transientToken' is set
            if (transientToken == null)
            {
                logger.Error("ApiException : Missing required parameter 'transientToken' when calling TransientTokenDataApi->GetTransactionForTransientToken");
                throw new ApiException(400, "Missing required parameter 'transientToken' when calling TransientTokenDataApi->GetTransactionForTransientToken");
            }

            var localVarPath = $"/up/v1/payment-details/{transientToken}";
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
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (transientToken != null)
            {
                localVarPathParams.Add("transientToken", Configuration.ApiClient.ParameterToString(transientToken)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactionForTransientToken", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            this.SetStatusCode(localVarStatusCode);
            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content); // Return statement
        }

        /// <summary>
        /// Get Transient Token Data Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetTransactionForTransientTokenAsync (string transientToken)
        {
            logger.Debug("CALLING API \"GetTransactionForTransientTokenAsync\" STARTED");
            this.SetStatusCode(null);
            await GetTransactionForTransientTokenAsyncWithHttpInfo(transientToken);

        }

        /// <summary>
        /// Get Transient Token Data Retrieve the data captured by Unified Checkout. This API is used to retrieve the detailed data represented by the Transient Token. This API will not return PCI payment data (PAN). Include the Request ID in the GET request to retrieve the transaction details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transientToken">Transient Token returned by the Unified Checkout application. </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetTransactionForTransientTokenAsyncWithHttpInfo (string transientToken)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'transientToken' is set
            if (transientToken == null)
            {
                logger.Error("ApiException : Missing required parameter 'transientToken' when calling TransientTokenDataApi->GetTransactionForTransientToken");
                throw new ApiException(400, "Missing required parameter 'transientToken' when calling TransientTokenDataApi->GetTransactionForTransientToken");
            }

            var localVarPath = $"/up/v1/payment-details/{transientToken}";
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
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (transientToken != null)
            {
                localVarPathParams.Add("transientToken", Configuration.ApiClient.ParameterToString(transientToken)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactionForTransientToken", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            this.SetStatusCode(localVarStatusCode);
            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content); // Return statement
        }
    }
}
