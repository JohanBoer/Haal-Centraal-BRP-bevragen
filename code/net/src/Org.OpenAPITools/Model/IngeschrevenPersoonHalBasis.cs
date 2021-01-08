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
    /// IngeschrevenPersoonHalBasis
    /// </summary>
    [DataContract]
    public partial class IngeschrevenPersoonHalBasis :  IEquatable<IngeschrevenPersoonHalBasis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IngeschrevenPersoonHalBasis" /> class.
        /// </summary>
        /// <param name="burgerservicenummer">burgerservicenummer.</param>
        /// <param name="geheimhoudingPersoonsgegevens">Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. .</param>
        /// <param name="geslachtsaanduiding">geslachtsaanduiding.</param>
        /// <param name="leeftijd">Leeftijd in jaren op het moment van bevragen. .</param>
        /// <param name="datumEersteInschrijvingGBA">datumEersteInschrijvingGBA.</param>
        /// <param name="kiesrecht">kiesrecht.</param>
        /// <param name="naam">naam.</param>
        /// <param name="inOnderzoek">inOnderzoek.</param>
        /// <param name="nationaliteiten">nationaliteiten.</param>
        /// <param name="geboorte">geboorte.</param>
        /// <param name="opschortingBijhouding">opschortingBijhouding.</param>
        /// <param name="overlijden">overlijden.</param>
        /// <param name="verblijfplaats">verblijfplaats.</param>
        /// <param name="gezagsverhouding">gezagsverhouding.</param>
        /// <param name="verblijfstitel">verblijfstitel.</param>
        /// <param name="reisdocumentnummers">reisdocumentnummers.</param>
        /// <param name="links">links.</param>
        public IngeschrevenPersoonHalBasis(string burgerservicenummer = default(string), bool geheimhoudingPersoonsgegevens = default(bool), GeslachtEnum geslachtsaanduiding = default(GeslachtEnum), int leeftijd = default(int), DatumOnvolledig datumEersteInschrijvingGBA = default(DatumOnvolledig), Kiesrecht kiesrecht = default(Kiesrecht), NaamPersoon naam = default(NaamPersoon), PersoonInOnderzoek inOnderzoek = default(PersoonInOnderzoek), List<Nationaliteit> nationaliteiten = default(List<Nationaliteit>), Geboorte geboorte = default(Geboorte), OpschortingBijhouding opschortingBijhouding = default(OpschortingBijhouding), Overlijden overlijden = default(Overlijden), Verblijfplaats verblijfplaats = default(Verblijfplaats), Gezagsverhouding gezagsverhouding = default(Gezagsverhouding), Verblijfstitel verblijfstitel = default(Verblijfstitel), List<string> reisdocumentnummers = default(List<string>), IngeschrevenPersoonLinks links = default(IngeschrevenPersoonLinks))
        {
            this.Burgerservicenummer = burgerservicenummer;
            this.GeheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
            this.Geslachtsaanduiding = geslachtsaanduiding;
            this.Leeftijd = leeftijd;
            this.DatumEersteInschrijvingGBA = datumEersteInschrijvingGBA;
            this.Kiesrecht = kiesrecht;
            this.Naam = naam;
            this.InOnderzoek = inOnderzoek;
            this.Nationaliteiten = nationaliteiten;
            this.Geboorte = geboorte;
            this.OpschortingBijhouding = opschortingBijhouding;
            this.Overlijden = overlijden;
            this.Verblijfplaats = verblijfplaats;
            this.Gezagsverhouding = gezagsverhouding;
            this.Verblijfstitel = verblijfstitel;
            this.Reisdocumentnummers = reisdocumentnummers;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Burgerservicenummer
        /// </summary>
        [DataMember(Name="burgerservicenummer", EmitDefaultValue=false)]
        public string Burgerservicenummer { get; set; }

        /// <summary>
        /// Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. 
        /// </summary>
        /// <value>Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. </value>
        [DataMember(Name="geheimhoudingPersoonsgegevens", EmitDefaultValue=false)]
        public bool GeheimhoudingPersoonsgegevens { get; set; }

        /// <summary>
        /// Gets or Sets Geslachtsaanduiding
        /// </summary>
        [DataMember(Name="geslachtsaanduiding", EmitDefaultValue=false)]
        public GeslachtEnum Geslachtsaanduiding { get; set; }

        /// <summary>
        /// Leeftijd in jaren op het moment van bevragen. 
        /// </summary>
        /// <value>Leeftijd in jaren op het moment van bevragen. </value>
        [DataMember(Name="leeftijd", EmitDefaultValue=false)]
        public int Leeftijd { get; set; }

        /// <summary>
        /// Gets or Sets DatumEersteInschrijvingGBA
        /// </summary>
        [DataMember(Name="datumEersteInschrijvingGBA", EmitDefaultValue=false)]
        public DatumOnvolledig DatumEersteInschrijvingGBA { get; set; }

        /// <summary>
        /// Gets or Sets Kiesrecht
        /// </summary>
        [DataMember(Name="kiesrecht", EmitDefaultValue=false)]
        public Kiesrecht Kiesrecht { get; set; }

        /// <summary>
        /// Gets or Sets Naam
        /// </summary>
        [DataMember(Name="naam", EmitDefaultValue=false)]
        public NaamPersoon Naam { get; set; }

        /// <summary>
        /// Gets or Sets InOnderzoek
        /// </summary>
        [DataMember(Name="inOnderzoek", EmitDefaultValue=false)]
        public PersoonInOnderzoek InOnderzoek { get; set; }

        /// <summary>
        /// Gets or Sets Nationaliteiten
        /// </summary>
        [DataMember(Name="nationaliteiten", EmitDefaultValue=false)]
        public List<Nationaliteit> Nationaliteiten { get; set; }

        /// <summary>
        /// Gets or Sets Geboorte
        /// </summary>
        [DataMember(Name="geboorte", EmitDefaultValue=false)]
        public Geboorte Geboorte { get; set; }

        /// <summary>
        /// Gets or Sets OpschortingBijhouding
        /// </summary>
        [DataMember(Name="opschortingBijhouding", EmitDefaultValue=false)]
        public OpschortingBijhouding OpschortingBijhouding { get; set; }

        /// <summary>
        /// Gets or Sets Overlijden
        /// </summary>
        [DataMember(Name="overlijden", EmitDefaultValue=false)]
        public Overlijden Overlijden { get; set; }

        /// <summary>
        /// Gets or Sets Verblijfplaats
        /// </summary>
        [DataMember(Name="verblijfplaats", EmitDefaultValue=false)]
        public Verblijfplaats Verblijfplaats { get; set; }

        /// <summary>
        /// Gets or Sets Gezagsverhouding
        /// </summary>
        [DataMember(Name="gezagsverhouding", EmitDefaultValue=false)]
        public Gezagsverhouding Gezagsverhouding { get; set; }

        /// <summary>
        /// Gets or Sets Verblijfstitel
        /// </summary>
        [DataMember(Name="verblijfstitel", EmitDefaultValue=false)]
        public Verblijfstitel Verblijfstitel { get; set; }

        /// <summary>
        /// Gets or Sets Reisdocumentnummers
        /// </summary>
        [DataMember(Name="reisdocumentnummers", EmitDefaultValue=false)]
        public List<string> Reisdocumentnummers { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public IngeschrevenPersoonLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IngeschrevenPersoonHalBasis {\n");
            sb.Append("  Burgerservicenummer: ").Append(Burgerservicenummer).Append("\n");
            sb.Append("  GeheimhoudingPersoonsgegevens: ").Append(GeheimhoudingPersoonsgegevens).Append("\n");
            sb.Append("  Geslachtsaanduiding: ").Append(Geslachtsaanduiding).Append("\n");
            sb.Append("  Leeftijd: ").Append(Leeftijd).Append("\n");
            sb.Append("  DatumEersteInschrijvingGBA: ").Append(DatumEersteInschrijvingGBA).Append("\n");
            sb.Append("  Kiesrecht: ").Append(Kiesrecht).Append("\n");
            sb.Append("  Naam: ").Append(Naam).Append("\n");
            sb.Append("  InOnderzoek: ").Append(InOnderzoek).Append("\n");
            sb.Append("  Nationaliteiten: ").Append(Nationaliteiten).Append("\n");
            sb.Append("  Geboorte: ").Append(Geboorte).Append("\n");
            sb.Append("  OpschortingBijhouding: ").Append(OpschortingBijhouding).Append("\n");
            sb.Append("  Overlijden: ").Append(Overlijden).Append("\n");
            sb.Append("  Verblijfplaats: ").Append(Verblijfplaats).Append("\n");
            sb.Append("  Gezagsverhouding: ").Append(Gezagsverhouding).Append("\n");
            sb.Append("  Verblijfstitel: ").Append(Verblijfstitel).Append("\n");
            sb.Append("  Reisdocumentnummers: ").Append(Reisdocumentnummers).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as IngeschrevenPersoonHalBasis);
        }

        /// <summary>
        /// Returns true if IngeschrevenPersoonHalBasis instances are equal
        /// </summary>
        /// <param name="input">Instance of IngeschrevenPersoonHalBasis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngeschrevenPersoonHalBasis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Burgerservicenummer == input.Burgerservicenummer ||
                    (this.Burgerservicenummer != null &&
                    this.Burgerservicenummer.Equals(input.Burgerservicenummer))
                ) && 
                (
                    this.GeheimhoudingPersoonsgegevens == input.GeheimhoudingPersoonsgegevens ||
                    (this.GeheimhoudingPersoonsgegevens != null &&
                    this.GeheimhoudingPersoonsgegevens.Equals(input.GeheimhoudingPersoonsgegevens))
                ) && 
                (
                    this.Geslachtsaanduiding == input.Geslachtsaanduiding ||
                    (this.Geslachtsaanduiding != null &&
                    this.Geslachtsaanduiding.Equals(input.Geslachtsaanduiding))
                ) && 
                (
                    this.Leeftijd == input.Leeftijd ||
                    (this.Leeftijd != null &&
                    this.Leeftijd.Equals(input.Leeftijd))
                ) && 
                (
                    this.DatumEersteInschrijvingGBA == input.DatumEersteInschrijvingGBA ||
                    (this.DatumEersteInschrijvingGBA != null &&
                    this.DatumEersteInschrijvingGBA.Equals(input.DatumEersteInschrijvingGBA))
                ) && 
                (
                    this.Kiesrecht == input.Kiesrecht ||
                    (this.Kiesrecht != null &&
                    this.Kiesrecht.Equals(input.Kiesrecht))
                ) && 
                (
                    this.Naam == input.Naam ||
                    (this.Naam != null &&
                    this.Naam.Equals(input.Naam))
                ) && 
                (
                    this.InOnderzoek == input.InOnderzoek ||
                    (this.InOnderzoek != null &&
                    this.InOnderzoek.Equals(input.InOnderzoek))
                ) && 
                (
                    this.Nationaliteiten == input.Nationaliteiten ||
                    this.Nationaliteiten != null &&
                    input.Nationaliteiten != null &&
                    this.Nationaliteiten.SequenceEqual(input.Nationaliteiten)
                ) && 
                (
                    this.Geboorte == input.Geboorte ||
                    (this.Geboorte != null &&
                    this.Geboorte.Equals(input.Geboorte))
                ) && 
                (
                    this.OpschortingBijhouding == input.OpschortingBijhouding ||
                    (this.OpschortingBijhouding != null &&
                    this.OpschortingBijhouding.Equals(input.OpschortingBijhouding))
                ) && 
                (
                    this.Overlijden == input.Overlijden ||
                    (this.Overlijden != null &&
                    this.Overlijden.Equals(input.Overlijden))
                ) && 
                (
                    this.Verblijfplaats == input.Verblijfplaats ||
                    (this.Verblijfplaats != null &&
                    this.Verblijfplaats.Equals(input.Verblijfplaats))
                ) && 
                (
                    this.Gezagsverhouding == input.Gezagsverhouding ||
                    (this.Gezagsverhouding != null &&
                    this.Gezagsverhouding.Equals(input.Gezagsverhouding))
                ) && 
                (
                    this.Verblijfstitel == input.Verblijfstitel ||
                    (this.Verblijfstitel != null &&
                    this.Verblijfstitel.Equals(input.Verblijfstitel))
                ) && 
                (
                    this.Reisdocumentnummers == input.Reisdocumentnummers ||
                    this.Reisdocumentnummers != null &&
                    input.Reisdocumentnummers != null &&
                    this.Reisdocumentnummers.SequenceEqual(input.Reisdocumentnummers)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Burgerservicenummer != null)
                    hashCode = hashCode * 59 + this.Burgerservicenummer.GetHashCode();
                if (this.GeheimhoudingPersoonsgegevens != null)
                    hashCode = hashCode * 59 + this.GeheimhoudingPersoonsgegevens.GetHashCode();
                if (this.Geslachtsaanduiding != null)
                    hashCode = hashCode * 59 + this.Geslachtsaanduiding.GetHashCode();
                if (this.Leeftijd != null)
                    hashCode = hashCode * 59 + this.Leeftijd.GetHashCode();
                if (this.DatumEersteInschrijvingGBA != null)
                    hashCode = hashCode * 59 + this.DatumEersteInschrijvingGBA.GetHashCode();
                if (this.Kiesrecht != null)
                    hashCode = hashCode * 59 + this.Kiesrecht.GetHashCode();
                if (this.Naam != null)
                    hashCode = hashCode * 59 + this.Naam.GetHashCode();
                if (this.InOnderzoek != null)
                    hashCode = hashCode * 59 + this.InOnderzoek.GetHashCode();
                if (this.Nationaliteiten != null)
                    hashCode = hashCode * 59 + this.Nationaliteiten.GetHashCode();
                if (this.Geboorte != null)
                    hashCode = hashCode * 59 + this.Geboorte.GetHashCode();
                if (this.OpschortingBijhouding != null)
                    hashCode = hashCode * 59 + this.OpschortingBijhouding.GetHashCode();
                if (this.Overlijden != null)
                    hashCode = hashCode * 59 + this.Overlijden.GetHashCode();
                if (this.Verblijfplaats != null)
                    hashCode = hashCode * 59 + this.Verblijfplaats.GetHashCode();
                if (this.Gezagsverhouding != null)
                    hashCode = hashCode * 59 + this.Gezagsverhouding.GetHashCode();
                if (this.Verblijfstitel != null)
                    hashCode = hashCode * 59 + this.Verblijfstitel.GetHashCode();
                if (this.Reisdocumentnummers != null)
                    hashCode = hashCode * 59 + this.Reisdocumentnummers.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
