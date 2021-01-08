"""
    Bevragen Ingeschreven Personen

    API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting.   # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

import nulltype  # noqa: F401

from openapi_client.model_utils import (  # noqa: F401
    ApiTypeError,
    ModelComposed,
    ModelNormal,
    ModelSimple,
    cached_property,
    change_keys_js_to_python,
    convert_js_args_to_python_args,
    date,
    datetime,
    file_type,
    none_type,
    validate_get_composed_info,
)

def lazy_import():
    from openapi_client.model.aanduiding_bij_huisnummer_enum import AanduidingBijHuisnummerEnum
    from openapi_client.model.datum_onvolledig import DatumOnvolledig
    from openapi_client.model.soort_adres_enum import SoortAdresEnum
    from openapi_client.model.verblijfplaats_in_onderzoek import VerblijfplaatsInOnderzoek
    from openapi_client.model.waardetabel import Waardetabel
    globals()['AanduidingBijHuisnummerEnum'] = AanduidingBijHuisnummerEnum
    globals()['DatumOnvolledig'] = DatumOnvolledig
    globals()['SoortAdresEnum'] = SoortAdresEnum
    globals()['VerblijfplaatsInOnderzoek'] = VerblijfplaatsInOnderzoek
    globals()['Waardetabel'] = Waardetabel


class VerblijfplaatsAllOf(ModelNormal):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.

    Attributes:
      allowed_values (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          with a capitalized key describing the allowed value and an allowed
          value. These dicts store the allowed enum values.
      attribute_map (dict): The key is attribute name
          and the value is json key in definition.
      discriminator_value_class_map (dict): A dict to go from the discriminator
          variable value to the discriminator class name.
      validations (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          that stores validations for max_length, min_length, max_items,
          min_items, exclusive_maximum, inclusive_maximum, exclusive_minimum,
          inclusive_minimum, and regex.
      additional_properties_type (tuple): A tuple of classes accepted
          as additional properties values.
    """

    allowed_values = {
    }

    validations = {
    }

    additional_properties_type = None

    _nullable = False

    @cached_property
    def openapi_types():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded

        Returns
            openapi_types (dict): The key is attribute name
                and the value is attribute type.
        """
        lazy_import()
        return {
            'adresseerbaar_object_identificatie': (str,),  # noqa: E501
            'aanduiding_bij_huisnummer': (AanduidingBijHuisnummerEnum,),  # noqa: E501
            'nummeraanduiding_identificatie': (str,),  # noqa: E501
            'functie_adres': (SoortAdresEnum,),  # noqa: E501
            'indicatie_vestiging_vanuit_buitenland': (bool,),  # noqa: E501
            'locatiebeschrijving': (str,),  # noqa: E501
            'korte_naam': (str,),  # noqa: E501
            'vanuit_vertrokken_onbekend_waarheen': (bool,),  # noqa: E501
            'datum_aanvang_adreshouding': (DatumOnvolledig,),  # noqa: E501
            'datum_ingang_geldigheid': (DatumOnvolledig,),  # noqa: E501
            'datum_inschrijving_in_gemeente': (DatumOnvolledig,),  # noqa: E501
            'datum_vestiging_in_nederland': (DatumOnvolledig,),  # noqa: E501
            'gemeente_van_inschrijving': (Waardetabel,),  # noqa: E501
            'land_vanwaar_ingeschreven': (Waardetabel,),  # noqa: E501
            'adresregel1': (str,),  # noqa: E501
            'adresregel2': (str,),  # noqa: E501
            'adresregel3': (str,),  # noqa: E501
            'vertrokken_onbekend_waarheen': (bool,),  # noqa: E501
            'land': (Waardetabel,),  # noqa: E501
            'in_onderzoek': (VerblijfplaatsInOnderzoek,),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'adresseerbaar_object_identificatie': 'adresseerbaarObjectIdentificatie',  # noqa: E501
        'aanduiding_bij_huisnummer': 'aanduidingBijHuisnummer',  # noqa: E501
        'nummeraanduiding_identificatie': 'nummeraanduidingIdentificatie',  # noqa: E501
        'functie_adres': 'functieAdres',  # noqa: E501
        'indicatie_vestiging_vanuit_buitenland': 'indicatieVestigingVanuitBuitenland',  # noqa: E501
        'locatiebeschrijving': 'locatiebeschrijving',  # noqa: E501
        'korte_naam': 'korteNaam',  # noqa: E501
        'vanuit_vertrokken_onbekend_waarheen': 'vanuitVertrokkenOnbekendWaarheen',  # noqa: E501
        'datum_aanvang_adreshouding': 'datumAanvangAdreshouding',  # noqa: E501
        'datum_ingang_geldigheid': 'datumIngangGeldigheid',  # noqa: E501
        'datum_inschrijving_in_gemeente': 'datumInschrijvingInGemeente',  # noqa: E501
        'datum_vestiging_in_nederland': 'datumVestigingInNederland',  # noqa: E501
        'gemeente_van_inschrijving': 'gemeenteVanInschrijving',  # noqa: E501
        'land_vanwaar_ingeschreven': 'landVanwaarIngeschreven',  # noqa: E501
        'adresregel1': 'adresregel1',  # noqa: E501
        'adresregel2': 'adresregel2',  # noqa: E501
        'adresregel3': 'adresregel3',  # noqa: E501
        'vertrokken_onbekend_waarheen': 'vertrokkenOnbekendWaarheen',  # noqa: E501
        'land': 'land',  # noqa: E501
        'in_onderzoek': 'inOnderzoek',  # noqa: E501
    }

    _composed_schemas = {}

    required_properties = set([
        '_data_store',
        '_check_type',
        '_spec_property_naming',
        '_path_to_item',
        '_configuration',
        '_visited_composed_classes',
    ])

    @convert_js_args_to_python_args
    def __init__(self, *args, **kwargs):  # noqa: E501
        """VerblijfplaatsAllOf - a model defined in OpenAPI

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            adresseerbaar_object_identificatie (str): De verblijfplaats van de persoon kan een ligplaats, een standplaats of een verblijfsobject zijn. . [optional]  # noqa: E501
            aanduiding_bij_huisnummer (AanduidingBijHuisnummerEnum): [optional]  # noqa: E501
            nummeraanduiding_identificatie (str): Unieke identificatie van een nummeraanduiding (en het bijbehorende adres) in de BAG. . [optional]  # noqa: E501
            functie_adres (SoortAdresEnum): [optional]  # noqa: E501
            indicatie_vestiging_vanuit_buitenland (bool): Geeft aan dat de ingeschreven persoon zich vanuit het buitenland heeft ingeschreven. . [optional]  # noqa: E501
            locatiebeschrijving (str): Omschrijving van de ligging van een verblijfsobject, standplaats of ligplaats. . [optional]  # noqa: E501
            korte_naam (str): De officiële openbareruimtenaam uit de Basisregistratie Gebouwen en Adressen (BAG) of een verkorte versie. . [optional]  # noqa: E501
            vanuit_vertrokken_onbekend_waarheen (bool): Geeft aan dat de persoon is teruggekeerd uit een situatie van 'vertrokken onbekend waarheen.' . [optional]  # noqa: E501
            datum_aanvang_adreshouding (DatumOnvolledig): [optional]  # noqa: E501
            datum_ingang_geldigheid (DatumOnvolledig): [optional]  # noqa: E501
            datum_inschrijving_in_gemeente (DatumOnvolledig): [optional]  # noqa: E501
            datum_vestiging_in_nederland (DatumOnvolledig): [optional]  # noqa: E501
            gemeente_van_inschrijving (Waardetabel): [optional]  # noqa: E501
            land_vanwaar_ingeschreven (Waardetabel): [optional]  # noqa: E501
            adresregel1 (str): Het eerste deel van een adres is een combinatie van de straat en huisnummer. . [optional]  # noqa: E501
            adresregel2 (str): Het tweede deel van een adres is een combinatie van woonplaats eventueel in combinatie met de postcode. . [optional]  # noqa: E501
            adresregel3 (str): Het derde deel van een adres is optioneel. Het gaat om een of meer geografische gebieden van het adres in het buitenland. . [optional]  # noqa: E501
            vertrokken_onbekend_waarheen (bool): Indicatie dat de ingeschreven persoon is vertrokken naar het buitenland, maar dat niet bekend is waar naar toe. . [optional]  # noqa: E501
            land (Waardetabel): [optional]  # noqa: E501
            in_onderzoek (VerblijfplaatsInOnderzoek): [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
