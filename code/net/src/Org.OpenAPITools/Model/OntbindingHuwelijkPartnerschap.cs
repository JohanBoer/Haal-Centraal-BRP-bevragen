/* 
 * Bevragingen ingeschreven personen
 *
 * API voor het ontsluiten van gegevens van ingeschreven personen en aanverwante gegevens uit de GBA en RNI. Met deze API worden de actuele gegevens van ingeschreven personen, hun kinderen, partners en ouders ontsloten. <br> Heeft een persoon bijvoorbeeld geen geldige nationaliteit, dan wordt nationaliteit niet geretourneerd. <br> Heeft een persoon een beëindigd partnerschap of huwelijk, dan wordt de partner niet geretourneerd. <br> <br> Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Bevragingen-ingeschreven-personen/tree/master/features) voor nadere toelichting. <br> 
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// OntbindingHuwelijkPartnerschap
    /// </summary>
    [DataContract]
    public partial class OntbindingHuwelijkPartnerschap :  IEquatable<OntbindingHuwelijkPartnerschap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OntbindingHuwelijkPartnerschap" /> class.
        /// </summary>
        /// <param name="indicatieHuwelijkPartnerschapBeeindigd">Indicatie of het huwelijk ontbonden is danwel het partnerschap beeindigd is. * &#x60;True&#x60; - Huwelijk/Partnerschap is beeindigd..</param>
        /// <param name="datum">datum.</param>
        /// <param name="land">land.</param>
        /// <param name="plaats">plaats.</param>
        /// <param name="reden">reden.</param>
        /// <param name="inOnderzoek">inOnderzoek.</param>
        public OntbindingHuwelijkPartnerschap(bool indicatieHuwelijkPartnerschapBeeindigd = default(bool), DatumOnvolledig datum = default(DatumOnvolledig), Waardetabel land = default(Waardetabel), Waardetabel plaats = default(Waardetabel), Waardetabel reden = default(Waardetabel), OntbindingHuwelijkInOnderzoek inOnderzoek = default(OntbindingHuwelijkInOnderzoek))
        {
            this.IndicatieHuwelijkPartnerschapBeeindigd = indicatieHuwelijkPartnerschapBeeindigd;
            this.Datum = datum;
            this.Land = land;
            this.Plaats = plaats;
            this.Reden = reden;
            this.InOnderzoek = inOnderzoek;
        }
        
        /// <summary>
        /// Indicatie of het huwelijk ontbonden is danwel het partnerschap beeindigd is. * &#x60;True&#x60; - Huwelijk/Partnerschap is beeindigd.
        /// </summary>
        /// <value>Indicatie of het huwelijk ontbonden is danwel het partnerschap beeindigd is. * &#x60;True&#x60; - Huwelijk/Partnerschap is beeindigd.</value>
        [DataMember(Name="indicatieHuwelijkPartnerschapBeeindigd", EmitDefaultValue=false)]
        public bool IndicatieHuwelijkPartnerschapBeeindigd { get; set; }

        /// <summary>
        /// Gets or Sets Datum
        /// </summary>
        [DataMember(Name="datum", EmitDefaultValue=false)]
        public DatumOnvolledig Datum { get; set; }

        /// <summary>
        /// Gets or Sets Land
        /// </summary>
        [DataMember(Name="land", EmitDefaultValue=false)]
        public Waardetabel Land { get; set; }

        /// <summary>
        /// Gets or Sets Plaats
        /// </summary>
        [DataMember(Name="plaats", EmitDefaultValue=false)]
        public Waardetabel Plaats { get; set; }

        /// <summary>
        /// Gets or Sets Reden
        /// </summary>
        [DataMember(Name="reden", EmitDefaultValue=false)]
        public Waardetabel Reden { get; set; }

        /// <summary>
        /// Gets or Sets InOnderzoek
        /// </summary>
        [DataMember(Name="inOnderzoek", EmitDefaultValue=false)]
        public OntbindingHuwelijkInOnderzoek InOnderzoek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OntbindingHuwelijkPartnerschap {\n");
            sb.Append("  IndicatieHuwelijkPartnerschapBeeindigd: ").Append(IndicatieHuwelijkPartnerschapBeeindigd).Append("\n");
            sb.Append("  Datum: ").Append(Datum).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
            sb.Append("  Plaats: ").Append(Plaats).Append("\n");
            sb.Append("  Reden: ").Append(Reden).Append("\n");
            sb.Append("  InOnderzoek: ").Append(InOnderzoek).Append("\n");
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
            return this.Equals(input as OntbindingHuwelijkPartnerschap);
        }

        /// <summary>
        /// Returns true if OntbindingHuwelijkPartnerschap instances are equal
        /// </summary>
        /// <param name="input">Instance of OntbindingHuwelijkPartnerschap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OntbindingHuwelijkPartnerschap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndicatieHuwelijkPartnerschapBeeindigd == input.IndicatieHuwelijkPartnerschapBeeindigd ||
                    (this.IndicatieHuwelijkPartnerschapBeeindigd != null &&
                    this.IndicatieHuwelijkPartnerschapBeeindigd.Equals(input.IndicatieHuwelijkPartnerschapBeeindigd))
                ) && 
                (
                    this.Datum == input.Datum ||
                    (this.Datum != null &&
                    this.Datum.Equals(input.Datum))
                ) && 
                (
                    this.Land == input.Land ||
                    (this.Land != null &&
                    this.Land.Equals(input.Land))
                ) && 
                (
                    this.Plaats == input.Plaats ||
                    (this.Plaats != null &&
                    this.Plaats.Equals(input.Plaats))
                ) && 
                (
                    this.Reden == input.Reden ||
                    (this.Reden != null &&
                    this.Reden.Equals(input.Reden))
                ) && 
                (
                    this.InOnderzoek == input.InOnderzoek ||
                    (this.InOnderzoek != null &&
                    this.InOnderzoek.Equals(input.InOnderzoek))
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
                if (this.IndicatieHuwelijkPartnerschapBeeindigd != null)
                    hashCode = hashCode * 59 + this.IndicatieHuwelijkPartnerschapBeeindigd.GetHashCode();
                if (this.Datum != null)
                    hashCode = hashCode * 59 + this.Datum.GetHashCode();
                if (this.Land != null)
                    hashCode = hashCode * 59 + this.Land.GetHashCode();
                if (this.Plaats != null)
                    hashCode = hashCode * 59 + this.Plaats.GetHashCode();
                if (this.Reden != null)
                    hashCode = hashCode * 59 + this.Reden.GetHashCode();
                if (this.InOnderzoek != null)
                    hashCode = hashCode * 59 + this.InOnderzoek.GetHashCode();
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