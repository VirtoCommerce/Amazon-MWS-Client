using System;
using System.Xml.Serialization;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Product
    {

        private string sKUField;

        private StandardProductID standardProductIDField;

        private ProductGtinExemptionReason gtinExemptionReasonField;

        private bool gtinExemptionReasonFieldSpecified;

        private RelatedProductID relatedProductIDField;

        private string productTaxCodeField;

        private System.DateTime launchDateField;

        private bool launchDateFieldSpecified;

        private System.DateTime discontinueDateField;

        private bool discontinueDateFieldSpecified;

        private System.DateTime releaseDateField;

        private bool releaseDateFieldSpecified;

        private string externalProductUrlField;

        private ProductOffAmazonChannel offAmazonChannelField;

        private bool offAmazonChannelFieldSpecified;

        private ProductOnAmazonChannel onAmazonChannelField;

        private bool onAmazonChannelFieldSpecified;

        private ConditionInfo conditionField;

        private RebateType[] rebateField;

        private string itemPackageQuantityField;

        private string numberOfItemsField;

        private VolumeDimension liquidVolumeField;

        private ProductDescriptionData descriptionDataField;

        private ProductPromoTag promoTagField;

        private ProductDiscoveryData discoveryDataField;

        private ProductProductData productDataField;

        private bool shippedByFreightField;

        private bool shippedByFreightFieldSpecified;

        private string[] enhancedImageURLField;

        private AmazonVendorOnly amazonVendorOnlyField;

        private AmazonOnly amazonOnlyField;

        private ProductRegisteredParameter registeredParameterField;

        private bool registeredParameterFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }

        /// <remarks/>
        public StandardProductID StandardProductID
        {
            get
            {
                return this.standardProductIDField;
            }
            set
            {
                this.standardProductIDField = value;
            }
        }

        /// <remarks/>
        public ProductGtinExemptionReason GtinExemptionReason
        {
            get
            {
                return this.gtinExemptionReasonField;
            }
            set
            {
                this.gtinExemptionReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GtinExemptionReasonSpecified
        {
            get
            {
                return this.gtinExemptionReasonFieldSpecified;
            }
            set
            {
                this.gtinExemptionReasonFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RelatedProductID RelatedProductID
        {
            get
            {
                return this.relatedProductIDField;
            }
            set
            {
                this.relatedProductIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ProductTaxCode
        {
            get
            {
                return this.productTaxCodeField;
            }
            set
            {
                this.productTaxCodeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime LaunchDate
        {
            get
            {
                return this.launchDateField;
            }
            set
            {
                this.launchDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaunchDateSpecified
        {
            get
            {
                return this.launchDateFieldSpecified;
            }
            set
            {
                this.launchDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime DiscontinueDate
        {
            get
            {
                return this.discontinueDateField;
            }
            set
            {
                this.discontinueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscontinueDateSpecified
        {
            get
            {
                return this.discontinueDateFieldSpecified;
            }
            set
            {
                this.discontinueDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ReleaseDate
        {
            get
            {
                return this.releaseDateField;
            }
            set
            {
                this.releaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReleaseDateSpecified
        {
            get
            {
                return this.releaseDateFieldSpecified;
            }
            set
            {
                this.releaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string ExternalProductUrl
        {
            get
            {
                return this.externalProductUrlField;
            }
            set
            {
                this.externalProductUrlField = value;
            }
        }

        /// <remarks/>
        public ProductOffAmazonChannel OffAmazonChannel
        {
            get
            {
                return this.offAmazonChannelField;
            }
            set
            {
                this.offAmazonChannelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OffAmazonChannelSpecified
        {
            get
            {
                return this.offAmazonChannelFieldSpecified;
            }
            set
            {
                this.offAmazonChannelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProductOnAmazonChannel OnAmazonChannel
        {
            get
            {
                return this.onAmazonChannelField;
            }
            set
            {
                this.onAmazonChannelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnAmazonChannelSpecified
        {
            get
            {
                return this.onAmazonChannelFieldSpecified;
            }
            set
            {
                this.onAmazonChannelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ConditionInfo Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rebate")]
        public RebateType[] Rebate
        {
            get
            {
                return this.rebateField;
            }
            set
            {
                this.rebateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ItemPackageQuantity
        {
            get
            {
                return this.itemPackageQuantityField;
            }
            set
            {
                this.itemPackageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfItems
        {
            get
            {
                return this.numberOfItemsField;
            }
            set
            {
                this.numberOfItemsField = value;
            }
        }

        /// <remarks/>
        public VolumeDimension LiquidVolume
        {
            get
            {
                return this.liquidVolumeField;
            }
            set
            {
                this.liquidVolumeField = value;
            }
        }

        /// <remarks/>
        public ProductDescriptionData DescriptionData
        {
            get
            {
                return this.descriptionDataField;
            }
            set
            {
                this.descriptionDataField = value;
            }
        }

        /// <remarks/>
        public ProductPromoTag PromoTag
        {
            get
            {
                return this.promoTagField;
            }
            set
            {
                this.promoTagField = value;
            }
        }

        /// <remarks/>
        public ProductDiscoveryData DiscoveryData
        {
            get
            {
                return this.discoveryDataField;
            }
            set
            {
                this.discoveryDataField = value;
            }
        }

        /// <remarks/>
        public ProductProductData ProductData
        {
            get
            {
                return this.productDataField;
            }
            set
            {
                this.productDataField = value;
            }
        }

        /// <remarks/>
        public bool ShippedByFreight
        {
            get
            {
                return this.shippedByFreightField;
            }
            set
            {
                this.shippedByFreightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippedByFreightSpecified
        {
            get
            {
                return this.shippedByFreightFieldSpecified;
            }
            set
            {
                this.shippedByFreightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnhancedImageURL", DataType = "anyURI")]
        public string[] EnhancedImageURL
        {
            get
            {
                return this.enhancedImageURLField;
            }
            set
            {
                this.enhancedImageURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Amazon-Vendor-Only")]
        public AmazonVendorOnly AmazonVendorOnly
        {
            get
            {
                return this.amazonVendorOnlyField;
            }
            set
            {
                this.amazonVendorOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Amazon-Only")]
        public AmazonOnly AmazonOnly
        {
            get
            {
                return this.amazonOnlyField;
            }
            set
            {
                this.amazonOnlyField = value;
            }
        }

        /// <remarks/>
        public ProductRegisteredParameter RegisteredParameter
        {
            get
            {
                return this.registeredParameterField;
            }
            set
            {
                this.registeredParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegisteredParameterSpecified
        {
            get
            {
                return this.registeredParameterFieldSpecified;
            }
            set
            {
                this.registeredParameterFieldSpecified = value;
            }
        }
    }
}