/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// IxFeDocumentCompleteDTO
    /// </summary>
    [DataContract]
    public partial class IxFeDocumentCompleteDTO :  IEquatable<IxFeDocumentCompleteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IxFeDocumentCompleteDTO" /> class.
        /// </summary>
        /// <param name="IxFeDocument">IxFeDocument.</param>
        /// <param name="Details">Details.</param>
        public IxFeDocumentCompleteDTO(IxFeDocumentDTO IxFeDocument = default(IxFeDocumentDTO), List<IxFeDocumentDetailDTO> Details = default(List<IxFeDocumentDetailDTO>))
        {
            this.IxFeDocument = IxFeDocument;
            this.Details = Details;
        }
        
        /// <summary>
        /// Gets or Sets IxFeDocument
        /// </summary>
        [DataMember(Name="ixFeDocument", EmitDefaultValue=false)]
        public IxFeDocumentDTO IxFeDocument { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<IxFeDocumentDetailDTO> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IxFeDocumentCompleteDTO {\n");
            sb.Append("  IxFeDocument: ").Append(IxFeDocument).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IxFeDocumentCompleteDTO);
        }

        /// <summary>
        /// Returns true if IxFeDocumentCompleteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IxFeDocumentCompleteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IxFeDocumentCompleteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IxFeDocument == input.IxFeDocument ||
                    (this.IxFeDocument != null &&
                    this.IxFeDocument.Equals(input.IxFeDocument))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                if (this.IxFeDocument != null)
                    hashCode = hashCode * 59 + this.IxFeDocument.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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