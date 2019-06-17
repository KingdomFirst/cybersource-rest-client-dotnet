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
    /// TssV2TransactionsGet200ResponseDeviceInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseDeviceInformation :  IEquatable<TssV2TransactionsGet200ResponseDeviceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseDeviceInformation" /> class.
        /// </summary>
        /// <param name="IpAddress">IP address of the customer. .</param>
        /// <param name="HostName">DNS resolved hostname from &#x60;ipAddress&#x60;..</param>
        /// <param name="CookiesAccepted">Whether the customer’s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer’s browser accepts cookies. - &#x60;no&#x60;: The customer’s browser does not accept cookies. .</param>
        public TssV2TransactionsGet200ResponseDeviceInformation(string IpAddress = default(string), string HostName = default(string), string CookiesAccepted = default(string))
        {
            this.IpAddress = IpAddress;
            this.HostName = HostName;
            this.CookiesAccepted = CookiesAccepted;
        }
        
        /// <summary>
        /// IP address of the customer. 
        /// </summary>
        /// <value>IP address of the customer. </value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// DNS resolved hostname from &#x60;ipAddress&#x60;.
        /// </summary>
        /// <value>DNS resolved hostname from &#x60;ipAddress&#x60;.</value>
        [DataMember(Name="hostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Whether the customer’s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer’s browser accepts cookies. - &#x60;no&#x60;: The customer’s browser does not accept cookies. 
        /// </summary>
        /// <value>Whether the customer’s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer’s browser accepts cookies. - &#x60;no&#x60;: The customer’s browser does not accept cookies. </value>
        [DataMember(Name="cookiesAccepted", EmitDefaultValue=false)]
        public string CookiesAccepted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseDeviceInformation {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  CookiesAccepted: ").Append(CookiesAccepted).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseDeviceInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseDeviceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseDeviceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseDeviceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.HostName == other.HostName ||
                    this.HostName != null &&
                    this.HostName.Equals(other.HostName)
                ) && 
                (
                    this.CookiesAccepted == other.CookiesAccepted ||
                    this.CookiesAccepted != null &&
                    this.CookiesAccepted.Equals(other.CookiesAccepted)
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
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.HostName != null)
                    hash = hash * 59 + this.HostName.GetHashCode();
                if (this.CookiesAccepted != null)
                    hash = hash * 59 + this.CookiesAccepted.GetHashCode();
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
            // IpAddress (string) maxLength
            if(this.IpAddress != null && this.IpAddress.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IpAddress, length must be less than 15.", new [] { "IpAddress" });
            }

            // HostName (string) maxLength
            if(this.HostName != null && this.HostName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HostName, length must be less than 60.", new [] { "HostName" });
            }

            yield break;
        }
    }

}
