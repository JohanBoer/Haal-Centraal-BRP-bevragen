# Behaviour driven specificatie
Het doel is door middel van gerichte voorbeelden de functionele werking van de api specificeren en illustreren. Voor de meeste features is de ontwikkelaar van de provider van de API doelgroep.

## Opbouw van de functionele specificaties
De specificaties zijn opgebouwd per functionalteit van de API. Op elke functionaliteit van de API is de werking beschreven én is de werking geïllustreerd in de vorm van scenario's (als ik dit doe, dan doet de api dat).

Naast de features die hier staan zijn voor de API ook enkele features relevant die zijn opgenomen in Haal Centraal common, omdat deze gelden voor alle Haal Centraal API's:
- [fields](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v.1.2.0/features/fields.feature)
- [expand](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature)
- [wildcard](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/wildcard.feature)
- [foutafhandeling](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/foutafhandeling.feature)
- [uri-templating](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/uri-templating.feature)
- [indicatoren](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/1.2.0/features/indicatoren.feature)
- [onvolledige datum](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/onvolledige_datum.feature)
- [self-links](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/self-links.feature)

## Features en scenario's
De specificatie/test is gespecificeerd in documenten per functionaliteit, elk met extensie ".feature". Per functionaliteit is een korte beschrijving van de functionaliteit opgenomen plus scenario's die de gewenste werking van de functionaliteit toelichten en demonstreren.

De specificatie is functioneel gedefinieerd in [Gherkin](https://docs.cucumber.io/gherkin/reference/). Hiermee kan in menselijke taal de specificatie/test worden opgesteld.
De specificatie is in de *Nederlandse taal* gedefinieerd.

Structuur wordt aangegeven via de sleutelwoorden "Functionaliteit", "Achtergrond", "Scenario", "Gegeven", "Als", "Dan" en "En", "Abstract Scenario" en "Voorbeelden".

| Sleutelwoord      | Engels equivalent | Betekenis                                   |
| ----------------- | ----------------- | ------------------------------------------- |
| Functionaliteit   | Feature           | Beschrijft de te testen functionaliteit     |
| Achtergrond       | Background        | Precondities die voor de hele test gelden   |
| Scenario          | Scenario          | Samenhangende groep teststappen             |
| Gegeven           | Given             | Preconditie die voor het scenario geldt     |
| Als               | When              | Teststap die de actie beschrijft            |
| Dan               | Then              | Teststap die de controle beschrijft         |
| En                | And               | Aanvullende teststap op Gegeven, Als of Dan |
| Abstract Scenario | Scenario Outline  | Scenario sjabloon die gevallen uit voorbeelden doorloopt |
| Voorbeelden       | Examples          | Tabel met testwaarden die met Abstract scenario worden doorlopen |

De Gherkin scenario's worden opgenomen in de map /features. Voor elke functionaliteit wordt een bestand gemaakt met als extensie ".feature". Per functionaliteit (feature-bestand) kunnen er meerdere scenario's zijn gedefinieerd om de betreffende functionaliteit te illustreren.

## Tests
Deze manier van specificeren maakt het mogelijk om te worden uitgevoerd als geautomatiseerde test van de API. Met deze opzet van de specificatie/test wordt [Behaviour Driven Development (BDD)](https://docs.cucumber.io/bdd) ondersteund.

De features zijn op dit moment niet volledig uitvoerbaar als BDD test. Voor de [referentie-implementatie](https://github.com/lostlemon/haal-centraal-brp-bevragen) is een belangrijk deel van de features in een werkende test omgezet, maar de hier gepubliceerde features zijn dat niet.
