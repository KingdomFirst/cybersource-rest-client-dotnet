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
    /// CheckPayerAuthEnrollmentRequest
    /// </summary>
    [DataContract]
    public partial class CheckPayerAuthEnrollmentRequest :  IEquatable<CheckPayerAuthEnrollmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPayerAuthEnrollmentRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="TokenInformation">TokenInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="AcquirerInformation">AcquirerInformation.</param>
        /// <param name="RecurringPaymentInformation">RecurringPaymentInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        /// <param name="RiskInformation">RiskInformation.</param>
        /// <param name="TravelInformation">TravelInformation.</param>
        /// <param name="MerchantDefinedInformation">MerchantDefinedInformation.</param>
        public CheckPayerAuthEnrollmentRequest(Riskv1decisionsClientReferenceInformation ClientReferenceInformation = default(Riskv1decisionsClientReferenceInformation), Riskv1authenticationsOrderInformation OrderInformation = default(Riskv1authenticationsOrderInformation), Riskv1authenticationsPaymentInformation PaymentInformation = default(Riskv1authenticationsPaymentInformation), Riskv1authenticationsetupsProcessingInformation ProcessingInformation = default(Riskv1authenticationsetupsProcessingInformation), Riskv1authenticationsetupsTokenInformation TokenInformation = default(Riskv1authenticationsetupsTokenInformation), Riskv1authenticationsBuyerInformation BuyerInformation = default(Riskv1authenticationsBuyerInformation), Riskv1authenticationsDeviceInformation DeviceInformation = default(Riskv1authenticationsDeviceInformation), Riskv1decisionsMerchantInformation MerchantInformation = default(Riskv1decisionsMerchantInformation), Riskv1decisionsAcquirerInformation AcquirerInformation = default(Riskv1decisionsAcquirerInformation), Ptsv2paymentsRecurringPaymentInformation RecurringPaymentInformation = default(Ptsv2paymentsRecurringPaymentInformation), Riskv1decisionsConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(Riskv1decisionsConsumerAuthenticationInformation), Riskv1authenticationsRiskInformation RiskInformation = default(Riskv1authenticationsRiskInformation), Riskv1authenticationsTravelInformation TravelInformation = default(Riskv1authenticationsTravelInformation), List<Riskv1decisionsMerchantDefinedInformation> MerchantDefinedInformation = default(List<Riskv1decisionsMerchantDefinedInformation>))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.OrderInformation = OrderInformation;
            this.PaymentInformation = PaymentInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.TokenInformation = TokenInformation;
            this.BuyerInformation = BuyerInformation;
            this.DeviceInformation = DeviceInformation;
            this.MerchantInformation = MerchantInformation;
            this.AcquirerInformation = AcquirerInformation;
            this.RecurringPaymentInformation = RecurringPaymentInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
            this.RiskInformation = RiskInformation;
            this.TravelInformation = TravelInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Riskv1decisionsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsetupsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets TokenInformation
        /// </summary>
        [DataMember(Name="tokenInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsetupsTokenInformation TokenInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public Riskv1decisionsMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets AcquirerInformation
        /// </summary>
        [DataMember(Name="acquirerInformation", EmitDefaultValue=false)]
        public Riskv1decisionsAcquirerInformation AcquirerInformation { get; set; }

        /// <summary>
        /// Gets or Sets RecurringPaymentInformation
        /// </summary>
        [DataMember(Name="recurringPaymentInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsRecurringPaymentInformation RecurringPaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public Riskv1decisionsConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets TravelInformation
        /// </summary>
        [DataMember(Name="travelInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsTravelInformation TravelInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantDefinedInformation
        /// </summary>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<Riskv1decisionsMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckPayerAuthEnrollmentRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  TokenInformation: ").Append(TokenInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  AcquirerInformation: ").Append(AcquirerInformation).Append("\n");
            sb.Append("  RecurringPaymentInformation: ").Append(RecurringPaymentInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  TravelInformation: ").Append(TravelInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
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
            return this.Equals(obj as CheckPayerAuthEnrollmentRequest);
        }

        /// <summary>
        /// Returns true if CheckPayerAuthEnrollmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckPayerAuthEnrollmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckPayerAuthEnrollmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.TokenInformation == other.TokenInformation ||
                    this.TokenInformation != null &&
                    this.TokenInformation.Equals(other.TokenInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.AcquirerInformation == other.AcquirerInformation ||
                    this.AcquirerInformation != null &&
                    this.AcquirerInformation.Equals(other.AcquirerInformation)
                ) && 
                (
                    this.RecurringPaymentInformation == other.RecurringPaymentInformation ||
                    this.RecurringPaymentInformation != null &&
                    this.RecurringPaymentInformation.Equals(other.RecurringPaymentInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
                ) && 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.TravelInformation == other.TravelInformation ||
                    this.TravelInformation != null &&
                    this.TravelInformation.Equals(other.TravelInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.TokenInformation != null)
                    hash = hash * 59 + this.TokenInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.AcquirerInformation != null)
                    hash = hash * 59 + this.AcquirerInformation.GetHashCode();
                if (this.RecurringPaymentInformation != null)
                    hash = hash * 59 + this.RecurringPaymentInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.TravelInformation != null)
                    hash = hash * 59 + this.TravelInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
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
