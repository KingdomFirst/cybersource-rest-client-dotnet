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
    /// Riskv1exportcomplianceinquiriesExportComplianceInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1exportcomplianceinquiriesExportComplianceInformation :  IEquatable<Riskv1exportcomplianceinquiriesExportComplianceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1exportcomplianceinquiriesExportComplianceInformation" /> class.
        /// </summary>
        /// <param name="AddressOperator">Parts of the customer’s information that must match with an entry in the DPL (denied parties list) before a match occurs. This field can contain one of the following values: - AND: (default) The customer’s name or company and the customer’s address must appear in the database. - OR: The customer’s name must appear in the database. - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address. .</param>
        /// <param name="Weights">Weights.</param>
        /// <param name="SanctionLists">Use this field to specify which list(s) you want checked with the request. The reply will include the list name as well as the response data. To check against multiple lists, enter multiple list codes separated by a caret (^). For more information, see \&quot;Restricted and Denied Parties List,\&quot; page 68. .</param>
        public Riskv1exportcomplianceinquiriesExportComplianceInformation(string AddressOperator = default(string), Riskv1exportcomplianceinquiriesExportComplianceInformationWeights Weights = default(Riskv1exportcomplianceinquiriesExportComplianceInformationWeights), List<string> SanctionLists = default(List<string>))
        {
            this.AddressOperator = AddressOperator;
            this.Weights = Weights;
            this.SanctionLists = SanctionLists;
        }
        
        /// <summary>
        /// Parts of the customer’s information that must match with an entry in the DPL (denied parties list) before a match occurs. This field can contain one of the following values: - AND: (default) The customer’s name or company and the customer’s address must appear in the database. - OR: The customer’s name must appear in the database. - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address. 
        /// </summary>
        /// <value>Parts of the customer’s information that must match with an entry in the DPL (denied parties list) before a match occurs. This field can contain one of the following values: - AND: (default) The customer’s name or company and the customer’s address must appear in the database. - OR: The customer’s name must appear in the database. - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address. </value>
        [DataMember(Name="addressOperator", EmitDefaultValue=false)]
        public string AddressOperator { get; set; }

        /// <summary>
        /// Gets or Sets Weights
        /// </summary>
        [DataMember(Name="weights", EmitDefaultValue=false)]
        public Riskv1exportcomplianceinquiriesExportComplianceInformationWeights Weights { get; set; }

        /// <summary>
        /// Use this field to specify which list(s) you want checked with the request. The reply will include the list name as well as the response data. To check against multiple lists, enter multiple list codes separated by a caret (^). For more information, see \&quot;Restricted and Denied Parties List,\&quot; page 68. 
        /// </summary>
        /// <value>Use this field to specify which list(s) you want checked with the request. The reply will include the list name as well as the response data. To check against multiple lists, enter multiple list codes separated by a caret (^). For more information, see \&quot;Restricted and Denied Parties List,\&quot; page 68. </value>
        [DataMember(Name="sanctionLists", EmitDefaultValue=false)]
        public List<string> SanctionLists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1exportcomplianceinquiriesExportComplianceInformation {\n");
            sb.Append("  AddressOperator: ").Append(AddressOperator).Append("\n");
            sb.Append("  Weights: ").Append(Weights).Append("\n");
            sb.Append("  SanctionLists: ").Append(SanctionLists).Append("\n");
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
            return this.Equals(obj as Riskv1exportcomplianceinquiriesExportComplianceInformation);
        }

        /// <summary>
        /// Returns true if Riskv1exportcomplianceinquiriesExportComplianceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1exportcomplianceinquiriesExportComplianceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1exportcomplianceinquiriesExportComplianceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressOperator == other.AddressOperator ||
                    this.AddressOperator != null &&
                    this.AddressOperator.Equals(other.AddressOperator)
                ) && 
                (
                    this.Weights == other.Weights ||
                    this.Weights != null &&
                    this.Weights.Equals(other.Weights)
                ) && 
                (
                    this.SanctionLists == other.SanctionLists ||
                    this.SanctionLists != null &&
                    this.SanctionLists.SequenceEqual(other.SanctionLists)
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
                if (this.AddressOperator != null)
                    hash = hash * 59 + this.AddressOperator.GetHashCode();
                if (this.Weights != null)
                    hash = hash * 59 + this.Weights.GetHashCode();
                if (this.SanctionLists != null)
                    hash = hash * 59 + this.SanctionLists.GetHashCode();
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
