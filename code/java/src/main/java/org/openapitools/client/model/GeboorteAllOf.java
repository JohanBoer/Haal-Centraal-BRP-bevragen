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
import org.openapitools.client.model.GeboorteInOnderzoek;
import org.openapitools.client.model.Waardetabel;

/**
 * Gegevens over de geboorte. * **datum** : datum waarop de persoon is geboren. * **land** : land waar de persoon is geboren * **plaats** : plaats waar de persoon is geboren. Voor een plaats buiten Nederland is gemeentecode&#x3D;1999 (RNI) en gemeentenaam de buitenlandse plaatsnaam of aanduiding. 
 */
@ApiModel(description = "Gegevens over de geboorte. * **datum** : datum waarop de persoon is geboren. * **land** : land waar de persoon is geboren * **plaats** : plaats waar de persoon is geboren. Voor een plaats buiten Nederland is gemeentecode=1999 (RNI) en gemeentenaam de buitenlandse plaatsnaam of aanduiding. ")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-08T14:07:51.955Z[Etc/UTC]")
public class GeboorteAllOf {
  public static final String SERIALIZED_NAME_LAND = "land";
  @SerializedName(SERIALIZED_NAME_LAND)
  private Waardetabel land;

  public static final String SERIALIZED_NAME_PLAATS = "plaats";
  @SerializedName(SERIALIZED_NAME_PLAATS)
  private Waardetabel plaats;

  public static final String SERIALIZED_NAME_IN_ONDERZOEK = "inOnderzoek";
  @SerializedName(SERIALIZED_NAME_IN_ONDERZOEK)
  private GeboorteInOnderzoek inOnderzoek;


  public GeboorteAllOf land(Waardetabel land) {
    
    this.land = land;
    return this;
  }

   /**
   * Get land
   * @return land
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardetabel getLand() {
    return land;
  }


  public void setLand(Waardetabel land) {
    this.land = land;
  }


  public GeboorteAllOf plaats(Waardetabel plaats) {
    
    this.plaats = plaats;
    return this;
  }

   /**
   * Get plaats
   * @return plaats
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Waardetabel getPlaats() {
    return plaats;
  }


  public void setPlaats(Waardetabel plaats) {
    this.plaats = plaats;
  }


  public GeboorteAllOf inOnderzoek(GeboorteInOnderzoek inOnderzoek) {
    
    this.inOnderzoek = inOnderzoek;
    return this;
  }

   /**
   * Get inOnderzoek
   * @return inOnderzoek
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public GeboorteInOnderzoek getInOnderzoek() {
    return inOnderzoek;
  }


  public void setInOnderzoek(GeboorteInOnderzoek inOnderzoek) {
    this.inOnderzoek = inOnderzoek;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GeboorteAllOf geboorteAllOf = (GeboorteAllOf) o;
    return Objects.equals(this.land, geboorteAllOf.land) &&
        Objects.equals(this.plaats, geboorteAllOf.plaats) &&
        Objects.equals(this.inOnderzoek, geboorteAllOf.inOnderzoek);
  }

  @Override
  public int hashCode() {
    return Objects.hash(land, plaats, inOnderzoek);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GeboorteAllOf {\n");
    sb.append("    land: ").append(toIndentedString(land)).append("\n");
    sb.append("    plaats: ").append(toIndentedString(plaats)).append("\n");
    sb.append("    inOnderzoek: ").append(toIndentedString(inOnderzoek)).append("\n");
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

