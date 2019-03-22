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
    /// Class of user permission
    /// </summary>
    [DataContract]
    public partial class UserPermissionDTO :  IEquatable<UserPermissionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPermissionDTO" /> class.
        /// </summary>
        /// <param name="Id">Identifier.</param>
        /// <param name="User">Identifier of user.</param>
        /// <param name="UserDescription">Description of the user.</param>
        /// <param name="Category">Possible values:  0: U  1: S  2: M  3: F  4: G  5: I  6: D .</param>
        /// <param name="Permissions">Permission list.</param>
        /// <param name="ExternalId">External Identifier.</param>
        public UserPermissionDTO(string Id = default(string), int? User = default(int?), string UserDescription = default(string), int? Category = default(int?), List<PermissionItemDTO> Permissions = default(List<PermissionItemDTO>), string ExternalId = default(string))
        {
            this.Id = Id;
            this.User = User;
            this.UserDescription = UserDescription;
            this.Category = Category;
            this.Permissions = Permissions;
            this.ExternalId = ExternalId;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier of user
        /// </summary>
        /// <value>Identifier of user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Description of the user
        /// </summary>
        /// <value>Description of the user</value>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Possible values:  0: U  1: S  2: M  3: F  4: G  5: I  6: D 
        /// </summary>
        /// <value>Possible values:  0: U  1: S  2: M  3: F  4: G  5: I  6: D </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public int? Category { get; set; }

        /// <summary>
        /// Permission list
        /// </summary>
        /// <value>Permission list</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionItemDTO> Permissions { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPermissionDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
            return this.Equals(input as UserPermissionDTO);
        }

        /// <summary>
        /// Returns true if UserPermissionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPermissionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPermissionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
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