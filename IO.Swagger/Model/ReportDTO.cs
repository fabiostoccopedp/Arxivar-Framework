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
    /// ReportDTO
    /// </summary>
    [DataContract]
    public partial class ReportDTO :  IEquatable<ReportDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDTO" /> class.
        /// </summary>
        /// <param name="Parameters">Parameters to input for the execution.</param>
        /// <param name="Id">Report Id.</param>
        /// <param name="ExternalId">Report external id.</param>
        /// <param name="Name">Name of the report.</param>
        /// <param name="Description">Description of the report.</param>
        /// <param name="Author">Author user.</param>
        /// <param name="AuthorCompleteName">Author name.</param>
        /// <param name="Modifier">Modifier user.</param>
        /// <param name="ModifierCompleteName">Modifier name.</param>
        /// <param name="CreationDate">Creation date of the report.</param>
        /// <param name="LastUpdateDate">The last update of the report.</param>
        /// <param name="IdFindGroup">Id of the find group of the source.</param>
        /// <param name="Security">Information about the report security.</param>
        public ReportDTO(List<ReportParamDTO> Parameters = default(List<ReportParamDTO>), string Id = default(string), string ExternalId = default(string), string Name = default(string), string Description = default(string), int? Author = default(int?), string AuthorCompleteName = default(string), int? Modifier = default(int?), string ModifierCompleteName = default(string), DateTime? CreationDate = default(DateTime?), DateTime? LastUpdateDate = default(DateTime?), string IdFindGroup = default(string), ReportSecurityDTO Security = default(ReportSecurityDTO))
        {
            this.Parameters = Parameters;
            this.Id = Id;
            this.ExternalId = ExternalId;
            this.Name = Name;
            this.Description = Description;
            this.Author = Author;
            this.AuthorCompleteName = AuthorCompleteName;
            this.Modifier = Modifier;
            this.ModifierCompleteName = ModifierCompleteName;
            this.CreationDate = CreationDate;
            this.LastUpdateDate = LastUpdateDate;
            this.IdFindGroup = IdFindGroup;
            this.Security = Security;
        }
        
        /// <summary>
        /// Parameters to input for the execution
        /// </summary>
        /// <value>Parameters to input for the execution</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ReportParamDTO> Parameters { get; set; }

        /// <summary>
        /// Report Id
        /// </summary>
        /// <value>Report Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Report external id
        /// </summary>
        /// <value>Report external id</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Name of the report
        /// </summary>
        /// <value>Name of the report</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the report
        /// </summary>
        /// <value>Description of the report</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Author user
        /// </summary>
        /// <value>Author user</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public int? Author { get; set; }

        /// <summary>
        /// Author name
        /// </summary>
        /// <value>Author name</value>
        [DataMember(Name="authorCompleteName", EmitDefaultValue=false)]
        public string AuthorCompleteName { get; set; }

        /// <summary>
        /// Modifier user
        /// </summary>
        /// <value>Modifier user</value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        public int? Modifier { get; set; }

        /// <summary>
        /// Modifier name
        /// </summary>
        /// <value>Modifier name</value>
        [DataMember(Name="modifierCompleteName", EmitDefaultValue=false)]
        public string ModifierCompleteName { get; set; }

        /// <summary>
        /// Creation date of the report
        /// </summary>
        /// <value>Creation date of the report</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// The last update of the report
        /// </summary>
        /// <value>The last update of the report</value>
        [DataMember(Name="lastUpdateDate", EmitDefaultValue=false)]
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Id of the find group of the source
        /// </summary>
        /// <value>Id of the find group of the source</value>
        [DataMember(Name="idFindGroup", EmitDefaultValue=false)]
        public string IdFindGroup { get; set; }

        /// <summary>
        /// Information about the report security
        /// </summary>
        /// <value>Information about the report security</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public ReportSecurityDTO Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportDTO {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  AuthorCompleteName: ").Append(AuthorCompleteName).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  ModifierCompleteName: ").Append(ModifierCompleteName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  IdFindGroup: ").Append(IdFindGroup).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as ReportDTO);
        }

        /// <summary>
        /// Returns true if ReportDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.AuthorCompleteName == input.AuthorCompleteName ||
                    (this.AuthorCompleteName != null &&
                    this.AuthorCompleteName.Equals(input.AuthorCompleteName))
                ) && 
                (
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && 
                (
                    this.ModifierCompleteName == input.ModifierCompleteName ||
                    (this.ModifierCompleteName != null &&
                    this.ModifierCompleteName.Equals(input.ModifierCompleteName))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.LastUpdateDate == input.LastUpdateDate ||
                    (this.LastUpdateDate != null &&
                    this.LastUpdateDate.Equals(input.LastUpdateDate))
                ) && 
                (
                    this.IdFindGroup == input.IdFindGroup ||
                    (this.IdFindGroup != null &&
                    this.IdFindGroup.Equals(input.IdFindGroup))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.AuthorCompleteName != null)
                    hashCode = hashCode * 59 + this.AuthorCompleteName.GetHashCode();
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.ModifierCompleteName != null)
                    hashCode = hashCode * 59 + this.ModifierCompleteName.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.LastUpdateDate != null)
                    hashCode = hashCode * 59 + this.LastUpdateDate.GetHashCode();
                if (this.IdFindGroup != null)
                    hashCode = hashCode * 59 + this.IdFindGroup.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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
