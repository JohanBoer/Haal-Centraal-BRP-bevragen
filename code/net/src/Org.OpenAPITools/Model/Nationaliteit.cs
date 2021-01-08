/* 
 * Bevragen Ingeschreven Personen
 *
 * API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// * **redenOpname** : De reden op grond waarvan de persoon de nationaliteit gekregen heeft. 
    /// </summary>
    [DataContract]
    public partial class Nationaliteit :  IEquatable<Nationaliteit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nationaliteit" /> class.
        /// </summary>
        /// <param name="aanduidingBijzonderNederlanderschap">aanduidingBijzonderNederlanderschap.</param>
        /// <param name="datumIngangGeldigheid">datumIngangGeldigheid.</param>
        /// <param name="nationaliteit">nationaliteit.</param>
        /// <param name="redenOpname">redenOpname.</param>
        /// <param name="inOnderzoek">inOnderzoek.</param>
        public Nationaliteit(AanduidingBijzonderNederlanderschapEnum aanduidingBijzonderNederlanderschap = default(AanduidingBijzonderNederlanderschapEnum), DatumOnvolledig datumIngangGeldigheid = default(DatumOnvolledig), Waardetabel nationaliteit = default(Waardetabel), Waardetabel redenOpname = default(Waardetabel), NationaliteitInOnderzoek inOnderzoek = default(NationaliteitInOnderzoek))
        {
            this.AanduidingBijzonderNederlanderschap = aanduidingBijzonderNederlanderschap;
            this.DatumIngangGeldigheid = datumIngangGeldigheid;
            this._Nationaliteit = nationaliteit;
            this.RedenOpname = redenOpname;
            this.InOnderzoek = inOnderzoek;
        }
        
        /// <summary>
        /// Gets or Sets AanduidingBijzonderNederlanderschap
        /// </summary>
        [DataMember(Name="aanduidingBijzonderNederlanderschap", EmitDefaultValue=false)]
        public AanduidingBijzonderNederlanderschapEnum AanduidingBijzonderNederlanderschap { get; set; }

        /// <summary>
        /// Gets or Sets DatumIngangGeldigheid
        /// </summary>
        [DataMember(Name="datumIngangGeldigheid", EmitDefaultValue=false)]
        public DatumOnvolledig DatumIngangGeldigheid { get; set; }

        /// <summary>
        /// Gets or Sets _Nationaliteit
        /// </summary>
        [DataMember(Name="nationaliteit", EmitDefaultValue=false)]
        public Waardetabel _Nationaliteit { get; set; }

        /// <summary>
        /// Gets or Sets RedenOpname
        /// </summary>
        [DataMember(Name="redenOpname", EmitDefaultValue=false)]
        public Waardetabel RedenOpname { get; set; }

        /// <summary>
        /// Gets or Sets InOnderzoek
        /// </summary>
        [DataMember(Name="inOnderzoek", EmitDefaultValue=false)]
        public NationaliteitInOnderzoek InOnderzoek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Nationaliteit {\n");
            sb.Append("  AanduidingBijzonderNederlanderschap: ").Append(AanduidingBijzonderNederlanderschap).Append("\n");
            sb.Append("  DatumIngangGeldigheid: ").Append(DatumIngangGeldigheid).Append("\n");
            sb.Append("  _Nationaliteit: ").Append(_Nationaliteit).Append("\n");
            sb.Append("  RedenOpname: ").Append(RedenOpname).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Nationaliteit);
        }

        /// <summary>
        /// Returns true if Nationaliteit instances are equal
        /// </summary>
        /// <param name="input">Instance of Nationaliteit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Nationaliteit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AanduidingBijzonderNederlanderschap == input.AanduidingBijzonderNederlanderschap ||
                    (this.AanduidingBijzonderNederlanderschap != null &&
                    this.AanduidingBijzonderNederlanderschap.Equals(input.AanduidingBijzonderNederlanderschap))
                ) && 
                (
                    this.DatumIngangGeldigheid == input.DatumIngangGeldigheid ||
                    (this.DatumIngangGeldigheid != null &&
                    this.DatumIngangGeldigheid.Equals(input.DatumIngangGeldigheid))
                ) && 
                (
                    this._Nationaliteit == input._Nationaliteit ||
                    (this._Nationaliteit != null &&
                    this._Nationaliteit.Equals(input._Nationaliteit))
                ) && 
                (
                    this.RedenOpname == input.RedenOpname ||
                    (this.RedenOpname != null &&
                    this.RedenOpname.Equals(input.RedenOpname))
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
                if (this.AanduidingBijzonderNederlanderschap != null)
                    hashCode = hashCode * 59 + this.AanduidingBijzonderNederlanderschap.GetHashCode();
                if (this.DatumIngangGeldigheid != null)
                    hashCode = hashCode * 59 + this.DatumIngangGeldigheid.GetHashCode();
                if (this._Nationaliteit != null)
                    hashCode = hashCode * 59 + this._Nationaliteit.GetHashCode();
                if (this.RedenOpname != null)
                    hashCode = hashCode * 59 + this.RedenOpname.GetHashCode();
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
