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
    /// Loop Control
    /// </summary>
    [DataContract]
    public partial class LoopControl :  IEquatable<LoopControl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoopControl" /> class.
        /// </summary>
        /// <param name="key">The loop control key determines how parameters and artifacts from a looped task can be identified.</param>
        public LoopControl
        (
           // Required parameters
           string key= default// Optional parameters
        )// BaseClass
        {
            this.Key = key;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The loop control key determines how parameters and artifacts from a looped task can be identified
        /// </summary>
        /// <value>The loop control key determines how parameters and artifacts from a looped task can be identified</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        [JsonProperty("key")]
        public string Key { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoopControl {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
        /// <returns>LoopControl object</returns>
        public static LoopControl FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LoopControl>(json, JsonSetting.ConvertSetting);
            return obj;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LoopControl object</returns>
        public LoopControl DuplicateLoopControl()
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
            return this.Equals(input as LoopControl);
        }

        /// <summary>
        /// Returns true if LoopControl instances are equal
        /// </summary>
        /// <param name="input">Instance of LoopControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoopControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
