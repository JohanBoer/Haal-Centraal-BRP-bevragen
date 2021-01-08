/*
 * Bevragen Ingeschreven Personen
 * API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting. 
 *
 * The version of the OpenAPI document: 1.1.0
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
import org.openapitools.client.model.DatumOnvolledig;

/**
 * Geeft aan welke gegevens over het voltrekken van het huwelijk of aangaan van het partnerschap in onderzoek zijn. Zie de functionele specificaties. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) 
 */
@ApiModel(description = "Geeft aan welke gegevens over het voltrekken van het huwelijk of aangaan van het partnerschap in onderzoek zijn. Zie de functionele specificaties. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-08T13:57:27.296Z[Etc/UTC]")
public class AangaanHuwelijkPartnerschapInOnderzoek {
  public static final String SERIALIZED_NAME_DATUM = "datum";
  @SerializedName(SERIALIZED_NAME_DATUM)
  private Boolean datum;

  public static final String SERIALIZED_NAME_LAND = "land";
  @SerializedName(SERIALIZED_NAME_LAND)
  private Boolean land;

  public static final String SERIALIZED_NAME_PLAATS = "plaats";
  @SerializedName(SERIALIZED_NAME_PLAATS)
  private Boolean plaats;

  public static final String SERIALIZED_NAME_DATUM_INGANG_ONDERZOEK = "datumIngangOnderzoek";
  @SerializedName(SERIALIZED_NAME_DATUM_INGANG_ONDERZOEK)
  private DatumOnvolledig datumIngangOnderzoek;


  public AangaanHuwelijkPartnerschapInOnderzoek datum(Boolean datum) {
    
    this.datum = datum;
    return this;
  }

   /**
   * Get datum
   * @return datum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getDatum() {
    return datum;
  }


  public void setDatum(Boolean datum) {
    this.datum = datum;
  }


  public AangaanHuwelijkPartnerschapInOnderzoek land(Boolean land) {
    
    this.land = land;
    return this;
  }

   /**
   * Get land
   * @return land
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getLand() {
    return land;
  }


  public void setLand(Boolean land) {
    this.land = land;
  }


  public AangaanHuwelijkPartnerschapInOnderzoek plaats(Boolean plaats) {
    
    this.plaats = plaats;
    return this;
  }

   /**
   * Get plaats
   * @return plaats
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getPlaats() {
    return plaats;
  }


  public void setPlaats(Boolean plaats) {
    this.plaats = plaats;
  }


  public AangaanHuwelijkPartnerschapInOnderzoek datumIngangOnderzoek(DatumOnvolledig datumIngangOnderzoek) {
    
    this.datumIngangOnderzoek = datumIngangOnderzoek;
    return this;
  }

   /**
   * Get datumIngangOnderzoek
   * @return datumIngangOnderzoek
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public DatumOnvolledig getDatumIngangOnderzoek() {
    return datumIngangOnderzoek;
  }


  public void setDatumIngangOnderzoek(DatumOnvolledig datumIngangOnderzoek) {
    this.datumIngangOnderzoek = datumIngangOnderzoek;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AangaanHuwelijkPartnerschapInOnderzoek aangaanHuwelijkPartnerschapInOnderzoek = (AangaanHuwelijkPartnerschapInOnderzoek) o;
    return Objects.equals(this.datum, aangaanHuwelijkPartnerschapInOnderzoek.datum) &&
        Objects.equals(this.land, aangaanHuwelijkPartnerschapInOnderzoek.land) &&
        Objects.equals(this.plaats, aangaanHuwelijkPartnerschapInOnderzoek.plaats) &&
        Objects.equals(this.datumIngangOnderzoek, aangaanHuwelijkPartnerschapInOnderzoek.datumIngangOnderzoek);
  }

  @Override
  public int hashCode() {
    return Objects.hash(datum, land, plaats, datumIngangOnderzoek);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AangaanHuwelijkPartnerschapInOnderzoek {\n");
    sb.append("    datum: ").append(toIndentedString(datum)).append("\n");
    sb.append("    land: ").append(toIndentedString(land)).append("\n");
    sb.append("    plaats: ").append(toIndentedString(plaats)).append("\n");
    sb.append("    datumIngangOnderzoek: ").append(toIndentedString(datumIngangOnderzoek)).append("\n");
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

