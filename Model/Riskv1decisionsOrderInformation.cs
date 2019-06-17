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
    /// Contains detailed order-level information.
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsOrderInformation :  IEquatable<Riskv1decisionsOrderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsOrderInformation" /> class.
        /// </summary>
        /// <param name="AmountDetails">AmountDetails.</param>
        /// <param name="ShippingDetails">ShippingDetails.</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="ReturnsAccepted">Boolean that indicates whether returns are accepted for this order. This field can contain one of the following values: - true: Returns are accepted for this order. - false: Returns are not accepted for this order. .</param>
        /// <param name="LineItems">This array contains detailed information about individual products in the order..</param>
        /// <param name="BillTo">BillTo.</param>
        public Riskv1decisionsOrderInformation(Riskv1decisionsOrderInformationAmountDetails AmountDetails = default(Riskv1decisionsOrderInformationAmountDetails), Riskv1decisionsOrderInformationShippingDetails ShippingDetails = default(Riskv1decisionsOrderInformationShippingDetails), Riskv1decisionsOrderInformationShipTo ShipTo = default(Riskv1decisionsOrderInformationShipTo), bool? ReturnsAccepted = default(bool?), List<Riskv1decisionsOrderInformationLineItems> LineItems = default(List<Riskv1decisionsOrderInformationLineItems>), Riskv1decisionsOrderInformationBillTo BillTo = default(Riskv1decisionsOrderInformationBillTo))
        {
            this.AmountDetails = AmountDetails;
            this.ShippingDetails = ShippingDetails;
            this.ShipTo = ShipTo;
            this.ReturnsAccepted = ReturnsAccepted;
            this.LineItems = LineItems;
            this.BillTo = BillTo;
        }
        
        /// <summary>
        /// Gets or Sets AmountDetails
        /// </summary>
        [DataMember(Name="amountDetails", EmitDefaultValue=false)]
        public Riskv1decisionsOrderInformationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Gets or Sets ShippingDetails
        /// </summary>
        [DataMember(Name="shippingDetails", EmitDefaultValue=false)]
        public Riskv1decisionsOrderInformationShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="shipTo", EmitDefaultValue=false)]
        public Riskv1decisionsOrderInformationShipTo ShipTo { get; set; }

        /// <summary>
        /// Boolean that indicates whether returns are accepted for this order. This field can contain one of the following values: - true: Returns are accepted for this order. - false: Returns are not accepted for this order. 
        /// </summary>
        /// <value>Boolean that indicates whether returns are accepted for this order. This field can contain one of the following values: - true: Returns are accepted for this order. - false: Returns are not accepted for this order. </value>
        [DataMember(Name="returnsAccepted", EmitDefaultValue=false)]
        public bool? ReturnsAccepted { get; set; }

        /// <summary>
        /// This array contains detailed information about individual products in the order.
        /// </summary>
        /// <value>This array contains detailed information about individual products in the order.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<Riskv1decisionsOrderInformationLineItems> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public Riskv1decisionsOrderInformationBillTo BillTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsOrderInformation {\n");
            sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
            sb.Append("  ShippingDetails: ").Append(ShippingDetails).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  ReturnsAccepted: ").Append(ReturnsAccepted).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsOrderInformation);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsOrderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsOrderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsOrderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountDetails == other.AmountDetails ||
                    this.AmountDetails != null &&
                    this.AmountDetails.Equals(other.AmountDetails)
                ) && 
                (
                    this.ShippingDetails == other.ShippingDetails ||
                    this.ShippingDetails != null &&
                    this.ShippingDetails.Equals(other.ShippingDetails)
                ) && 
                (
                    this.ShipTo == other.ShipTo ||
                    this.ShipTo != null &&
                    this.ShipTo.Equals(other.ShipTo)
                ) && 
                (
                    this.ReturnsAccepted == other.ReturnsAccepted ||
                    this.ReturnsAccepted != null &&
                    this.ReturnsAccepted.Equals(other.ReturnsAccepted)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
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
                if (this.AmountDetails != null)
                    hash = hash * 59 + this.AmountDetails.GetHashCode();
                if (this.ShippingDetails != null)
                    hash = hash * 59 + this.ShippingDetails.GetHashCode();
                if (this.ShipTo != null)
                    hash = hash * 59 + this.ShipTo.GetHashCode();
                if (this.ReturnsAccepted != null)
                    hash = hash * 59 + this.ReturnsAccepted.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
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
