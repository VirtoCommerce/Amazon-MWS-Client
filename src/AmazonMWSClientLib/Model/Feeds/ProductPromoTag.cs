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
    public partial class ProductPromoTag
    {

        private ProductPromoTagPromoTagType promoTagTypeField;

        private System.DateTime effectiveFromDateField;

        private System.DateTime effectiveThroughDateField;

        private bool effectiveThroughDateFieldSpecified;

        /// <remarks/>
        public ProductPromoTagPromoTagType PromoTagType
        {
            get
            {
                return this.promoTagTypeField;
            }
            set
            {
                this.promoTagTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime EffectiveFromDate
        {
            get
            {
                return this.effectiveFromDateField;
            }
            set
            {
                this.effectiveFromDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime EffectiveThroughDate
        {
            get
            {
                return this.effectiveThroughDateField;
            }
            set
            {
                this.effectiveThroughDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveThroughDateSpecified
        {
            get
            {
                return this.effectiveThroughDateFieldSpecified;
            }
            set
            {
                this.effectiveThroughDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductPromoTagPromoTagType
    {

        /// <remarks/>
        Sale,

        /// <remarks/>
        New,

        /// <remarks/>
        NewArrival,

        /// <remarks/>
        WebOnly,

        /// <remarks/>
        Clearance,

        /// <remarks/>
        LimitedOffer,

        /// <remarks/>
        SpecialOffer,

        /// <remarks/>
        SpecialPurchase,

        /// <remarks/>
        OnlyInStores,
    }
}