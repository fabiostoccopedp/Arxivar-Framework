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
    /// Dto for user default binders type and state selection
    /// </summary>
    [DataContract]
    public partial class BinderUserDefaultTypeAndStateDto :  IEquatable<BinderUserDefaultTypeAndStateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderUserDefaultTypeAndStateDto" /> class.
        /// </summary>
        /// <param name="DefaultBinderType">Default binder type.</param>
        /// <param name="DefaultBinderState">Default binder state.</param>
        public BinderUserDefaultTypeAndStateDto(int? DefaultBinderType = default(int?), int? DefaultBinderState = default(int?))
        {
            this.DefaultBinderType = DefaultBinderType;
            this.DefaultBinderState = DefaultBinderState;
        }
        
        /// <summary>
        /// Default binder type
        /// </summary>
        /// <value>Default binder type</value>
        [DataMember(Name="defaultBinderType", EmitDefaultValue=false)]
        public int? DefaultBinderType { get; set; }

        /// <summary>
        /// Default binder state
        /// </summary>
        /// <value>Default binder state</value>
        [DataMember(Name="defaultBinderState", EmitDefaultValue=false)]
        public int? DefaultBinderState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderUserDefaultTypeAndStateDto {\n");
            sb.Append("  DefaultBinderType: ").Append(DefaultBinderType).Append("\n");
            sb.Append("  DefaultBinderState: ").Append(DefaultBinderState).Append("\n");
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
            return this.Equals(input as BinderUserDefaultTypeAndStateDto);
        }

        /// <summary>
        /// Returns true if BinderUserDefaultTypeAndStateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BinderUserDefaultTypeAndStateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderUserDefaultTypeAndStateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultBinderType == input.DefaultBinderType ||
                    (this.DefaultBinderType != null &&
                    this.DefaultBinderType.Equals(input.DefaultBinderType))
                ) && 
                (
                    this.DefaultBinderState == input.DefaultBinderState ||
                    (this.DefaultBinderState != null &&
                    this.DefaultBinderState.Equals(input.DefaultBinderState))
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
                if (this.DefaultBinderType != null)
                    hashCode = hashCode * 59 + this.DefaultBinderType.GetHashCode();
                if (this.DefaultBinderState != null)
                    hashCode = hashCode * 59 + this.DefaultBinderState.GetHashCode();
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
