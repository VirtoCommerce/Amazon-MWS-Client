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
    [System.Xml.Serialization.XmlRootAttribute("Amazon-Only", Namespace = "", IsNullable = false)]
    public partial class AmazonOnly
    {

        private string tierField;

        private string purchasingCategoryField;

        private string purchasingSubCategoryField;

        private string packagingTypeField;

        private AmazonOnlyUnderlyingAvailability underlyingAvailabilityField;

        private AmazonOnlyReplenishmentCategory replenishmentCategoryField;

        private AmazonOnlyDropShipStatus dropShipStatusField;

        private AmazonOnlyOutOfStockWebsiteMessage outOfStockWebsiteMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Tier
        {
            get
            {
                return this.tierField;
            }
            set
            {
                this.tierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PurchasingCategory
        {
            get
            {
                return this.purchasingCategoryField;
            }
            set
            {
                this.purchasingCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PurchasingSubCategory
        {
            get
            {
                return this.purchasingSubCategoryField;
            }
            set
            {
                this.purchasingSubCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PackagingType
        {
            get
            {
                return this.packagingTypeField;
            }
            set
            {
                this.packagingTypeField = value;
            }
        }

        /// <remarks/>
        public AmazonOnlyUnderlyingAvailability UnderlyingAvailability
        {
            get
            {
                return this.underlyingAvailabilityField;
            }
            set
            {
                this.underlyingAvailabilityField = value;
            }
        }

        /// <remarks/>
        public AmazonOnlyReplenishmentCategory ReplenishmentCategory
        {
            get
            {
                return this.replenishmentCategoryField;
            }
            set
            {
                this.replenishmentCategoryField = value;
            }
        }

        /// <remarks/>
        public AmazonOnlyDropShipStatus DropShipStatus
        {
            get
            {
                return this.dropShipStatusField;
            }
            set
            {
                this.dropShipStatusField = value;
            }
        }

        /// <remarks/>
        public AmazonOnlyOutOfStockWebsiteMessage OutOfStockWebsiteMessage
        {
            get
            {
                return this.outOfStockWebsiteMessageField;
            }
            set
            {
                this.outOfStockWebsiteMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AmazonOnlyUnderlyingAvailability
    {

        /// <remarks/>
        backordered,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("manufacturer-out-of-stock")]
        manufactureroutofstock,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("pre-ordered")]
        preordered,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2-3-days")]
        Item23days,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1-2-weeks")]
        Item12weeks,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4-6-weeks")]
        Item46weeks,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AmazonOnlyReplenishmentCategory
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("basic-replenishment")]
        basicreplenishment,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("limited-replenishment")]
        limitedreplenishment,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("manufacturer-out-of-stock")]
        manufactureroutofstock,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("new-product")]
        newproduct,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("non-replenishable")]
        nonreplenishable,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("non-stockupable")]
        nonstockupable,

        /// <remarks/>
        obsolete,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("planned-replenishment")]
        plannedreplenishment,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AmazonOnlyDropShipStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("drop-ship-disabled")]
        dropshipdisabled,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("drop-ship-disabled-by-buyer")]
        dropshipdisabledbybuyer,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("drop-ship-enabled")]
        dropshipenabled,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("drop-ship-enabled-no-auto-pricing")]
        dropshipenablednoautopricing,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("drop-ship-only")]
        dropshiponly,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AmazonOnlyOutOfStockWebsiteMessage
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("email-me-when-available")]
        emailmewhenavailable,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("out-of-stock")]
        outofstock,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("pre-order-ute")]
        preorderute,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("underlying-availability")]
        underlyingavailability,
    }
}