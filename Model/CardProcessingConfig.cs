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
    /// CardProcessingConfig
    /// </summary>
    [DataContract]
    public partial class CardProcessingConfig :  IEquatable<CardProcessingConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardProcessingConfig" /> class.
        /// </summary>
        /// <param name="Common">Common.</param>
        /// <param name="Features">Features.</param>
        public CardProcessingConfig(CardProcessingConfigCommon Common = default(CardProcessingConfigCommon), CardProcessingConfigFeatures Features = default(CardProcessingConfigFeatures))
        {
            this.Common = Common;
            this.Features = Features;
        }
        
        /// <summary>
        /// Gets or Sets Common
        /// </summary>
        [DataMember(Name="common", EmitDefaultValue=false)]
        public CardProcessingConfigCommon Common { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public CardProcessingConfigFeatures Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardProcessingConfig {\n");
            sb.Append("  Common: ").Append(Common).Append("\n");
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
            return this.Equals(obj as CardProcessingConfig);
        }

        /// <summary>
        /// Returns true if CardProcessingConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of CardProcessingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardProcessingConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Common == other.Common ||
                    this.Common != null &&
                    this.Common.Equals(other.Common)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.Equals(other.Features)
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
                if (this.Common != null)
                    hash = hash * 59 + this.Common.GetHashCode();
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
