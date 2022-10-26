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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// InlineResponse4003
    /// </summary>
    [DataContract]
    public partial class InlineResponse4003 :  IEquatable<InlineResponse4003>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum INVALIDAPIKEY for "INVALID_APIKEY"
            /// </summary>
            [EnumMember(Value = "INVALID_APIKEY")]
            INVALIDAPIKEY,
            
            /// <summary>
            /// Enum INVALIDSHIPPINGINPUTPARAMS for "INVALID_SHIPPING_INPUT_PARAMS"
            /// </summary>
            [EnumMember(Value = "INVALID_SHIPPING_INPUT_PARAMS")]
            INVALIDSHIPPINGINPUTPARAMS,
            
            /// <summary>
            /// Enum CAPTURECONTEXTINVALID for "CAPTURE_CONTEXT_INVALID"
            /// </summary>
            [EnumMember(Value = "CAPTURE_CONTEXT_INVALID")]
            CAPTURECONTEXTINVALID,
            
            /// <summary>
            /// Enum CAPTURECONTEXTEXPIRED for "CAPTURE_CONTEXT_EXPIRED"
            /// </summary>
            [EnumMember(Value = "CAPTURE_CONTEXT_EXPIRED")]
            CAPTURECONTEXTEXPIRED,
            
            /// <summary>
            /// Enum SDKXHRERROR for "SDK_XHR_ERROR"
            /// </summary>
            [EnumMember(Value = "SDK_XHR_ERROR")]
            SDKXHRERROR,
            
            /// <summary>
            /// Enum UNIFIEDPAYMENTSVALIDATIONPARAMS for "UNIFIEDPAYMENTS_VALIDATION_PARAMS"
            /// </summary>
            [EnumMember(Value = "UNIFIEDPAYMENTS_VALIDATION_PARAMS")]
            UNIFIEDPAYMENTSVALIDATIONPARAMS,
            
            /// <summary>
            /// Enum UNIFIEDPAYMENTSVALIDATIONFIELDS for "UNIFIEDPAYMENTS_VALIDATION_FIELDS"
            /// </summary>
            [EnumMember(Value = "UNIFIEDPAYMENTS_VALIDATION_FIELDS")]
            UNIFIEDPAYMENTSVALIDATIONFIELDS,
            
            /// <summary>
            /// Enum UNIFIEDPAYMENTPAYMENTPARAMITERS for "UNIFIEDPAYMENT_PAYMENT_PARAMITERS"
            /// </summary>
            [EnumMember(Value = "UNIFIEDPAYMENT_PAYMENT_PARAMITERS")]
            UNIFIEDPAYMENTPAYMENTPARAMITERS,
            
            /// <summary>
            /// Enum CREATETOKENTIMEOUT for "CREATE_TOKEN_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "CREATE_TOKEN_TIMEOUT")]
            CREATETOKENTIMEOUT,
            
            /// <summary>
            /// Enum CREATETOKENXHRERROR for "CREATE_TOKEN_XHR_ERROR"
            /// </summary>
            [EnumMember(Value = "CREATE_TOKEN_XHR_ERROR")]
            CREATETOKENXHRERROR,
            
            /// <summary>
            /// Enum SHOWLOADCONTAINERSELECTOR for "SHOW_LOAD_CONTAINER_SELECTOR"
            /// </summary>
            [EnumMember(Value = "SHOW_LOAD_CONTAINER_SELECTOR")]
            SHOWLOADCONTAINERSELECTOR,
            
            /// <summary>
            /// Enum SHOWLOADINVALIDCONTAINER for "SHOW_LOAD_INVALID_CONTAINER"
            /// </summary>
            [EnumMember(Value = "SHOW_LOAD_INVALID_CONTAINER")]
            SHOWLOADINVALIDCONTAINER,
            
            /// <summary>
            /// Enum SHOWTOKENTIMEOUT for "SHOW_TOKEN_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "SHOW_TOKEN_TIMEOUT")]
            SHOWTOKENTIMEOUT,
            
            /// <summary>
            /// Enum SHOWTOKENXHRERROR for "SHOW_TOKEN_XHR_ERROR"
            /// </summary>
            [EnumMember(Value = "SHOW_TOKEN_XHR_ERROR")]
            SHOWTOKENXHRERROR,
            
            /// <summary>
            /// Enum SHOWPAYMENTTIMEOUT for "SHOW_PAYMENT_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "SHOW_PAYMENT_TIMEOUT")]
            SHOWPAYMENTTIMEOUT
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4003" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse4003() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4003" /> class.
        /// </summary>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="Details">Details.</param>
        /// <param name="InformationLink">InformationLink.</param>
        /// <param name="Message">Message (required).</param>
        /// <param name="Reason">Reason (required).</param>
        public InlineResponse4003(string CorrelationId = default(string), List<InlineResponse4003Details> Details = default(List<InlineResponse4003Details>), string InformationLink = default(string), string Message = default(string), ReasonEnum? Reason = default(ReasonEnum?))
        {
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for InlineResponse4003 and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for InlineResponse4003 and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            this.CorrelationId = CorrelationId;
            this.Details = Details;
            this.InformationLink = InformationLink;
        }
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<InlineResponse4003Details> Details { get; set; }

        /// <summary>
        /// Gets or Sets InformationLink
        /// </summary>
        [DataMember(Name="informationLink", EmitDefaultValue=false)]
        public string InformationLink { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse4003 {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  InformationLink: ").Append(InformationLink).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse4003);
        }

        /// <summary>
        /// Returns true if InlineResponse4003 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse4003 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse4003 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) && 
                (
                    this.InformationLink == other.InformationLink ||
                    this.InformationLink != null &&
                    this.InformationLink.Equals(other.InformationLink)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.InformationLink != null)
                    hash = hash * 59 + this.InformationLink.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
