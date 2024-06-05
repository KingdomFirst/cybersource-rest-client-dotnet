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
    /// DmConfigPortfolioControls
    /// </summary>
    [DataContract]
    public partial class DmConfigPortfolioControls :  IEquatable<DmConfigPortfolioControls>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DmConfigPortfolioControls" /> class.
        /// </summary>
        /// <param name="HideRiskMenus">HideRiskMenus.</param>
        /// <param name="HideRiskTransactionData">HideRiskTransactionData.</param>
        public DmConfigPortfolioControls(bool? HideRiskMenus = default(bool?), bool? HideRiskTransactionData = default(bool?))
        {
            this.HideRiskMenus = HideRiskMenus;
            this.HideRiskTransactionData = HideRiskTransactionData;
        }
        
        /// <summary>
        /// Gets or Sets HideRiskMenus
        /// </summary>
        [DataMember(Name="hideRiskMenus", EmitDefaultValue=false)]
        public bool? HideRiskMenus { get; set; }

        /// <summary>
        /// Gets or Sets HideRiskTransactionData
        /// </summary>
        [DataMember(Name="hideRiskTransactionData", EmitDefaultValue=false)]
        public bool? HideRiskTransactionData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DmConfigPortfolioControls {\n");
            sb.Append("  HideRiskMenus: ").Append(HideRiskMenus).Append("\n");
            sb.Append("  HideRiskTransactionData: ").Append(HideRiskTransactionData).Append("\n");
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
            return this.Equals(obj as DmConfigPortfolioControls);
        }

        /// <summary>
        /// Returns true if DmConfigPortfolioControls instances are equal
        /// </summary>
        /// <param name="other">Instance of DmConfigPortfolioControls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DmConfigPortfolioControls other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HideRiskMenus == other.HideRiskMenus ||
                    this.HideRiskMenus != null &&
                    this.HideRiskMenus.Equals(other.HideRiskMenus)
                ) && 
                (
                    this.HideRiskTransactionData == other.HideRiskTransactionData ||
                    this.HideRiskTransactionData != null &&
                    this.HideRiskTransactionData.Equals(other.HideRiskTransactionData)
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
                if (this.HideRiskMenus != null)
                    hash = hash * 59 + this.HideRiskMenus.GetHashCode();
                if (this.HideRiskTransactionData != null)
                    hash = hash * 59 + this.HideRiskTransactionData.GetHashCode();
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
