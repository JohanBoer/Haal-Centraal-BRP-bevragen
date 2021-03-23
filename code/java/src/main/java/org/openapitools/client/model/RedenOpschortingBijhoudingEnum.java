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
import io.swagger.annotations.ApiModel;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Redenen voor opschorting van de bijhouding * &#x60;overlijden&#x60; - O * &#x60;emigratie&#x60; - E * &#x60;ministerieel_besluit&#x60; - M * &#x60;pl_aangelegd_in_de_rni&#x60; - R - opgeschort omdat persoon is ingeschreven in het Register Niet Ingezeten (RNI). * &#x60;fout&#x60; - F 
 */
@JsonAdapter(RedenOpschortingBijhoudingEnum.Adapter.class)
public enum RedenOpschortingBijhoudingEnum {
  
  OVERLIJDEN("overlijden"),
  
  EMIGRATIE("emigratie"),
  
  MINISTERIEEL_BESLUIT("ministerieel_besluit"),
  
  PL_AANGELEGD_IN_DE_RNI("pl_aangelegd_in_de_rni"),
  
  FOUT("fout");

  private String value;

  RedenOpschortingBijhoudingEnum(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static RedenOpschortingBijhoudingEnum fromValue(String value) {
    for (RedenOpschortingBijhoudingEnum b : RedenOpschortingBijhoudingEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<RedenOpschortingBijhoudingEnum> {
    @Override
    public void write(final JsonWriter jsonWriter, final RedenOpschortingBijhoudingEnum enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public RedenOpschortingBijhoudingEnum read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return RedenOpschortingBijhoudingEnum.fromValue(value);
    }
  }
}

