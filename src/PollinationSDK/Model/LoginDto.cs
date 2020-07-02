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
    /// LoginDto
    /// </summary>
    [DataContract]
    public partial class LoginDto :  IEquatable<LoginDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoginDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginDto" /> class.
        /// </summary>
        /// <param name="apiToken">An api token generated by calling the POST /user/tokens endpoint (required).</param>
        public LoginDto
        (
           string apiToken// Required parameters
           // Optional parameters
        )// BaseClass
        {
            // to ensure "apiToken" is required (not null)
            if (apiToken == null)
            {
                throw new InvalidDataException("apiToken is a required property for LoginDto and cannot be null");
            }
            else
            {
                this.ApiToken = apiToken;
            }
            

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// An api token generated by calling the POST /user/tokens endpoint
        /// </summary>
        /// <value>An api token generated by calling the POST /user/tokens endpoint</value>
        [DataMember(Name="api_token", EmitDefaultValue=false)]
        [JsonProperty("api_token")]
        public string ApiToken { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginDto {\n");
            sb.Append("  ApiToken: ").Append(ApiToken).Append("\n");
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
            return this.Equals(input as LoginDto);
        }

        /// <summary>
        /// Returns true if LoginDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LoginDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiToken == input.ApiToken ||
                    (this.ApiToken != null &&
                    this.ApiToken.Equals(input.ApiToken))
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
                if (this.ApiToken != null)
                    hashCode = hashCode * 59 + this.ApiToken.GetHashCode();
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