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
    /// Processor Information
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsProcessorInformation :  IEquatable<Ptsv2paymentsProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsProcessorInformation" /> class.
        /// </summary>
        /// <param name="PreApprovalToken">Token received in original session service..</param>
        /// <param name="AuthorizationOptions">AuthorizationOptions.</param>
        /// <param name="Reversal">Reversal.</param>
        public Ptsv2paymentsProcessorInformation(string PreApprovalToken = default(string), Ptsv2paymentsProcessorInformationAuthorizationOptions AuthorizationOptions = default(Ptsv2paymentsProcessorInformationAuthorizationOptions), Ptsv2paymentsProcessorInformationReversal Reversal = default(Ptsv2paymentsProcessorInformationReversal))
        {
            this.PreApprovalToken = PreApprovalToken;
            this.AuthorizationOptions = AuthorizationOptions;
            this.Reversal = Reversal;
        }
        
        /// <summary>
        /// Token received in original session service.
        /// </summary>
        /// <value>Token received in original session service.</value>
        [DataMember(Name="preApprovalToken", EmitDefaultValue=false)]
        public string PreApprovalToken { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationOptions
        /// </summary>
        [DataMember(Name="authorizationOptions", EmitDefaultValue=false)]
        public Ptsv2paymentsProcessorInformationAuthorizationOptions AuthorizationOptions { get; set; }

        /// <summary>
        /// Gets or Sets Reversal
        /// </summary>
        [DataMember(Name="reversal", EmitDefaultValue=false)]
        public Ptsv2paymentsProcessorInformationReversal Reversal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsProcessorInformation {\n");
            sb.Append("  PreApprovalToken: ").Append(PreApprovalToken).Append("\n");
            sb.Append("  AuthorizationOptions: ").Append(AuthorizationOptions).Append("\n");
            sb.Append("  Reversal: ").Append(Reversal).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsProcessorInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreApprovalToken == other.PreApprovalToken ||
                    this.PreApprovalToken != null &&
                    this.PreApprovalToken.Equals(other.PreApprovalToken)
                ) && 
                (
                    this.AuthorizationOptions == other.AuthorizationOptions ||
                    this.AuthorizationOptions != null &&
                    this.AuthorizationOptions.Equals(other.AuthorizationOptions)
                ) && 
                (
                    this.Reversal == other.Reversal ||
                    this.Reversal != null &&
                    this.Reversal.Equals(other.Reversal)
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
                if (this.PreApprovalToken != null)
                    hash = hash * 59 + this.PreApprovalToken.GetHashCode();
                if (this.AuthorizationOptions != null)
                    hash = hash * 59 + this.AuthorizationOptions.GetHashCode();
                if (this.Reversal != null)
                    hash = hash * 59 + this.Reversal.GetHashCode();
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
