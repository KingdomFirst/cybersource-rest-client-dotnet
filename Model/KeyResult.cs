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
    /// KeyResult
    /// </summary>
    [DataContract]
    public partial class KeyResult :  IEquatable<KeyResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyResult" /> class.
        /// </summary>
        /// <param name="KeyId">Unique identifier for the generated token. Used in the subsequent Tokenize Card request from your customer’s device or browser..</param>
        /// <param name="Der">Der.</param>
        /// <param name="Jwk">Jwk.</param>
        public KeyResult(string KeyId = default(string), FlexV1KeysPost200ResponseDer Der = default(FlexV1KeysPost200ResponseDer), FlexV1KeysPost200ResponseJwk Jwk = default(FlexV1KeysPost200ResponseJwk))
        {
            this.KeyId = KeyId;
            this.Der = Der;
            this.Jwk = Jwk;
        }
        
        /// <summary>
        /// Unique identifier for the generated token. Used in the subsequent Tokenize Card request from your customer’s device or browser.
        /// </summary>
        /// <value>Unique identifier for the generated token. Used in the subsequent Tokenize Card request from your customer’s device or browser.</value>
        [DataMember(Name="keyId", EmitDefaultValue=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or Sets Der
        /// </summary>
        [DataMember(Name="der", EmitDefaultValue=false)]
        public FlexV1KeysPost200ResponseDer Der { get; set; }

        /// <summary>
        /// Gets or Sets Jwk
        /// </summary>
        [DataMember(Name="jwk", EmitDefaultValue=false)]
        public FlexV1KeysPost200ResponseJwk Jwk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyResult {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  Der: ").Append(Der).Append("\n");
            sb.Append("  Jwk: ").Append(Jwk).Append("\n");
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
            return this.Equals(obj as KeyResult);
        }

        /// <summary>
        /// Returns true if KeyResult instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.KeyId == other.KeyId ||
                    this.KeyId != null &&
                    this.KeyId.Equals(other.KeyId)
                ) && 
                (
                    this.Der == other.Der ||
                    this.Der != null &&
                    this.Der.Equals(other.Der)
                ) && 
                (
                    this.Jwk == other.Jwk ||
                    this.Jwk != null &&
                    this.Jwk.Equals(other.Jwk)
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
                if (this.KeyId != null)
                    hash = hash * 59 + this.KeyId.GetHashCode();
                if (this.Der != null)
                    hash = hash * 59 + this.Der.GetHashCode();
                if (this.Jwk != null)
                    hash = hash * 59 + this.Jwk.GetHashCode();
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
