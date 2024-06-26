﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// A field collected from the regulatory form.
    /// </summary>
    [DataContract]
    public partial class RegulatedInformationField : IEquatable<RegulatedInformationField>, IValidatableObject
    {
        /// <summary>
        /// The type of field.
        /// </summary>
        /// <value>The type of field.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldTypeEnum
        {

            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 1,

            /// <summary>
            /// Enum FileAttachment for value: FileAttachment
            /// </summary>
            [EnumMember(Value = "FileAttachment")]
            FileAttachment = 2
        }

        /// <summary>
        /// The type of field.
        /// </summary>
        /// <value>The type of field.</value>
        [DataMember(Name = "FieldType", EmitDefaultValue = false)]
        public FieldTypeEnum FieldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedInformationField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RegulatedInformationField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegulatedInformationField" /> class.
        /// </summary>
        /// <param name="fieldId">The unique identifier for the field. (required).</param>
        /// <param name="fieldLabel">The name for the field. (required).</param>
        /// <param name="fieldType">The type of field. (required).</param>
        /// <param name="fieldValue">The content of the field as collected in regulatory form. Note that FileAttachment type fields will contain a URL to download the attachment here. (required).</param>
        public RegulatedInformationField(string fieldId = default(string), string fieldLabel = default(string), FieldTypeEnum fieldType = default(FieldTypeEnum), string fieldValue = default(string))
        {
            // to ensure "fieldId" is required (not null)
            if (fieldId == null)
            {
                throw new InvalidDataException("fieldId is a required property for RegulatedInformationField and cannot be null");
            }
            else
            {
                this.FieldId = fieldId;
            }
            // to ensure "fieldLabel" is required (not null)
            if (fieldLabel == null)
            {
                throw new InvalidDataException("fieldLabel is a required property for RegulatedInformationField and cannot be null");
            }
            else
            {
                this.FieldLabel = fieldLabel;
            }
            // to ensure "fieldType" is required (not null)
            if (fieldType == null)
            {
                throw new InvalidDataException("fieldType is a required property for RegulatedInformationField and cannot be null");
            }
            else
            {
                this.FieldType = fieldType;
            }
            // to ensure "fieldValue" is required (not null)
            if (fieldValue == null)
            {
                throw new InvalidDataException("fieldValue is a required property for RegulatedInformationField and cannot be null");
            }
            else
            {
                this.FieldValue = fieldValue;
            }
        }

        /// <summary>
        /// The unique identifier for the field.
        /// </summary>
        /// <value>The unique identifier for the field.</value>
        [DataMember(Name = "FieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        /// The name for the field.
        /// </summary>
        /// <value>The name for the field.</value>
        [DataMember(Name = "FieldLabel", EmitDefaultValue = false)]
        public string FieldLabel { get; set; }


        /// <summary>
        /// The content of the field as collected in regulatory form. Note that FileAttachment type fields will contain a URL to download the attachment here.
        /// </summary>
        /// <value>The content of the field as collected in regulatory form. Note that FileAttachment type fields will contain a URL to download the attachment here.</value>
        [DataMember(Name = "FieldValue", EmitDefaultValue = false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegulatedInformationField {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldLabel: ").Append(FieldLabel).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
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
            return this.Equals(input as RegulatedInformationField);
        }

        /// <summary>
        /// Returns true if RegulatedInformationField instances are equal
        /// </summary>
        /// <param name="input">Instance of RegulatedInformationField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegulatedInformationField input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) &&
                (
                    this.FieldLabel == input.FieldLabel ||
                    (this.FieldLabel != null &&
                    this.FieldLabel.Equals(input.FieldLabel))
                ) &&
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) &&
                (
                    this.FieldValue == input.FieldValue ||
                    (this.FieldValue != null &&
                    this.FieldValue.Equals(input.FieldValue))
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
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.FieldLabel != null)
                    hashCode = hashCode * 59 + this.FieldLabel.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldValue != null)
                    hashCode = hashCode * 59 + this.FieldValue.GetHashCode();
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