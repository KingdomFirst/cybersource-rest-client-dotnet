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
    /// TssV2TransactionsGet200ResponseOrderInformationShippingDetails
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseOrderInformationShippingDetails :  IEquatable<TssV2TransactionsGet200ResponseOrderInformationShippingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseOrderInformationShippingDetails" /> class.
        /// </summary>
        /// <param name="GiftWrap">Boolean that indicates whether the customer requested gift wrapping for this purchase. This field can contain one of the following values: - true: The customer requested gift wrapping. - false: The customer did not request gift wrapping. .</param>
        /// <param name="ShippingMethod">Shipping method for the product. Possible values:   - &#x60;lowcost&#x60;: Lowest-cost service  - &#x60;sameday&#x60;: Courier or same-day service  - &#x60;oneday&#x60;: Next-day or overnight service  - &#x60;twoday&#x60;: Two-day service  - &#x60;threeday&#x60;: Three-day service  - &#x60;pickup&#x60;: Store pick-up  - &#x60;other&#x60;: Other shipping method  - &#x60;none&#x60;: No shipping method because product is a service or subscription .</param>
        public TssV2TransactionsGet200ResponseOrderInformationShippingDetails(bool? GiftWrap = default(bool?), string ShippingMethod = default(string))
        {
            this.GiftWrap = GiftWrap;
            this.ShippingMethod = ShippingMethod;
        }
        
        /// <summary>
        /// Boolean that indicates whether the customer requested gift wrapping for this purchase. This field can contain one of the following values: - true: The customer requested gift wrapping. - false: The customer did not request gift wrapping. 
        /// </summary>
        /// <value>Boolean that indicates whether the customer requested gift wrapping for this purchase. This field can contain one of the following values: - true: The customer requested gift wrapping. - false: The customer did not request gift wrapping. </value>
        [DataMember(Name="giftWrap", EmitDefaultValue=false)]
        public bool? GiftWrap { get; set; }

        /// <summary>
        /// Shipping method for the product. Possible values:   - &#x60;lowcost&#x60;: Lowest-cost service  - &#x60;sameday&#x60;: Courier or same-day service  - &#x60;oneday&#x60;: Next-day or overnight service  - &#x60;twoday&#x60;: Two-day service  - &#x60;threeday&#x60;: Three-day service  - &#x60;pickup&#x60;: Store pick-up  - &#x60;other&#x60;: Other shipping method  - &#x60;none&#x60;: No shipping method because product is a service or subscription 
        /// </summary>
        /// <value>Shipping method for the product. Possible values:   - &#x60;lowcost&#x60;: Lowest-cost service  - &#x60;sameday&#x60;: Courier or same-day service  - &#x60;oneday&#x60;: Next-day or overnight service  - &#x60;twoday&#x60;: Two-day service  - &#x60;threeday&#x60;: Three-day service  - &#x60;pickup&#x60;: Store pick-up  - &#x60;other&#x60;: Other shipping method  - &#x60;none&#x60;: No shipping method because product is a service or subscription </value>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseOrderInformationShippingDetails {\n");
            sb.Append("  GiftWrap: ").Append(GiftWrap).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseOrderInformationShippingDetails);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseOrderInformationShippingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseOrderInformationShippingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseOrderInformationShippingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GiftWrap == other.GiftWrap ||
                    this.GiftWrap != null &&
                    this.GiftWrap.Equals(other.GiftWrap)
                ) && 
                (
                    this.ShippingMethod == other.ShippingMethod ||
                    this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(other.ShippingMethod)
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
                if (this.GiftWrap != null)
                    hash = hash * 59 + this.GiftWrap.GetHashCode();
                if (this.ShippingMethod != null)
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
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
            // ShippingMethod (string) maxLength
            if(this.ShippingMethod != null && this.ShippingMethod.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingMethod, length must be less than 10.", new [] { "ShippingMethod" });
            }

            yield break;
        }
    }

}
