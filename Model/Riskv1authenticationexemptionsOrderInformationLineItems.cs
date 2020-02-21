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
    /// Riskv1authenticationexemptionsOrderInformationLineItems
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationexemptionsOrderInformationLineItems :  IEquatable<Riskv1authenticationexemptionsOrderInformationLineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationexemptionsOrderInformationLineItems" /> class.
        /// </summary>
        /// <param name="TotalAmount">Total amount for the item. Normally calculated as the unit price times quantity.  When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the purchase amount total for prepaid gift cards in major units.  Example: 123.45 USD &#x3D; 123 .</param>
        /// <param name="UnitPrice">Per-item price of the product. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places.  For processor-specific information, see the &#x60;amount&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths. See these guides for details: - [Merchant Descriptors Using the SCMP API Guide] (https://apps.cybersource.com/library/documentation/dev_guides/Merchant_Descriptors_SCMP_API/html/) - \&quot;Capture Information for Specific Processors\&quot; section in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request. For details, see \&quot;Dynamic Currency Conversion with a Third Party Provider\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### FDMS South If you accept IDR or CLP currencies, see the entry for FDMS South in the [Merchant Descriptors Using the SCMP API Guide.] (https://apps.cybersource.com/library/documentation/dev_guides/Merchant_Descriptors_SCMP_API/html/)  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen. See \&quot;Zero Amount Authorizations\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) .</param>
        /// <param name="Quantity">Number of units for this order.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when _orderInformation.lineItems[].productCode_ is not set to **default** or one of the other values that are related to shipping and/or handling.  When orderInformation.lineItems[].productCode is \&quot;gift_card\&quot;, this is the total count of individual prepaid gift cards purchased. .</param>
        /// <param name="TaxAmount">Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must be in the same currency. The tax amount field is additive.  The following example uses a two-exponent currency such as USD:   1. You include each line item in your request.  ..- 1st line item has amount&#x3D;10.00, quantity&#x3D;1, and taxAmount&#x3D;0.80  ..- 2nd line item has amount&#x3D;20.00, quantity&#x3D;1, and taxAmount&#x3D;1.60  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.  If you want to include the tax amount and also request the ics_tax service, see Tax Calculation Service Using the SCMP API.  This field is frequently used for Level II and Level III transactions. For details, see &#x60;tax_amount&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) .</param>
        public Riskv1authenticationexemptionsOrderInformationLineItems(string TotalAmount = default(string), string UnitPrice = default(string), int? Quantity = default(int?), string TaxAmount = default(string))
        {
            this.TotalAmount = TotalAmount;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.TaxAmount = TaxAmount;
        }
        
        /// <summary>
        /// Total amount for the item. Normally calculated as the unit price times quantity.  When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the purchase amount total for prepaid gift cards in major units.  Example: 123.45 USD &#x3D; 123 
        /// </summary>
        /// <value>Total amount for the item. Normally calculated as the unit price times quantity.  When &#x60;orderInformation.lineItems[].productCode&#x60; is \&quot;gift_card\&quot;, this is the purchase amount total for prepaid gift cards in major units.  Example: 123.45 USD &#x3D; 123 </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Per-item price of the product. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places.  For processor-specific information, see the &#x60;amount&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths. See these guides for details: - [Merchant Descriptors Using the SCMP API Guide] (https://apps.cybersource.com/library/documentation/dev_guides/Merchant_Descriptors_SCMP_API/html/) - \&quot;Capture Information for Specific Processors\&quot; section in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request. For details, see \&quot;Dynamic Currency Conversion with a Third Party Provider\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### FDMS South If you accept IDR or CLP currencies, see the entry for FDMS South in the [Merchant Descriptors Using the SCMP API Guide.] (https://apps.cybersource.com/library/documentation/dev_guides/Merchant_Descriptors_SCMP_API/html/)  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen. See \&quot;Zero Amount Authorizations\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) 
        /// </summary>
        /// <value>Per-item price of the product. This value cannot be negative. You can include a decimal point (.), but you cannot include any other special characters. CyberSource truncates the amount to the correct number of decimal places.  For processor-specific information, see the &#x60;amount&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths. See these guides for details: - [Merchant Descriptors Using the SCMP API Guide] (https://apps.cybersource.com/library/documentation/dev_guides/Merchant_Descriptors_SCMP_API/html/) - \&quot;Capture Information for Specific Processors\&quot; section in the [Credit Card Services Using the SCMP API Guide](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request. For details, see \&quot;Dynamic Currency Conversion with a Third Party Provider\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  #### FDMS South If you accept IDR or CLP currencies, see the entry for FDMS South in the [Merchant Descriptors Using the SCMP API Guide.] (https://apps.cybersource.com/library/documentation/dev_guides/Merchant_Descriptors_SCMP_API/html/)  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen. See \&quot;Zero Amount Authorizations\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) </value>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Number of units for this order.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when _orderInformation.lineItems[].productCode_ is not set to **default** or one of the other values that are related to shipping and/or handling.  When orderInformation.lineItems[].productCode is \&quot;gift_card\&quot;, this is the total count of individual prepaid gift cards purchased. 
        /// </summary>
        /// <value>Number of units for this order.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when _orderInformation.lineItems[].productCode_ is not set to **default** or one of the other values that are related to shipping and/or handling.  When orderInformation.lineItems[].productCode is \&quot;gift_card\&quot;, this is the total count of individual prepaid gift cards purchased. </value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must be in the same currency. The tax amount field is additive.  The following example uses a two-exponent currency such as USD:   1. You include each line item in your request.  ..- 1st line item has amount&#x3D;10.00, quantity&#x3D;1, and taxAmount&#x3D;0.80  ..- 2nd line item has amount&#x3D;20.00, quantity&#x3D;1, and taxAmount&#x3D;1.60  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.  If you want to include the tax amount and also request the ics_tax service, see Tax Calculation Service Using the SCMP API.  This field is frequently used for Level II and Level III transactions. For details, see &#x60;tax_amount&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) 
        /// </summary>
        /// <value>Total tax to apply to the product. This value cannot be negative. The tax amount and the offer amount must be in the same currency. The tax amount field is additive.  The following example uses a two-exponent currency such as USD:   1. You include each line item in your request.  ..- 1st line item has amount&#x3D;10.00, quantity&#x3D;1, and taxAmount&#x3D;0.80  ..- 2nd line item has amount&#x3D;20.00, quantity&#x3D;1, and taxAmount&#x3D;1.60  2. The total amount authorized will be 32.40, not 30.00 with 2.40 of tax included.  If you want to include the tax amount and also request the ics_tax service, see Tax Calculation Service Using the SCMP API.  This field is frequently used for Level II and Level III transactions. For details, see &#x60;tax_amount&#x60; field description in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/) </value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationexemptionsOrderInformationLineItems {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationexemptionsOrderInformationLineItems);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationexemptionsOrderInformationLineItems instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationexemptionsOrderInformationLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationexemptionsOrderInformationLineItems other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
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
            // TotalAmount (string) maxLength
            if(this.TotalAmount != null && this.TotalAmount.Length >= 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalAmount, length must be less than or equal to 13.", new [] { "TotalAmount" });
            }

            // UnitPrice (string) maxLength
            if(this.UnitPrice != null && this.UnitPrice.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPrice, length must be less than or equal to 15.", new [] { "UnitPrice" });
            }

            // Quantity (int?) maximum
            if(this.Quantity >= (int?)999999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value less than or equal to 999999999.", new [] { "Quantity" });
            }

            // Quantity (int?) minimum
            if(this.Quantity <= (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            // TaxAmount (string) maxLength
            if(this.TaxAmount != null && this.TaxAmount.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxAmount, length must be less than or equal to 15.", new [] { "TaxAmount" });
            }

            yield break;
        }
    }

}
