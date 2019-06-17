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
    public interface ISecureFileShareApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        void GetFile (string fileId, string organizationId = null);

        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetFileWithHttpInfo (string fileId, string organizationId = null);
        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>V1FileDetailsGet200Response</returns>
        V1FileDetailsGet200Response GetFileDetail (DateTime? startDate, DateTime? endDate, string organizationId = null);

        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of V1FileDetailsGet200Response</returns>
        ApiResponse<V1FileDetailsGet200Response> GetFileDetailWithHttpInfo (DateTime? startDate, DateTime? endDate, string organizationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetFileAsync (string fileId, string organizationId = null);

        /// <summary>
        /// Download a file with file identifier
        /// </summary>
        /// <remarks>
        /// Download a file for the given file identifier
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetFileAsyncWithHttpInfo (string fileId, string organizationId = null);
        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of V1FileDetailsGet200Response</returns>
        System.Threading.Tasks.Task<V1FileDetailsGet200Response> GetFileDetailAsync (DateTime? startDate, DateTime? endDate, string organizationId = null);

        /// <summary>
        /// Get list of files
        /// </summary>
        /// <remarks>
        /// Get list of files and it&#39;s information of them available inside the report directory
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (V1FileDetailsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1FileDetailsGet200Response>> GetFileDetailAsyncWithHttpInfo (DateTime? startDate, DateTime? endDate, string organizationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SecureFileShareApi : ISecureFileShareApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecureFileShareApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecureFileShareApi(String basePath)
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
        /// Initializes a new instance of the <see cref="SecureFileShareApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SecureFileShareApi(Configuration configuration = null)
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
        /// Download a file with file identifier Download a file for the given file identifier
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns></returns>
        public void GetFile (string fileId, string organizationId = null)
        {
             GetFileWithHttpInfo(fileId, organizationId);
        }

        /// <summary>
        /// Download a file with file identifier Download a file for the given file identifier
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetFileWithHttpInfo (string fileId, string organizationId = null)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling SecureFileShareApi->GetFile");

            var localVarPath = $"/sfs/v1/files/{fileId}";
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
                "application/xml",
                "text/csv",
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content);
        }

        /// <summary>
        /// Download a file with file identifier Download a file for the given file identifier
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetFileAsync (string fileId, string organizationId = null)
        {
             await GetFileAsyncWithHttpInfo(fileId, organizationId);

        }

        /// <summary>
        /// Download a file with file identifier Download a file for the given file identifier
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">Unique identifier for each file</param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetFileAsyncWithHttpInfo (string fileId, string organizationId = null)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling SecureFileShareApi->GetFile");

            var localVarPath = $"/sfs/v1/files/{fileId}";
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
                "application/xml",
                "text/csv",
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileId != null) localVarPathParams.Add("fileId", Configuration.ApiClient.ParameterToString(fileId)); // path parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get list of files Get list of files and it&#39;s information of them available inside the report directory
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>V1FileDetailsGet200Response</returns>
        public V1FileDetailsGet200Response GetFileDetail (DateTime? startDate, DateTime? endDate, string organizationId = null)
        {
             ApiResponse<V1FileDetailsGet200Response> localVarResponse = GetFileDetailWithHttpInfo(startDate, endDate, organizationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of files Get list of files and it&#39;s information of them available inside the report directory
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>ApiResponse of V1FileDetailsGet200Response</returns>
        public ApiResponse< V1FileDetailsGet200Response > GetFileDetailWithHttpInfo (DateTime? startDate, DateTime? endDate, string organizationId = null)
        {
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling SecureFileShareApi->GetFileDetail");
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling SecureFileShareApi->GetFileDetail");

            var localVarPath = $"/sfs/v1/file-details";
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

            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate.Value.ToString("yyyy-MM-dd"))); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate.Value.ToString("yyyy-MM-dd"))); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFileDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1FileDetailsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1FileDetailsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1FileDetailsGet200Response)));
        }

        /// <summary>
        /// Get list of files Get list of files and it&#39;s information of them available inside the report directory
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of V1FileDetailsGet200Response</returns>
        public async System.Threading.Tasks.Task<V1FileDetailsGet200Response> GetFileDetailAsync (DateTime? startDate, DateTime? endDate, string organizationId = null)
        {
             ApiResponse<V1FileDetailsGet200Response> localVarResponse = await GetFileDetailAsyncWithHttpInfo(startDate, endDate, organizationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of files Get list of files and it&#39;s information of them available inside the report directory
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Valid start date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="endDate">Valid end date in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (V1FileDetailsGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1FileDetailsGet200Response>> GetFileDetailAsyncWithHttpInfo (DateTime? startDate, DateTime? endDate, string organizationId = null)
        {
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling SecureFileShareApi->GetFileDetail");
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling SecureFileShareApi->GetFileDetail");

            var localVarPath = $"/sfs/v1/file-details";
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

            if (startDate != null) localVarQueryParams.Add("startDate", Configuration.ApiClient.ParameterToString(startDate.Value.ToString("yyyy-MM-dd"))); // query parameter
            if (endDate != null) localVarQueryParams.Add("endDate", Configuration.ApiClient.ParameterToString(endDate.Value.ToString("yyyy-MM-dd"))); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFileDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1FileDetailsGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (V1FileDetailsGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1FileDetailsGet200Response)));
        }

    }
}
