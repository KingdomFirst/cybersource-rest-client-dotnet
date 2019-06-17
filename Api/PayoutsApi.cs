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
    public interface IPayoutsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>PtsV2PayoutsPost201Response</returns>
        PtsV2PayoutsPost201Response OctCreatePayment (OctCreatePaymentRequest octCreatePaymentRequest);

        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PayoutsPost201Response</returns>
        ApiResponse<PtsV2PayoutsPost201Response> OctCreatePaymentWithHttpInfo (OctCreatePaymentRequest octCreatePaymentRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>Task of PtsV2PayoutsPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PayoutsPost201Response> OctCreatePaymentAsync (OctCreatePaymentRequest octCreatePaymentRequest);

        /// <summary>
        /// Process a Payout
        /// </summary>
        /// <remarks>
        /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PayoutsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PayoutsPost201Response>> OctCreatePaymentAsyncWithHttpInfo (OctCreatePaymentRequest octCreatePaymentRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PayoutsApi : IPayoutsApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PayoutsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PayoutsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PayoutsApi(Configuration configuration = null)
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
        /// Process a Payout Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>PtsV2PayoutsPost201Response</returns>
        public PtsV2PayoutsPost201Response OctCreatePayment (OctCreatePaymentRequest octCreatePaymentRequest)
        {
             ApiResponse<PtsV2PayoutsPost201Response> localVarResponse = OctCreatePaymentWithHttpInfo(octCreatePaymentRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process a Payout Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PayoutsPost201Response</returns>
        public ApiResponse< PtsV2PayoutsPost201Response > OctCreatePaymentWithHttpInfo (OctCreatePaymentRequest octCreatePaymentRequest)
        {
            // verify the required parameter 'octCreatePaymentRequest' is set
            if (octCreatePaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'octCreatePaymentRequest' when calling PayoutsApi->OctCreatePayment");

            var localVarPath = $"/pts/v2/payouts";
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
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (octCreatePaymentRequest != null && octCreatePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(octCreatePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = octCreatePaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OctCreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PayoutsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PayoutsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PayoutsPost201Response)));
        }

        /// <summary>
        /// Process a Payout Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>Task of PtsV2PayoutsPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PayoutsPost201Response> OctCreatePaymentAsync (OctCreatePaymentRequest octCreatePaymentRequest)
        {
             ApiResponse<PtsV2PayoutsPost201Response> localVarResponse = await OctCreatePaymentAsyncWithHttpInfo(octCreatePaymentRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process a Payout Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="octCreatePaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PayoutsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PayoutsPost201Response>> OctCreatePaymentAsyncWithHttpInfo (OctCreatePaymentRequest octCreatePaymentRequest)
        {
            // verify the required parameter 'octCreatePaymentRequest' is set
            if (octCreatePaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'octCreatePaymentRequest' when calling PayoutsApi->OctCreatePayment");

            var localVarPath = $"/pts/v2/payouts";
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
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (octCreatePaymentRequest != null && octCreatePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(octCreatePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = octCreatePaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OctCreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PayoutsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PayoutsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PayoutsPost201Response)));
        }

    }
}

