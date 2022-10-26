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
    /// Upv1capturecontextsCheckoutApiInitialization
    /// </summary>
    [DataContract]
    public partial class Upv1capturecontextsCheckoutApiInitialization :  IEquatable<Upv1capturecontextsCheckoutApiInitialization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Upv1capturecontextsCheckoutApiInitialization" /> class.
        /// </summary>
        /// <param name="ProfileId">ProfileId.</param>
        /// <param name="AccessKey">AccessKey.</param>
        /// <param name="ReferenceNumber">ReferenceNumber.</param>
        /// <param name="TransactionUuid">TransactionUuid.</param>
        /// <param name="TransactionType">TransactionType.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Locale">Locale.</param>
        /// <param name="OverrideCustomReceiptPage">OverrideCustomReceiptPage.</param>
        /// <param name="UnsignedFieldNames">UnsignedFieldNames.</param>
        public Upv1capturecontextsCheckoutApiInitialization(string ProfileId = default(string), string AccessKey = default(string), string ReferenceNumber = default(string), string TransactionUuid = default(string), string TransactionType = default(string), string Currency = default(string), string Amount = default(string), string Locale = default(string), string OverrideCustomReceiptPage = default(string), string UnsignedFieldNames = default(string))
        {
            this.ProfileId = ProfileId;
            this.AccessKey = AccessKey;
            this.ReferenceNumber = ReferenceNumber;
            this.TransactionUuid = TransactionUuid;
            this.TransactionType = TransactionType;
            this.Currency = Currency;
            this.Amount = Amount;
            this.Locale = Locale;
            this.OverrideCustomReceiptPage = OverrideCustomReceiptPage;
            this.UnsignedFieldNames = UnsignedFieldNames;
        }
        
        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name="profile_id", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name="access_key", EmitDefaultValue=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNumber
        /// </summary>
        [DataMember(Name="reference_number", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets TransactionUuid
        /// </summary>
        [DataMember(Name="transaction_uuid", EmitDefaultValue=false)]
        public string TransactionUuid { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name="transaction_type", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets OverrideCustomReceiptPage
        /// </summary>
        [DataMember(Name="override_custom_receipt_page", EmitDefaultValue=false)]
        public string OverrideCustomReceiptPage { get; set; }

        /// <summary>
        /// Gets or Sets UnsignedFieldNames
        /// </summary>
        [DataMember(Name="unsigned_field_names", EmitDefaultValue=false)]
        public string UnsignedFieldNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Upv1capturecontextsCheckoutApiInitialization {\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  TransactionUuid: ").Append(TransactionUuid).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  OverrideCustomReceiptPage: ").Append(OverrideCustomReceiptPage).Append("\n");
            sb.Append("  UnsignedFieldNames: ").Append(UnsignedFieldNames).Append("\n");
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
            return this.Equals(obj as Upv1capturecontextsCheckoutApiInitialization);
        }

        /// <summary>
        /// Returns true if Upv1capturecontextsCheckoutApiInitialization instances are equal
        /// </summary>
        /// <param name="other">Instance of Upv1capturecontextsCheckoutApiInitialization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Upv1capturecontextsCheckoutApiInitialization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProfileId == other.ProfileId ||
                    this.ProfileId != null &&
                    this.ProfileId.Equals(other.ProfileId)
                ) && 
                (
                    this.AccessKey == other.AccessKey ||
                    this.AccessKey != null &&
                    this.AccessKey.Equals(other.AccessKey)
                ) && 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.TransactionUuid == other.TransactionUuid ||
                    this.TransactionUuid != null &&
                    this.TransactionUuid.Equals(other.TransactionUuid)
                ) && 
                (
                    this.TransactionType == other.TransactionType ||
                    this.TransactionType != null &&
                    this.TransactionType.Equals(other.TransactionType)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) && 
                (
                    this.OverrideCustomReceiptPage == other.OverrideCustomReceiptPage ||
                    this.OverrideCustomReceiptPage != null &&
                    this.OverrideCustomReceiptPage.Equals(other.OverrideCustomReceiptPage)
                ) && 
                (
                    this.UnsignedFieldNames == other.UnsignedFieldNames ||
                    this.UnsignedFieldNames != null &&
                    this.UnsignedFieldNames.Equals(other.UnsignedFieldNames)
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
                if (this.ProfileId != null)
                    hash = hash * 59 + this.ProfileId.GetHashCode();
                if (this.AccessKey != null)
                    hash = hash * 59 + this.AccessKey.GetHashCode();
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                if (this.TransactionUuid != null)
                    hash = hash * 59 + this.TransactionUuid.GetHashCode();
                if (this.TransactionType != null)
                    hash = hash * 59 + this.TransactionType.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                if (this.OverrideCustomReceiptPage != null)
                    hash = hash * 59 + this.OverrideCustomReceiptPage.GetHashCode();
                if (this.UnsignedFieldNames != null)
                    hash = hash * 59 + this.UnsignedFieldNames.GetHashCode();
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
