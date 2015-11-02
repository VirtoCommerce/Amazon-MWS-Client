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
    public partial class ProductDescriptionData
    {

        private string titleField;

        private string brandField;

        private string designerField;

        private string descriptionField;

        private string[] bulletPointField;

        private Dimensions itemDimensionsField;

        private Dimensions packageDimensionsField;

        private PositiveWeightDimension packageWeightField;

        private PositiveWeightDimension shippingWeightField;

        private string merchantCatalogNumberField;

        private CurrencyAmount mSRPField;

        private CurrencyAmount mSRPWithTaxField;

        private string maxOrderQuantityField;

        private bool serialNumberRequiredField;

        private bool serialNumberRequiredFieldSpecified;

        private bool prop65Field;

        private bool prop65FieldSpecified;

        private ProductDescriptionDataCPSIAWarning[] cPSIAWarningField;

        private string cPSIAWarningDescriptionField;

        private string legalDisclaimerField;

        private string manufacturerField;

        private string mfrPartNumberField;

        private string[] searchTermsField;

        private string[] platinumKeywordsField;

        private bool memorabiliaField;

        private bool memorabiliaFieldSpecified;

        private bool autographedField;

        private bool autographedFieldSpecified;

        private string[] usedForField;

        private string itemTypeField;

        private string[] otherItemAttributesField;

        private string[] targetAudienceField;

        private string[] subjectContentField;

        private bool isGiftWrapAvailableField;

        private bool isGiftWrapAvailableFieldSpecified;

        private bool isGiftMessageAvailableField;

        private bool isGiftMessageAvailableFieldSpecified;

        private string[] promotionKeywordsField;

        private bool isDiscontinuedByManufacturerField;

        private bool isDiscontinuedByManufacturerFieldSpecified;

        private string deliveryScheduleGroupIDField;

        private DeliveryChannel[] deliveryChannelField;

        private ProductDescriptionDataPurchasingChannel[] purchasingChannelField;

        private string maxAggregateShipQuantityField;

        private bool isCustomizableField;

        private bool isCustomizableFieldSpecified;

        private string customizableTemplateNameField;

        private string[] recommendedBrowseNodeField;

        private string merchantShippingGroupNameField;

        private string fEDAS_IDField;

        private ProductDescriptionDataTSDAgeWarning tSDAgeWarningField;

        private bool tSDAgeWarningFieldSpecified;

        private ProductDescriptionDataTSDWarning[] tSDWarningField;

        private ProductDescriptionDataTSDLanguage[] tSDLanguageField;

        private ProductDescriptionDataOptionalPaymentTypeExclusion[] optionalPaymentTypeExclusionField;

        private DistributionDesignationValues distributionDesignationField;

        private bool distributionDesignationFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Designer
        {
            get
            {
                return this.designerField;
            }
            set
            {
                this.designerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BulletPoint", DataType = "normalizedString")]
        public string[] BulletPoint
        {
            get
            {
                return this.bulletPointField;
            }
            set
            {
                this.bulletPointField = value;
            }
        }

        /// <remarks/>
        public Dimensions ItemDimensions
        {
            get
            {
                return this.itemDimensionsField;
            }
            set
            {
                this.itemDimensionsField = value;
            }
        }

        /// <remarks/>
        public Dimensions PackageDimensions
        {
            get
            {
                return this.packageDimensionsField;
            }
            set
            {
                this.packageDimensionsField = value;
            }
        }

        /// <remarks/>
        public PositiveWeightDimension PackageWeight
        {
            get
            {
                return this.packageWeightField;
            }
            set
            {
                this.packageWeightField = value;
            }
        }

        /// <remarks/>
        public PositiveWeightDimension ShippingWeight
        {
            get
            {
                return this.shippingWeightField;
            }
            set
            {
                this.shippingWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MerchantCatalogNumber
        {
            get
            {
                return this.merchantCatalogNumberField;
            }
            set
            {
                this.merchantCatalogNumberField = value;
            }
        }

        /// <remarks/>
        public CurrencyAmount MSRP
        {
            get
            {
                return this.mSRPField;
            }
            set
            {
                this.mSRPField = value;
            }
        }

        /// <remarks/>
        public CurrencyAmount MSRPWithTax
        {
            get
            {
                return this.mSRPWithTaxField;
            }
            set
            {
                this.mSRPWithTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaxOrderQuantity
        {
            get
            {
                return this.maxOrderQuantityField;
            }
            set
            {
                this.maxOrderQuantityField = value;
            }
        }

        /// <remarks/>
        public bool SerialNumberRequired
        {
            get
            {
                return this.serialNumberRequiredField;
            }
            set
            {
                this.serialNumberRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialNumberRequiredSpecified
        {
            get
            {
                return this.serialNumberRequiredFieldSpecified;
            }
            set
            {
                this.serialNumberRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool Prop65
        {
            get
            {
                return this.prop65Field;
            }
            set
            {
                this.prop65Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Prop65Specified
        {
            get
            {
                return this.prop65FieldSpecified;
            }
            set
            {
                this.prop65FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CPSIAWarning")]
        public ProductDescriptionDataCPSIAWarning[] CPSIAWarning
        {
            get
            {
                return this.cPSIAWarningField;
            }
            set
            {
                this.cPSIAWarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CPSIAWarningDescription
        {
            get
            {
                return this.cPSIAWarningDescriptionField;
            }
            set
            {
                this.cPSIAWarningDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string LegalDisclaimer
        {
            get
            {
                return this.legalDisclaimerField;
            }
            set
            {
                this.legalDisclaimerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MfrPartNumber
        {
            get
            {
                return this.mfrPartNumberField;
            }
            set
            {
                this.mfrPartNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchTerms", DataType = "normalizedString")]
        public string[] SearchTerms
        {
            get
            {
                return this.searchTermsField;
            }
            set
            {
                this.searchTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlatinumKeywords", DataType = "normalizedString")]
        public string[] PlatinumKeywords
        {
            get
            {
                return this.platinumKeywordsField;
            }
            set
            {
                this.platinumKeywordsField = value;
            }
        }

        /// <remarks/>
        public bool Memorabilia
        {
            get
            {
                return this.memorabiliaField;
            }
            set
            {
                this.memorabiliaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MemorabiliaSpecified
        {
            get
            {
                return this.memorabiliaFieldSpecified;
            }
            set
            {
                this.memorabiliaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool Autographed
        {
            get
            {
                return this.autographedField;
            }
            set
            {
                this.autographedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutographedSpecified
        {
            get
            {
                return this.autographedFieldSpecified;
            }
            set
            {
                this.autographedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedFor", DataType = "normalizedString")]
        public string[] UsedFor
        {
            get
            {
                return this.usedForField;
            }
            set
            {
                this.usedForField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ItemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherItemAttributes", DataType = "normalizedString")]
        public string[] OtherItemAttributes
        {
            get
            {
                return this.otherItemAttributesField;
            }
            set
            {
                this.otherItemAttributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TargetAudience", DataType = "normalizedString")]
        public string[] TargetAudience
        {
            get
            {
                return this.targetAudienceField;
            }
            set
            {
                this.targetAudienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectContent", DataType = "normalizedString")]
        public string[] SubjectContent
        {
            get
            {
                return this.subjectContentField;
            }
            set
            {
                this.subjectContentField = value;
            }
        }

        /// <remarks/>
        public bool IsGiftWrapAvailable
        {
            get
            {
                return this.isGiftWrapAvailableField;
            }
            set
            {
                this.isGiftWrapAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsGiftWrapAvailableSpecified
        {
            get
            {
                return this.isGiftWrapAvailableFieldSpecified;
            }
            set
            {
                this.isGiftWrapAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsGiftMessageAvailable
        {
            get
            {
                return this.isGiftMessageAvailableField;
            }
            set
            {
                this.isGiftMessageAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsGiftMessageAvailableSpecified
        {
            get
            {
                return this.isGiftMessageAvailableFieldSpecified;
            }
            set
            {
                this.isGiftMessageAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionKeywords", DataType = "normalizedString")]
        public string[] PromotionKeywords
        {
            get
            {
                return this.promotionKeywordsField;
            }
            set
            {
                this.promotionKeywordsField = value;
            }
        }

        /// <remarks/>
        public bool IsDiscontinuedByManufacturer
        {
            get
            {
                return this.isDiscontinuedByManufacturerField;
            }
            set
            {
                this.isDiscontinuedByManufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDiscontinuedByManufacturerSpecified
        {
            get
            {
                return this.isDiscontinuedByManufacturerFieldSpecified;
            }
            set
            {
                this.isDiscontinuedByManufacturerFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string DeliveryScheduleGroupID
        {
            get
            {
                return this.deliveryScheduleGroupIDField;
            }
            set
            {
                this.deliveryScheduleGroupIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryChannel")]
        public DeliveryChannel[] DeliveryChannel
        {
            get
            {
                return this.deliveryChannelField;
            }
            set
            {
                this.deliveryChannelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PurchasingChannel")]
        public ProductDescriptionDataPurchasingChannel[] PurchasingChannel
        {
            get
            {
                return this.purchasingChannelField;
            }
            set
            {
                this.purchasingChannelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaxAggregateShipQuantity
        {
            get
            {
                return this.maxAggregateShipQuantityField;
            }
            set
            {
                this.maxAggregateShipQuantityField = value;
            }
        }

        /// <remarks/>
        public bool IsCustomizable
        {
            get
            {
                return this.isCustomizableField;
            }
            set
            {
                this.isCustomizableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCustomizableSpecified
        {
            get
            {
                return this.isCustomizableFieldSpecified;
            }
            set
            {
                this.isCustomizableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CustomizableTemplateName
        {
            get
            {
                return this.customizableTemplateNameField;
            }
            set
            {
                this.customizableTemplateNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecommendedBrowseNode", DataType = "positiveInteger")]
        public string[] RecommendedBrowseNode
        {
            get
            {
                return this.recommendedBrowseNodeField;
            }
            set
            {
                this.recommendedBrowseNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MerchantShippingGroupName
        {
            get
            {
                return this.merchantShippingGroupNameField;
            }
            set
            {
                this.merchantShippingGroupNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FEDAS_ID
        {
            get
            {
                return this.fEDAS_IDField;
            }
            set
            {
                this.fEDAS_IDField = value;
            }
        }

        /// <remarks/>
        public ProductDescriptionDataTSDAgeWarning TSDAgeWarning
        {
            get
            {
                return this.tSDAgeWarningField;
            }
            set
            {
                this.tSDAgeWarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TSDAgeWarningSpecified
        {
            get
            {
                return this.tSDAgeWarningFieldSpecified;
            }
            set
            {
                this.tSDAgeWarningFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TSDWarning")]
        public ProductDescriptionDataTSDWarning[] TSDWarning
        {
            get
            {
                return this.tSDWarningField;
            }
            set
            {
                this.tSDWarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TSDLanguage")]
        public ProductDescriptionDataTSDLanguage[] TSDLanguage
        {
            get
            {
                return this.tSDLanguageField;
            }
            set
            {
                this.tSDLanguageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OptionalPaymentTypeExclusion")]
        public ProductDescriptionDataOptionalPaymentTypeExclusion[] OptionalPaymentTypeExclusion
        {
            get
            {
                return this.optionalPaymentTypeExclusionField;
            }
            set
            {
                this.optionalPaymentTypeExclusionField = value;
            }
        }

        /// <remarks/>
        public DistributionDesignationValues DistributionDesignation
        {
            get
            {
                return this.distributionDesignationField;
            }
            set
            {
                this.distributionDesignationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistributionDesignationSpecified
        {
            get
            {
                return this.distributionDesignationFieldSpecified;
            }
            set
            {
                this.distributionDesignationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    public enum DistributionDesignationValues
    {

        /// <remarks/>
        jp_parallel_import,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductDescriptionDataCPSIAWarning
    {

        /// <remarks/>
        choking_hazard_balloon,

        /// <remarks/>
        choking_hazard_contains_a_marble,

        /// <remarks/>
        choking_hazard_contains_small_ball,

        /// <remarks/>
        choking_hazard_is_a_marble,

        /// <remarks/>
        choking_hazard_is_a_small_ball,

        /// <remarks/>
        choking_hazard_small_parts,

        /// <remarks/>
        no_warning_applicable,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductDescriptionDataPurchasingChannel
    {

        /// <remarks/>
        in_store,

        /// <remarks/>
        online,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductDescriptionDataTSDAgeWarning
    {

        /// <remarks/>
        not_suitable_under_36_months,

        /// <remarks/>
        not_suitable_under_3_years_supervision,

        /// <remarks/>
        not_suitable_under_4_years_supervision,

        /// <remarks/>
        not_suitable_under_5_years_supervision,

        /// <remarks/>
        not_suitable_under_6_years_supervision,

        /// <remarks/>
        not_suitable_under_7_years_supervision,

        /// <remarks/>
        not_suitable_under_8_years_supervision,

        /// <remarks/>
        not_suitable_under_9_years_supervision,

        /// <remarks/>
        not_suitable_under_10_years_supervision,

        /// <remarks/>
        not_suitable_under_11_years_supervision,

        /// <remarks/>
        not_suitable_under_12_years_supervision,

        /// <remarks/>
        not_suitable_under_13_years_supervision,

        /// <remarks/>
        not_suitable_under_14_years_supervision,

        /// <remarks/>
        no_warning_applicable,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductDescriptionDataTSDWarning
    {

        /// <remarks/>
        only_domestic_use,

        /// <remarks/>
        adult_supervision_required,

        /// <remarks/>
        protective_equipment_required,

        /// <remarks/>
        water_adult_supervision_required,

        /// <remarks/>
        toy_inside,

        /// <remarks/>
        no_protective_equipment,

        /// <remarks/>
        risk_of_entanglement,

        /// <remarks/>
        fragrances_allergy_risk,

        /// <remarks/>
        no_warning_applicable,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductDescriptionDataTSDLanguage
    {

        /// <remarks/>
        English,

        /// <remarks/>
        French,

        /// <remarks/>
        German,

        /// <remarks/>
        Italian,

        /// <remarks/>
        Spanish,

        /// <remarks/>
        Dutch,

        /// <remarks/>
        Polish,

        /// <remarks/>
        Bulgarian,

        /// <remarks/>
        Czech,

        /// <remarks/>
        Danish,

        /// <remarks/>
        Estonian,

        /// <remarks/>
        Finnish,

        /// <remarks/>
        Greek,

        /// <remarks/>
        Hungarian,

        /// <remarks/>
        Latvian,

        /// <remarks/>
        Lithuanian,

        /// <remarks/>
        Portuguese,

        /// <remarks/>
        Romanian,

        /// <remarks/>
        Slovak,

        /// <remarks/>
        Slovene,

        /// <remarks/>
        Swedish,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProductDescriptionDataOptionalPaymentTypeExclusion
    {

        /// <remarks/>
        cash_on_delivery,

        /// <remarks/>
        cvs,

        /// <remarks/>
        exclude_none,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exclude cod")]
        excludecod,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exclude cvs")]
        excludecvs,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("exclude cod and cvs")]
        excludecodandcvs,
    }
}