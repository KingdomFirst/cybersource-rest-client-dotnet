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
    public interface IPush_FundsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process a Push Funds Transfer
        /// </summary>
        /// <remarks>
        /// Receive funds using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>PushFunds201Response</returns>
        PushFunds201Response CreatePushFundsTransfer (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId);

        /// <summary>
        /// Process a Push Funds Transfer
        /// </summary>
        /// <remarks>
        /// Receive funds using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>ApiResponse of PushFunds201Response</returns>
        ApiResponse<PushFunds201Response> CreatePushFundsTransferWithHttpInfo (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process a Push Funds Transfer
        /// </summary>
        /// <remarks>
        /// Receive funds using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>Task of PushFunds201Response</returns>
        System.Threading.Tasks.Task<PushFunds201Response> CreatePushFundsTransferAsync (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId);

        /// <summary>
        /// Process a Push Funds Transfer
        /// </summary>
        /// <remarks>
        /// Receive funds using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>Task of ApiResponse (PushFunds201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PushFunds201Response>> CreatePushFundsTransferAsyncWithHttpInfo (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Push_FundsApi : IPush_FundsApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="Push_FundsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public Push_FundsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="Push_FundsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public Push_FundsApi(Configuration configuration = null)
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
        /// Process a Push Funds Transfer Receive funds using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>PushFunds201Response</returns>
        public PushFunds201Response CreatePushFundsTransfer (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)
        {
            logger.Debug("CALLING API \"CreatePushFundsTransfer\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PushFunds201Response> localVarResponse = CreatePushFundsTransferWithHttpInfo(pushFundsRequest, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
            logger.Debug("CALLING API \"CreatePushFundsTransfer\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Process a Push Funds Transfer Receive funds using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>ApiResponse of PushFunds201Response</returns>
        public ApiResponse< PushFunds201Response > CreatePushFundsTransferWithHttpInfo (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'pushFundsRequest' is set
            if (pushFundsRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'pushFundsRequest' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'pushFundsRequest' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'contentType' is set
            if (contentType == null)
            {
                logger.Error("ApiException : Missing required parameter 'contentType' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'contentType' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'xRequestid' is set
            if (xRequestid == null)
            {
                logger.Error("ApiException : Missing required parameter 'xRequestid' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'xRequestid' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCMerchantId' is set
            if (vCMerchantId == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCMerchantId' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCMerchantId' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCPermissions' is set
            if (vCPermissions == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCPermissions' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCPermissions' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCCorrelationId' is set
            if (vCCorrelationId == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCCorrelationId' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCCorrelationId' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCOrganizationId' is set
            if (vCOrganizationId == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCOrganizationId' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCOrganizationId' when calling Push_FundsApi->CreatePushFundsTransfer");
            }

            var localVarPath = $"/pts/v1/push-funds-transfer";
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

            if (contentType != null)
            {
                localVarHeaderParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            }
            if (xRequestid != null)
            {
                localVarHeaderParams.Add("x-requestid", Configuration.ApiClient.ParameterToString(xRequestid)); // header parameter
            }
            if (vCMerchantId != null)
            {
                localVarHeaderParams.Add("v-c-merchant-id", Configuration.ApiClient.ParameterToString(vCMerchantId)); // header parameter
            }
            if (vCPermissions != null)
            {
                localVarHeaderParams.Add("v-c-permissions", Configuration.ApiClient.ParameterToString(vCPermissions)); // header parameter
            }
            if (vCCorrelationId != null)
            {
                localVarHeaderParams.Add("v-c-correlation-id", Configuration.ApiClient.ParameterToString(vCCorrelationId)); // header parameter
            }
            if (vCOrganizationId != null)
            {
                localVarHeaderParams.Add("v-c-organization-id", Configuration.ApiClient.ParameterToString(vCOrganizationId)); // header parameter
            }
            if (pushFundsRequest != null && pushFundsRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                pushFundsRequest = (PushFundsRequest)sdkTracker.InsertDeveloperIdTracker(pushFundsRequest, pushFundsRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(pushFundsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushFundsRequest; // byte array
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePushFundsTransfer", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PushFunds201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PushFunds201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PushFunds201Response))); // Return statement
        }

        /// <summary>
        /// Process a Push Funds Transfer Receive funds using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>Task of PushFunds201Response</returns>
        public async System.Threading.Tasks.Task<PushFunds201Response> CreatePushFundsTransferAsync (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)
        {
            logger.Debug("CALLING API \"CreatePushFundsTransferAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PushFunds201Response> localVarResponse = await CreatePushFundsTransferAsyncWithHttpInfo(pushFundsRequest, contentType, xRequestid, vCMerchantId, vCPermissions, vCCorrelationId, vCOrganizationId);
            logger.Debug("CALLING API \"CreatePushFundsTransferAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Process a Push Funds Transfer Receive funds using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushFundsRequest"></param>
        /// <param name="contentType"></param>
        /// <param name="xRequestid"></param>
        /// <param name="vCMerchantId"></param>
        /// <param name="vCPermissions"></param>
        /// <param name="vCCorrelationId"></param>
        /// <param name="vCOrganizationId"></param>
        /// <returns>Task of ApiResponse (PushFunds201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PushFunds201Response>> CreatePushFundsTransferAsyncWithHttpInfo (PushFundsRequest pushFundsRequest, string contentType, string xRequestid, string vCMerchantId, string vCPermissions, string vCCorrelationId, string vCOrganizationId)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'pushFundsRequest' is set
            if (pushFundsRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'pushFundsRequest' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'pushFundsRequest' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'contentType' is set
            if (contentType == null)
            {
                logger.Error("ApiException : Missing required parameter 'contentType' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'contentType' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'xRequestid' is set
            if (xRequestid == null)
            {
                logger.Error("ApiException : Missing required parameter 'xRequestid' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'xRequestid' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCMerchantId' is set
            if (vCMerchantId == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCMerchantId' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCMerchantId' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCPermissions' is set
            if (vCPermissions == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCPermissions' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCPermissions' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCCorrelationId' is set
            if (vCCorrelationId == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCCorrelationId' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCCorrelationId' when calling Push_FundsApi->CreatePushFundsTransfer");
            }
            // verify the required parameter 'vCOrganizationId' is set
            if (vCOrganizationId == null)
            {
                logger.Error("ApiException : Missing required parameter 'vCOrganizationId' when calling Push_FundsApi->CreatePushFundsTransfer");
                throw new ApiException(400, "Missing required parameter 'vCOrganizationId' when calling Push_FundsApi->CreatePushFundsTransfer");
            }

            var localVarPath = $"/pts/v1/push-funds-transfer";
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

            if (contentType != null)
            {
                localVarHeaderParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            }
            if (xRequestid != null)
            {
                localVarHeaderParams.Add("x-requestid", Configuration.ApiClient.ParameterToString(xRequestid)); // header parameter
            }
            if (vCMerchantId != null)
            {
                localVarHeaderParams.Add("v-c-merchant-id", Configuration.ApiClient.ParameterToString(vCMerchantId)); // header parameter
            }
            if (vCPermissions != null)
            {
                localVarHeaderParams.Add("v-c-permissions", Configuration.ApiClient.ParameterToString(vCPermissions)); // header parameter
            }
            if (vCCorrelationId != null)
            {
                localVarHeaderParams.Add("v-c-correlation-id", Configuration.ApiClient.ParameterToString(vCCorrelationId)); // header parameter
            }
            if (vCOrganizationId != null)
            {
                localVarHeaderParams.Add("v-c-organization-id", Configuration.ApiClient.ParameterToString(vCOrganizationId)); // header parameter
            }
            if (pushFundsRequest != null && pushFundsRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                pushFundsRequest = (PushFundsRequest)sdkTracker.InsertDeveloperIdTracker(pushFundsRequest, pushFundsRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(pushFundsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushFundsRequest; // byte array
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
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePushFundsTransfer", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PushFunds201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PushFunds201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PushFunds201Response))); // Return statement
        }
    }
}
