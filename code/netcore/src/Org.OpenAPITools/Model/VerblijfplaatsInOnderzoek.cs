/*
 * Bevragen Ingeschreven Personen
 *
 * API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 1.3.0
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
    /// Geeft aan welke gegevens over het verblijf en adres van de persoon in onderzoek zijn. Elementen van het GBA-adres zelf (Dat zou eigenlijk een BAG-adres moeten zijn) kunnen niet in onderzoek zijn. Wel de relatie naar de nummeraanduiding. Dat wordt gedaan door de identificatiecodeNummeraanduiding in onderzoek te zetten. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) 
    /// </summary>
    [DataContract(Name = "VerblijfplaatsInOnderzoek")]
    public partial class VerblijfplaatsInOnderzoek : IEquatable<VerblijfplaatsInOnderzoek>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerblijfplaatsInOnderzoek" /> class.
        /// </summary>
        /// <param name="aanduidingBijHuisnummer">aanduidingBijHuisnummer.</param>
        /// <param name="datumAanvangAdreshouding">datumAanvangAdreshouding.</param>
        /// <param name="datumIngangGeldigheid">datumIngangGeldigheid.</param>
        /// <param name="datumInschrijvingInGemeente">datumInschrijvingInGemeente.</param>
        /// <param name="datumVestigingInNederland">datumVestigingInNederland.</param>
        /// <param name="functieAdres">functieAdres.</param>
        /// <param name="gemeenteVanInschrijving">gemeenteVanInschrijving.</param>
        /// <param name="huisletter">huisletter.</param>
        /// <param name="huisnummer">huisnummer.</param>
        /// <param name="huisnummertoevoeging">huisnummertoevoeging.</param>
        /// <param name="nummeraanduidingIdentificatie">nummeraanduidingIdentificatie.</param>
        /// <param name="adresseerbaarObjectIdentificatie">adresseerbaarObjectIdentificatie.</param>
        /// <param name="landVanwaarIngeschreven">landVanwaarIngeschreven.</param>
        /// <param name="locatiebeschrijving">locatiebeschrijving.</param>
        /// <param name="straat">straat.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="korteNaam">korteNaam.</param>
        /// <param name="verblijfBuitenland">verblijfBuitenland.</param>
        /// <param name="woonplaats">woonplaats.</param>
        /// <param name="datumIngangOnderzoek">datumIngangOnderzoek.</param>
        public VerblijfplaatsInOnderzoek(bool aanduidingBijHuisnummer = default(bool), bool datumAanvangAdreshouding = default(bool), bool datumIngangGeldigheid = default(bool), bool datumInschrijvingInGemeente = default(bool), bool datumVestigingInNederland = default(bool), bool functieAdres = default(bool), bool gemeenteVanInschrijving = default(bool), bool huisletter = default(bool), bool huisnummer = default(bool), bool huisnummertoevoeging = default(bool), bool nummeraanduidingIdentificatie = default(bool), bool adresseerbaarObjectIdentificatie = default(bool), bool landVanwaarIngeschreven = default(bool), bool locatiebeschrijving = default(bool), bool straat = default(bool), bool postcode = default(bool), bool korteNaam = default(bool), bool verblijfBuitenland = default(bool), bool woonplaats = default(bool), DatumOnvolledig datumIngangOnderzoek = default(DatumOnvolledig))
        {
            this.AanduidingBijHuisnummer = aanduidingBijHuisnummer;
            this.DatumAanvangAdreshouding = datumAanvangAdreshouding;
            this.DatumIngangGeldigheid = datumIngangGeldigheid;
            this.DatumInschrijvingInGemeente = datumInschrijvingInGemeente;
            this.DatumVestigingInNederland = datumVestigingInNederland;
            this.FunctieAdres = functieAdres;
            this.GemeenteVanInschrijving = gemeenteVanInschrijving;
            this.Huisletter = huisletter;
            this.Huisnummer = huisnummer;
            this.Huisnummertoevoeging = huisnummertoevoeging;
            this.NummeraanduidingIdentificatie = nummeraanduidingIdentificatie;
            this.AdresseerbaarObjectIdentificatie = adresseerbaarObjectIdentificatie;
            this.LandVanwaarIngeschreven = landVanwaarIngeschreven;
            this.Locatiebeschrijving = locatiebeschrijving;
            this.Straat = straat;
            this.Postcode = postcode;
            this.KorteNaam = korteNaam;
            this.VerblijfBuitenland = verblijfBuitenland;
            this.Woonplaats = woonplaats;
            this.DatumIngangOnderzoek = datumIngangOnderzoek;
        }

        /// <summary>
        /// Gets or Sets AanduidingBijHuisnummer
        /// </summary>
        [DataMember(Name = "aanduidingBijHuisnummer", EmitDefaultValue = false)]
        public bool AanduidingBijHuisnummer { get; set; }

        /// <summary>
        /// Gets or Sets DatumAanvangAdreshouding
        /// </summary>
        [DataMember(Name = "datumAanvangAdreshouding", EmitDefaultValue = false)]
        public bool DatumAanvangAdreshouding { get; set; }

        /// <summary>
        /// Gets or Sets DatumIngangGeldigheid
        /// </summary>
        [DataMember(Name = "datumIngangGeldigheid", EmitDefaultValue = false)]
        public bool DatumIngangGeldigheid { get; set; }

        /// <summary>
        /// Gets or Sets DatumInschrijvingInGemeente
        /// </summary>
        [DataMember(Name = "datumInschrijvingInGemeente", EmitDefaultValue = false)]
        public bool DatumInschrijvingInGemeente { get; set; }

        /// <summary>
        /// Gets or Sets DatumVestigingInNederland
        /// </summary>
        [DataMember(Name = "datumVestigingInNederland", EmitDefaultValue = false)]
        public bool DatumVestigingInNederland { get; set; }

        /// <summary>
        /// Gets or Sets FunctieAdres
        /// </summary>
        [DataMember(Name = "functieAdres", EmitDefaultValue = false)]
        public bool FunctieAdres { get; set; }

        /// <summary>
        /// Gets or Sets GemeenteVanInschrijving
        /// </summary>
        [DataMember(Name = "gemeenteVanInschrijving", EmitDefaultValue = false)]
        public bool GemeenteVanInschrijving { get; set; }

        /// <summary>
        /// Gets or Sets Huisletter
        /// </summary>
        [DataMember(Name = "huisletter", EmitDefaultValue = false)]
        public bool Huisletter { get; set; }

        /// <summary>
        /// Gets or Sets Huisnummer
        /// </summary>
        [DataMember(Name = "huisnummer", EmitDefaultValue = false)]
        public bool Huisnummer { get; set; }

        /// <summary>
        /// Gets or Sets Huisnummertoevoeging
        /// </summary>
        [DataMember(Name = "huisnummertoevoeging", EmitDefaultValue = false)]
        public bool Huisnummertoevoeging { get; set; }

        /// <summary>
        /// Gets or Sets NummeraanduidingIdentificatie
        /// </summary>
        [DataMember(Name = "nummeraanduidingIdentificatie", EmitDefaultValue = false)]
        public bool NummeraanduidingIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets AdresseerbaarObjectIdentificatie
        /// </summary>
        [DataMember(Name = "adresseerbaarObjectIdentificatie", EmitDefaultValue = false)]
        public bool AdresseerbaarObjectIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets LandVanwaarIngeschreven
        /// </summary>
        [DataMember(Name = "landVanwaarIngeschreven", EmitDefaultValue = false)]
        public bool LandVanwaarIngeschreven { get; set; }

        /// <summary>
        /// Gets or Sets Locatiebeschrijving
        /// </summary>
        [DataMember(Name = "locatiebeschrijving", EmitDefaultValue = false)]
        public bool Locatiebeschrijving { get; set; }

        /// <summary>
        /// Gets or Sets Straat
        /// </summary>
        [DataMember(Name = "straat", EmitDefaultValue = false)]
        public bool Straat { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public bool Postcode { get; set; }

        /// <summary>
        /// Gets or Sets KorteNaam
        /// </summary>
        [DataMember(Name = "korteNaam", EmitDefaultValue = false)]
        public bool KorteNaam { get; set; }

        /// <summary>
        /// Gets or Sets VerblijfBuitenland
        /// </summary>
        [DataMember(Name = "verblijfBuitenland", EmitDefaultValue = false)]
        public bool VerblijfBuitenland { get; set; }

        /// <summary>
        /// Gets or Sets Woonplaats
        /// </summary>
        [DataMember(Name = "woonplaats", EmitDefaultValue = false)]
        public bool Woonplaats { get; set; }

        /// <summary>
        /// Gets or Sets DatumIngangOnderzoek
        /// </summary>
        [DataMember(Name = "datumIngangOnderzoek", EmitDefaultValue = false)]
        public DatumOnvolledig DatumIngangOnderzoek { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerblijfplaatsInOnderzoek {\n");
            sb.Append("  AanduidingBijHuisnummer: ").Append(AanduidingBijHuisnummer).Append("\n");
            sb.Append("  DatumAanvangAdreshouding: ").Append(DatumAanvangAdreshouding).Append("\n");
            sb.Append("  DatumIngangGeldigheid: ").Append(DatumIngangGeldigheid).Append("\n");
            sb.Append("  DatumInschrijvingInGemeente: ").Append(DatumInschrijvingInGemeente).Append("\n");
            sb.Append("  DatumVestigingInNederland: ").Append(DatumVestigingInNederland).Append("\n");
            sb.Append("  FunctieAdres: ").Append(FunctieAdres).Append("\n");
            sb.Append("  GemeenteVanInschrijving: ").Append(GemeenteVanInschrijving).Append("\n");
            sb.Append("  Huisletter: ").Append(Huisletter).Append("\n");
            sb.Append("  Huisnummer: ").Append(Huisnummer).Append("\n");
            sb.Append("  Huisnummertoevoeging: ").Append(Huisnummertoevoeging).Append("\n");
            sb.Append("  NummeraanduidingIdentificatie: ").Append(NummeraanduidingIdentificatie).Append("\n");
            sb.Append("  AdresseerbaarObjectIdentificatie: ").Append(AdresseerbaarObjectIdentificatie).Append("\n");
            sb.Append("  LandVanwaarIngeschreven: ").Append(LandVanwaarIngeschreven).Append("\n");
            sb.Append("  Locatiebeschrijving: ").Append(Locatiebeschrijving).Append("\n");
            sb.Append("  Straat: ").Append(Straat).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  KorteNaam: ").Append(KorteNaam).Append("\n");
            sb.Append("  VerblijfBuitenland: ").Append(VerblijfBuitenland).Append("\n");
            sb.Append("  Woonplaats: ").Append(Woonplaats).Append("\n");
            sb.Append("  DatumIngangOnderzoek: ").Append(DatumIngangOnderzoek).Append("\n");
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
            return this.Equals(input as VerblijfplaatsInOnderzoek);
        }

        /// <summary>
        /// Returns true if VerblijfplaatsInOnderzoek instances are equal
        /// </summary>
        /// <param name="input">Instance of VerblijfplaatsInOnderzoek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerblijfplaatsInOnderzoek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AanduidingBijHuisnummer == input.AanduidingBijHuisnummer ||
                    this.AanduidingBijHuisnummer.Equals(input.AanduidingBijHuisnummer)
                ) && 
                (
                    this.DatumAanvangAdreshouding == input.DatumAanvangAdreshouding ||
                    this.DatumAanvangAdreshouding.Equals(input.DatumAanvangAdreshouding)
                ) && 
                (
                    this.DatumIngangGeldigheid == input.DatumIngangGeldigheid ||
                    this.DatumIngangGeldigheid.Equals(input.DatumIngangGeldigheid)
                ) && 
                (
                    this.DatumInschrijvingInGemeente == input.DatumInschrijvingInGemeente ||
                    this.DatumInschrijvingInGemeente.Equals(input.DatumInschrijvingInGemeente)
                ) && 
                (
                    this.DatumVestigingInNederland == input.DatumVestigingInNederland ||
                    this.DatumVestigingInNederland.Equals(input.DatumVestigingInNederland)
                ) && 
                (
                    this.FunctieAdres == input.FunctieAdres ||
                    this.FunctieAdres.Equals(input.FunctieAdres)
                ) && 
                (
                    this.GemeenteVanInschrijving == input.GemeenteVanInschrijving ||
                    this.GemeenteVanInschrijving.Equals(input.GemeenteVanInschrijving)
                ) && 
                (
                    this.Huisletter == input.Huisletter ||
                    this.Huisletter.Equals(input.Huisletter)
                ) && 
                (
                    this.Huisnummer == input.Huisnummer ||
                    this.Huisnummer.Equals(input.Huisnummer)
                ) && 
                (
                    this.Huisnummertoevoeging == input.Huisnummertoevoeging ||
                    this.Huisnummertoevoeging.Equals(input.Huisnummertoevoeging)
                ) && 
                (
                    this.NummeraanduidingIdentificatie == input.NummeraanduidingIdentificatie ||
                    this.NummeraanduidingIdentificatie.Equals(input.NummeraanduidingIdentificatie)
                ) && 
                (
                    this.AdresseerbaarObjectIdentificatie == input.AdresseerbaarObjectIdentificatie ||
                    this.AdresseerbaarObjectIdentificatie.Equals(input.AdresseerbaarObjectIdentificatie)
                ) && 
                (
                    this.LandVanwaarIngeschreven == input.LandVanwaarIngeschreven ||
                    this.LandVanwaarIngeschreven.Equals(input.LandVanwaarIngeschreven)
                ) && 
                (
                    this.Locatiebeschrijving == input.Locatiebeschrijving ||
                    this.Locatiebeschrijving.Equals(input.Locatiebeschrijving)
                ) && 
                (
                    this.Straat == input.Straat ||
                    this.Straat.Equals(input.Straat)
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    this.Postcode.Equals(input.Postcode)
                ) && 
                (
                    this.KorteNaam == input.KorteNaam ||
                    this.KorteNaam.Equals(input.KorteNaam)
                ) && 
                (
                    this.VerblijfBuitenland == input.VerblijfBuitenland ||
                    this.VerblijfBuitenland.Equals(input.VerblijfBuitenland)
                ) && 
                (
                    this.Woonplaats == input.Woonplaats ||
                    this.Woonplaats.Equals(input.Woonplaats)
                ) && 
                (
                    this.DatumIngangOnderzoek == input.DatumIngangOnderzoek ||
                    (this.DatumIngangOnderzoek != null &&
                    this.DatumIngangOnderzoek.Equals(input.DatumIngangOnderzoek))
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
                hashCode = hashCode * 59 + this.AanduidingBijHuisnummer.GetHashCode();
                hashCode = hashCode * 59 + this.DatumAanvangAdreshouding.GetHashCode();
                hashCode = hashCode * 59 + this.DatumIngangGeldigheid.GetHashCode();
                hashCode = hashCode * 59 + this.DatumInschrijvingInGemeente.GetHashCode();
                hashCode = hashCode * 59 + this.DatumVestigingInNederland.GetHashCode();
                hashCode = hashCode * 59 + this.FunctieAdres.GetHashCode();
                hashCode = hashCode * 59 + this.GemeenteVanInschrijving.GetHashCode();
                hashCode = hashCode * 59 + this.Huisletter.GetHashCode();
                hashCode = hashCode * 59 + this.Huisnummer.GetHashCode();
                hashCode = hashCode * 59 + this.Huisnummertoevoeging.GetHashCode();
                hashCode = hashCode * 59 + this.NummeraanduidingIdentificatie.GetHashCode();
                hashCode = hashCode * 59 + this.AdresseerbaarObjectIdentificatie.GetHashCode();
                hashCode = hashCode * 59 + this.LandVanwaarIngeschreven.GetHashCode();
                hashCode = hashCode * 59 + this.Locatiebeschrijving.GetHashCode();
                hashCode = hashCode * 59 + this.Straat.GetHashCode();
                hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                hashCode = hashCode * 59 + this.KorteNaam.GetHashCode();
                hashCode = hashCode * 59 + this.VerblijfBuitenland.GetHashCode();
                hashCode = hashCode * 59 + this.Woonplaats.GetHashCode();
                if (this.DatumIngangOnderzoek != null)
                    hashCode = hashCode * 59 + this.DatumIngangOnderzoek.GetHashCode();
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
