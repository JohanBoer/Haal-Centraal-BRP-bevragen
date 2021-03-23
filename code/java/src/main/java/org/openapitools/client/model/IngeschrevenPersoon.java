/*
 * Bevragen Ingeschreven Personen
 * API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 1.3.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.DatumOnvolledig;
import org.openapitools.client.model.Geboorte;
import org.openapitools.client.model.GeslachtEnum;
import org.openapitools.client.model.Gezagsverhouding;
import org.openapitools.client.model.Kiesrecht;
import org.openapitools.client.model.NaamPersoon;
import org.openapitools.client.model.Nationaliteit;
import org.openapitools.client.model.OpschortingBijhouding;
import org.openapitools.client.model.Overlijden;
import org.openapitools.client.model.PersoonInOnderzoek;
import org.openapitools.client.model.Verblijfplaats;
import org.openapitools.client.model.Verblijfstitel;

/**
 * IngeschrevenPersoon
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-03-02T09:47:37.422Z[Etc/UTC]")
public class IngeschrevenPersoon {
  public static final String SERIALIZED_NAME_BURGERSERVICENUMMER = "burgerservicenummer";
  @SerializedName(SERIALIZED_NAME_BURGERSERVICENUMMER)
  private String burgerservicenummer;

  public static final String SERIALIZED_NAME_A_NUMMER = "aNummer";
  @SerializedName(SERIALIZED_NAME_A_NUMMER)
  private String aNummer;

  public static final String SERIALIZED_NAME_GEHEIMHOUDING_PERSOONSGEGEVENS = "geheimhoudingPersoonsgegevens";
  @SerializedName(SERIALIZED_NAME_GEHEIMHOUDING_PERSOONSGEGEVENS)
  private Boolean geheimhoudingPersoonsgegevens;

  public static final String SERIALIZED_NAME_GESLACHTSAANDUIDING = "geslachtsaanduiding";
  @SerializedName(SERIALIZED_NAME_GESLACHTSAANDUIDING)
  private GeslachtEnum geslachtsaanduiding;

  public static final String SERIALIZED_NAME_LEEFTIJD = "leeftijd";
  @SerializedName(SERIALIZED_NAME_LEEFTIJD)
  private Integer leeftijd;

  public static final String SERIALIZED_NAME_DATUM_EERSTE_INSCHRIJVING_G_B_A = "datumEersteInschrijvingGBA";
  @SerializedName(SERIALIZED_NAME_DATUM_EERSTE_INSCHRIJVING_G_B_A)
  private DatumOnvolledig datumEersteInschrijvingGBA;

  public static final String SERIALIZED_NAME_KIESRECHT = "kiesrecht";
  @SerializedName(SERIALIZED_NAME_KIESRECHT)
  private Kiesrecht kiesrecht;

  public static final String SERIALIZED_NAME_NAAM = "naam";
  @SerializedName(SERIALIZED_NAME_NAAM)
  private NaamPersoon naam = null;

  public static final String SERIALIZED_NAME_IN_ONDERZOEK = "inOnderzoek";
  @SerializedName(SERIALIZED_NAME_IN_ONDERZOEK)
  private PersoonInOnderzoek inOnderzoek;

  public static final String SERIALIZED_NAME_NATIONALITEITEN = "nationaliteiten";
  @SerializedName(SERIALIZED_NAME_NATIONALITEITEN)
  private List<Nationaliteit> nationaliteiten = null;

  public static final String SERIALIZED_NAME_GEBOORTE = "geboorte";
  @SerializedName(SERIALIZED_NAME_GEBOORTE)
  private Geboorte geboorte = null;

  public static final String SERIALIZED_NAME_OPSCHORTING_BIJHOUDING = "opschortingBijhouding";
  @SerializedName(SERIALIZED_NAME_OPSCHORTING_BIJHOUDING)
  private OpschortingBijhouding opschortingBijhouding;

  public static final String SERIALIZED_NAME_OVERLIJDEN = "overlijden";
  @SerializedName(SERIALIZED_NAME_OVERLIJDEN)
  private Overlijden overlijden;

  public static final String SERIALIZED_NAME_VERBLIJFPLAATS = "verblijfplaats";
  @SerializedName(SERIALIZED_NAME_VERBLIJFPLAATS)
  private Verblijfplaats verblijfplaats = null;

  public static final String SERIALIZED_NAME_GEZAGSVERHOUDING = "gezagsverhouding";
  @SerializedName(SERIALIZED_NAME_GEZAGSVERHOUDING)
  private Gezagsverhouding gezagsverhouding;

  public static final String SERIALIZED_NAME_VERBLIJFSTITEL = "verblijfstitel";
  @SerializedName(SERIALIZED_NAME_VERBLIJFSTITEL)
  private Verblijfstitel verblijfstitel;

  public static final String SERIALIZED_NAME_REISDOCUMENTNUMMERS = "reisdocumentnummers";
  @SerializedName(SERIALIZED_NAME_REISDOCUMENTNUMMERS)
  private List<String> reisdocumentnummers = null;


  public IngeschrevenPersoon burgerservicenummer(String burgerservicenummer) {
    
    this.burgerservicenummer = burgerservicenummer;
    return this;
  }

   /**
   * Get burgerservicenummer
   * @return burgerservicenummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "555555021", value = "")

  public String getBurgerservicenummer() {
    return burgerservicenummer;
  }


  public void setBurgerservicenummer(String burgerservicenummer) {
    this.burgerservicenummer = burgerservicenummer;
  }


  public IngeschrevenPersoon aNummer(String aNummer) {
    
    this.aNummer = aNummer;
    return this;
  }

   /**
   * Het A-nummer van de persoon 
   * @return aNummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Het A-nummer van de persoon ")

  public String getaNummer() {
    return aNummer;
  }


  public void setaNummer(String aNummer) {
    this.aNummer = aNummer;
  }


  public IngeschrevenPersoon geheimhoudingPersoonsgegevens(Boolean geheimhoudingPersoonsgegevens) {
    
    this.geheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
    return this;
  }

   /**
   * Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. 
   * @return geheimhoudingPersoonsgegevens
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Gegevens mogen niet worden verstrekt aan derden / maatschappelijke instellingen. ")

  public Boolean getGeheimhoudingPersoonsgegevens() {
    return geheimhoudingPersoonsgegevens;
  }


  public void setGeheimhoudingPersoonsgegevens(Boolean geheimhoudingPersoonsgegevens) {
    this.geheimhoudingPersoonsgegevens = geheimhoudingPersoonsgegevens;
  }


  public IngeschrevenPersoon geslachtsaanduiding(GeslachtEnum geslachtsaanduiding) {
    
    this.geslachtsaanduiding = geslachtsaanduiding;
    return this;
  }

   /**
   * Get geslachtsaanduiding
   * @return geslachtsaanduiding
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public GeslachtEnum getGeslachtsaanduiding() {
    return geslachtsaanduiding;
  }


  public void setGeslachtsaanduiding(GeslachtEnum geslachtsaanduiding) {
    this.geslachtsaanduiding = geslachtsaanduiding;
  }


  public IngeschrevenPersoon leeftijd(Integer leeftijd) {
    
    this.leeftijd = leeftijd;
    return this;
  }

   /**
   * Leeftijd in jaren op het moment van bevragen. 
   * @return leeftijd
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "34", value = "Leeftijd in jaren op het moment van bevragen. ")

  public Integer getLeeftijd() {
    return leeftijd;
  }


  public void setLeeftijd(Integer leeftijd) {
    this.leeftijd = leeftijd;
  }


  public IngeschrevenPersoon datumEersteInschrijvingGBA(DatumOnvolledig datumEersteInschrijvingGBA) {
    
    this.datumEersteInschrijvingGBA = datumEersteInschrijvingGBA;
    return this;
  }

   /**
   * Get datumEersteInschrijvingGBA
   * @return datumEersteInschrijvingGBA
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public DatumOnvolledig getDatumEersteInschrijvingGBA() {
    return datumEersteInschrijvingGBA;
  }


  public void setDatumEersteInschrijvingGBA(DatumOnvolledig datumEersteInschrijvingGBA) {
    this.datumEersteInschrijvingGBA = datumEersteInschrijvingGBA;
  }


  public IngeschrevenPersoon kiesrecht(Kiesrecht kiesrecht) {
    
    this.kiesrecht = kiesrecht;
    return this;
  }

   /**
   * Get kiesrecht
   * @return kiesrecht
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Kiesrecht getKiesrecht() {
    return kiesrecht;
  }


  public void setKiesrecht(Kiesrecht kiesrecht) {
    this.kiesrecht = kiesrecht;
  }


  public IngeschrevenPersoon naam(NaamPersoon naam) {
    
    this.naam = naam;
    return this;
  }

   /**
   * Get naam
   * @return naam
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public NaamPersoon getNaam() {
    return naam;
  }


  public void setNaam(NaamPersoon naam) {
    this.naam = naam;
  }


  public IngeschrevenPersoon inOnderzoek(PersoonInOnderzoek inOnderzoek) {
    
    this.inOnderzoek = inOnderzoek;
    return this;
  }

   /**
   * Get inOnderzoek
   * @return inOnderzoek
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public PersoonInOnderzoek getInOnderzoek() {
    return inOnderzoek;
  }


  public void setInOnderzoek(PersoonInOnderzoek inOnderzoek) {
    this.inOnderzoek = inOnderzoek;
  }


  public IngeschrevenPersoon nationaliteiten(List<Nationaliteit> nationaliteiten) {
    
    this.nationaliteiten = nationaliteiten;
    return this;
  }

  public IngeschrevenPersoon addNationaliteitenItem(Nationaliteit nationaliteitenItem) {
    if (this.nationaliteiten == null) {
      this.nationaliteiten = new ArrayList<>();
    }
    this.nationaliteiten.add(nationaliteitenItem);
    return this;
  }

   /**
   * Get nationaliteiten
   * @return nationaliteiten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<Nationaliteit> getNationaliteiten() {
    return nationaliteiten;
  }


  public void setNationaliteiten(List<Nationaliteit> nationaliteiten) {
    this.nationaliteiten = nationaliteiten;
  }


  public IngeschrevenPersoon geboorte(Geboorte geboorte) {
    
    this.geboorte = geboorte;
    return this;
  }

   /**
   * Get geboorte
   * @return geboorte
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Geboorte getGeboorte() {
    return geboorte;
  }


  public void setGeboorte(Geboorte geboorte) {
    this.geboorte = geboorte;
  }


  public IngeschrevenPersoon opschortingBijhouding(OpschortingBijhouding opschortingBijhouding) {
    
    this.opschortingBijhouding = opschortingBijhouding;
    return this;
  }

   /**
   * Get opschortingBijhouding
   * @return opschortingBijhouding
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OpschortingBijhouding getOpschortingBijhouding() {
    return opschortingBijhouding;
  }


  public void setOpschortingBijhouding(OpschortingBijhouding opschortingBijhouding) {
    this.opschortingBijhouding = opschortingBijhouding;
  }


  public IngeschrevenPersoon overlijden(Overlijden overlijden) {
    
    this.overlijden = overlijden;
    return this;
  }

   /**
   * Get overlijden
   * @return overlijden
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Overlijden getOverlijden() {
    return overlijden;
  }


  public void setOverlijden(Overlijden overlijden) {
    this.overlijden = overlijden;
  }


  public IngeschrevenPersoon verblijfplaats(Verblijfplaats verblijfplaats) {
    
    this.verblijfplaats = verblijfplaats;
    return this;
  }

   /**
   * Get verblijfplaats
   * @return verblijfplaats
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Verblijfplaats getVerblijfplaats() {
    return verblijfplaats;
  }


  public void setVerblijfplaats(Verblijfplaats verblijfplaats) {
    this.verblijfplaats = verblijfplaats;
  }


  public IngeschrevenPersoon gezagsverhouding(Gezagsverhouding gezagsverhouding) {
    
    this.gezagsverhouding = gezagsverhouding;
    return this;
  }

   /**
   * Get gezagsverhouding
   * @return gezagsverhouding
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Gezagsverhouding getGezagsverhouding() {
    return gezagsverhouding;
  }


  public void setGezagsverhouding(Gezagsverhouding gezagsverhouding) {
    this.gezagsverhouding = gezagsverhouding;
  }


  public IngeschrevenPersoon verblijfstitel(Verblijfstitel verblijfstitel) {
    
    this.verblijfstitel = verblijfstitel;
    return this;
  }

   /**
   * Get verblijfstitel
   * @return verblijfstitel
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Verblijfstitel getVerblijfstitel() {
    return verblijfstitel;
  }


  public void setVerblijfstitel(Verblijfstitel verblijfstitel) {
    this.verblijfstitel = verblijfstitel;
  }


  public IngeschrevenPersoon reisdocumentnummers(List<String> reisdocumentnummers) {
    
    this.reisdocumentnummers = reisdocumentnummers;
    return this;
  }

  public IngeschrevenPersoon addReisdocumentnummersItem(String reisdocumentnummersItem) {
    if (this.reisdocumentnummers == null) {
      this.reisdocumentnummers = new ArrayList<>();
    }
    this.reisdocumentnummers.add(reisdocumentnummersItem);
    return this;
  }

   /**
   * Get reisdocumentnummers
   * @return reisdocumentnummers
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getReisdocumentnummers() {
    return reisdocumentnummers;
  }


  public void setReisdocumentnummers(List<String> reisdocumentnummers) {
    this.reisdocumentnummers = reisdocumentnummers;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    IngeschrevenPersoon ingeschrevenPersoon = (IngeschrevenPersoon) o;
    return Objects.equals(this.burgerservicenummer, ingeschrevenPersoon.burgerservicenummer) &&
        Objects.equals(this.aNummer, ingeschrevenPersoon.aNummer) &&
        Objects.equals(this.geheimhoudingPersoonsgegevens, ingeschrevenPersoon.geheimhoudingPersoonsgegevens) &&
        Objects.equals(this.geslachtsaanduiding, ingeschrevenPersoon.geslachtsaanduiding) &&
        Objects.equals(this.leeftijd, ingeschrevenPersoon.leeftijd) &&
        Objects.equals(this.datumEersteInschrijvingGBA, ingeschrevenPersoon.datumEersteInschrijvingGBA) &&
        Objects.equals(this.kiesrecht, ingeschrevenPersoon.kiesrecht) &&
        Objects.equals(this.naam, ingeschrevenPersoon.naam) &&
        Objects.equals(this.inOnderzoek, ingeschrevenPersoon.inOnderzoek) &&
        Objects.equals(this.nationaliteiten, ingeschrevenPersoon.nationaliteiten) &&
        Objects.equals(this.geboorte, ingeschrevenPersoon.geboorte) &&
        Objects.equals(this.opschortingBijhouding, ingeschrevenPersoon.opschortingBijhouding) &&
        Objects.equals(this.overlijden, ingeschrevenPersoon.overlijden) &&
        Objects.equals(this.verblijfplaats, ingeschrevenPersoon.verblijfplaats) &&
        Objects.equals(this.gezagsverhouding, ingeschrevenPersoon.gezagsverhouding) &&
        Objects.equals(this.verblijfstitel, ingeschrevenPersoon.verblijfstitel) &&
        Objects.equals(this.reisdocumentnummers, ingeschrevenPersoon.reisdocumentnummers);
  }

  @Override
  public int hashCode() {
    return Objects.hash(burgerservicenummer, aNummer, geheimhoudingPersoonsgegevens, geslachtsaanduiding, leeftijd, datumEersteInschrijvingGBA, kiesrecht, naam, inOnderzoek, nationaliteiten, geboorte, opschortingBijhouding, overlijden, verblijfplaats, gezagsverhouding, verblijfstitel, reisdocumentnummers);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class IngeschrevenPersoon {\n");
    sb.append("    burgerservicenummer: ").append(toIndentedString(burgerservicenummer)).append("\n");
    sb.append("    aNummer: ").append(toIndentedString(aNummer)).append("\n");
    sb.append("    geheimhoudingPersoonsgegevens: ").append(toIndentedString(geheimhoudingPersoonsgegevens)).append("\n");
    sb.append("    geslachtsaanduiding: ").append(toIndentedString(geslachtsaanduiding)).append("\n");
    sb.append("    leeftijd: ").append(toIndentedString(leeftijd)).append("\n");
    sb.append("    datumEersteInschrijvingGBA: ").append(toIndentedString(datumEersteInschrijvingGBA)).append("\n");
    sb.append("    kiesrecht: ").append(toIndentedString(kiesrecht)).append("\n");
    sb.append("    naam: ").append(toIndentedString(naam)).append("\n");
    sb.append("    inOnderzoek: ").append(toIndentedString(inOnderzoek)).append("\n");
    sb.append("    nationaliteiten: ").append(toIndentedString(nationaliteiten)).append("\n");
    sb.append("    geboorte: ").append(toIndentedString(geboorte)).append("\n");
    sb.append("    opschortingBijhouding: ").append(toIndentedString(opschortingBijhouding)).append("\n");
    sb.append("    overlijden: ").append(toIndentedString(overlijden)).append("\n");
    sb.append("    verblijfplaats: ").append(toIndentedString(verblijfplaats)).append("\n");
    sb.append("    gezagsverhouding: ").append(toIndentedString(gezagsverhouding)).append("\n");
    sb.append("    verblijfstitel: ").append(toIndentedString(verblijfstitel)).append("\n");
    sb.append("    reisdocumentnummers: ").append(toIndentedString(reisdocumentnummers)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

