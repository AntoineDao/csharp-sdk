/* 
 * Pollination Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.5.32
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
    /// ProjectAccessPolicyDto
    /// </summary>
    [DataContract]
    public partial class ProjectAccessPolicyDto :  IEquatable<ProjectAccessPolicyDto>, IValidatableObject
    {
        /// <summary>
        /// The permission to associate with the policy subject. Can be one of &#x60;admin&#x60;, &#x60;contribute&#x60;, or &#x60;use&#x60;
        /// </summary>
        /// <value>The permission to associate with the policy subject. Can be one of &#x60;admin&#x60;, &#x60;contribute&#x60;, or &#x60;use&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 1,

            /// <summary>
            /// Enum Contribute for value: contribute
            /// </summary>
            [EnumMember(Value = "contribute")]
            Contribute = 2,

            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 3

        }

        /// <summary>
        /// The permission to associate with the policy subject. Can be one of &#x60;admin&#x60;, &#x60;contribute&#x60;, or &#x60;use&#x60;
        /// </summary>
        /// <value>The permission to associate with the policy subject. Can be one of &#x60;admin&#x60;, &#x60;contribute&#x60;, or &#x60;use&#x60;</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionEnum Permission { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccessPolicyDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectAccessPolicyDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccessPolicyDto" /> class.
        /// </summary>
        /// <param name="subject">The subject the access policy refers to (required).</param>
        /// <param name="permission">The permission to associate with the policy subject. Can be one of &#x60;admin&#x60;, &#x60;contribute&#x60;, or &#x60;use&#x60; (required).</param>
        public ProjectAccessPolicyDto
        (
           ProjectPolicySubjectDto subject, PermissionEnum permission// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for ProjectAccessPolicyDto and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            
            // to ensure "permission" is required (not null)
            if (permission == null)
            {
                throw new InvalidDataException("permission is a required property for ProjectAccessPolicyDto and cannot be null");
            }
            else
            {
                this.Permission = permission;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The subject the access policy refers to
        /// </summary>
        /// <value>The subject the access policy refers to</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        [JsonProperty("subject")]
        public ProjectPolicySubjectDto Subject { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectAccessPolicyDto {\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.ConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ProjectAccessPolicyDto object</returns>
        public static ProjectAccessPolicyDto FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectAccessPolicyDto>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectAccessPolicyDto object</returns>
        public ProjectAccessPolicyDto DuplicateProjectAccessPolicyDto()
        {
            return FromJson(this.ToJson());
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectAccessPolicyDto);
        }

        /// <summary>
        /// Returns true if ProjectAccessPolicyDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectAccessPolicyDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectAccessPolicyDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
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
