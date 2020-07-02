/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.5.28
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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


namespace PollinationSDK.Model
{
    /// <summary>
    /// TeamDto
    /// </summary>
    [DataContract]
    public partial class TeamDto :  IEquatable<TeamDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamDto" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="id">id (required).</param>
        /// <param name="slug">slug (required).</param>
        /// <param name="org">org (required).</param>
        /// <param name="memberCount">The number of members that are part of this org (default to 0).</param>
        public TeamDto
        (
           string name, string id, string slug, TeamOrg org, // Required parameters
           string description= default, int memberCount = 0// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TeamDto and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TeamDto and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for TeamDto and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            
            // to ensure "org" is required (not null)
            if (org == null)
            {
                throw new InvalidDataException("org is a required property for TeamDto and cannot be null");
            }
            else
            {
                this.Org = org;
            }
            
            this.Description = description;
            // use default value if no "memberCount" provided
            if (memberCount == null)
            {
                this.MemberCount =0;
            }
            else
            {
                this.MemberCount = memberCount;
            }

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        [JsonProperty("description")]
        public string Description { get; set; } 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        [JsonProperty("slug")]
        public string Slug { get; set; } 
        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name="org", EmitDefaultValue=false)]
        [JsonProperty("org")]
        public TeamOrg Org { get; set; } 
        /// <summary>
        /// The number of members that are part of this org
        /// </summary>
        /// <value>The number of members that are part of this org</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }  = 0;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
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
            return this.Equals(input as TeamDto);
        }

        /// <summary>
        /// Returns true if TeamDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamDto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Org == input.Org ||
                    (this.Org != null &&
                    this.Org.Equals(input.Org))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Org != null)
                    hashCode = hashCode * 59 + this.Org.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
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