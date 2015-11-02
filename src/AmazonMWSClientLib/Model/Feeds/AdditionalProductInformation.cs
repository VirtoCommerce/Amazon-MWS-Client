using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AdditionalProductInformation
    {

        private string[] materialFabricField;

        private string importDesignationField;

        private string countryAsLabeledField;

        private string furDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialFabric", DataType = "normalizedString")]
        public string[] MaterialFabric
        {
            get
            {
                return this.materialFabricField;
            }
            set
            {
                this.materialFabricField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ImportDesignation
        {
            get
            {
                return this.importDesignationField;
            }
            set
            {
                this.importDesignationField = value;
            }
        }

        /// <remarks/>
        public string CountryAsLabeled
        {
            get
            {
                return this.countryAsLabeledField;
            }
            set
            {
                this.countryAsLabeledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FurDescription
        {
            get
            {
                return this.furDescriptionField;
            }
            set
            {
                this.furDescriptionField = value;
            }
        }
    }
}