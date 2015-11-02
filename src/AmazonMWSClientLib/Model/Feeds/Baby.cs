using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  AmazonMWSClientLib.Model.Feeds
{
    public partial class Baby
    {

        private BabyProductType productTypeField;

        /// <remarks/>
        public BabyProductType ProductType
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
    public partial class BabyProductType
    {

        private BabyProducts itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BabyProducts")]
        public BabyProducts Item
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
    public partial class BabyProducts
    {

        private string alertTypeField;

        private string assemblyInstructionsField;

        private AssemblyTimeDimension assemblyTimeField;

        private string awardsWonField;

        private string baseTypeField;

        private LengthDimension baseWidthField;

        private Battery batteryField;

        private BatteryLifeDimension batteryAverageLifeField;

        private BatteryLifeDimension batteryAverageLifeStandbyField;

        private TimeDimension batteryAverageLifeTalkTimeField;

        private BatteryPowerDimension batteryCapacityField;

        private BatteryCellTypeValues batteryCellCompositionField;

        private bool batteryCellCompositionFieldSpecified;

        private TimeDimension batteryChargeTimeField;

        private string batteryDescriptionField;

        private BatteryPowerIntegerDimension batteryPowerField;

        private string bottleNippleTypeField;

        private string bottleTypeField;

        private string[] careInstructionsField;

        private WeightDimension carrierWeightField;

        private CarSeatWeightGroupEUType[] carSeatWeightGroupEUField;

        private ClothingSizeDimension chestSizeField;

        private string colorMapField;

        private string colorNameField;

        private string communicationInterfaceField;

        private string compatibleDevicesField;

        private string controlTypeField;

        private string countryOfOriginField;

        private string cupSizeField;

        private string directionsField;

        private LengthDimension displaySizeField;

        private string displayTypeField;

        private string educationalValueField;

        private string fillMaterialTypeField;

        private string foldedSizeField;

        private ForwardFacingWeight forwardFacingWeightField;

        private string frequencyBandsSupportedField;

        private FrequencyDimension frequencyResponseField;

        private string furnitureFinishField;

        private LengthDimension handleHeightField;

        private string hardwareVisibilityField;

        private string harnessTypeField;

        private bool includesAcAdapterField;

        private bool includesAcAdapterFieldSpecified;

        private bool includesRemoteField;

        private bool includesRemoteFieldSpecified;

        private string ingredientsField;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private bool isDishwasherSafeField;

        private bool isDishwasherSafeFieldSpecified;

        private bool isPortableField;

        private bool isPortableFieldSpecified;

        private LengthDimension itemDepthField;

        private LengthDimension itemDiameterField;

        private VolumeDimension displayVolumeField;

        private WeightDimension displayWeightField;

        private LengthDimension displayLengthField;

        private LanguageStringType languageField;

        private bool languageFieldSpecified;

        private string[] lifestyleField;

        private EnergyConsumptionDimension lithiumBatteryEnergyContentField;

        private BabyProductsLithiumBatteryPackaging lithiumBatteryPackagingField;

        private bool lithiumBatteryPackagingFieldSpecified;

        private string manufacturerWarrantyDescriptionField;

        private string materialCompositionField;

        private string materialTypeField;

        private string[] materialTypeFreeField;

        private WeightDimension maximumAnchoringWeightCapacityField;

        private LengthDimension maximumHeightRecommendationField;

        private OptionalAgeRecommendedDimension maximumManufacturerAgeRecommendedField;

        private LengthDimension maximumItemWidthField;

        private LengthDimension maximumRangeIndoorsField;

        private LengthDimension maximumRangeOpenSpaceField;

        private PositiveWeightDimension maximumWeightRecommendationField;

        private string mfgWarrantyDescriptionLaborField;

        private string mfgWarrantyDescriptionPartsField;

        private string mfgWarrantyDescriptionTypeField;

        private LengthDimension minimumHeightRecommendationField;

        private OptionalAgeRecommendedDimension minimumManufacturerAgeRecommendedField;

        private PositiveWeightDimension minimumWeightRecommendationField;

        private string numberOfChannelsField;

        private string numberOfControlChannelsField;

        private string numberOfFrequencyChannelsField;

        private string numberOfHeightPositionsField;

        private string numberOfLithiumIonCellsField;

        private string numberOfLithiumMetalCellsField;

        private string numberOfPiecesField;

        private string numberOfPlayersField;

        private string numberOfPositionsField;

        private string operationModeField;

        private string orientationField;

        private BabyProductsVariationData variationDataField;

        private LengthDimension portableDisplaySizeField;

        private string powerSourceTypeField;

        private string railGaugeField;

        private string railTypeField;

        private WeightDimension rearFacingMaximumWeightField;

        private WeightDimension rearFacingMinimumWeightField;

        private string[] recommendedUsesForProductField;

        private string regionOfOriginField;

        private string remoteControlTechnologyField;

        private string safetyWarningField;

        private string scaleNameField;

        private LengthDimension seatBackInteriorHeightField;

        private LengthDimension seatHeightField;

        private LengthDimension seatInteriorWidthField;

        private LengthDimension seatLengthField;

        private LengthDimension seatWidthField;

        private string seatingCapacityField;

        private string sellerWarrantyDescriptionField;

        private string[] sensorTechnologyField;

        private LengthDimension shoulderHarnessMaximumHeightField;

        private LengthDimension shoulderHarnessMinimumHeightField;

        private string sizeMapField;

        private string sizeNameField;

        private string[] specialFeaturesField;

        private string[] specificUsesForProductField;

        private string specificationMetField;

        private string[] styleNameField;

        private string[] subjectCharacterField;

        private string suspensionTypeField;

        private TargetGenderType targetGenderField;

        private bool targetGenderFieldSpecified;

        private LengthDimension tireDiameterField;

        private string tireMaterialField;

        private LengthDimension totalTravelField;

        private string[] trayTypeField;

        private BabyProductsUnitCount unitCountField;

        private string warrantyDescriptionField;

        private string wheelTypeField;

        private string wirelessCommunicationTechnologyField;

        private string unknownSubjectField;

        private string engineTypeField;

        private string batteryTypeLithiumIonField;

        private string batteryTypeLithiumMetalField;

        private string lithiumBatteryVoltageField;

        private string lithiumBatteryWeightField;

        private DistributionDesignationValues distributionDesignationField;

        private bool distributionDesignationFieldSpecified;

        private string countryStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AlertType
        {
            get
            {
                return this.alertTypeField;
            }
            set
            {
                this.alertTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AssemblyInstructions
        {
            get
            {
                return this.assemblyInstructionsField;
            }
            set
            {
                this.assemblyInstructionsField = value;
            }
        }

        /// <remarks/>
        public AssemblyTimeDimension AssemblyTime
        {
            get
            {
                return this.assemblyTimeField;
            }
            set
            {
                this.assemblyTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string AwardsWon
        {
            get
            {
                return this.awardsWonField;
            }
            set
            {
                this.awardsWonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string BaseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }

        /// <remarks/>
        public LengthDimension BaseWidth
        {
            get
            {
                return this.baseWidthField;
            }
            set
            {
                this.baseWidthField = value;
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
        public TimeDimension BatteryAverageLifeTalkTime
        {
            get
            {
                return this.batteryAverageLifeTalkTimeField;
            }
            set
            {
                this.batteryAverageLifeTalkTimeField = value;
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
        public string BatteryDescription
        {
            get
            {
                return this.batteryDescriptionField;
            }
            set
            {
                this.batteryDescriptionField = value;
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
        public string BottleNippleType
        {
            get
            {
                return this.bottleNippleTypeField;
            }
            set
            {
                this.bottleNippleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string BottleType
        {
            get
            {
                return this.bottleTypeField;
            }
            set
            {
                this.bottleTypeField = value;
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
        public WeightDimension CarrierWeight
        {
            get
            {
                return this.carrierWeightField;
            }
            set
            {
                this.carrierWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarSeatWeightGroupEU")]
        public CarSeatWeightGroupEUType[] CarSeatWeightGroupEU
        {
            get
            {
                return this.carSeatWeightGroupEUField;
            }
            set
            {
                this.carSeatWeightGroupEUField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension ChestSize
        {
            get
            {
                return this.chestSizeField;
            }
            set
            {
                this.chestSizeField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ColorName
        {
            get
            {
                return this.colorNameField;
            }
            set
            {
                this.colorNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CommunicationInterface
        {
            get
            {
                return this.communicationInterfaceField;
            }
            set
            {
                this.communicationInterfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CompatibleDevices
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ControlType
        {
            get
            {
                return this.controlTypeField;
            }
            set
            {
                this.controlTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CupSize
        {
            get
            {
                return this.cupSizeField;
            }
            set
            {
                this.cupSizeField = value;
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
        public LengthDimension DisplaySize
        {
            get
            {
                return this.displaySizeField;
            }
            set
            {
                this.displaySizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string DisplayType
        {
            get
            {
                return this.displayTypeField;
            }
            set
            {
                this.displayTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string EducationalValue
        {
            get
            {
                return this.educationalValueField;
            }
            set
            {
                this.educationalValueField = value;
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
        public string FoldedSize
        {
            get
            {
                return this.foldedSizeField;
            }
            set
            {
                this.foldedSizeField = value;
            }
        }

        /// <remarks/>
        public ForwardFacingWeight ForwardFacingWeight
        {
            get
            {
                return this.forwardFacingWeightField;
            }
            set
            {
                this.forwardFacingWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FrequencyBandsSupported
        {
            get
            {
                return this.frequencyBandsSupportedField;
            }
            set
            {
                this.frequencyBandsSupportedField = value;
            }
        }

        /// <remarks/>
        public FrequencyDimension FrequencyResponse
        {
            get
            {
                return this.frequencyResponseField;
            }
            set
            {
                this.frequencyResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FurnitureFinish
        {
            get
            {
                return this.furnitureFinishField;
            }
            set
            {
                this.furnitureFinishField = value;
            }
        }

        /// <remarks/>
        public LengthDimension HandleHeight
        {
            get
            {
                return this.handleHeightField;
            }
            set
            {
                this.handleHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HardwareVisibility
        {
            get
            {
                return this.hardwareVisibilityField;
            }
            set
            {
                this.hardwareVisibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HarnessType
        {
            get
            {
                return this.harnessTypeField;
            }
            set
            {
                this.harnessTypeField = value;
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
        public bool IsDishwasherSafe
        {
            get
            {
                return this.isDishwasherSafeField;
            }
            set
            {
                this.isDishwasherSafeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDishwasherSafeSpecified
        {
            get
            {
                return this.isDishwasherSafeFieldSpecified;
            }
            set
            {
                this.isDishwasherSafeFieldSpecified = value;
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
        public LengthDimension ItemDepth
        {
            get
            {
                return this.itemDepthField;
            }
            set
            {
                this.itemDepthField = value;
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
        public LanguageStringType Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageSpecified
        {
            get
            {
                return this.languageFieldSpecified;
            }
            set
            {
                this.languageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lifestyle", DataType = "normalizedString")]
        public string[] Lifestyle
        {
            get
            {
                return this.lifestyleField;
            }
            set
            {
                this.lifestyleField = value;
            }
        }

        /// <remarks/>
        public EnergyConsumptionDimension LithiumBatteryEnergyContent
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
        public BabyProductsLithiumBatteryPackaging LithiumBatteryPackaging
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ManufacturerWarrantyDescription
        {
            get
            {
                return this.manufacturerWarrantyDescriptionField;
            }
            set
            {
                this.manufacturerWarrantyDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MaterialComposition
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MaterialType
        {
            get
            {
                return this.materialTypeField;
            }
            set
            {
                this.materialTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTypeFree", DataType = "normalizedString")]
        public string[] MaterialTypeFree
        {
            get
            {
                return this.materialTypeFreeField;
            }
            set
            {
                this.materialTypeFreeField = value;
            }
        }

        /// <remarks/>
        public WeightDimension MaximumAnchoringWeightCapacity
        {
            get
            {
                return this.maximumAnchoringWeightCapacityField;
            }
            set
            {
                this.maximumAnchoringWeightCapacityField = value;
            }
        }

        /// <remarks/>
        public LengthDimension MaximumHeightRecommendation
        {
            get
            {
                return this.maximumHeightRecommendationField;
            }
            set
            {
                this.maximumHeightRecommendationField = value;
            }
        }

        /// <remarks/>
        public OptionalAgeRecommendedDimension MaximumManufacturerAgeRecommended
        {
            get
            {
                return this.maximumManufacturerAgeRecommendedField;
            }
            set
            {
                this.maximumManufacturerAgeRecommendedField = value;
            }
        }

        /// <remarks/>
        public LengthDimension MaximumItemWidth
        {
            get
            {
                return this.maximumItemWidthField;
            }
            set
            {
                this.maximumItemWidthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension MaximumRangeIndoors
        {
            get
            {
                return this.maximumRangeIndoorsField;
            }
            set
            {
                this.maximumRangeIndoorsField = value;
            }
        }

        /// <remarks/>
        public LengthDimension MaximumRangeOpenSpace
        {
            get
            {
                return this.maximumRangeOpenSpaceField;
            }
            set
            {
                this.maximumRangeOpenSpaceField = value;
            }
        }

        /// <remarks/>
        public PositiveWeightDimension MaximumWeightRecommendation
        {
            get
            {
                return this.maximumWeightRecommendationField;
            }
            set
            {
                this.maximumWeightRecommendationField = value;
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
        public LengthDimension MinimumHeightRecommendation
        {
            get
            {
                return this.minimumHeightRecommendationField;
            }
            set
            {
                this.minimumHeightRecommendationField = value;
            }
        }

        /// <remarks/>
        public OptionalAgeRecommendedDimension MinimumManufacturerAgeRecommended
        {
            get
            {
                return this.minimumManufacturerAgeRecommendedField;
            }
            set
            {
                this.minimumManufacturerAgeRecommendedField = value;
            }
        }

        /// <remarks/>
        public PositiveWeightDimension MinimumWeightRecommendation
        {
            get
            {
                return this.minimumWeightRecommendationField;
            }
            set
            {
                this.minimumWeightRecommendationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfChannels
        {
            get
            {
                return this.numberOfChannelsField;
            }
            set
            {
                this.numberOfChannelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfControlChannels
        {
            get
            {
                return this.numberOfControlChannelsField;
            }
            set
            {
                this.numberOfControlChannelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfFrequencyChannels
        {
            get
            {
                return this.numberOfFrequencyChannelsField;
            }
            set
            {
                this.numberOfFrequencyChannelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfHeightPositions
        {
            get
            {
                return this.numberOfHeightPositionsField;
            }
            set
            {
                this.numberOfHeightPositionsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfPieces
        {
            get
            {
                return this.numberOfPiecesField;
            }
            set
            {
                this.numberOfPiecesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfPlayers
        {
            get
            {
                return this.numberOfPlayersField;
            }
            set
            {
                this.numberOfPlayersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfPositions
        {
            get
            {
                return this.numberOfPositionsField;
            }
            set
            {
                this.numberOfPositionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OperationMode
        {
            get
            {
                return this.operationModeField;
            }
            set
            {
                this.operationModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }

        /// <remarks/>
        public BabyProductsVariationData VariationData
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
        public LengthDimension PortableDisplaySize
        {
            get
            {
                return this.portableDisplaySizeField;
            }
            set
            {
                this.portableDisplaySizeField = value;
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
        public string RailGauge
        {
            get
            {
                return this.railGaugeField;
            }
            set
            {
                this.railGaugeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string RailType
        {
            get
            {
                return this.railTypeField;
            }
            set
            {
                this.railTypeField = value;
            }
        }

        /// <remarks/>
        public WeightDimension RearFacingMaximumWeight
        {
            get
            {
                return this.rearFacingMaximumWeightField;
            }
            set
            {
                this.rearFacingMaximumWeightField = value;
            }
        }

        /// <remarks/>
        public WeightDimension RearFacingMinimumWeight
        {
            get
            {
                return this.rearFacingMinimumWeightField;
            }
            set
            {
                this.rearFacingMinimumWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecommendedUsesForProduct", DataType = "normalizedString")]
        public string[] RecommendedUsesForProduct
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string RegionOfOrigin
        {
            get
            {
                return this.regionOfOriginField;
            }
            set
            {
                this.regionOfOriginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string RemoteControlTechnology
        {
            get
            {
                return this.remoteControlTechnologyField;
            }
            set
            {
                this.remoteControlTechnologyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SafetyWarning
        {
            get
            {
                return this.safetyWarningField;
            }
            set
            {
                this.safetyWarningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ScaleName
        {
            get
            {
                return this.scaleNameField;
            }
            set
            {
                this.scaleNameField = value;
            }
        }

        /// <remarks/>
        public LengthDimension SeatBackInteriorHeight
        {
            get
            {
                return this.seatBackInteriorHeightField;
            }
            set
            {
                this.seatBackInteriorHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension SeatHeight
        {
            get
            {
                return this.seatHeightField;
            }
            set
            {
                this.seatHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension SeatInteriorWidth
        {
            get
            {
                return this.seatInteriorWidthField;
            }
            set
            {
                this.seatInteriorWidthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension SeatLength
        {
            get
            {
                return this.seatLengthField;
            }
            set
            {
                this.seatLengthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension SeatWidth
        {
            get
            {
                return this.seatWidthField;
            }
            set
            {
                this.seatWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string SeatingCapacity
        {
            get
            {
                return this.seatingCapacityField;
            }
            set
            {
                this.seatingCapacityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SensorTechnology", DataType = "normalizedString")]
        public string[] SensorTechnology
        {
            get
            {
                return this.sensorTechnologyField;
            }
            set
            {
                this.sensorTechnologyField = value;
            }
        }

        /// <remarks/>
        public LengthDimension ShoulderHarnessMaximumHeight
        {
            get
            {
                return this.shoulderHarnessMaximumHeightField;
            }
            set
            {
                this.shoulderHarnessMaximumHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension ShoulderHarnessMinimumHeight
        {
            get
            {
                return this.shoulderHarnessMinimumHeightField;
            }
            set
            {
                this.shoulderHarnessMinimumHeightField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SizeName
        {
            get
            {
                return this.sizeNameField;
            }
            set
            {
                this.sizeNameField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SpecificUsesForProduct", DataType = "normalizedString")]
        public string[] SpecificUsesForProduct
        {
            get
            {
                return this.specificUsesForProductField;
            }
            set
            {
                this.specificUsesForProductField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("StyleName", DataType = "normalizedString")]
        public string[] StyleName
        {
            get
            {
                return this.styleNameField;
            }
            set
            {
                this.styleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectCharacter", DataType = "normalizedString")]
        public string[] SubjectCharacter
        {
            get
            {
                return this.subjectCharacterField;
            }
            set
            {
                this.subjectCharacterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SuspensionType
        {
            get
            {
                return this.suspensionTypeField;
            }
            set
            {
                this.suspensionTypeField = value;
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
        public LengthDimension TireDiameter
        {
            get
            {
                return this.tireDiameterField;
            }
            set
            {
                this.tireDiameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string TireMaterial
        {
            get
            {
                return this.tireMaterialField;
            }
            set
            {
                this.tireMaterialField = value;
            }
        }

        /// <remarks/>
        public LengthDimension TotalTravel
        {
            get
            {
                return this.totalTravelField;
            }
            set
            {
                this.totalTravelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrayType", DataType = "normalizedString")]
        public string[] TrayType
        {
            get
            {
                return this.trayTypeField;
            }
            set
            {
                this.trayTypeField = value;
            }
        }

        /// <remarks/>
        public BabyProductsUnitCount UnitCount
        {
            get
            {
                return this.unitCountField;
            }
            set
            {
                this.unitCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string WarrantyDescription
        {
            get
            {
                return this.warrantyDescriptionField;
            }
            set
            {
                this.warrantyDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string WheelType
        {
            get
            {
                return this.wheelTypeField;
            }
            set
            {
                this.wheelTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string WirelessCommunicationTechnology
        {
            get
            {
                return this.wirelessCommunicationTechnologyField;
            }
            set
            {
                this.wirelessCommunicationTechnologyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string UnknownSubject
        {
            get
            {
                return this.unknownSubjectField;
            }
            set
            {
                this.unknownSubjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string EngineType
        {
            get
            {
                return this.engineTypeField;
            }
            set
            {
                this.engineTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string BatteryTypeLithiumIon
        {
            get
            {
                return this.batteryTypeLithiumIonField;
            }
            set
            {
                this.batteryTypeLithiumIonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string BatteryTypeLithiumMetal
        {
            get
            {
                return this.batteryTypeLithiumMetalField;
            }
            set
            {
                this.batteryTypeLithiumMetalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string LithiumBatteryVoltage
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string LithiumBatteryWeight
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CountryString
        {
            get
            {
                return this.countryStringField;
            }
            set
            {
                this.countryStringField = value;
            }
        }
    }


}