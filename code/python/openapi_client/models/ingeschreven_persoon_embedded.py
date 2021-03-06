# coding: utf-8

"""
    Bevragen Ingeschreven Personen

    API voor het bevragen van ingeschreven personen uit de basisregistratie personen (BRP), inclusief de registratie niet-ingezeten (RNI). Met deze API kun je personen zoeken en actuele gegevens over personen, kinderen, partners en ouders raadplegen.  Gegevens die er niet zijn of niet actueel zijn krijg je niet terug. Heeft een persoon bijvoorbeeld geen geldige nationaliteit, en alleen een beëindigd partnerschap, dan krijg je geen gegevens over nationaliteit en partner.  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-bevragen/tree/v1.1.0/features) voor nadere toelichting.   # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class IngeschrevenPersoonEmbedded(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'ouders': 'list[OuderHalBasis]',
        'kinderen': 'list[KindHalBasis]',
        'partners': 'list[PartnerHalBasis]'
    }

    attribute_map = {
        'ouders': 'ouders',
        'kinderen': 'kinderen',
        'partners': 'partners'
    }

    def __init__(self, ouders=None, kinderen=None, partners=None, local_vars_configuration=None):  # noqa: E501
        """IngeschrevenPersoonEmbedded - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._ouders = None
        self._kinderen = None
        self._partners = None
        self.discriminator = None

        if ouders is not None:
            self.ouders = ouders
        if kinderen is not None:
            self.kinderen = kinderen
        if partners is not None:
            self.partners = partners

    @property
    def ouders(self):
        """Gets the ouders of this IngeschrevenPersoonEmbedded.  # noqa: E501

        De ouders van de persoon.   # noqa: E501

        :return: The ouders of this IngeschrevenPersoonEmbedded.  # noqa: E501
        :rtype: list[OuderHalBasis]
        """
        return self._ouders

    @ouders.setter
    def ouders(self, ouders):
        """Sets the ouders of this IngeschrevenPersoonEmbedded.

        De ouders van de persoon.   # noqa: E501

        :param ouders: The ouders of this IngeschrevenPersoonEmbedded.  # noqa: E501
        :type: list[OuderHalBasis]
        """

        self._ouders = ouders

    @property
    def kinderen(self):
        """Gets the kinderen of this IngeschrevenPersoonEmbedded.  # noqa: E501

        De kinderen van de persoon.   # noqa: E501

        :return: The kinderen of this IngeschrevenPersoonEmbedded.  # noqa: E501
        :rtype: list[KindHalBasis]
        """
        return self._kinderen

    @kinderen.setter
    def kinderen(self, kinderen):
        """Sets the kinderen of this IngeschrevenPersoonEmbedded.

        De kinderen van de persoon.   # noqa: E501

        :param kinderen: The kinderen of this IngeschrevenPersoonEmbedded.  # noqa: E501
        :type: list[KindHalBasis]
        """

        self._kinderen = kinderen

    @property
    def partners(self):
        """Gets the partners of this IngeschrevenPersoonEmbedded.  # noqa: E501

        De partners van de persoon. Een beëindigd huwelijk of geregistreerd partnerschap wordt niet teruggegeven.   # noqa: E501

        :return: The partners of this IngeschrevenPersoonEmbedded.  # noqa: E501
        :rtype: list[PartnerHalBasis]
        """
        return self._partners

    @partners.setter
    def partners(self, partners):
        """Sets the partners of this IngeschrevenPersoonEmbedded.

        De partners van de persoon. Een beëindigd huwelijk of geregistreerd partnerschap wordt niet teruggegeven.   # noqa: E501

        :param partners: The partners of this IngeschrevenPersoonEmbedded.  # noqa: E501
        :type: list[PartnerHalBasis]
        """

        self._partners = partners

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, IngeschrevenPersoonEmbedded):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, IngeschrevenPersoonEmbedded):
            return True

        return self.to_dict() != other.to_dict()
