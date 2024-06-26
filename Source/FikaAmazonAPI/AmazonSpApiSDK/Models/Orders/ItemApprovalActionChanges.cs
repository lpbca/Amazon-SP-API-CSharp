﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// Changes required for the approval. Each approval type defines the allowed changes valid sub-set in its specific schema.
    /// </summary>
    [DataContract]
    public partial class ItemApprovalActionChanges : IEquatable<ItemApprovalActionChanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemApprovalActionChanges" /> class.
        /// </summary>
        /// <param name="itemPrice">Price to be charged to the customer for each unit of the item. If substitutedBy is specified, this value applies to the substitution item..</param>
        /// <param name="quantity">Quantity approved. If substitutedBy is specified, this value applies to the substitution item..</param>
        /// <param name="substitutedBy">Identifier of the item to substitute this item in the order..</param>
        public ItemApprovalActionChanges(Money itemPrice = default(Money), int? quantity = default(int?), ItemIdentifier substitutedBy = default(ItemIdentifier))
        {
            this.ItemPrice = itemPrice;
            this.Quantity = quantity;
            this.SubstitutedBy = substitutedBy;
        }

        /// <summary>
        /// Price to be charged to the customer for each unit of the item. If substitutedBy is specified, this value applies to the substitution item.
        /// </summary>
        /// <value>Price to be charged to the customer for each unit of the item. If substitutedBy is specified, this value applies to the substitution item.</value>
        [DataMember(Name = "ItemPrice", EmitDefaultValue = false)]
        public Money ItemPrice { get; set; }

        /// <summary>
        /// Quantity approved. If substitutedBy is specified, this value applies to the substitution item.
        /// </summary>
        /// <value>Quantity approved. If substitutedBy is specified, this value applies to the substitution item.</value>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Identifier of the item to substitute this item in the order.
        /// </summary>
        /// <value>Identifier of the item to substitute this item in the order.</value>
        [DataMember(Name = "SubstitutedBy", EmitDefaultValue = false)]
        public ItemIdentifier SubstitutedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemApprovalActionChanges {\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SubstitutedBy: ").Append(SubstitutedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemApprovalActionChanges);
        }

        /// <summary>
        /// Returns true if ItemApprovalActionChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemApprovalActionChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemApprovalActionChanges input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ItemPrice == input.ItemPrice ||
                    (this.ItemPrice != null &&
                    this.ItemPrice.Equals(input.ItemPrice))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) &&
                (
                    this.SubstitutedBy == input.SubstitutedBy ||
                    (this.SubstitutedBy != null &&
                    this.SubstitutedBy.Equals(input.SubstitutedBy))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ItemPrice != null)
                    hashCode = hashCode * 59 + this.ItemPrice.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SubstitutedBy != null)
                    hashCode = hashCode * 59 + this.SubstitutedBy.GetHashCode();
                return hashCode;
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