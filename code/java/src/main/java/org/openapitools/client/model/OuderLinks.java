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
import org.openapitools.client.model.HalLink;

/**
 * OuderLinks
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-08T13:57:27.296Z[Etc/UTC]")
public class OuderLinks {
  public static final String SERIALIZED_NAME_SELF = "self";
  @SerializedName(SERIALIZED_NAME_SELF)
  private HalLink self;

  public static final String SERIALIZED_NAME_INGESCHREVEN_PERSOON = "ingeschrevenPersoon";
  @SerializedName(SERIALIZED_NAME_INGESCHREVEN_PERSOON)
  private HalLink ingeschrevenPersoon;


  public OuderLinks self(HalLink self) {
    
    this.self = self;
    return this;
  }

   /**
   * Get self
   * @return self
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getSelf() {
    return self;
  }


  public void setSelf(HalLink self) {
    this.self = self;
  }


  public OuderLinks ingeschrevenPersoon(HalLink ingeschrevenPersoon) {
    
    this.ingeschrevenPersoon = ingeschrevenPersoon;
    return this;
  }

   /**
   * Get ingeschrevenPersoon
   * @return ingeschrevenPersoon
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public HalLink getIngeschrevenPersoon() {
    return ingeschrevenPersoon;
  }


  public void setIngeschrevenPersoon(HalLink ingeschrevenPersoon) {
    this.ingeschrevenPersoon = ingeschrevenPersoon;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OuderLinks ouderLinks = (OuderLinks) o;
    return Objects.equals(this.self, ouderLinks.self) &&
        Objects.equals(this.ingeschrevenPersoon, ouderLinks.ingeschrevenPersoon);
  }

  @Override
  public int hashCode() {
    return Objects.hash(self, ingeschrevenPersoon);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OuderLinks {\n");
    sb.append("    self: ").append(toIndentedString(self)).append("\n");
    sb.append("    ingeschrevenPersoon: ").append(toIndentedString(ingeschrevenPersoon)).append("\n");
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

