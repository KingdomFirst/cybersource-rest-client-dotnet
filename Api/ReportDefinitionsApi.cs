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
    public interface IReportDefinitionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Report Definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportDefinitionsNameGet200Response</returns>
        ReportingV3ReportDefinitionsNameGet200Response GetResourceInfoByReportDefinition (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null);

        /// <summary>
        /// Get Report Definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportDefinitionsNameGet200Response</returns>
        ApiResponse<ReportingV3ReportDefinitionsNameGet200Response> GetResourceInfoByReportDefinitionWithHttpInfo (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null);
        /// <summary>
        /// Get Reporting Resource Information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportDefinitionsGet200Response</returns>
        ReportingV3ReportDefinitionsGet200Response GetResourceV2Info (string subscriptionType = null, string organizationId = null);

        /// <summary>
        /// Get Reporting Resource Information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportDefinitionsGet200Response</returns>
        ApiResponse<ReportingV3ReportDefinitionsGet200Response> GetResourceV2InfoWithHttpInfo (string subscriptionType = null, string organizationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Report Definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportDefinitionsNameGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3ReportDefinitionsNameGet200Response> GetResourceInfoByReportDefinitionAsync (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null);

        /// <summary>
        /// Get Report Definition
        /// </summary>
        /// <remarks>
        /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportDefinitionsNameGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3ReportDefinitionsNameGet200Response>> GetResourceInfoByReportDefinitionAsyncWithHttpInfo (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null);
        /// <summary>
        /// Get Reporting Resource Information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportDefinitionsGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3ReportDefinitionsGet200Response> GetResourceV2InfoAsync (string subscriptionType = null, string organizationId = null);

        /// <summary>
        /// Get Reporting Resource Information
        /// </summary>
        /// <remarks>
        /// View a list of supported reports and their attributes before subscribing to them. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportDefinitionsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3ReportDefinitionsGet200Response>> GetResourceV2InfoAsyncWithHttpInfo (string subscriptionType = null, string organizationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportDefinitionsApi : IReportDefinitionsApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDefinitionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportDefinitionsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ReportDefinitionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportDefinitionsApi(Configuration configuration = null)
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
        /// Get Report Definition View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportDefinitionsNameGet200Response</returns>
        public ReportingV3ReportDefinitionsNameGet200Response GetResourceInfoByReportDefinition (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null)
        {
             ApiResponse<ReportingV3ReportDefinitionsNameGet200Response> localVarResponse = GetResourceInfoByReportDefinitionWithHttpInfo(reportDefinitionName, subscriptionType, reportMimeType, organizationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Report Definition View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportDefinitionsNameGet200Response</returns>
        public ApiResponse< ReportingV3ReportDefinitionsNameGet200Response > GetResourceInfoByReportDefinitionWithHttpInfo (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null)
        {
            // verify the required parameter 'reportDefinitionName' is set
            if (reportDefinitionName == null)
                throw new ApiException(400, "Missing required parameter 'reportDefinitionName' when calling ReportDefinitionsApi->GetResourceInfoByReportDefinition");

            var localVarPath = $"/reporting/v3/report-definitions/{reportDefinitionName}";
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
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (reportDefinitionName != null) localVarPathParams.Add("reportDefinitionName", Configuration.ApiClient.ParameterToString(reportDefinitionName)); // path parameter
            if (subscriptionType != null) localVarQueryParams.Add("subscriptionType", Configuration.ApiClient.ParameterToString(subscriptionType)); // query parameter
            if (reportMimeType != null) localVarQueryParams.Add("reportMimeType", Configuration.ApiClient.ParameterToString(reportMimeType)); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResourceInfoByReportDefinition", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportingV3ReportDefinitionsNameGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportingV3ReportDefinitionsNameGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3ReportDefinitionsNameGet200Response)));
        }

        /// <summary>
        /// Get Report Definition View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportDefinitionsNameGet200Response</returns>
        public async System.Threading.Tasks.Task<ReportingV3ReportDefinitionsNameGet200Response> GetResourceInfoByReportDefinitionAsync (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null)
        {
             ApiResponse<ReportingV3ReportDefinitionsNameGet200Response> localVarResponse = await GetResourceInfoByReportDefinitionAsyncWithHttpInfo(reportDefinitionName, subscriptionType, reportMimeType, organizationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Report Definition View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/) 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
        /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportDefinitionsNameGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportingV3ReportDefinitionsNameGet200Response>> GetResourceInfoByReportDefinitionAsyncWithHttpInfo (string reportDefinitionName, string subscriptionType = null, string reportMimeType = null, string organizationId = null)
        {
            // verify the required parameter 'reportDefinitionName' is set
            if (reportDefinitionName == null)
                throw new ApiException(400, "Missing required parameter 'reportDefinitionName' when calling ReportDefinitionsApi->GetResourceInfoByReportDefinition");

            var localVarPath = $"/reporting/v3/report-definitions/{reportDefinitionName}";
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
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (reportDefinitionName != null) localVarPathParams.Add("reportDefinitionName", Configuration.ApiClient.ParameterToString(reportDefinitionName)); // path parameter
            if (subscriptionType != null) localVarQueryParams.Add("subscriptionType", Configuration.ApiClient.ParameterToString(subscriptionType)); // query parameter
            if (reportMimeType != null) localVarQueryParams.Add("reportMimeType", Configuration.ApiClient.ParameterToString(reportMimeType)); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResourceInfoByReportDefinition", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportingV3ReportDefinitionsNameGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportingV3ReportDefinitionsNameGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3ReportDefinitionsNameGet200Response)));
        }

        /// <summary>
        /// Get Reporting Resource Information View a list of supported reports and their attributes before subscribing to them. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ReportingV3ReportDefinitionsGet200Response</returns>
        public ReportingV3ReportDefinitionsGet200Response GetResourceV2Info (string subscriptionType = null, string organizationId = null)
        {
             ApiResponse<ReportingV3ReportDefinitionsGet200Response> localVarResponse = GetResourceV2InfoWithHttpInfo(subscriptionType, organizationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Reporting Resource Information View a list of supported reports and their attributes before subscribing to them. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3ReportDefinitionsGet200Response</returns>
        public ApiResponse< ReportingV3ReportDefinitionsGet200Response > GetResourceV2InfoWithHttpInfo (string subscriptionType = null, string organizationId = null)
        {

            var localVarPath = $"/reporting/v3/report-definitions";
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
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (subscriptionType != null) localVarQueryParams.Add("subscriptionType", Configuration.ApiClient.ParameterToString(subscriptionType)); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResourceV2Info", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportingV3ReportDefinitionsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportingV3ReportDefinitionsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3ReportDefinitionsGet200Response)));
        }

        /// <summary>
        /// Get Reporting Resource Information View a list of supported reports and their attributes before subscribing to them. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ReportingV3ReportDefinitionsGet200Response</returns>
        public async System.Threading.Tasks.Task<ReportingV3ReportDefinitionsGet200Response> GetResourceV2InfoAsync (string subscriptionType = null, string organizationId = null)
        {
             ApiResponse<ReportingV3ReportDefinitionsGet200Response> localVarResponse = await GetResourceV2InfoAsyncWithHttpInfo(subscriptionType, organizationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Reporting Resource Information View a list of supported reports and their attributes before subscribing to them. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD  (optional)</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3ReportDefinitionsGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportingV3ReportDefinitionsGet200Response>> GetResourceV2InfoAsyncWithHttpInfo (string subscriptionType = null, string organizationId = null)
        {

            var localVarPath = $"/reporting/v3/report-definitions";
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
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (subscriptionType != null) localVarQueryParams.Add("subscriptionType", Configuration.ApiClient.ParameterToString(subscriptionType)); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResourceV2Info", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportingV3ReportDefinitionsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportingV3ReportDefinitionsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3ReportDefinitionsGet200Response)));
        }

    }
}
