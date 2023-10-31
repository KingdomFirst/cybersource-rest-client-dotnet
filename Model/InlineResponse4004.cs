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
    /// Error Bean
    /// </summary>
    [DataContract]
    public partial class InlineResponse4004 :  IEquatable<InlineResponse4004>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4004" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse4004() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse4004" /> class.
        /// </summary>
        /// <param name="Code">Error code (required).</param>
        /// <param name="Message">Error message (required).</param>
        /// <param name="LocalizationKey">Localization Key Name.</param>
        /// <param name="CorrelationId">Correlation Id.</param>
        /// <param name="Detail">Error Detail.</param>
        /// <param name="Fields">Error fields List.</param>
        public InlineResponse4004(string Code = default(string), string Message = default(string), string LocalizationKey = default(string), string CorrelationId = default(string), string Detail = default(string), List<InlineResponse4004Fields> Fields = default(List<InlineResponse4004Fields>))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for InlineResponse4004 and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for InlineResponse4004 and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            this.LocalizationKey = LocalizationKey;
            this.CorrelationId = CorrelationId;
            this.Detail = Detail;
            this.Fields = Fields;
        }
        
        /// <summary>
        /// Error code
        /// </summary>
        /// <value>Error code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        /// <value>Error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Localization Key Name
        /// </summary>
        /// <value>Localization Key Name</value>
        [DataMember(Name="localizationKey", EmitDefaultValue=false)]
        public string LocalizationKey { get; set; }

        /// <summary>
        /// Correlation Id
        /// </summary>
        /// <value>Correlation Id</value>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Error Detail
        /// </summary>
        /// <value>Error Detail</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Error fields List
        /// </summary>
        /// <value>Error fields List</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<InlineResponse4004Fields> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse4004 {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  LocalizationKey: ").Append(LocalizationKey).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(obj as InlineResponse4004);
        }

        /// <summary>
        /// Returns true if InlineResponse4004 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse4004 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse4004 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.LocalizationKey == other.LocalizationKey ||
                    this.LocalizationKey != null &&
                    this.LocalizationKey.Equals(other.LocalizationKey)
                ) && 
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) && 
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.LocalizationKey != null)
                    hash = hash * 59 + this.LocalizationKey.GetHashCode();
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
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
