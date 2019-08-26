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
    /// Ptsv2paymentsMerchantInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsMerchantInformation :  IEquatable<Ptsv2paymentsMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsMerchantInformation" /> class.
        /// </summary>
        /// <param name="MerchantDescriptor">MerchantDescriptor.</param>
        /// <param name="SalesOrganizationId">Company ID assigned to an independent sales organization. Get this value from Mastercard.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCR6 - Position: 106-116 - Field: Mastercard Independent Sales Organization ID  **Note** The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.  For processor-specific information, see the &#x60;sales_organization_ID&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="CategoryCode">The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the &#x60;merchant_category_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code .</param>
        /// <param name="CategoryCodeDomestic">Merchant category code for domestic transactions. The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. Including this field in a request for a domestic transaction might reduce interchange fees.  When you include this field in a request: - Do not include the &#x60;merchant_category_code&#x60; field. - The value for this field overrides the value in your CyberSource account.  This field is supported only for: - Domestic transactions with Mastercard in Spain. Domestic means that you and the cardholder are in the same country. - Merchants enrolled in the OmniPay Direct interchange program. - First Data Merchant Solutions (Europe) on OmniPay Direct. .</param>
        /// <param name="TaxId">Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  For details, see &#x60;bill_merchant_tax_id&#x60; field description in the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        /// <param name="VatRegistrationNumber">Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the &#x60;merchant_vat_registration_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="CardAcceptorReferenceNumber">Reference number that facilitates card acceptor/corporation communication and record keeping.  For processor-specific information, see the &#x60;card_acceptor_ref_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TransactionLocalDateTime">Local date and time at your physical location. Include both the date and time in this field or leave it blank. This field is supported only for **CyberSource through VisaNet**.  For processor-specific information, see the &#x60;transaction_local_date_time&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  Format: &#x60;YYYYMMDDhhmmss&#x60;, where:   - YYYY &#x3D; year  - MM &#x3D; month  - DD &#x3D; day  - hh &#x3D; hour  - mm &#x3D; minutes  - ss &#x3D; seconds   For processor-specific information, see the &#x60;transaction_local_date_time&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ServiceFeeDescriptor">ServiceFeeDescriptor.</param>
        public Ptsv2paymentsMerchantInformation(Ptsv2paymentsMerchantInformationMerchantDescriptor MerchantDescriptor = default(Ptsv2paymentsMerchantInformationMerchantDescriptor), string SalesOrganizationId = default(string), int? CategoryCode = default(int?), int? CategoryCodeDomestic = default(int?), string TaxId = default(string), string VatRegistrationNumber = default(string), string CardAcceptorReferenceNumber = default(string), string TransactionLocalDateTime = default(string), Ptsv2paymentsMerchantInformationServiceFeeDescriptor ServiceFeeDescriptor = default(Ptsv2paymentsMerchantInformationServiceFeeDescriptor))
        {
            this.MerchantDescriptor = MerchantDescriptor;
            this.SalesOrganizationId = SalesOrganizationId;
            this.CategoryCode = CategoryCode;
            this.CategoryCodeDomestic = CategoryCodeDomestic;
            this.TaxId = TaxId;
            this.VatRegistrationNumber = VatRegistrationNumber;
            this.CardAcceptorReferenceNumber = CardAcceptorReferenceNumber;
            this.TransactionLocalDateTime = TransactionLocalDateTime;
            this.ServiceFeeDescriptor = ServiceFeeDescriptor;
        }
        
        /// <summary>
        /// Gets or Sets MerchantDescriptor
        /// </summary>
        [DataMember(Name="merchantDescriptor", EmitDefaultValue=false)]
        public Ptsv2paymentsMerchantInformationMerchantDescriptor MerchantDescriptor { get; set; }

        /// <summary>
        /// Company ID assigned to an independent sales organization. Get this value from Mastercard.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCR6 - Position: 106-116 - Field: Mastercard Independent Sales Organization ID  **Note** The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.  For processor-specific information, see the &#x60;sales_organization_ID&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Company ID assigned to an independent sales organization. Get this value from Mastercard.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCR6 - Position: 106-116 - Field: Mastercard Independent Sales Organization ID  **Note** The TC 33 Capture file contains information about the purchases and refunds that a merchant submits to CyberSource. CyberSource through VisaNet creates the TC 33 Capture file at the end of the day and sends it to the merchant’s acquirer, who uses this information to facilitate end-of-day clearing processing with payment card companies.  For processor-specific information, see the &#x60;sales_organization_ID&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="salesOrganizationId", EmitDefaultValue=false)]
        public string SalesOrganizationId { get; set; }

        /// <summary>
        /// The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the &#x60;merchant_category_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code 
        /// </summary>
        /// <value>The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  For processor-specific information, see the &#x60;merchant_category_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code </value>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// Merchant category code for domestic transactions. The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. Including this field in a request for a domestic transaction might reduce interchange fees.  When you include this field in a request: - Do not include the &#x60;merchant_category_code&#x60; field. - The value for this field overrides the value in your CyberSource account.  This field is supported only for: - Domestic transactions with Mastercard in Spain. Domestic means that you and the cardholder are in the same country. - Merchants enrolled in the OmniPay Direct interchange program. - First Data Merchant Solutions (Europe) on OmniPay Direct. 
        /// </summary>
        /// <value>Merchant category code for domestic transactions. The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company’s cards. Including this field in a request for a domestic transaction might reduce interchange fees.  When you include this field in a request: - Do not include the &#x60;merchant_category_code&#x60; field. - The value for this field overrides the value in your CyberSource account.  This field is supported only for: - Domestic transactions with Mastercard in Spain. Domestic means that you and the cardholder are in the same country. - Merchants enrolled in the OmniPay Direct interchange program. - First Data Merchant Solutions (Europe) on OmniPay Direct. </value>
        [DataMember(Name="categoryCodeDomestic", EmitDefaultValue=false)]
        public int? CategoryCodeDomestic { get; set; }

        /// <summary>
        /// Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  For details, see &#x60;bill_merchant_tax_id&#x60; field description in the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  For details, see &#x60;bill_merchant_tax_id&#x60; field description in the [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the &#x60;merchant_vat_registration_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Your government-assigned tax identification number.  For CtV processors, the maximum length is 20.  For other processor-specific information, see the &#x60;merchant_vat_registration_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="vatRegistrationNumber", EmitDefaultValue=false)]
        public string VatRegistrationNumber { get; set; }

        /// <summary>
        /// Reference number that facilitates card acceptor/corporation communication and record keeping.  For processor-specific information, see the &#x60;card_acceptor_ref_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Reference number that facilitates card acceptor/corporation communication and record keeping.  For processor-specific information, see the &#x60;card_acceptor_ref_number&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="cardAcceptorReferenceNumber", EmitDefaultValue=false)]
        public string CardAcceptorReferenceNumber { get; set; }

        /// <summary>
        /// Local date and time at your physical location. Include both the date and time in this field or leave it blank. This field is supported only for **CyberSource through VisaNet**.  For processor-specific information, see the &#x60;transaction_local_date_time&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  Format: &#x60;YYYYMMDDhhmmss&#x60;, where:   - YYYY &#x3D; year  - MM &#x3D; month  - DD &#x3D; day  - hh &#x3D; hour  - mm &#x3D; minutes  - ss &#x3D; seconds   For processor-specific information, see the &#x60;transaction_local_date_time&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Local date and time at your physical location. Include both the date and time in this field or leave it blank. This field is supported only for **CyberSource through VisaNet**.  For processor-specific information, see the &#x60;transaction_local_date_time&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  Format: &#x60;YYYYMMDDhhmmss&#x60;, where:   - YYYY &#x3D; year  - MM &#x3D; month  - DD &#x3D; day  - hh &#x3D; hour  - mm &#x3D; minutes  - ss &#x3D; seconds   For processor-specific information, see the &#x60;transaction_local_date_time&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="transactionLocalDateTime", EmitDefaultValue=false)]
        public string TransactionLocalDateTime { get; set; }

        /// <summary>
        /// Gets or Sets ServiceFeeDescriptor
        /// </summary>
        [DataMember(Name="serviceFeeDescriptor", EmitDefaultValue=false)]
        public Ptsv2paymentsMerchantInformationServiceFeeDescriptor ServiceFeeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsMerchantInformation {\n");
            sb.Append("  MerchantDescriptor: ").Append(MerchantDescriptor).Append("\n");
            sb.Append("  SalesOrganizationId: ").Append(SalesOrganizationId).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  CategoryCodeDomestic: ").Append(CategoryCodeDomestic).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  VatRegistrationNumber: ").Append(VatRegistrationNumber).Append("\n");
            sb.Append("  CardAcceptorReferenceNumber: ").Append(CardAcceptorReferenceNumber).Append("\n");
            sb.Append("  TransactionLocalDateTime: ").Append(TransactionLocalDateTime).Append("\n");
            sb.Append("  ServiceFeeDescriptor: ").Append(ServiceFeeDescriptor).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsMerchantInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantDescriptor == other.MerchantDescriptor ||
                    this.MerchantDescriptor != null &&
                    this.MerchantDescriptor.Equals(other.MerchantDescriptor)
                ) && 
                (
                    this.SalesOrganizationId == other.SalesOrganizationId ||
                    this.SalesOrganizationId != null &&
                    this.SalesOrganizationId.Equals(other.SalesOrganizationId)
                ) && 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
                ) && 
                (
                    this.CategoryCodeDomestic == other.CategoryCodeDomestic ||
                    this.CategoryCodeDomestic != null &&
                    this.CategoryCodeDomestic.Equals(other.CategoryCodeDomestic)
                ) && 
                (
                    this.TaxId == other.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(other.TaxId)
                ) && 
                (
                    this.VatRegistrationNumber == other.VatRegistrationNumber ||
                    this.VatRegistrationNumber != null &&
                    this.VatRegistrationNumber.Equals(other.VatRegistrationNumber)
                ) && 
                (
                    this.CardAcceptorReferenceNumber == other.CardAcceptorReferenceNumber ||
                    this.CardAcceptorReferenceNumber != null &&
                    this.CardAcceptorReferenceNumber.Equals(other.CardAcceptorReferenceNumber)
                ) && 
                (
                    this.TransactionLocalDateTime == other.TransactionLocalDateTime ||
                    this.TransactionLocalDateTime != null &&
                    this.TransactionLocalDateTime.Equals(other.TransactionLocalDateTime)
                ) && 
                (
                    this.ServiceFeeDescriptor == other.ServiceFeeDescriptor ||
                    this.ServiceFeeDescriptor != null &&
                    this.ServiceFeeDescriptor.Equals(other.ServiceFeeDescriptor)
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
                if (this.MerchantDescriptor != null)
                    hash = hash * 59 + this.MerchantDescriptor.GetHashCode();
                if (this.SalesOrganizationId != null)
                    hash = hash * 59 + this.SalesOrganizationId.GetHashCode();
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                if (this.CategoryCodeDomestic != null)
                    hash = hash * 59 + this.CategoryCodeDomestic.GetHashCode();
                if (this.TaxId != null)
                    hash = hash * 59 + this.TaxId.GetHashCode();
                if (this.VatRegistrationNumber != null)
                    hash = hash * 59 + this.VatRegistrationNumber.GetHashCode();
                if (this.CardAcceptorReferenceNumber != null)
                    hash = hash * 59 + this.CardAcceptorReferenceNumber.GetHashCode();
                if (this.TransactionLocalDateTime != null)
                    hash = hash * 59 + this.TransactionLocalDateTime.GetHashCode();
                if (this.ServiceFeeDescriptor != null)
                    hash = hash * 59 + this.ServiceFeeDescriptor.GetHashCode();
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
            // SalesOrganizationId (string) maxLength
            if(this.SalesOrganizationId != null && this.SalesOrganizationId.Length >= 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesOrganizationId, length must be less than or equal to 11.", new [] { "SalesOrganizationId" });
            }

            // CategoryCode (int?) maximum
            if(this.CategoryCode >= (int?)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CategoryCode, must be a value less than or equal to 9999.", new [] { "CategoryCode" });
            }

            // CategoryCodeDomestic (int?) maximum
            if(this.CategoryCodeDomestic >= (int?)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CategoryCodeDomestic, must be a value less than or equal to 9999.", new [] { "CategoryCodeDomestic" });
            }

            // TaxId (string) maxLength
            if(this.TaxId != null && this.TaxId.Length >= 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxId, length must be less than or equal to 15.", new [] { "TaxId" });
            }

            // VatRegistrationNumber (string) maxLength
            if(this.VatRegistrationNumber != null && this.VatRegistrationNumber.Length >= 21)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatRegistrationNumber, length must be less than or equal to 21.", new [] { "VatRegistrationNumber" });
            }

            // CardAcceptorReferenceNumber (string) maxLength
            if(this.CardAcceptorReferenceNumber != null && this.CardAcceptorReferenceNumber.Length >= 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardAcceptorReferenceNumber, length must be less than or equal to 25.", new [] { "CardAcceptorReferenceNumber" });
            }

            // TransactionLocalDateTime (string) maxLength
            if(this.TransactionLocalDateTime != null && this.TransactionLocalDateTime.Length >= 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionLocalDateTime, length must be less than or equal to 14.", new [] { "TransactionLocalDateTime" });
            }

            yield break;
        }
    }

}
