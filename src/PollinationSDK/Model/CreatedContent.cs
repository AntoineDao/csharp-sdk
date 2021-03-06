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
    /// Content for created response.
    /// </summary>
    [DataContract]
    public partial class CreatedContent :  IEquatable<CreatedContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatedContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedContent" /> class.
        /// </summary>
        /// <param name="id">Id for the newly created resource. (required).</param>
        /// <param name="message"> A human readable message.</param>
        public CreatedContent
        (
           Guid id, // Required parameters
           string message= default// Optional parameters
        )// BaseClass
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreatedContent and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            this.Message = message;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// Id for the newly created resource.
        /// </summary>
        /// <value>Id for the newly created resource.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public Guid Id { get; set; } 
        /// <summary>
        ///  A human readable message
        /// </summary>
        /// <value> A human readable message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty("message")]
        public string Message { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatedContent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
        /// <returns>CreatedContent object</returns>
        public static CreatedContent FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<CreatedContent>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>CreatedContent object</returns>
        public CreatedContent DuplicateCreatedContent()
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
            return this.Equals(input as CreatedContent);
        }

        /// <summary>
        /// Returns true if CreatedContent instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedContent input)
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
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
