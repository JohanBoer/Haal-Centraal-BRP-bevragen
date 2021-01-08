/*
 * Bevragen Ingeschreven Personen
 *
 * API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 1.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NaamPersoonInOnderzoekAllOf
    /// </summary>
    [DataContract(Name = "NaamPersoonInOnderzoek_allOf")]
    public partial class NaamPersoonInOnderzoekAllOf : IEquatable<NaamPersoonInOnderzoekAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaamPersoonInOnderzoekAllOf" /> class.
        /// </summary>
        /// <param name="aanduidingNaamgebruik">aanduidingNaamgebruik.</param>
        public NaamPersoonInOnderzoekAllOf(bool aanduidingNaamgebruik = default(bool))
        {
            this.AanduidingNaamgebruik = aanduidingNaamgebruik;
        }

        /// <summary>
        /// Gets or Sets AanduidingNaamgebruik
        /// </summary>
        [DataMember(Name = "aanduidingNaamgebruik", EmitDefaultValue = false)]
        public bool AanduidingNaamgebruik { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NaamPersoonInOnderzoekAllOf {\n");
            sb.Append("  AanduidingNaamgebruik: ").Append(AanduidingNaamgebruik).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NaamPersoonInOnderzoekAllOf);
        }

        /// <summary>
        /// Returns true if NaamPersoonInOnderzoekAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NaamPersoonInOnderzoekAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NaamPersoonInOnderzoekAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AanduidingNaamgebruik == input.AanduidingNaamgebruik ||
                    this.AanduidingNaamgebruik.Equals(input.AanduidingNaamgebruik)
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
                hashCode = hashCode * 59 + this.AanduidingNaamgebruik.GetHashCode();
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
