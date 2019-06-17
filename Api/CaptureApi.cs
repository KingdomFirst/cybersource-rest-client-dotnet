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
    public interface ICaptureApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>PtsV2PaymentsCapturesPost201Response</returns>
        PtsV2PaymentsCapturesPost201Response CapturePayment (CapturePaymentRequest capturePaymentRequest, string id);

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>ApiResponse of PtsV2PaymentsCapturesPost201Response</returns>
        ApiResponse<PtsV2PaymentsCapturesPost201Response> CapturePaymentWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of PtsV2PaymentsCapturesPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsCapturesPost201Response> CapturePaymentAsync (CapturePaymentRequest capturePaymentRequest, string id);

        /// <summary>
        /// Capture a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to capture the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsCapturesPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsCapturesPost201Response>> CapturePaymentAsyncWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CaptureApi : ICaptureApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CaptureApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CaptureApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CaptureApi(Configuration configuration = null)
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
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>PtsV2PaymentsCapturesPost201Response</returns>
        public PtsV2PaymentsCapturesPost201Response CapturePayment (CapturePaymentRequest capturePaymentRequest, string id)
        {
             ApiResponse<PtsV2PaymentsCapturesPost201Response> localVarResponse = CapturePaymentWithHttpInfo(capturePaymentRequest, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>ApiResponse of PtsV2PaymentsCapturesPost201Response</returns>
        public ApiResponse< PtsV2PaymentsCapturesPost201Response > CapturePaymentWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id)
        {
            // verify the required parameter 'capturePaymentRequest' is set
            if (capturePaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'capturePaymentRequest' when calling CaptureApi->CapturePayment");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CaptureApi->CapturePayment");

            var localVarPath = $"/pts/v2/payments/{id}/captures";
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

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (capturePaymentRequest != null && capturePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(capturePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = capturePaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CapturePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsCapturesPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsCapturesPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsCapturesPost201Response)));
        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of PtsV2PaymentsCapturesPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsCapturesPost201Response> CapturePaymentAsync (CapturePaymentRequest capturePaymentRequest, string id)
        {
             ApiResponse<PtsV2PaymentsCapturesPost201Response> localVarResponse = await CapturePaymentAsyncWithHttpInfo(capturePaymentRequest, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Capture a Payment Include the payment ID in the POST request to capture the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="capturePaymentRequest"></param>
        /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment. </param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsCapturesPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsCapturesPost201Response>> CapturePaymentAsyncWithHttpInfo (CapturePaymentRequest capturePaymentRequest, string id)
        {
            // verify the required parameter 'capturePaymentRequest' is set
            if (capturePaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'capturePaymentRequest' when calling CaptureApi->CapturePayment");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CaptureApi->CapturePayment");

            var localVarPath = $"/pts/v2/payments/{id}/captures";
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

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (capturePaymentRequest != null && capturePaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(capturePaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = capturePaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CapturePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsCapturesPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsCapturesPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsCapturesPost201Response)));
        }

    }
}

