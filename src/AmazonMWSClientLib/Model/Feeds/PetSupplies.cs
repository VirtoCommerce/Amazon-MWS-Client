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
    public partial class PetSupplies
    {

        private PetSuppliesProductType productTypeField;

        /// <remarks/>
        public PetSuppliesProductType ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PetSuppliesProductType
    {

        private PetSuppliesMisc itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PetSuppliesMisc")]
        public PetSuppliesMisc Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PetSuppliesMisc
    {

        private PetSuppliesMiscVariationData variationDataField;

        private AllergenInformationType[] allergenInformationField;

        private Battery batteryField;

        private BatteryLifeDimension batteryAverageLifeField;

        private BatteryLifeDimension batteryAverageLifeStandbyField;

        private BatteryPowerDimension batteryCapacityField;

        private BatteryCellTypeValues batteryCellCompositionField;

        private bool batteryCellCompositionFieldSpecified;

        private TimeDimension batteryChargeTimeField;

        private string batteryFormFactorField;

        private BatteryPowerIntegerDimension batteryPowerField;

        private string breedRecommendationField;

        private TimeIntegerDimension bulbLifeSpanField;

        private string[] careInstructionsField;

        private string closureTypeField;

        private string[] compatibleDevicesField;

        private bool containsFoodOrBeverageField;

        private bool containsFoodOrBeverageFieldSpecified;

        private string countryOfOriginField;

        private PetSuppliesMiscColorSpecification colorSpecificationField;

        private string directionsField;

        private LengthDimension displayLengthField;

        private VolumeDimension displayVolumeField;

        private WeightDimension displayWeightField;

        private string dogSizeField;

        private string energyEfficiencyRatingField;

        private string eUEnergyLabelEfficiencyClassField;

        private string[] externalCertificationField;

        private string fillMaterialTypeField;

        private string flavorField;

        private GirthSizeType girthSizeField;

        private HeightRecommendationType heightRecommendationField;

        private string[] healthBenefitsField;

        private string[] includedComponentsField;

        private bool includesAcAdapterField;

        private bool includesAcAdapterFieldSpecified;

        private bool includesRemoteField;

        private bool includesRemoteFieldSpecified;

        private string ingredientsField;

        private string innerMaterialTypeField;

        private bool isExpirationDatedProductField;

        private bool isExpirationDatedProductFieldSpecified;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private LengthDimension itemDiameterField;

        private LengthDimension itemDisplayDiameterField;

        private LengthDimension itemDisplayHeightField;

        private LengthDimension itemDisplayWidthField;

        private string itemFormField;

        private LengthDimension itemThicknessField;

        private string itemPackageQuantityField;

        private LuminancePositiveIntegerDimension lightOutputLuminanceField;

        private decimal lithiumBatteryEnergyContentField;

        private bool lithiumBatteryEnergyContentFieldSpecified;

        private PetSuppliesMiscLithiumBatteryPackaging lithiumBatteryPackagingField;

        private bool lithiumBatteryPackagingFieldSpecified;

        private decimal lithiumBatteryVoltageField;

        private bool lithiumBatteryVoltageFieldSpecified;

        private decimal lithiumBatteryWeightField;

        private bool lithiumBatteryWeightFieldSpecified;

        private string materialField;

        private string[] materialCompositionField;

        private string maxOrderingQuantityField;

        private string maximumAgeRecommendationField;

        private PetPowerDimension maximumPowerField;

        private string mfgWarrantyDescriptionLaborField;

        private string mfgWarrantyDescriptionPartsField;

        private string mfgWarrantyDescriptionTypeField;

        private string minimumAgeRecommendationField;

        private NeckSizeType neckSizeField;

        private string numberOfItemsField;

        private string numberOfLithiumIonCellsField;

        private string numberOfLithiumMetalCellsField;

        private string nutritionFactsField;

        private string outerMaterialTypeField;

        private string patternNameField;

        private string petLifeStageField;

        private string[] petTypeField;

        private string powerSourceTypeField;

        private string productFeatureField;

        private System.DateTime productSampleReceivedDateField;

        private bool productSampleReceivedDateFieldSpecified;

        private string recommendedUsesForProductField;

        private decimal recycledContentPercentageField;

        private bool recycledContentPercentageFieldSpecified;

        private string sellerWarrantyDescriptionField;

        private string scentNameField;

        private string sizeField;

        private string sizeMapField;

        private string[] specialFeaturesField;

        private string specificationMetField;

        private string storageInstructionsField;

        private VolumeDimension tankSizeField;

        private TargetGenderType targetGenderField;

        private bool targetGenderFieldSpecified;

        private string voltageField;

        private VolumeDimension volumeField;

        private string warningsField;

        private string wattageField;

        private WeightRecommendationType weightRecommendationField;

        private WidthSizeType widthSizeField;

        private string modelNameField;

        private string materialFeaturesField;

        public PetSuppliesMisc()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public PetSuppliesMiscVariationData VariationData
        {
            get
            {
                return this.variationDataField;
            }
            set
            {
                this.variationDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllergenInformation")]
        public AllergenInformationType[] AllergenInformation
        {
            get
            {
                return this.allergenInformationField;
            }
            set
            {
                this.allergenInformationField = value;
            }
        }

        /// <remarks/>
        public Battery Battery
        {
            get
            {
                return this.batteryField;
            }
            set
            {
                this.batteryField = value;
            }
        }

        /// <remarks/>
        public BatteryLifeDimension BatteryAverageLife
        {
            get
            {
                return this.batteryAverageLifeField;
            }
            set
            {
                this.batteryAverageLifeField = value;
            }
        }

        /// <remarks/>
        public BatteryLifeDimension BatteryAverageLifeStandby
        {
            get
            {
                return this.batteryAverageLifeStandbyField;
            }
            set
            {
                this.batteryAverageLifeStandbyField = value;
            }
        }

        /// <remarks/>
        public BatteryPowerDimension BatteryCapacity
        {
            get
            {
                return this.batteryCapacityField;
            }
            set
            {
                this.batteryCapacityField = value;
            }
        }

        /// <remarks/>
        public BatteryCellTypeValues BatteryCellComposition
        {
            get
            {
                return this.batteryCellCompositionField;
            }
            set
            {
                this.batteryCellCompositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryCellCompositionSpecified
        {
            get
            {
                return this.batteryCellCompositionFieldSpecified;
            }
            set
            {
                this.batteryCellCompositionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TimeDimension BatteryChargeTime
        {
            get
            {
                return this.batteryChargeTimeField;
            }
            set
            {
                this.batteryChargeTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string BatteryFormFactor
        {
            get
            {
                return this.batteryFormFactorField;
            }
            set
            {
                this.batteryFormFactorField = value;
            }
        }

        /// <remarks/>
        public BatteryPowerIntegerDimension BatteryPower
        {
            get
            {
                return this.batteryPowerField;
            }
            set
            {
                this.batteryPowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string BreedRecommendation
        {
            get
            {
                return this.breedRecommendationField;
            }
            set
            {
                this.breedRecommendationField = value;
            }
        }

        /// <remarks/>
        public TimeIntegerDimension BulbLifeSpan
        {
            get
            {
                return this.bulbLifeSpanField;
            }
            set
            {
                this.bulbLifeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CareInstructions", DataType = "normalizedString")]
        public string[] CareInstructions
        {
            get
            {
                return this.careInstructionsField;
            }
            set
            {
                this.careInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ClosureType
        {
            get
            {
                return this.closureTypeField;
            }
            set
            {
                this.closureTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompatibleDevices", DataType = "normalizedString")]
        public string[] CompatibleDevices
        {
            get
            {
                return this.compatibleDevicesField;
            }
            set
            {
                this.compatibleDevicesField = value;
            }
        }

        /// <remarks/>
        public bool ContainsFoodOrBeverage
        {
            get
            {
                return this.containsFoodOrBeverageField;
            }
            set
            {
                this.containsFoodOrBeverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContainsFoodOrBeverageSpecified
        {
            get
            {
                return this.containsFoodOrBeverageFieldSpecified;
            }
            set
            {
                this.containsFoodOrBeverageFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CountryOfOrigin
        {
            get
            {
                return this.countryOfOriginField;
            }
            set
            {
                this.countryOfOriginField = value;
            }
        }

        /// <remarks/>
        public PetSuppliesMiscColorSpecification ColorSpecification
        {
            get
            {
                return this.colorSpecificationField;
            }
            set
            {
                this.colorSpecificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Directions
        {
            get
            {
                return this.directionsField;
            }
            set
            {
                this.directionsField = value;
            }
        }

        /// <remarks/>
        public LengthDimension DisplayLength
        {
            get
            {
                return this.displayLengthField;
            }
            set
            {
                this.displayLengthField = value;
            }
        }

        /// <remarks/>
        public VolumeDimension DisplayVolume
        {
            get
            {
                return this.displayVolumeField;
            }
            set
            {
                this.displayVolumeField = value;
            }
        }

        /// <remarks/>
        public WeightDimension DisplayWeight
        {
            get
            {
                return this.displayWeightField;
            }
            set
            {
                this.displayWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string DogSize
        {
            get
            {
                return this.dogSizeField;
            }
            set
            {
                this.dogSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string EnergyEfficiencyRating
        {
            get
            {
                return this.energyEfficiencyRatingField;
            }
            set
            {
                this.energyEfficiencyRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string EUEnergyLabelEfficiencyClass
        {
            get
            {
                return this.eUEnergyLabelEfficiencyClassField;
            }
            set
            {
                this.eUEnergyLabelEfficiencyClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalCertification", DataType = "normalizedString")]
        public string[] ExternalCertification
        {
            get
            {
                return this.externalCertificationField;
            }
            set
            {
                this.externalCertificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FillMaterialType
        {
            get
            {
                return this.fillMaterialTypeField;
            }
            set
            {
                this.fillMaterialTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Flavor
        {
            get
            {
                return this.flavorField;
            }
            set
            {
                this.flavorField = value;
            }
        }

        /// <remarks/>
        public GirthSizeType GirthSize
        {
            get
            {
                return this.girthSizeField;
            }
            set
            {
                this.girthSizeField = value;
            }
        }

        /// <remarks/>
        public HeightRecommendationType HeightRecommendation
        {
            get
            {
                return this.heightRecommendationField;
            }
            set
            {
                this.heightRecommendationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HealthBenefits", DataType = "normalizedString")]
        public string[] HealthBenefits
        {
            get
            {
                return this.healthBenefitsField;
            }
            set
            {
                this.healthBenefitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncludedComponents", DataType = "normalizedString")]
        public string[] IncludedComponents
        {
            get
            {
                return this.includedComponentsField;
            }
            set
            {
                this.includedComponentsField = value;
            }
        }

        /// <remarks/>
        public bool IncludesAcAdapter
        {
            get
            {
                return this.includesAcAdapterField;
            }
            set
            {
                this.includesAcAdapterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludesAcAdapterSpecified
        {
            get
            {
                return this.includesAcAdapterFieldSpecified;
            }
            set
            {
                this.includesAcAdapterFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IncludesRemote
        {
            get
            {
                return this.includesRemoteField;
            }
            set
            {
                this.includesRemoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludesRemoteSpecified
        {
            get
            {
                return this.includesRemoteFieldSpecified;
            }
            set
            {
                this.includesRemoteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Ingredients
        {
            get
            {
                return this.ingredientsField;
            }
            set
            {
                this.ingredientsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string InnerMaterialType
        {
            get
            {
                return this.innerMaterialTypeField;
            }
            set
            {
                this.innerMaterialTypeField = value;
            }
        }

        /// <remarks/>
        public bool IsExpirationDatedProduct
        {
            get
            {
                return this.isExpirationDatedProductField;
            }
            set
            {
                this.isExpirationDatedProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsExpirationDatedProductSpecified
        {
            get
            {
                return this.isExpirationDatedProductFieldSpecified;
            }
            set
            {
                this.isExpirationDatedProductFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsAssemblyRequired
        {
            get
            {
                return this.isAssemblyRequiredField;
            }
            set
            {
                this.isAssemblyRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAssemblyRequiredSpecified
        {
            get
            {
                return this.isAssemblyRequiredFieldSpecified;
            }
            set
            {
                this.isAssemblyRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsPortable
        {
            get
            {
                return this.isPortableField;
            }
            set
            {
                this.isPortableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPortableSpecified
        {
            get
            {
                return this.isPortableFieldSpecified;
            }
            set
            {
                this.isPortableFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LengthDimension ItemDiameter
        {
            get
            {
                return this.itemDiameterField;
            }
            set
            {
                this.itemDiameterField = value;
            }
        }

        /// <remarks/>
        public LengthDimension ItemDisplayDiameter
        {
            get
            {
                return this.itemDisplayDiameterField;
            }
            set
            {
                this.itemDisplayDiameterField = value;
            }
        }

        /// <remarks/>
        public LengthDimension ItemDisplayHeight
        {
            get
            {
                return this.itemDisplayHeightField;
            }
            set
            {
                this.itemDisplayHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension ItemDisplayWidth
        {
            get
            {
                return this.itemDisplayWidthField;
            }
            set
            {
                this.itemDisplayWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ItemForm
        {
            get
            {
                return this.itemFormField;
            }
            set
            {
                this.itemFormField = value;
            }
        }

        /// <remarks/>
        public LengthDimension ItemThickness
        {
            get
            {
                return this.itemThicknessField;
            }
            set
            {
                this.itemThicknessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
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
        public LuminancePositiveIntegerDimension LightOutputLuminance
        {
            get
            {
                return this.lightOutputLuminanceField;
            }
            set
            {
                this.lightOutputLuminanceField = value;
            }
        }

        /// <remarks/>
        public decimal LithiumBatteryEnergyContent
        {
            get
            {
                return this.lithiumBatteryEnergyContentField;
            }
            set
            {
                this.lithiumBatteryEnergyContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryEnergyContentSpecified
        {
            get
            {
                return this.lithiumBatteryEnergyContentFieldSpecified;
            }
            set
            {
                this.lithiumBatteryEnergyContentFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PetSuppliesMiscLithiumBatteryPackaging LithiumBatteryPackaging
        {
            get
            {
                return this.lithiumBatteryPackagingField;
            }
            set
            {
                this.lithiumBatteryPackagingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryPackagingSpecified
        {
            get
            {
                return this.lithiumBatteryPackagingFieldSpecified;
            }
            set
            {
                this.lithiumBatteryPackagingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal LithiumBatteryVoltage
        {
            get
            {
                return this.lithiumBatteryVoltageField;
            }
            set
            {
                this.lithiumBatteryVoltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryVoltageSpecified
        {
            get
            {
                return this.lithiumBatteryVoltageFieldSpecified;
            }
            set
            {
                this.lithiumBatteryVoltageFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal LithiumBatteryWeight
        {
            get
            {
                return this.lithiumBatteryWeightField;
            }
            set
            {
                this.lithiumBatteryWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LithiumBatteryWeightSpecified
        {
            get
            {
                return this.lithiumBatteryWeightFieldSpecified;
            }
            set
            {
                this.lithiumBatteryWeightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialComposition", DataType = "normalizedString")]
        public string[] MaterialComposition
        {
            get
            {
                return this.materialCompositionField;
            }
            set
            {
                this.materialCompositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaxOrderingQuantity
        {
            get
            {
                return this.maxOrderingQuantityField;
            }
            set
            {
                this.maxOrderingQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MaximumAgeRecommendation
        {
            get
            {
                return this.maximumAgeRecommendationField;
            }
            set
            {
                this.maximumAgeRecommendationField = value;
            }
        }

        /// <remarks/>
        public PetPowerDimension MaximumPower
        {
            get
            {
                return this.maximumPowerField;
            }
            set
            {
                this.maximumPowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MfgWarrantyDescriptionLabor
        {
            get
            {
                return this.mfgWarrantyDescriptionLaborField;
            }
            set
            {
                this.mfgWarrantyDescriptionLaborField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MfgWarrantyDescriptionParts
        {
            get
            {
                return this.mfgWarrantyDescriptionPartsField;
            }
            set
            {
                this.mfgWarrantyDescriptionPartsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MfgWarrantyDescriptionType
        {
            get
            {
                return this.mfgWarrantyDescriptionTypeField;
            }
            set
            {
                this.mfgWarrantyDescriptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MinimumAgeRecommendation
        {
            get
            {
                return this.minimumAgeRecommendationField;
            }
            set
            {
                this.minimumAgeRecommendationField = value;
            }
        }

        /// <remarks/>
        public NeckSizeType NeckSize
        {
            get
            {
                return this.neckSizeField;
            }
            set
            {
                this.neckSizeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfLithiumIonCells
        {
            get
            {
                return this.numberOfLithiumIonCellsField;
            }
            set
            {
                this.numberOfLithiumIonCellsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfLithiumMetalCells
        {
            get
            {
                return this.numberOfLithiumMetalCellsField;
            }
            set
            {
                this.numberOfLithiumMetalCellsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string NutritionFacts
        {
            get
            {
                return this.nutritionFactsField;
            }
            set
            {
                this.nutritionFactsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OuterMaterialType
        {
            get
            {
                return this.outerMaterialTypeField;
            }
            set
            {
                this.outerMaterialTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PatternName
        {
            get
            {
                return this.patternNameField;
            }
            set
            {
                this.patternNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PetLifeStage
        {
            get
            {
                return this.petLifeStageField;
            }
            set
            {
                this.petLifeStageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PetType", DataType = "normalizedString")]
        public string[] PetType
        {
            get
            {
                return this.petTypeField;
            }
            set
            {
                this.petTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PowerSourceType
        {
            get
            {
                return this.powerSourceTypeField;
            }
            set
            {
                this.powerSourceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ProductFeature
        {
            get
            {
                return this.productFeatureField;
            }
            set
            {
                this.productFeatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ProductSampleReceivedDate
        {
            get
            {
                return this.productSampleReceivedDateField;
            }
            set
            {
                this.productSampleReceivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductSampleReceivedDateSpecified
        {
            get
            {
                return this.productSampleReceivedDateFieldSpecified;
            }
            set
            {
                this.productSampleReceivedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string RecommendedUsesForProduct
        {
            get
            {
                return this.recommendedUsesForProductField;
            }
            set
            {
                this.recommendedUsesForProductField = value;
            }
        }

        /// <remarks/>
        public decimal RecycledContentPercentage
        {
            get
            {
                return this.recycledContentPercentageField;
            }
            set
            {
                this.recycledContentPercentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecycledContentPercentageSpecified
        {
            get
            {
                return this.recycledContentPercentageFieldSpecified;
            }
            set
            {
                this.recycledContentPercentageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SellerWarrantyDescription
        {
            get
            {
                return this.sellerWarrantyDescriptionField;
            }
            set
            {
                this.sellerWarrantyDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ScentName
        {
            get
            {
                return this.scentNameField;
            }
            set
            {
                this.scentNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SizeMap
        {
            get
            {
                return this.sizeMapField;
            }
            set
            {
                this.sizeMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialFeatures", DataType = "normalizedString")]
        public string[] SpecialFeatures
        {
            get
            {
                return this.specialFeaturesField;
            }
            set
            {
                this.specialFeaturesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SpecificationMet
        {
            get
            {
                return this.specificationMetField;
            }
            set
            {
                this.specificationMetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string StorageInstructions
        {
            get
            {
                return this.storageInstructionsField;
            }
            set
            {
                this.storageInstructionsField = value;
            }
        }

        /// <remarks/>
        public VolumeDimension TankSize
        {
            get
            {
                return this.tankSizeField;
            }
            set
            {
                this.tankSizeField = value;
            }
        }

        /// <remarks/>
        public TargetGenderType TargetGender
        {
            get
            {
                return this.targetGenderField;
            }
            set
            {
                this.targetGenderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetGenderSpecified
        {
            get
            {
                return this.targetGenderFieldSpecified;
            }
            set
            {
                this.targetGenderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Voltage
        {
            get
            {
                return this.voltageField;
            }
            set
            {
                this.voltageField = value;
            }
        }

        /// <remarks/>
        public VolumeDimension Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string Wattage
        {
            get
            {
                return this.wattageField;
            }
            set
            {
                this.wattageField = value;
            }
        }

        /// <remarks/>
        public WeightRecommendationType WeightRecommendation
        {
            get
            {
                return this.weightRecommendationField;
            }
            set
            {
                this.weightRecommendationField = value;
            }
        }

        /// <remarks/>
        public WidthSizeType WidthSize
        {
            get
            {
                return this.widthSizeField;
            }
            set
            {
                this.widthSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MaterialFeatures
        {
            get
            {
                return this.materialFeaturesField;
            }
            set
            {
                this.materialFeaturesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PetSuppliesMiscVariationData
    {

        private PetSuppliesMiscVariationDataParentage parentageField;

        private PetSuppliesMiscVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public PetSuppliesMiscVariationDataParentage Parentage
        {
            get
            {
                return this.parentageField;
            }
            set
            {
                this.parentageField = value;
            }
        }

        /// <remarks/>
        public PetSuppliesMiscVariationDataVariationTheme VariationTheme
        {
            get
            {
                return this.variationThemeField;
            }
            set
            {
                this.variationThemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariationThemeSpecified
        {
            get
            {
                return this.variationThemeFieldSpecified;
            }
            set
            {
                this.variationThemeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum PetSuppliesMiscVariationDataParentage
    {

        /// <remarks/>
        parent,

        /// <remarks/>
        child,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum PetSuppliesMiscVariationDataVariationTheme
    {

        /// <remarks/>
        Color,

        /// <remarks/>
        Size,

        /// <remarks/>
        SizeColor,

        /// <remarks/>
        Flavor,

        /// <remarks/>
        FlavorSize,

        /// <remarks/>
        PatternName,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Color-PatternName")]
        ColorPatternName,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PatternName-Size")]
        PatternNameSize,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PatternName-Flavor")]
        PatternNameFlavor,

        /// <remarks/>
        Scent,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    public enum AllergenInformationType
    {

        /// <remarks/>
        abalone,

        /// <remarks/>
        abalone_free,

        /// <remarks/>
        amberjack,

        /// <remarks/>
        amberjack_free,

        /// <remarks/>
        apple,

        /// <remarks/>
        apple_free,

        /// <remarks/>
        banana,

        /// <remarks/>
        banana_free,

        /// <remarks/>
        barley,

        /// <remarks/>
        barley_free,

        /// <remarks/>
        beef,

        /// <remarks/>
        beef_free,

        /// <remarks/>
        buckwheat,

        /// <remarks/>
        buckwheat_free,

        /// <remarks/>
        celery,

        /// <remarks/>
        celery_free,

        /// <remarks/>
        chicken_meat,

        /// <remarks/>
        chicken_meat_free,

        /// <remarks/>
        codfish,

        /// <remarks/>
        codfish_free,

        /// <remarks/>
        crab,

        /// <remarks/>
        crab_free,

        /// <remarks/>
        dairy,

        /// <remarks/>
        dairy_free,

        /// <remarks/>
        eggs,

        /// <remarks/>
        egg_free,

        /// <remarks/>
        fish,

        /// <remarks/>
        fish_free,

        /// <remarks/>
        gelatin,

        /// <remarks/>
        gelatin_free,

        /// <remarks/>
        gluten,

        /// <remarks/>
        gluten_free,

        /// <remarks/>
        kiwi,

        /// <remarks/>
        kiwi_free,

        /// <remarks/>
        mackerel,

        /// <remarks/>
        mackerel_free,

        /// <remarks/>
        melon,

        /// <remarks/>
        melon_free,

        /// <remarks/>
        mushroom,

        /// <remarks/>
        mushroom_free,

        /// <remarks/>
        octopus,

        /// <remarks/>
        octopus_free,

        /// <remarks/>
        orange,

        /// <remarks/>
        orange_free,

        /// <remarks/>
        peach,

        /// <remarks/>
        peach_free,

        /// <remarks/>
        peanuts,

        /// <remarks/>
        peanut_free,

        /// <remarks/>
        pork,

        /// <remarks/>
        pork_free,

        /// <remarks/>
        salmon,

        /// <remarks/>
        salmon_free,

        /// <remarks/>
        salmon_roe,

        /// <remarks/>
        salmon_roe_free,

        /// <remarks/>
        scad,

        /// <remarks/>
        scad_free,

        /// <remarks/>
        scallop,

        /// <remarks/>
        scallop_free,

        /// <remarks/>
        sesame_seeds,

        /// <remarks/>
        sesame_seeds_free,

        /// <remarks/>
        shellfish,

        /// <remarks/>
        shellfish_free,

        /// <remarks/>
        shrimp,

        /// <remarks/>
        shrimp_free,

        /// <remarks/>
        soy,

        /// <remarks/>
        soy_free,

        /// <remarks/>
        squid,

        /// <remarks/>
        squid_free,

        /// <remarks/>
        tree_nuts,

        /// <remarks/>
        tree_nut_free,

        /// <remarks/>
        tuna,

        /// <remarks/>
        tuna_free,

        /// <remarks/>
        walnut,

        /// <remarks/>
        walnut_free,

        /// <remarks/>
        yam,

        /// <remarks/>
        yam_free,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PetSuppliesMiscColorSpecification
    {

        private string colorField;

        private string colorMapField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ColorMap
        {
            get
            {
                return this.colorMapField;
            }
            set
            {
                this.colorMapField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum PetSuppliesMiscLithiumBatteryPackaging
    {

        /// <remarks/>
        batteries_contained_in_equipment,

        /// <remarks/>
        batteries_only,

        /// <remarks/>
        batteries_packed_with_equipment,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    public enum TargetGenderType
    {

        /// <remarks/>
        male,

        /// <remarks/>
        female,

        /// <remarks/>
        unisex,
    }


}