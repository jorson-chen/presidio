/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * OpenAPI spec version: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Microsoft.Presidio.Models
{ 
    /// <summary>
    /// Replace with a given character
    /// </summary>
    [DataContract]
    public partial class Mask : IEquatable<Mask>
    { 
        /// <summary>
        /// mask
        /// </summary>
        /// <value>mask</value>
        [Required]
        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// The replacement character
        /// </summary>
        /// <value>The replacement character</value>
        [Required]
        [DataMember(Name="masking_char")]
        public string MaskingChar { get; set; }

        /// <summary>
        /// The amount of characters that should be replaced
        /// </summary>
        /// <value>The amount of characters that should be replaced</value>
        [Required]
        [DataMember(Name="chars_to_mask")]
        public int? CharsToMask { get; set; }

        /// <summary>
        /// Whether to mask the PII from it&#x27;s end
        /// </summary>
        /// <value>Whether to mask the PII from it&#x27;s end</value>
        [DataMember(Name="from_end")]
        public bool? FromEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mask {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaskingChar: ").Append(MaskingChar).Append("\n");
            sb.Append("  CharsToMask: ").Append(CharsToMask).Append("\n");
            sb.Append("  FromEnd: ").Append(FromEnd).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Mask)obj);
        }

        /// <summary>
        /// Returns true if Mask instances are equal
        /// </summary>
        /// <param name="other">Instance of Mask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mask other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    MaskingChar == other.MaskingChar ||
                    MaskingChar != null &&
                    MaskingChar.Equals(other.MaskingChar)
                ) && 
                (
                    CharsToMask == other.CharsToMask ||
                    CharsToMask != null &&
                    CharsToMask.Equals(other.CharsToMask)
                ) && 
                (
                    FromEnd == other.FromEnd ||
                    FromEnd != null &&
                    FromEnd.Equals(other.FromEnd)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (MaskingChar != null)
                    hashCode = hashCode * 59 + MaskingChar.GetHashCode();
                    if (CharsToMask != null)
                    hashCode = hashCode * 59 + CharsToMask.GetHashCode();
                    if (FromEnd != null)
                    hashCode = hashCode * 59 + FromEnd.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Mask left, Mask right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Mask left, Mask right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
