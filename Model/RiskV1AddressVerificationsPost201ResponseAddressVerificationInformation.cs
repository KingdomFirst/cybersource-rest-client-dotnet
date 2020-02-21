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
    /// RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation
    /// </summary>
    [DataContract]
    public partial class RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation :  IEquatable<RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation" /> class.
        /// </summary>
        /// <param name="AddressType">Contains the record type of the postal code with which the address was matched.  #### U.S. Addresses Depending on the quantity and quality of the address information provided, this field contains one or two characters:  - One character: sufficient correct information was provided to result in accurate matching. - Two characters: standardization would provide a better address if more or better input address information were available. The second character is D (default).  Blank fields are unassigned. When an address cannot be standardized, how the input data was parsed determines the address type. In this case, standardization may indicate a street, rural route, highway contract, general delivery, or PO box. For possible values, see the description for the &#x60;dav_address_type&#x60; reply field in [CyberSource Verification Services Using the SCMP API](https://apps.cybersource.com/library/documentation/dev_guides/Verification_Svcs_SCMP_API/html/)  #### All Other Countries This field contains one of the following values: - P: Post. - S: Street. - x: Unknown. .</param>
        /// <param name="BarCode">BarCode.</param>
        /// <param name="ApplicableRegion">Value can be - Canada - US - International. The values of errorCode and statusCode mean different things depending on the applicable region. Refer to the guide for more info. .</param>
        /// <param name="ErrorCode">Four-character error code returned for Canadian, US and international addresses. For possible values, see Verification Services guide. The meaning of the errorCode depends on value of applicableRegion. .</param>
        /// <param name="StatusCode">Four-to-ten character status code returned for Canadian, US and international addresses. For possible values, see Verification Services guide. The meaning of the errorCode depends on value of applicableRegion. .</param>
        /// <param name="CareOf">Care of data dropped from the standard address..</param>
        /// <param name="MatchScore">Indicates the probable correctness of the address match. Returned for U.S. and Canadian addresses. Returns a value from 0-9, where 0 is most likely to be correct and 9 is least likely to be correct, or -1 if there is no address match. .</param>
        /// <param name="StandardAddress">StandardAddress.</param>
        public RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation(string AddressType = default(string), RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationBarCode BarCode = default(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationBarCode), string ApplicableRegion = default(string), string ErrorCode = default(string), string StatusCode = default(string), string CareOf = default(string), int? MatchScore = default(int?), RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress StandardAddress = default(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress))
        {
            this.AddressType = AddressType;
            this.BarCode = BarCode;
            this.ApplicableRegion = ApplicableRegion;
            this.ErrorCode = ErrorCode;
            this.StatusCode = StatusCode;
            this.CareOf = CareOf;
            this.MatchScore = MatchScore;
            this.StandardAddress = StandardAddress;
        }
        
        /// <summary>
        /// Contains the record type of the postal code with which the address was matched.  #### U.S. Addresses Depending on the quantity and quality of the address information provided, this field contains one or two characters:  - One character: sufficient correct information was provided to result in accurate matching. - Two characters: standardization would provide a better address if more or better input address information were available. The second character is D (default).  Blank fields are unassigned. When an address cannot be standardized, how the input data was parsed determines the address type. In this case, standardization may indicate a street, rural route, highway contract, general delivery, or PO box. For possible values, see the description for the &#x60;dav_address_type&#x60; reply field in [CyberSource Verification Services Using the SCMP API](https://apps.cybersource.com/library/documentation/dev_guides/Verification_Svcs_SCMP_API/html/)  #### All Other Countries This field contains one of the following values: - P: Post. - S: Street. - x: Unknown. 
        /// </summary>
        /// <value>Contains the record type of the postal code with which the address was matched.  #### U.S. Addresses Depending on the quantity and quality of the address information provided, this field contains one or two characters:  - One character: sufficient correct information was provided to result in accurate matching. - Two characters: standardization would provide a better address if more or better input address information were available. The second character is D (default).  Blank fields are unassigned. When an address cannot be standardized, how the input data was parsed determines the address type. In this case, standardization may indicate a street, rural route, highway contract, general delivery, or PO box. For possible values, see the description for the &#x60;dav_address_type&#x60; reply field in [CyberSource Verification Services Using the SCMP API](https://apps.cybersource.com/library/documentation/dev_guides/Verification_Svcs_SCMP_API/html/)  #### All Other Countries This field contains one of the following values: - P: Post. - S: Street. - x: Unknown. </value>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or Sets BarCode
        /// </summary>
        [DataMember(Name="barCode", EmitDefaultValue=false)]
        public RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationBarCode BarCode { get; set; }

        /// <summary>
        /// Value can be - Canada - US - International. The values of errorCode and statusCode mean different things depending on the applicable region. Refer to the guide for more info. 
        /// </summary>
        /// <value>Value can be - Canada - US - International. The values of errorCode and statusCode mean different things depending on the applicable region. Refer to the guide for more info. </value>
        [DataMember(Name="applicableRegion", EmitDefaultValue=false)]
        public string ApplicableRegion { get; set; }

        /// <summary>
        /// Four-character error code returned for Canadian, US and international addresses. For possible values, see Verification Services guide. The meaning of the errorCode depends on value of applicableRegion. 
        /// </summary>
        /// <value>Four-character error code returned for Canadian, US and international addresses. For possible values, see Verification Services guide. The meaning of the errorCode depends on value of applicableRegion. </value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Four-to-ten character status code returned for Canadian, US and international addresses. For possible values, see Verification Services guide. The meaning of the errorCode depends on value of applicableRegion. 
        /// </summary>
        /// <value>Four-to-ten character status code returned for Canadian, US and international addresses. For possible values, see Verification Services guide. The meaning of the errorCode depends on value of applicableRegion. </value>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// Care of data dropped from the standard address.
        /// </summary>
        /// <value>Care of data dropped from the standard address.</value>
        [DataMember(Name="careOf", EmitDefaultValue=false)]
        public string CareOf { get; set; }

        /// <summary>
        /// Indicates the probable correctness of the address match. Returned for U.S. and Canadian addresses. Returns a value from 0-9, where 0 is most likely to be correct and 9 is least likely to be correct, or -1 if there is no address match. 
        /// </summary>
        /// <value>Indicates the probable correctness of the address match. Returned for U.S. and Canadian addresses. Returns a value from 0-9, where 0 is most likely to be correct and 9 is least likely to be correct, or -1 if there is no address match. </value>
        [DataMember(Name="matchScore", EmitDefaultValue=false)]
        public int? MatchScore { get; set; }

        /// <summary>
        /// Gets or Sets StandardAddress
        /// </summary>
        [DataMember(Name="standardAddress", EmitDefaultValue=false)]
        public RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddress StandardAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation {\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  BarCode: ").Append(BarCode).Append("\n");
            sb.Append("  ApplicableRegion: ").Append(ApplicableRegion).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  CareOf: ").Append(CareOf).Append("\n");
            sb.Append("  MatchScore: ").Append(MatchScore).Append("\n");
            sb.Append("  StandardAddress: ").Append(StandardAddress).Append("\n");
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
            return this.Equals(obj as RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation);
        }

        /// <summary>
        /// Returns true if RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressType == other.AddressType ||
                    this.AddressType != null &&
                    this.AddressType.Equals(other.AddressType)
                ) && 
                (
                    this.BarCode == other.BarCode ||
                    this.BarCode != null &&
                    this.BarCode.Equals(other.BarCode)
                ) && 
                (
                    this.ApplicableRegion == other.ApplicableRegion ||
                    this.ApplicableRegion != null &&
                    this.ApplicableRegion.Equals(other.ApplicableRegion)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    this.CareOf == other.CareOf ||
                    this.CareOf != null &&
                    this.CareOf.Equals(other.CareOf)
                ) && 
                (
                    this.MatchScore == other.MatchScore ||
                    this.MatchScore != null &&
                    this.MatchScore.Equals(other.MatchScore)
                ) && 
                (
                    this.StandardAddress == other.StandardAddress ||
                    this.StandardAddress != null &&
                    this.StandardAddress.Equals(other.StandardAddress)
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
                if (this.AddressType != null)
                    hash = hash * 59 + this.AddressType.GetHashCode();
                if (this.BarCode != null)
                    hash = hash * 59 + this.BarCode.GetHashCode();
                if (this.ApplicableRegion != null)
                    hash = hash * 59 + this.ApplicableRegion.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.CareOf != null)
                    hash = hash * 59 + this.CareOf.GetHashCode();
                if (this.MatchScore != null)
                    hash = hash * 59 + this.MatchScore.GetHashCode();
                if (this.StandardAddress != null)
                    hash = hash * 59 + this.StandardAddress.GetHashCode();
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
            // AddressType (string) maxLength
            if(this.AddressType != null && this.AddressType.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressType, length must be less than or equal to 255.", new [] { "AddressType" });
            }

            // ApplicableRegion (string) maxLength
            if(this.ApplicableRegion != null && this.ApplicableRegion.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApplicableRegion, length must be less than or equal to 255.", new [] { "ApplicableRegion" });
            }

            // ErrorCode (string) maxLength
            if(this.ErrorCode != null && this.ErrorCode.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ErrorCode, length must be less than or equal to 255.", new [] { "ErrorCode" });
            }

            // StatusCode (string) maxLength
            if(this.StatusCode != null && this.StatusCode.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, length must be less than or equal to 255.", new [] { "StatusCode" });
            }

            // CareOf (string) maxLength
            if(this.CareOf != null && this.CareOf.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CareOf, length must be less than or equal to 255.", new [] { "CareOf" });
            }

            yield break;
        }
    }

}
