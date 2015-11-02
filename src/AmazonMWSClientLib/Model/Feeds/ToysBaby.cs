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
    public partial class ToysBaby
    {

        private ToysBabyProductType productTypeField;

        private AgeRecommendation ageRecommendationField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string assemblyInstructionsField;

        private AssemblyTimeDimension assemblyTimeField;

        private Battery batteryField;

        private bool isAssemblyRequiredField;

        private bool isAssemblyRequiredFieldSpecified;

        private string manufacturerSafetyWarningField;

        private string manufacturerWarrantyDescriptionField;

        private string numberOfPiecesField;

        private string numberOfPlayersField;

        private Recall recallField;

        private ToysBabyToyAwardName[] toyAwardNameField;

        private WeightRecommendation weightRecommendationField;

        private HeightRecommendation heightRecommendationField;

        private string countryOfOriginField;

        private string foldedSizeField;

        private string materialTypeField;

        private string[] careInstructionsField;

        private string[] specialFeaturesField;

        private LengthDimension handleHeightField;

        private ToysBabySeatLength seatLengthField;

        private ToysBabySeatWidth seatWidthField;

        private string tireMaterialField;

        private ToysBabyTireDiameter tireDiameterField;

        private ToysBabyTargetGender targetGenderField;

        private bool targetGenderFieldSpecified;

        private LengthDimension displayLengthField;

        private VolumeDimension displayVolumeField;

        private WeightDimension displayWeightField;

        private ToysBabyUnitCount unitCountField;

        private ToysBabyVariationData variationDataField;

        private string sizeField;

        private string sizeMapField;

        private string colorField;

        private string colorMapField;

        private string batteryTypeLithiumIonField;

        private string batteryTypeLithiumMetalField;

        private decimal lithiumBatteryEnergyContentField;

        private bool lithiumBatteryEnergyContentFieldSpecified;

        private ToysBabyLithiumBatteryPackaging lithiumBatteryPackagingField;

        private bool lithiumBatteryPackagingFieldSpecified;

        private decimal lithiumBatteryVoltageField;

        private bool lithiumBatteryVoltageFieldSpecified;

        private decimal lithiumBatteryWeightField;

        private bool lithiumBatteryWeightFieldSpecified;

        private string numberOfLithiumIonCellsField;

        private string numberOfLithiumMetalCellsField;

        private string educationalValueField;

        /// <remarks/>
        public ToysBabyProductType ProductType
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

        /// <remarks/>
        public AgeRecommendation AgeRecommendation
        {
            get
            {
                return this.ageRecommendationField;
            }
            set
            {
                this.ageRecommendationField = value;
            }
        }

        /// <remarks/>
        public bool IsAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ManufacturerSafetyWarning
        {
            get
            {
                return this.manufacturerSafetyWarningField;
            }
            set
            {
                this.manufacturerSafetyWarningField = value;
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
        public Recall Recall
        {
            get
            {
                return this.recallField;
            }
            set
            {
                this.recallField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToyAwardName")]
        public ToysBabyToyAwardName[] ToyAwardName
        {
            get
            {
                return this.toyAwardNameField;
            }
            set
            {
                this.toyAwardNameField = value;
            }
        }

        /// <remarks/>
        public WeightRecommendation WeightRecommendation
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
        public HeightRecommendation HeightRecommendation
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
        public ToysBabySeatLength SeatLength
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
        public ToysBabySeatWidth SeatWidth
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
        public ToysBabyTireDiameter TireDiameter
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
        public ToysBabyTargetGender TargetGender
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
        public ToysBabyUnitCount UnitCount
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
        public ToysBabyVariationData VariationData
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
        public ToysBabyLithiumBatteryPackaging LithiumBatteryPackaging
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ToysBabyProductType
    {

        /// <remarks/>
        ToysAndGames,

        /// <remarks/>
        BabyProducts,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ToysBabyToyAwardName
    {

        /// <remarks/>
        baby_and_you,

        /// <remarks/>
        babyworld,

        /// <remarks/>
        child_magazine,

        /// <remarks/>
        dr_toys_100_best_child_products,

        /// <remarks/>
        family_fun_toy_of_the_year_seal,

        /// <remarks/>
        games_magazine,

        /// <remarks/>
        gomama_today,

        /// <remarks/>
        junior,

        /// <remarks/>
        lion_mark,

        /// <remarks/>
        mother_and_baby,

        /// <remarks/>
        mum_knows_best,

        /// <remarks/>
        national_parenting_approval_award,

        /// <remarks/>
        oppenheim_toys,

        /// <remarks/>
        parents_choice_portfolio,

        /// <remarks/>
        parents_magazine,

        /// <remarks/>
        practical_parenting,

        /// <remarks/>
        prima_baby,

        /// <remarks/>
        reddot,

        /// <remarks/>
        the_times,

        /// <remarks/>
        toy_wishes,

        /// <remarks/>
        unknown,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ToysBabySeatLength
    {

        private LengthUnitOfMeasure unitOfMeasureField;

        private bool unitOfMeasureFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LengthUnitOfMeasure unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitOfMeasureSpecified
        {
            get
            {
                return this.unitOfMeasureFieldSpecified;
            }
            set
            {
                this.unitOfMeasureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ToysBabySeatWidth
    {

        private LengthUnitOfMeasure unitOfMeasureField;

        private bool unitOfMeasureFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LengthUnitOfMeasure unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitOfMeasureSpecified
        {
            get
            {
                return this.unitOfMeasureFieldSpecified;
            }
            set
            {
                this.unitOfMeasureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ToysBabyTireDiameter
    {

        private LengthUnitOfMeasure unitOfMeasureField;

        private bool unitOfMeasureFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LengthUnitOfMeasure unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitOfMeasureSpecified
        {
            get
            {
                return this.unitOfMeasureFieldSpecified;
            }
            set
            {
                this.unitOfMeasureFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ToysBabyTargetGender
    {

        /// <remarks/>
        male,

        /// <remarks/>
        female,

        /// <remarks/>
        unisex,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ToysBabyUnitCount
    {

        private string unitOfMeasureField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ToysBabyVariationData
    {

        private ToysBabyVariationDataParentage parentageField;

        private ToysBabyVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public ToysBabyVariationDataParentage Parentage
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
        public ToysBabyVariationDataVariationTheme VariationTheme
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
    public enum ToysBabyVariationDataParentage
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
    public enum ToysBabyVariationDataVariationTheme
    {

        /// <remarks/>
        Size,

        /// <remarks/>
        Color,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Size-Color")]
        SizeColor,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ToysBabyLithiumBatteryPackaging
    {

        /// <remarks/>
        batteries_contained_in_equipment,

        /// <remarks/>
        batteries_only,

        /// <remarks/>
        batteries_packed_with_equipment,
    }


}