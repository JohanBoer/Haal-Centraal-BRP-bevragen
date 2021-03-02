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
import org.openapitools.client.model.DatumOnvolledig;

/**
 * Geeft aan welke gegevens over het huwelijk of het partnerschap in onderzoek zijn. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) 
 */
@ApiModel(description = "Geeft aan welke gegevens over het huwelijk of het partnerschap in onderzoek zijn. Zie de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/blob/v1.1.0/features/in_onderzoek.feature) ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-03-02T09:47:37.422Z[Etc/UTC]")
public class PartnerInOnderzoek {
  public static final String SERIALIZED_NAME_BURGERSERVICENUMMER = "burgerservicenummer";
  @SerializedName(SERIALIZED_NAME_BURGERSERVICENUMMER)
  private Boolean burgerservicenummer;

  public static final String SERIALIZED_NAME_GESLACHTSAANDUIDING = "geslachtsaanduiding";
  @SerializedName(SERIALIZED_NAME_GESLACHTSAANDUIDING)
  private Boolean geslachtsaanduiding;

  public static final String SERIALIZED_NAME_SOORT_VERBINTENIS = "soortVerbintenis";
  @SerializedName(SERIALIZED_NAME_SOORT_VERBINTENIS)
  private Boolean soortVerbintenis;

  public static final String SERIALIZED_NAME_DATUM_INGANG_ONDERZOEK = "datumIngangOnderzoek";
  @SerializedName(SERIALIZED_NAME_DATUM_INGANG_ONDERZOEK)
  private DatumOnvolledig datumIngangOnderzoek;


  public PartnerInOnderzoek burgerservicenummer(Boolean burgerservicenummer) {
    
    this.burgerservicenummer = burgerservicenummer;
    return this;
  }

   /**
   * Get burgerservicenummer
   * @return burgerservicenummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getBurgerservicenummer() {
    return burgerservicenummer;
  }


  public void setBurgerservicenummer(Boolean burgerservicenummer) {
    this.burgerservicenummer = burgerservicenummer;
  }


  public PartnerInOnderzoek geslachtsaanduiding(Boolean geslachtsaanduiding) {
    
    this.geslachtsaanduiding = geslachtsaanduiding;
    return this;
  }

   /**
   * Get geslachtsaanduiding
   * @return geslachtsaanduiding
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getGeslachtsaanduiding() {
    return geslachtsaanduiding;
  }


  public void setGeslachtsaanduiding(Boolean geslachtsaanduiding) {
    this.geslachtsaanduiding = geslachtsaanduiding;
  }


  public PartnerInOnderzoek soortVerbintenis(Boolean soortVerbintenis) {
    
    this.soortVerbintenis = soortVerbintenis;
    return this;
  }

   /**
   * Get soortVerbintenis
   * @return soortVerbintenis
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getSoortVerbintenis() {
    return soortVerbintenis;
  }


  public void setSoortVerbintenis(Boolean soortVerbintenis) {
    this.soortVerbintenis = soortVerbintenis;
  }


  public PartnerInOnderzoek datumIngangOnderzoek(DatumOnvolledig datumIngangOnderzoek) {
    
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
    PartnerInOnderzoek partnerInOnderzoek = (PartnerInOnderzoek) o;
    return Objects.equals(this.burgerservicenummer, partnerInOnderzoek.burgerservicenummer) &&
        Objects.equals(this.geslachtsaanduiding, partnerInOnderzoek.geslachtsaanduiding) &&
        Objects.equals(this.soortVerbintenis, partnerInOnderzoek.soortVerbintenis) &&
        Objects.equals(this.datumIngangOnderzoek, partnerInOnderzoek.datumIngangOnderzoek);
  }

  @Override
  public int hashCode() {
    return Objects.hash(burgerservicenummer, geslachtsaanduiding, soortVerbintenis, datumIngangOnderzoek);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PartnerInOnderzoek {\n");
    sb.append("    burgerservicenummer: ").append(toIndentedString(burgerservicenummer)).append("\n");
    sb.append("    geslachtsaanduiding: ").append(toIndentedString(geslachtsaanduiding)).append("\n");
    sb.append("    soortVerbintenis: ").append(toIndentedString(soortVerbintenis)).append("\n");
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

