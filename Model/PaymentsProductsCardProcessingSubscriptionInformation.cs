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
    /// PaymentsProductsCardProcessingSubscriptionInformation
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsCardProcessingSubscriptionInformation :  IEquatable<PaymentsProductsCardProcessingSubscriptionInformation>, IValidatableObject
    {
        /// <summary>
        /// Indicates if the organization can enable this product using self service.
        /// </summary>
        /// <value>Indicates if the organization can enable this product using self service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SelfServiceabilityEnum
        {
            
            /// <summary>
            /// Enum SELFSERVICEABLE for "SELF_SERVICEABLE"
            /// </summary>
            [EnumMember(Value = "SELF_SERVICEABLE")]
            SELFSERVICEABLE,
            
            /// <summary>
            /// Enum NOTSELFSERVICEABLE for "NOT_SELF_SERVICEABLE"
            /// </summary>
            [EnumMember(Value = "NOT_SELF_SERVICEABLE")]
            NOTSELFSERVICEABLE,
            
            /// <summary>
            /// Enum SELFSERVICEONLY for "SELF_SERVICE_ONLY"
            /// </summary>
            [EnumMember(Value = "SELF_SERVICE_ONLY")]
            SELFSERVICEONLY
        }
        /// <summary>
        /// Indicates if the organization can enable this product using self service.
        /// </summary>
        /// <value>Indicates if the organization can enable this product using self service.</value>
        [DataMember(Name="selfServiceability", EmitDefaultValue=false)]
        public SelfServiceabilityEnum? SelfServiceability { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsCardProcessingSubscriptionInformation" /> class.
        /// </summary>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="SelfServiceability">Indicates if the organization can enable this product using self service. (default to SelfServiceabilityEnum.NOTSELFSERVICEABLE).</param>
        /// <param name="Features">This is a map. The allowed keys are below. Value should be an object containing a sole boolean property - enabled. &lt;table&gt;    &lt;tr&gt;       &lt;td&gt;cardPresent&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;       &lt;td&gt;cardNotPresent&lt;/td&gt;    &lt;/tr&gt; &lt;/table&gt; .</param>
        public PaymentsProductsCardProcessingSubscriptionInformation(bool? Enabled = default(bool?), SelfServiceabilityEnum? SelfServiceability = SelfServiceabilityEnum.NOTSELFSERVICEABLE, Dictionary<string, PaymentsProductsCardProcessingSubscriptionInformationFeatures> Features = default(Dictionary<string, PaymentsProductsCardProcessingSubscriptionInformationFeatures>))
        {
            this.Enabled = Enabled;
            // use default value if no "SelfServiceability" provided
            if (SelfServiceability == null)
            {
                this.SelfServiceability = SelfServiceabilityEnum.NOTSELFSERVICEABLE;
            }
            else
            {
                this.SelfServiceability = SelfServiceability;
            }
            this.Features = Features;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


        /// <summary>
        /// This is a map. The allowed keys are below. Value should be an object containing a sole boolean property - enabled. &lt;table&gt;    &lt;tr&gt;       &lt;td&gt;cardPresent&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;       &lt;td&gt;cardNotPresent&lt;/td&gt;    &lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>This is a map. The allowed keys are below. Value should be an object containing a sole boolean property - enabled. &lt;table&gt;    &lt;tr&gt;       &lt;td&gt;cardPresent&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;       &lt;td&gt;cardNotPresent&lt;/td&gt;    &lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public Dictionary<string, PaymentsProductsCardProcessingSubscriptionInformationFeatures> Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsCardProcessingSubscriptionInformation {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SelfServiceability: ").Append(SelfServiceability).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(obj as PaymentsProductsCardProcessingSubscriptionInformation);
        }

        /// <summary>
        /// Returns true if PaymentsProductsCardProcessingSubscriptionInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsCardProcessingSubscriptionInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsCardProcessingSubscriptionInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.SelfServiceability == other.SelfServiceability ||
                    this.SelfServiceability != null &&
                    this.SelfServiceability.Equals(other.SelfServiceability)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.SelfServiceability != null)
                    hash = hash * 59 + this.SelfServiceability.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
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
