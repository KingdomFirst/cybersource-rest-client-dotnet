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
    /// DmConfigThirdpartyProviderSignifyd
    /// </summary>
    [DataContract]
    public partial class DmConfigThirdpartyProviderSignifyd :  IEquatable<DmConfigThirdpartyProviderSignifyd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DmConfigThirdpartyProviderSignifyd" /> class.
        /// </summary>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Credentials">Credentials.</param>
        public DmConfigThirdpartyProviderSignifyd(bool? Enabled = default(bool?), DmConfigThirdpartyProviderSignifydCredentials Credentials = default(DmConfigThirdpartyProviderSignifydCredentials))
        {
            this.Enabled = Enabled;
            this.Credentials = Credentials;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public DmConfigThirdpartyProviderSignifydCredentials Credentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DmConfigThirdpartyProviderSignifyd {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
            return this.Equals(obj as DmConfigThirdpartyProviderSignifyd);
        }

        /// <summary>
        /// Returns true if DmConfigThirdpartyProviderSignifyd instances are equal
        /// </summary>
        /// <param name="other">Instance of DmConfigThirdpartyProviderSignifyd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DmConfigThirdpartyProviderSignifyd other)
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
                    this.Credentials == other.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.Equals(other.Credentials)
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
                if (this.Credentials != null)
                    hash = hash * 59 + this.Credentials.GetHashCode();
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
