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
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using AuthenticationSdk.core;
using AuthenticationSdk.util;
using System.Security.Cryptography.X509Certificates;
using NLog;
using System.Security;

namespace CyberSource.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request); // CHANGED

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(IRestRequest request, IRestResponse response); // CHANGED

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration and base path (https://apitest.cybersource.com).
        /// </summary>
        public ApiClient()
        {
            Configuration = Configuration.Default;
            RestClient = new RestClient("https://apitest.cybersource.com");
            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path (https://apitest.cybersource.com).
        /// </summary>
        /// <param name="config">An instance of Configuration.</param>
        public ApiClient(Configuration config = null)
        {
            if (config == null)
                Configuration = Configuration.Default;
            else
                Configuration = config;

            RestClient = new RestClient("https://apitest.cybersource.com");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default configuration.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(string basePath = "https://apitest.cybersource.com")
        {
           if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");

            RestClient = new RestClient(basePath);
            Configuration = Configuration.Default;
        }

        /// <summary>
        /// Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The default API client.</value>
        [Obsolete("ApiClient.Default is deprecated, please use 'Configuration.Default.ApiClient' instead.")]
        public static ApiClient Default;

        /// <summary>
        /// Gets or sets the Configuration.
        /// </summary>
        /// <value>An instance of the Configuration.</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Sets the Accept Header Type.
        /// </summary>
        /// <value>User-defined Accept Header Type.</value>
        public string AcceptHeader { get; set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }

        /// <summary>
        /// Gets or sets the file name, in which the response to be downloaded.
        /// </summary>
        /// <value>An instance of the Configuration.</value>
        public string DownloadResponseFileName { get; set; }

        /// <summary>
        /// Internal class logger
        /// </summary>
        private static Logger logger;

        // Creates and sets up a IRestRequest prior to a call.
        private IRestRequest PrepareRequest(
            string path, Method method, Dictionary<string, string> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            //1.set in the defaultHeaders of configuration

            // Change to path(Request Target) to be sent to Authentication SDK
            // Include Query Params in the Request target
            var firstQueryParam = true;
            foreach (var param in queryParams)
            {
                var key = param.Key;
                var val = param.Value;

                if (!firstQueryParam)
                {
                    path = path + "&" + key + "=" + val;
                }
                else
                {
                    path = path + "?" + key + "=" + val;
                    firstQueryParam = false;
                }
            }

            var request = new RestRequest(path, method);

            // add path parameter, if any
            foreach(var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            // 2. passed to this function
            foreach (var param in headerParams)
            {
                if (param.Key == "Authorization")
                {
                    request.AddParameter("Authorization", string.Format("Bearer " + param.Value),
                        ParameterType.HttpHeader);
                }
                else
                    request.AddHeader(param.Key, param.Value);
            }

            if (postBody == null)
            {
                CallAuthenticationHeaders(method.ToString(), path);
            }
            else
            {
                CallAuthenticationHeaders(method.ToString(), path, postBody.ToString());
            }

            foreach (var param in Configuration.DefaultHeader)
            {
                if (param.Key == "Authorization")
                {
                    request.AddParameter("Authorization", string.Format("Bearer " + param.Value),
                        ParameterType.HttpHeader);
                }
                else
                {
                    if (request.Parameters.Any(x => string.Equals(x.Name, param.Key, StringComparison.OrdinalIgnoreCase) && x.Type == ParameterType.HttpHeader))
                    {
                        continue;
                    }
                    request.AddHeader(param.Key, param.Value);
                }
            }

            // add query parameter, if any
            // foreach(var param in queryParams)
            //     request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach(var param in formParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach(var param in fileParams)
            {
                request.AddFile(param.Value.Name, param.Value.FileName, param.Value.ContentType);
            }

            if (postBody != null) // http body (model or byte[]) parameter
            {
                if (postBody.GetType() == typeof(string))
                {
                    if (contentType == "application/x-www-form-urlencoded")
                    {
                        var bodyParams = JsonConvert.DeserializeObject<Dictionary<string, string>>((string)postBody);
                        foreach (KeyValuePair<string, string> param in bodyParams)
                        {
                            request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);
                        }
                    }
                    else
                    {
                        request.AddParameter("application/json", postBody, ParameterType.RequestBody);
                        //request.AddJsonBody(postBody); // RestSharp 108+ change
                    }
                }
                else if (postBody.GetType() == typeof(byte[]))
                {
                    request.AddParameter(contentType, postBody, ParameterType.RequestBody);
                }
            }

            return request;
        }

        private IRestRequest PrepareIRestRequest(
            string path, Method method, Dictionary<string, string> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            // Change to path(Request Target) to be sent to Authentication SDK
            // Include Query Params in the Request target
            var firstQueryParam = true;
            foreach (var param in queryParams)
            {
                var key = param.Key;
                var val = param.Value;

                if (!firstQueryParam)
                {
                    path = path + "&" + key + "=" + val;
                }
                else
                {
                    path = path + "?" + key + "=" + val;
                    firstQueryParam = false;
                }
            }

            IRestRequest requestT = new RestRequest(path);
            RestClient.UserAgent = Configuration.UserAgent;

            if (Configuration.Proxy != null)
            {
                RestClient.Proxy = Configuration.Proxy;
            }

            // Add Header Parameter, if any
            // Passed to this function
            foreach (var param in headerParams)
            {
                requestT.AddHeader(param.Key, param.Value);
            }

            //initiate the default authentication headers
            if (postBody == null)
            {
                CallAuthenticationHeaders(method.ToString(), path);
            }
            else
            {
                CallAuthenticationHeaders(method.ToString(), path, postBody.ToString());
            }

            foreach (var param in Configuration.DefaultHeader)
            {
                if (param.Key == "Authorization")
                {
                    requestT.AddHeader("Authorization", string.Format("Bearer " + param.Value));
                }
                else
                {
                    if (requestT.Parameters.Any(x => string.Equals(x.Name, param.Key, StringComparison.OrdinalIgnoreCase) && x.Type == ParameterType.HttpHeader))
                    {
                        continue;
                    }
                    if (param.Key == "Date")
                    {
                        requestT.AddHeader("Date", DateTime.Parse(param.Value).ToString());
                    }
                    else if (param.Key == "Host")
                    { }
                    else
                    {
                        requestT.AddHeader(param.Key, param.Value);
                    }
                }
            }

            return requestT;
        }

        // Creates and sets up a HttpWebRequest for calls which needs response in a file format.
        private HttpWebRequest PrepareHttpWebRequest(
            string path, Method method, Dictionary<string, string> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            // Change to path(Request Target) to be sent to Authentication SDK
            // Include Query Params in the Request target
            var firstQueryParam = true;
            foreach (var param in queryParams)
            {
                var key = param.Key;
                var val = param.Value;

                if (!firstQueryParam)
                {
                    path = path + "&" + key + "=" + val;
                }
                else
                {
                    path = path + "?" + key + "=" + val;
                    firstQueryParam = false;
                }
            }

            //initiate a HttpWebRequest object
            HttpWebRequest requestT = (HttpWebRequest)WebRequest.Create(Uri.EscapeUriString("https://" + RestClient.BaseUrl.Host + path));
            requestT.UserAgent = Configuration.UserAgent;

            if (Configuration.Proxy != null)
            {
                requestT.Proxy = Configuration.Proxy;
            }
            requestT.ContentType = contentType;

            // add header parameter, if any
            // passed to this function
            foreach (var param in headerParams)
            {
                if (param.Key == "Accept")
                {
                    requestT.Accept = param.Value;
                }
                else
                    requestT.Headers.Add(param.Key, param.Value);
            }

            //initiate the default authentication headers
            if (postBody == null)
            {
                CallAuthenticationHeaders(method.ToString(), path);
            }
            else
            {
                CallAuthenticationHeaders(method.ToString(), path, postBody.ToString());
            }

            foreach (var param in Configuration.DefaultHeader)
            {
                if (param.Key == "Authorization")
                {
                    requestT.Headers.Add("Authorization", string.Format("Bearer " + param.Value));
                }
                else if (param.Key == "Date")
                {
                    requestT.Date = DateTime.Parse(param.Value);
                }
                else if (param.Key == "Host")
                { }
                else
                    requestT.Headers.Add(param.Key, param.Value);
            }

            return requestT;
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <returns>Object</returns>
        public object CallApi(
            string path, Method method, Dictionary<string, string> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            //declared separately to handle both regular call and download file calls
            int httpResponseStatusCode;
            IList<Parameter> httpResponseHeaders = null;
            string httpResponseData = string.Empty;

            LogUtility logUtility = new LogUtility();

            var response = new RestResponse();

            if (!string.IsNullOrEmpty(AcceptHeader))
            {
                var defaultAcceptHeader = "," + headerParams["Accept"];
                defaultAcceptHeader = AcceptHeader + defaultAcceptHeader.Replace("," + AcceptHeader, "");
                headerParams.Remove("Accept");
                headerParams.Add("Accept", defaultAcceptHeader);
            }

            //check if the Response is to be downloaded as a file, this value to be set by the calling API class
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);

            // set timeout
            request.Timeout = Configuration.Timeout;
            // set user agent
            RestClient.UserAgent = Configuration.UserAgent;

            // RestClient.ClearHandlers();

            if (Configuration.Proxy != null)
            {
                RestClient.Proxy = Configuration.Proxy;
            }

            // Adding Client Cert
            if(Configuration.MerchantConfigDictionaryObj.ContainsKey("enableClientCert") && Equals(bool.Parse(Configuration.MerchantConfigDictionaryObj["enableClientCert"]), true))
            {
                string clientCertDirectory = Configuration.MerchantConfigDictionaryObj["clientCertDirectory"];
                string clientCertFile = Configuration.MerchantConfigDictionaryObj["clientCertFile"];
                SecureString clientCertPassword = new SecureString();
                foreach (char c in Configuration.MerchantConfigDictionaryObj["clientCertPassword"])
                {
                    clientCertPassword.AppendChar(c);
                }
                clientCertPassword.MakeReadOnly();
                string fileName = Path.Combine(clientCertDirectory, clientCertFile);
                // Importing Certificates
                var certificate = new X509Certificate2(fileName, clientCertPassword);
                clientCertPassword.Dispose();
                RestClient.ClientCertificates = new X509CertificateCollection { certificate };
            }

            // Logging Request Headers
            var headerPrintOutput = new StringBuilder();
            foreach (var param in request.Parameters)
            {
                if (param.Type.ToString().Equals("HttpHeader"))
                {
                    headerPrintOutput.Append($"{param.Name} : {param.Value}\n");
                }
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Headers :\n{logUtility.MaskSensitiveData(headerPrintOutput.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Headers :\n{headerPrintOutput}");
            }

            InterceptRequest(request);
            response = (RestResponse) RestClient.Execute(request);
            InterceptResponse(request, response);

            Configuration.DefaultHeader.Clear();

            // Logging Response Headers
            httpResponseStatusCode = (int)response.StatusCode;
            httpResponseHeaders = response.Headers.ToList<Parameter>();
            httpResponseData = response.Content;

            logger.Debug($"HTTP Response Status Code: {httpResponseStatusCode}");

            var responseHeadersBuilder = new StringBuilder();
            foreach (var header in httpResponseHeaders)
            {
                responseHeadersBuilder.Append($"{header}\n");
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Response Headers :\n{logUtility.MaskSensitiveData(responseHeadersBuilder.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Response Headers :\n{responseHeadersBuilder.ToString()}");
            }

            if (!string.IsNullOrEmpty(httpResponseData))
            {
                if (logUtility.IsMaskingEnabled(logger))
                {
                    logger.Debug($"HTTP Response Body :\n{logUtility.MaskSensitiveData(httpResponseData)}");
                }
                else
                {
                    logger.Debug($"HTTP Response Body :\n{httpResponseData}");
                }
            }

            return response;
        }

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async System.Threading.Tasks.Task<object> CallApiAsync(
            string path, Method method, Dictionary<string, string> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            LogUtility logUtility = new LogUtility();

            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);

            // Logging Request Headers
            var headerPrintOutput = new StringBuilder();
            foreach (var param in request.Parameters)
            {
                if (param.Type.ToString().Equals("HttpHeader"))
                {
                    headerPrintOutput.Append($"{param.Name} : {param.Value}\n");
                }
            }

            // set timeout
            request.Timeout = Configuration.Timeout;
            // set user agent
            RestClient.UserAgent = Configuration.UserAgent;

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Headers :\n{logUtility.MaskSensitiveData(headerPrintOutput.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Headers :\n{headerPrintOutput.ToString()}");
            }

            InterceptRequest(request);
            var response = await RestClient.ExecuteTaskAsync( request);
            InterceptResponse(request, response);

            // Logging Response Headers
            var httpResponseStatusCode = (int)response.StatusCode;
            var httpResponseHeaders = response.Headers;
            var httpResponseData = response.Content;

            logger.Debug($"HTTP Response Status Code: {httpResponseStatusCode}");

            var responseHeadersBuilder = new StringBuilder();
            foreach (var header in httpResponseHeaders)
            {
                responseHeadersBuilder.Append($"{header}\n");
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Response Headers :\n{logUtility.MaskSensitiveData(responseHeadersBuilder.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Response Headers :\n{responseHeadersBuilder.ToString()}");
            }

            if (!string.IsNullOrEmpty(httpResponseData))
            {
                if (logUtility.IsMaskingEnabled(logger))
                {
                    logger.Debug($"HTTP Response Body :\n{logUtility.MaskSensitiveData(httpResponseData)}");
                }
                else
                {
                    logger.Debug($"HTTP Response Body :\n{httpResponseData}");
                }
            }

            return response;
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return UrlEncode(str);
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, ReadAsBytes(stream), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, ReadAsBytes(stream), "no_file_name_provided");
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime) {
                string outDateTime = null;

                if (((DateTime)obj).TimeOfDay.CompareTo(new TimeSpan(0, 0, 0)) == 0) {
                    outDateTime = ((DateTime?)obj).Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    outDateTime = ((DateTime?)obj).Value.ToString("yyyy-MM-ddTHH:mm:ssZ");
                }

                return outDateTime;
            }
            else if (obj is DateTimeOffset) {
                return ((DateTimeOffset)obj).ToString (Configuration.DateTimeFormat);
            }
            else if (obj is IList)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in (IList)obj)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append(",");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else
                return Convert.ToString (obj);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(IRestResponse response, Type type) // CHANGED
        {
            IList<Parameter> headers = response.Headers.ToList<Parameter>();
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            if (type == typeof(Stream))
            {
                if (headers != null)
                {
                    var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, response.RawBytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(response.RawBytes);
                return stream;
            }

            if ( type == typeof(DateTime?)) // return a datetime object
            {
                return DateTime.Parse(response.Content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, serializerSettings);
            }
            catch (Exception e)
            {
                logger.Error($"JSON Deserialization Exception : {e.Message}");
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                logger.Error($"JSON Serialization Exception : {e.Message}");
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            if (contentTypes.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="source">Object to be casted</param>
        /// <param name="dest">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic source, Type dest)
        {
            return Convert.ChangeType(source, dest);
        }

        /// <summary>
        /// Convert stream to byte array
        /// Credit/Ref: http://stackoverflow.com/a/221941/677735
        /// </summary>
        /// <param name="input">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream input)
        {
            byte[] buffer = new byte[16*1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">String to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                logger.Error("ArgumentNullException : URL to encode is null");
                throw new ArgumentNullException("URL to encode is null.");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string substring = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(substring));
                index += substring.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return filename;
            }
        }

        /// <summary>
        /// Generate Request Authentication Headers using the Authentication SDK
        /// </summary>
        /// <param name="requestType">GET/POST/PUT/PATCH/DELETE</param>
        /// <param name="requestTarget">Resource Path</param>
        /// <param name="requestJsonData">Request Payload</param>
        public void CallAuthenticationHeaders(string requestType, string requestTarget, string requestJsonData = null)
        {
            requestTarget = Uri.EscapeUriString(requestTarget);

            var merchantConfig = Configuration.MerchantConfigDictionaryObj != null
                ? new MerchantConfig(Configuration.MerchantConfigDictionaryObj)
                : new MerchantConfig();

            merchantConfig.RequestType = requestType;
            merchantConfig.RequestTarget = requestTarget;
            merchantConfig.RequestJsonData = requestJsonData;

            var authorize = new Authorize(merchantConfig);

            //these are the Request Headers to be sent along with the HTTP Request
            var authenticationHeaders = new Dictionary<string, string>();

            if (merchantConfig.IsJwtTokenAuthType)
            {
                //generate token and set JWT token headers
                var jwtToken = authorize.GetToken();
                authenticationHeaders.Add("Authorization", jwtToken.BearerToken);
            }
            else if (merchantConfig.IsHttpSignAuthType)
            {
                //generate signature and set HTTP Signature headers
                var httpSign = authorize.GetSignature();
                authenticationHeaders.Add("v-c-merchant-id", httpSign.MerchantId);
                authenticationHeaders.Add("Date", httpSign.GmtDateTime);
                authenticationHeaders.Add("Host", httpSign.HostName);
                authenticationHeaders.Add("Signature", httpSign.SignatureParam);

                if (merchantConfig.IsPostRequest || merchantConfig.IsPutRequest || merchantConfig.IsPatchRequest)
                    authenticationHeaders.Add("Digest", httpSign.Digest);
            }
            else if (merchantConfig.IsOAuthTokenAuthType)
            {
                var oAuthToken = authorize.GetOAuthToken();
                authenticationHeaders.Add("Authorization", oAuthToken.AccessToken);
            }

            if (!string.IsNullOrEmpty(Configuration.ClientId))
            {
                authenticationHeaders.Add("v-c-client-id", Configuration.ClientId);
            }

            // if (!string.IsNullOrEmpty(Configuration.SolutionId))
            // {
            //     authenticationHeaders.Add("v-c-solution-id", Configuration.SolutionId);
            // }

            if (Configuration.Proxy == null && merchantConfig.UseProxy != null)
            {
                if (bool.Parse(merchantConfig.UseProxy))
                {
                    if (!string.IsNullOrWhiteSpace(merchantConfig.ProxyAddress) && int.TryParse(merchantConfig.ProxyPort, out int proxyPortTest))
                    {
                        WebProxy proxy = new WebProxy(merchantConfig.ProxyAddress, proxyPortTest);

                        if (!string.IsNullOrWhiteSpace(merchantConfig.ProxyUsername) && !string.IsNullOrWhiteSpace(merchantConfig.ProxyPassword))
                        {
                            proxy.Credentials = new NetworkCredential(merchantConfig.ProxyUsername, merchantConfig.ProxyPassword);
                        }

                        Configuration.AddWebProxy(proxy);
                    }
                }
            }

            //Set the Configuration
            Configuration.DefaultHeader = authenticationHeaders;
            //if (!string.IsNullOrWhiteSpace(merchantConfig.IntermediateHost))
            //{
            //    //change with intermediate hostname if present
            //    //supporting both for http or https for intermediate url
            //    if (merchantConfig.IntermediateHost.StartsWith("http://") || merchantConfig.IntermediateHost.StartsWith("https://"))
            //    {
            //        RestClient = new RestClient(merchantConfig.IntermediateHost);
            //    }
            //    else
            //    {
            //        RestClient = new RestClient("https://" + merchantConfig.IntermediateHost);
            //    }
            //}
            //else
            //{
                RestClient = new RestClient("https://" + merchantConfig.HostName);
            //}

            if (Configuration.Proxy != null)
            {
                RestClient.Proxy = Configuration.Proxy;
            }
        }
    }
}
