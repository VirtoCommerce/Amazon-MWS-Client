
namespace AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Address", Namespace = "", IsNullable = false)]
    public partial class AddressType
    {

        private string nameField;

        private string formalTitleField;

        private string givenNameField;

        private string familyNameField;

        private string addressFieldOneField;

        private string addressFieldTwoField;

        private string addressFieldThreeField;

        private string cityField;

        private string countyField;

        private string stateOrRegionField;

        private string postalCodeField;

        private string countryCodeField;

        private PhoneNumberType[] phoneNumberField;

        private bool isDefaultShippingField;

        private bool isDefaultShippingFieldSpecified;

        private bool isDefaultBillingField;

        private bool isDefaultBillingFieldSpecified;

        private bool isDefaultOneClickField;

        private bool isDefaultOneClickFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FormalTitle
        {
            get
            {
                return this.formalTitleField;
            }
            set
            {
                this.formalTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AddressFieldOne
        {
            get
            {
                return this.addressFieldOneField;
            }
            set
            {
                this.addressFieldOneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AddressFieldTwo
        {
            get
            {
                return this.addressFieldTwoField;
            }
            set
            {
                this.addressFieldTwoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AddressFieldThree
        {
            get
            {
                return this.addressFieldThreeField;
            }
            set
            {
                this.addressFieldThreeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string StateOrRegion
        {
            get
            {
                return this.stateOrRegionField;
            }
            set
            {
                this.stateOrRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhoneNumber")]
        public PhoneNumberType[] PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }

        /// <remarks/>
        public bool isDefaultShipping
        {
            get
            {
                return this.isDefaultShippingField;
            }
            set
            {
                this.isDefaultShippingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultShippingSpecified
        {
            get
            {
                return this.isDefaultShippingFieldSpecified;
            }
            set
            {
                this.isDefaultShippingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDefaultBilling
        {
            get
            {
                return this.isDefaultBillingField;
            }
            set
            {
                this.isDefaultBillingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultBillingSpecified
        {
            get
            {
                return this.isDefaultBillingFieldSpecified;
            }
            set
            {
                this.isDefaultBillingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool isDefaultOneClick
        {
            get
            {
                return this.isDefaultOneClickField;
            }
            set
            {
                this.isDefaultOneClickField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDefaultOneClickSpecified
        {
            get
            {
                return this.isDefaultOneClickFieldSpecified;
            }
            set
            {
                this.isDefaultOneClickFieldSpecified = value;
            }
        }
    }
}
