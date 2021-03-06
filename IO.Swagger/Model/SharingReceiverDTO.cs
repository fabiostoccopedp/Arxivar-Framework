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
    /// Sharing receiver informations.
    /// </summary>
    [DataContract]
    public partial class SharingReceiverDTO :  IEquatable<SharingReceiverDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingReceiverDTO" /> class.
        /// </summary>
        /// <param name="SharingReceiverId">Unique identifier for sharing receiver.</param>
        /// <param name="SharingId">Unique identifier for sharing..</param>
        /// <param name="Email">email address..</param>
        /// <param name="Address">Postal Address..</param>
        /// <param name="Cap">Postal code..</param>
        /// <param name="Location">Location.</param>
        /// <param name="Province">Provincia..</param>
        /// <param name="Country">Country..</param>
        /// <param name="AddressBookId">Unique identifier for AddressBook.</param>
        /// <param name="ContactId">Unique identifier for Contact.</param>
        /// <param name="SharingReadingTime">Number of read operations..</param>
        /// <param name="SharingReadingLastTime">Last reading DateTIme..</param>
        /// <param name="Lang">Lang code..</param>
        /// <param name="ReceiverName">Name of the receiver..</param>
        /// <param name="Processed">Number of sharing elaboration.</param>
        public SharingReceiverDTO(string SharingReceiverId = default(string), string SharingId = default(string), string Email = default(string), string Address = default(string), string Cap = default(string), string Location = default(string), string Province = default(string), string Country = default(string), int? AddressBookId = default(int?), int? ContactId = default(int?), int? SharingReadingTime = default(int?), DateTime? SharingReadingLastTime = default(DateTime?), string Lang = default(string), string ReceiverName = default(string), int? Processed = default(int?))
        {
            this.SharingReceiverId = SharingReceiverId;
            this.SharingId = SharingId;
            this.Email = Email;
            this.Address = Address;
            this.Cap = Cap;
            this.Location = Location;
            this.Province = Province;
            this.Country = Country;
            this.AddressBookId = AddressBookId;
            this.ContactId = ContactId;
            this.SharingReadingTime = SharingReadingTime;
            this.SharingReadingLastTime = SharingReadingLastTime;
            this.Lang = Lang;
            this.ReceiverName = ReceiverName;
            this.Processed = Processed;
        }
        
        /// <summary>
        /// Unique identifier for sharing receiver
        /// </summary>
        /// <value>Unique identifier for sharing receiver</value>
        [DataMember(Name="sharingReceiverId", EmitDefaultValue=false)]
        public string SharingReceiverId { get; set; }

        /// <summary>
        /// Unique identifier for sharing.
        /// </summary>
        /// <value>Unique identifier for sharing.</value>
        [DataMember(Name="sharingId", EmitDefaultValue=false)]
        public string SharingId { get; set; }

        /// <summary>
        /// email address.
        /// </summary>
        /// <value>email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Postal Address.
        /// </summary>
        /// <value>Postal Address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name="cap", EmitDefaultValue=false)]
        public string Cap { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        /// <value>Location</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Provincia.
        /// </summary>
        /// <value>Provincia.</value>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        /// <value>Country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Unique identifier for AddressBook
        /// </summary>
        /// <value>Unique identifier for AddressBook</value>
        [DataMember(Name="addressBookId", EmitDefaultValue=false)]
        public int? AddressBookId { get; set; }

        /// <summary>
        /// Unique identifier for Contact
        /// </summary>
        /// <value>Unique identifier for Contact</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public int? ContactId { get; set; }

        /// <summary>
        /// Number of read operations.
        /// </summary>
        /// <value>Number of read operations.</value>
        [DataMember(Name="sharingReadingTime", EmitDefaultValue=false)]
        public int? SharingReadingTime { get; set; }

        /// <summary>
        /// Last reading DateTIme.
        /// </summary>
        /// <value>Last reading DateTIme.</value>
        [DataMember(Name="sharingReadingLastTime", EmitDefaultValue=false)]
        public DateTime? SharingReadingLastTime { get; set; }

        /// <summary>
        /// Lang code.
        /// </summary>
        /// <value>Lang code.</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Name of the receiver.
        /// </summary>
        /// <value>Name of the receiver.</value>
        [DataMember(Name="receiverName", EmitDefaultValue=false)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Number of sharing elaboration
        /// </summary>
        /// <value>Number of sharing elaboration</value>
        [DataMember(Name="processed", EmitDefaultValue=false)]
        public int? Processed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingReceiverDTO {\n");
            sb.Append("  SharingReceiverId: ").Append(SharingReceiverId).Append("\n");
            sb.Append("  SharingId: ").Append(SharingId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressBookId: ").Append(AddressBookId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  SharingReadingTime: ").Append(SharingReadingTime).Append("\n");
            sb.Append("  SharingReadingLastTime: ").Append(SharingReadingLastTime).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  ReceiverName: ").Append(ReceiverName).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
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
            return this.Equals(input as SharingReceiverDTO);
        }

        /// <summary>
        /// Returns true if SharingReceiverDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingReceiverDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingReceiverDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharingReceiverId == input.SharingReceiverId ||
                    (this.SharingReceiverId != null &&
                    this.SharingReceiverId.Equals(input.SharingReceiverId))
                ) && 
                (
                    this.SharingId == input.SharingId ||
                    (this.SharingId != null &&
                    this.SharingId.Equals(input.SharingId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Cap == input.Cap ||
                    (this.Cap != null &&
                    this.Cap.Equals(input.Cap))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AddressBookId == input.AddressBookId ||
                    (this.AddressBookId != null &&
                    this.AddressBookId.Equals(input.AddressBookId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.SharingReadingTime == input.SharingReadingTime ||
                    (this.SharingReadingTime != null &&
                    this.SharingReadingTime.Equals(input.SharingReadingTime))
                ) && 
                (
                    this.SharingReadingLastTime == input.SharingReadingLastTime ||
                    (this.SharingReadingLastTime != null &&
                    this.SharingReadingLastTime.Equals(input.SharingReadingLastTime))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.ReceiverName == input.ReceiverName ||
                    (this.ReceiverName != null &&
                    this.ReceiverName.Equals(input.ReceiverName))
                ) && 
                (
                    this.Processed == input.Processed ||
                    (this.Processed != null &&
                    this.Processed.Equals(input.Processed))
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
                if (this.SharingReceiverId != null)
                    hashCode = hashCode * 59 + this.SharingReceiverId.GetHashCode();
                if (this.SharingId != null)
                    hashCode = hashCode * 59 + this.SharingId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Cap != null)
                    hashCode = hashCode * 59 + this.Cap.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AddressBookId != null)
                    hashCode = hashCode * 59 + this.AddressBookId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.SharingReadingTime != null)
                    hashCode = hashCode * 59 + this.SharingReadingTime.GetHashCode();
                if (this.SharingReadingLastTime != null)
                    hashCode = hashCode * 59 + this.SharingReadingLastTime.GetHashCode();
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
                if (this.ReceiverName != null)
                    hashCode = hashCode * 59 + this.ReceiverName.GetHashCode();
                if (this.Processed != null)
                    hashCode = hashCode * 59 + this.Processed.GetHashCode();
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
