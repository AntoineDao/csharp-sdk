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
    /// The Status of a Workflow Task
    /// </summary>
    [DataContract]
    public partial class TaskStatus :  IEquatable<TaskStatus>, IValidatableObject
    {
        /// <summary>
        /// The type of task this status is for. Can be \&quot;function\&quot;, \&quot;dag\&quot; or \&quot;loop\&quot;
        /// </summary>
        /// <value>The type of task this status is for. Can be \&quot;function\&quot;, \&quot;dag\&quot; or \&quot;loop\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Function for value: function
            /// </summary>
            [EnumMember(Value = "function")]
            Function = 1,

            /// <summary>
            /// Enum Dag for value: dag
            /// </summary>
            [EnumMember(Value = "dag")]
            Dag = 2,

            /// <summary>
            /// Enum Loop for value: loop
            /// </summary>
            [EnumMember(Value = "loop")]
            Loop = 3

        }

        /// <summary>
        /// The type of task this status is for. Can be \&quot;function\&quot;, \&quot;dag\&quot; or \&quot;loop\&quot;
        /// </summary>
        /// <value>The type of task this status is for. Can be \&quot;function\&quot;, \&quot;dag\&quot; or \&quot;loop\&quot;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatus" /> class.
        /// </summary>
        /// <param name="status">The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot; (required).</param>
        /// <param name="message">Any message produced by the task. Usually error/debugging hints..</param>
        /// <param name="startedAt">The time at which the task was started (required).</param>
        /// <param name="finishedAt">The time at which the task was completed.</param>
        /// <param name="id">The task unique ID (required).</param>
        /// <param name="name">A human readable name for the task. Usually defined by the DAG task name but can be extended if the task is part of a loop for example. This name is unique within the boundary of the DAG/Workflow that generated it. (required).</param>
        /// <param name="type">The type of task this status is for. Can be \&quot;function\&quot;, \&quot;dag\&quot; or \&quot;loop\&quot; (required).</param>
        /// <param name="templateRef">The name of the template that spawned this task (required).</param>
        /// <param name="command">The command used to run this task. Only applies to Function tasks..</param>
        /// <param name="inputs">The inputs used by this task (required).</param>
        /// <param name="outputs">The outputs produced by this task (required).</param>
        /// <param name="boundaryId">This indicates the task ID of the associated template root             task in which this task belongs to. A DAG task will have the id of the             parent DAG for example..</param>
        /// <param name="children">A list of child task IDs (required).</param>
        /// <param name="outboundTasks">A list of the last tasks to ran in the context of this task. In the case of a DAG or a workflow this will be the last task that has been executed. It will remain empty for functions. (required).</param>
        public TaskStatus
        (
           string status, DateTime startedAt, string id, string name, TypeEnum type, string templateRef, Arguments inputs, Arguments outputs, List<string> children, List<string> outboundTasks, // Required parameters
           string message= default, DateTime finishedAt= default, string command= default, string boundaryId= default // Optional parameters
        )// BaseClass
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            
            // to ensure "startedAt" is required (not null)
            if (startedAt == null)
            {
                throw new InvalidDataException("startedAt is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.StartedAt = startedAt;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "templateRef" is required (not null)
            if (templateRef == null)
            {
                throw new InvalidDataException("templateRef is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.TemplateRef = templateRef;
            }
            
            // to ensure "inputs" is required (not null)
            if (inputs == null)
            {
                throw new InvalidDataException("inputs is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Inputs = inputs;
            }
            
            // to ensure "outputs" is required (not null)
            if (outputs == null)
            {
                throw new InvalidDataException("outputs is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Outputs = outputs;
            }
            
            // to ensure "children" is required (not null)
            if (children == null)
            {
                throw new InvalidDataException("children is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.Children = children;
            }
            
            // to ensure "outboundTasks" is required (not null)
            if (outboundTasks == null)
            {
                throw new InvalidDataException("outboundTasks is a required property for TaskStatus and cannot be null");
            }
            else
            {
                this.OutboundTasks = outboundTasks;
            }
            
            this.Message = message;
            this.FinishedAt = finishedAt;
            this.Command = command;
            this.BoundaryId = boundaryId;

            // Set non-required readonly properties with defaultValue
        }
        
        /// <summary>
        /// The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot;
        /// </summary>
        /// <value>The status of this task. Can be \&quot;Running\&quot;, \&quot;Succeeded\&quot;, \&quot;Failed\&quot; or \&quot;Error\&quot;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        [JsonProperty("status")]
        public string Status { get; set; } 
        /// <summary>
        /// Any message produced by the task. Usually error/debugging hints.
        /// </summary>
        /// <value>Any message produced by the task. Usually error/debugging hints.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty("message")]
        public string Message { get; set; } 
        /// <summary>
        /// The time at which the task was started
        /// </summary>
        /// <value>The time at which the task was started</value>
        [DataMember(Name="started_at", EmitDefaultValue=false)]
        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; } 
        /// <summary>
        /// The time at which the task was completed
        /// </summary>
        /// <value>The time at which the task was completed</value>
        [DataMember(Name="finished_at", EmitDefaultValue=false)]
        [JsonProperty("finished_at")]
        public DateTime FinishedAt { get; set; } 
        /// <summary>
        /// The task unique ID
        /// </summary>
        /// <value>The task unique ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        [JsonProperty("id")]
        public string Id { get; set; } 
        /// <summary>
        /// A human readable name for the task. Usually defined by the DAG task name but can be extended if the task is part of a loop for example. This name is unique within the boundary of the DAG/Workflow that generated it.
        /// </summary>
        /// <value>A human readable name for the task. Usually defined by the DAG task name but can be extended if the task is part of a loop for example. This name is unique within the boundary of the DAG/Workflow that generated it.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; } 
        /// <summary>
        /// The name of the template that spawned this task
        /// </summary>
        /// <value>The name of the template that spawned this task</value>
        [DataMember(Name="template_ref", EmitDefaultValue=false)]
        [JsonProperty("template_ref")]
        public string TemplateRef { get; set; } 
        /// <summary>
        /// The command used to run this task. Only applies to Function tasks.
        /// </summary>
        /// <value>The command used to run this task. Only applies to Function tasks.</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        [JsonProperty("command")]
        public string Command { get; set; } 
        /// <summary>
        /// The inputs used by this task
        /// </summary>
        /// <value>The inputs used by this task</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        [JsonProperty("inputs")]
        public Arguments Inputs { get; set; } 
        /// <summary>
        /// The outputs produced by this task
        /// </summary>
        /// <value>The outputs produced by this task</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        [JsonProperty("outputs")]
        public Arguments Outputs { get; set; } 
        /// <summary>
        /// This indicates the task ID of the associated template root             task in which this task belongs to. A DAG task will have the id of the             parent DAG for example.
        /// </summary>
        /// <value>This indicates the task ID of the associated template root             task in which this task belongs to. A DAG task will have the id of the             parent DAG for example.</value>
        [DataMember(Name="boundary_id", EmitDefaultValue=false)]
        [JsonProperty("boundary_id")]
        public string BoundaryId { get; set; } 
        /// <summary>
        /// A list of child task IDs
        /// </summary>
        /// <value>A list of child task IDs</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        [JsonProperty("children")]
        public List<string> Children { get; set; } 
        /// <summary>
        /// A list of the last tasks to ran in the context of this task. In the case of a DAG or a workflow this will be the last task that has been executed. It will remain empty for functions.
        /// </summary>
        /// <value>A list of the last tasks to ran in the context of this task. In the case of a DAG or a workflow this will be the last task that has been executed. It will remain empty for functions.</value>
        [DataMember(Name="outbound_tasks", EmitDefaultValue=false)]
        [JsonProperty("outbound_tasks")]
        public List<string> OutboundTasks { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TemplateRef: ").Append(TemplateRef).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  BoundaryId: ").Append(BoundaryId).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  OutboundTasks: ").Append(OutboundTasks).Append("\n");
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
            return this.Equals(input as TaskStatus);
        }

        /// <summary>
        /// Returns true if TaskStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TemplateRef == input.TemplateRef ||
                    (this.TemplateRef != null &&
                    this.TemplateRef.Equals(input.TemplateRef))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    (this.Inputs != null &&
                    this.Inputs.Equals(input.Inputs))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    (this.Outputs != null &&
                    this.Outputs.Equals(input.Outputs))
                ) && 
                (
                    this.BoundaryId == input.BoundaryId ||
                    (this.BoundaryId != null &&
                    this.BoundaryId.Equals(input.BoundaryId))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.OutboundTasks == input.OutboundTasks ||
                    this.OutboundTasks != null &&
                    input.OutboundTasks != null &&
                    this.OutboundTasks.SequenceEqual(input.OutboundTasks)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TemplateRef != null)
                    hashCode = hashCode * 59 + this.TemplateRef.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.BoundaryId != null)
                    hashCode = hashCode * 59 + this.BoundaryId.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.OutboundTasks != null)
                    hashCode = hashCode * 59 + this.OutboundTasks.GetHashCode();
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