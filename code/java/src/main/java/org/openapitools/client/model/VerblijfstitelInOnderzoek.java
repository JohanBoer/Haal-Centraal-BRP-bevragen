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
 * Geeft aan welke gegevens over de verblijfstitel in onderzoek zijn. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) 
 */
@ApiModel(description = "Geeft aan welke gegevens over de verblijfstitel in onderzoek zijn. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-08T13:57:27.296Z[Etc/UTC]")
public class VerblijfstitelInOnderzoek {
  public static final String SERIALIZED_NAME_AANDUIDING = "aanduiding";
  @SerializedName(SERIALIZED_NAME_AANDUIDING)
  private Boolean aanduiding;

  public static final String SERIALIZED_NAME_DATUM_EINDE = "datumEinde";
  @SerializedName(SERIALIZED_NAME_DATUM_EINDE)
  private Boolean datumEinde;

  public static final String SERIALIZED_NAME_DATUM_INGANG = "datumIngang";
  @SerializedName(SERIALIZED_NAME_DATUM_INGANG)
  private Boolean datumIngang;

  public static final String SERIALIZED_NAME_DATUM_INGANG_ONDERZOEK = "datumIngangOnderzoek";
  @SerializedName(SERIALIZED_NAME_DATUM_INGANG_ONDERZOEK)
  private DatumOnvolledig datumIngangOnderzoek;


  public VerblijfstitelInOnderzoek aanduiding(Boolean aanduiding) {
    
    this.aanduiding = aanduiding;
    return this;
  }

   /**
   * Get aanduiding
   * @return aanduiding
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getAanduiding() {
    return aanduiding;
  }


  public void setAanduiding(Boolean aanduiding) {
    this.aanduiding = aanduiding;
  }


  public VerblijfstitelInOnderzoek datumEinde(Boolean datumEinde) {
    
    this.datumEinde = datumEinde;
    return this;
  }

   /**
   * Get datumEinde
   * @return datumEinde
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getDatumEinde() {
    return datumEinde;
  }


  public void setDatumEinde(Boolean datumEinde) {
    this.datumEinde = datumEinde;
  }


  public VerblijfstitelInOnderzoek datumIngang(Boolean datumIngang) {
    
    this.datumIngang = datumIngang;
    return this;
  }

   /**
   * Get datumIngang
   * @return datumIngang
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getDatumIngang() {
    return datumIngang;
  }


  public void setDatumIngang(Boolean datumIngang) {
    this.datumIngang = datumIngang;
  }


  public VerblijfstitelInOnderzoek datumIngangOnderzoek(DatumOnvolledig datumIngangOnderzoek) {
    
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
    VerblijfstitelInOnderzoek verblijfstitelInOnderzoek = (VerblijfstitelInOnderzoek) o;
    return Objects.equals(this.aanduiding, verblijfstitelInOnderzoek.aanduiding) &&
        Objects.equals(this.datumEinde, verblijfstitelInOnderzoek.datumEinde) &&
        Objects.equals(this.datumIngang, verblijfstitelInOnderzoek.datumIngang) &&
        Objects.equals(this.datumIngangOnderzoek, verblijfstitelInOnderzoek.datumIngangOnderzoek);
  }

  @Override
  public int hashCode() {
    return Objects.hash(aanduiding, datumEinde, datumIngang, datumIngangOnderzoek);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VerblijfstitelInOnderzoek {\n");
    sb.append("    aanduiding: ").append(toIndentedString(aanduiding)).append("\n");
    sb.append("    datumEinde: ").append(toIndentedString(datumEinde)).append("\n");
    sb.append("    datumIngang: ").append(toIndentedString(datumIngang)).append("\n");
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

