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
    /// Maintainer information
    /// </summary>
    [DataContract]
    public partial class QueenbeeRecipeMetadataMaintainer :  IEquatable<QueenbeeRecipeMetadataMaintainer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueenbeeRecipeMetadataMaintainer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueenbeeRecipeMetadataMaintainer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueenbeeRecipeMetadataMaintainer" /> class.
        /// </summary>
        /// <param name="name">The name of the author/maintainer person or organization. (required).</param>
        /// <param name="email">The email address of the author/maintainer person or organization..</param>
        public QueenbeeRecipeMetadataMaintainer
        (
           string name, // Required parameters
           string email= default// Optional parameters
        )// BaseClass
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for QueenbeeRecipeMetadataMaintainer and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Email = email;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The name of the author/maintainer person or organization.
        /// </summary>
        /// <value>The name of the author/maintainer person or organization.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The email address of the author/maintainer person or organization.
        /// </summary>
        /// <value>The email address of the author/maintainer person or organization.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        [JsonProperty("email")]
        public string Email { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueenbeeRecipeMetadataMaintainer {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
        /// <returns>QueenbeeRecipeMetadataMaintainer object</returns>
        public static QueenbeeRecipeMetadataMaintainer FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<QueenbeeRecipeMetadataMaintainer>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>QueenbeeRecipeMetadataMaintainer object</returns>
        public QueenbeeRecipeMetadataMaintainer DuplicateQueenbeeRecipeMetadataMaintainer()
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
            return this.Equals(input as QueenbeeRecipeMetadataMaintainer);
        }

        /// <summary>
        /// Returns true if QueenbeeRecipeMetadataMaintainer instances are equal
        /// </summary>
        /// <param name="input">Instance of QueenbeeRecipeMetadataMaintainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueenbeeRecipeMetadataMaintainer input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
