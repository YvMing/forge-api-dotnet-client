/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// ProjectRelationships
    /// </summary>
    [DataContract]
    public partial class ProjectRelationships :  IEquatable<ProjectRelationships>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRelationships" /> class.
        /// </summary>
        /// <param name="Hub">Hub (required).</param>
        /// <param name="RootFolder">RootFolder (required).</param>
        public ProjectRelationships(JsonApiRelationshipsLinksInternalResource Hub = null, JsonApiRelationshipsLinksExternalResource RootFolder = null)
        {
            // to ensure "Hub" is required (not null)
            if (Hub == null)
            {
                throw new InvalidDataException("Hub is a required property for ProjectRelationships and cannot be null");
            }
            else
            {
                this.Hub = Hub;
            }
            // to ensure "RootFolder" is required (not null)
            if (RootFolder == null)
            {
                throw new InvalidDataException("RootFolder is a required property for ProjectRelationships and cannot be null");
            }
            else
            {
                this.RootFolder = RootFolder;
            }
        }
        
        /// <summary>
        /// Gets or Sets Hub
        /// </summary>
        [DataMember(Name="hub", EmitDefaultValue=false)]
        public JsonApiRelationshipsLinksInternalResource Hub { get; set; }
        /// <summary>
        /// Gets or Sets RootFolder
        /// </summary>
        [DataMember(Name="rootFolder", EmitDefaultValue=false)]
        public JsonApiRelationshipsLinksExternalResource RootFolder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectRelationships {\n");
            sb.Append("  Hub: ").Append(Hub).Append("\n");
            sb.Append("  RootFolder: ").Append(RootFolder).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ProjectRelationships);
        }

        /// <summary>
        /// Returns true if ProjectRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hub == other.Hub ||
                    this.Hub != null &&
                    this.Hub.Equals(other.Hub)
                ) && 
                (
                    this.RootFolder == other.RootFolder ||
                    this.RootFolder != null &&
                    this.RootFolder.Equals(other.RootFolder)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Hub != null)
                    hash = hash * 59 + this.Hub.GetHashCode();
                if (this.RootFolder != null)
                    hash = hash * 59 + this.RootFolder.GetHashCode();
                return hash;
            }
        }
    }

}
