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
    /// 
    /// </summary>
    [DataContract]
    public partial class RecognizerResult : IEquatable<RecognizerResult>
    { 
        /// <summary>
        /// Where the PII starts
        /// </summary>
        /// <value>Where the PII starts</value>
        [Required]
        [DataMember(Name="start")]
        public int? Start { get; set; }

        /// <summary>
        /// Where the PII ends
        /// </summary>
        /// <value>Where the PII ends</value>
        [Required]
        [DataMember(Name="end")]
        public int? End { get; set; }

        /// <summary>
        /// The PII detection score
        /// </summary>
        /// <value>The PII detection score</value>
        [Required]
        [DataMember(Name="score")]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [Required]
        [DataMember(Name="entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecognizerResult {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RecognizerResult)obj);
        }

        /// <summary>
        /// Returns true if RecognizerResult instances are equal
        /// </summary>
        /// <param name="other">Instance of RecognizerResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecognizerResult other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Start == other.Start ||
                    Start != null &&
                    Start.Equals(other.Start)
                ) && 
                (
                    End == other.End ||
                    End != null &&
                    End.Equals(other.End)
                ) && 
                (
                    Score == other.Score ||
                    Score != null &&
                    Score.Equals(other.Score)
                ) && 
                (
                    EntityType == other.EntityType ||
                    EntityType != null &&
                    EntityType.Equals(other.EntityType)
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
                    if (Start != null)
                    hashCode = hashCode * 59 + Start.GetHashCode();
                    if (End != null)
                    hashCode = hashCode * 59 + End.GetHashCode();
                    if (Score != null)
                    hashCode = hashCode * 59 + Score.GetHashCode();
                    if (EntityType != null)
                    hashCode = hashCode * 59 + EntityType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RecognizerResult left, RecognizerResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RecognizerResult left, RecognizerResult right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
