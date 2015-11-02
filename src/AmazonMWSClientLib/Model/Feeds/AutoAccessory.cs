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
    public partial class AutoAccessory
    {

        private AutoAccessoryProductType productTypeField;

        private Battery batteryField;

        private decimal batteryAverageLifeField;

        private bool batteryAverageLifeFieldSpecified;

        private decimal batteryAverageLifeStandbyField;

        private bool batteryAverageLifeStandbyFieldSpecified;

        private decimal batteryChargeTimeField;

        private bool batteryChargeTimeFieldSpecified;

        private string batteryTypeLithiumIonField;

        private string batteryTypeLithiumMetalField;

        private string bodyPartExteriorFinishField;

        private string cAPACertifiedField;

        private string[] hollanderNumberField;

        private string lightBulbTypeField;

        private decimal lithiumBatteryEnergyContentField;

        private bool lithiumBatteryEnergyContentFieldSpecified;

        private AutoAccessoryLithiumBatteryPackaging lithiumBatteryPackagingField;

        private bool lithiumBatteryPackagingFieldSpecified;

        private decimal lithiumBatteryVoltageField;

        private bool lithiumBatteryVoltageFieldSpecified;

        private decimal lithiumBatteryWeightField;

        private bool lithiumBatteryWeightFieldSpecified;

        private string mfgWarrantyDescriptionLaborField;

        private string mfgWarrantyDescriptionPartsField;

        private string mfgWarrantyDescriptionTypeField;

        private string mirrorAdjustmentField;

        private string mirrorDimmingFeatureField;

        private bool mirrorFoldingField;

        private bool mirrorFoldingFieldSpecified;

        private bool mirrorHeatedField;

        private bool mirrorHeatedFieldSpecified;

        private string mirrorHousingIncludedField;

        private string mirrorLensCurvatureField;

        private string[] mirrorSpecialFeatureField;

        private string mirrorTurnSignalIndicatorField;

        private string numberOfLithiumIonCellsField;

        private string numberOfLithiumMetalCellsField;

        private string[] oEMPartNumberField;

        private string part_type_idField;

        private string[] pARTSLINKNumberField;

        private string powerSourceField;

        private string sellerWarrantyDescriptionField;

        private AutoAccessoryTargetGender targetGenderField;

        private bool targetGenderFieldSpecified;

        private string warningsField;

        private string windowRegulatorLiftTypeField;

        /// <remarks/>
        public AutoAccessoryProductType ProductType
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
        public decimal BatteryAverageLife
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryAverageLifeSpecified
        {
            get
            {
                return this.batteryAverageLifeFieldSpecified;
            }
            set
            {
                this.batteryAverageLifeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal BatteryAverageLifeStandby
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryAverageLifeStandbySpecified
        {
            get
            {
                return this.batteryAverageLifeStandbyFieldSpecified;
            }
            set
            {
                this.batteryAverageLifeStandbyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal BatteryChargeTime
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatteryChargeTimeSpecified
        {
            get
            {
                return this.batteryChargeTimeFieldSpecified;
            }
            set
            {
                this.batteryChargeTimeFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string BodyPartExteriorFinish
        {
            get
            {
                return this.bodyPartExteriorFinishField;
            }
            set
            {
                this.bodyPartExteriorFinishField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CAPACertified
        {
            get
            {
                return this.cAPACertifiedField;
            }
            set
            {
                this.cAPACertifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HollanderNumber", DataType = "normalizedString")]
        public string[] HollanderNumber
        {
            get
            {
                return this.hollanderNumberField;
            }
            set
            {
                this.hollanderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string LightBulbType
        {
            get
            {
                return this.lightBulbTypeField;
            }
            set
            {
                this.lightBulbTypeField = value;
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
        public AutoAccessoryLithiumBatteryPackaging LithiumBatteryPackaging
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MirrorAdjustment
        {
            get
            {
                return this.mirrorAdjustmentField;
            }
            set
            {
                this.mirrorAdjustmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MirrorDimmingFeature
        {
            get
            {
                return this.mirrorDimmingFeatureField;
            }
            set
            {
                this.mirrorDimmingFeatureField = value;
            }
        }

        /// <remarks/>
        public bool MirrorFolding
        {
            get
            {
                return this.mirrorFoldingField;
            }
            set
            {
                this.mirrorFoldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MirrorFoldingSpecified
        {
            get
            {
                return this.mirrorFoldingFieldSpecified;
            }
            set
            {
                this.mirrorFoldingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool MirrorHeated
        {
            get
            {
                return this.mirrorHeatedField;
            }
            set
            {
                this.mirrorHeatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MirrorHeatedSpecified
        {
            get
            {
                return this.mirrorHeatedFieldSpecified;
            }
            set
            {
                this.mirrorHeatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MirrorHousingIncluded
        {
            get
            {
                return this.mirrorHousingIncludedField;
            }
            set
            {
                this.mirrorHousingIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MirrorLensCurvature
        {
            get
            {
                return this.mirrorLensCurvatureField;
            }
            set
            {
                this.mirrorLensCurvatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MirrorSpecialFeature", DataType = "normalizedString")]
        public string[] MirrorSpecialFeature
        {
            get
            {
                return this.mirrorSpecialFeatureField;
            }
            set
            {
                this.mirrorSpecialFeatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MirrorTurnSignalIndicator
        {
            get
            {
                return this.mirrorTurnSignalIndicatorField;
            }
            set
            {
                this.mirrorTurnSignalIndicatorField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OEMPartNumber", DataType = "normalizedString")]
        public string[] OEMPartNumber
        {
            get
            {
                return this.oEMPartNumberField;
            }
            set
            {
                this.oEMPartNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string part_type_id
        {
            get
            {
                return this.part_type_idField;
            }
            set
            {
                this.part_type_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PARTSLINKNumber", DataType = "normalizedString")]
        public string[] PARTSLINKNumber
        {
            get
            {
                return this.pARTSLINKNumberField;
            }
            set
            {
                this.pARTSLINKNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PowerSource
        {
            get
            {
                return this.powerSourceField;
            }
            set
            {
                this.powerSourceField = value;
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
        public AutoAccessoryTargetGender TargetGender
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string WindowRegulatorLiftType
        {
            get
            {
                return this.windowRegulatorLiftTypeField;
            }
            set
            {
                this.windowRegulatorLiftTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoAccessoryProductType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AutoAccessoryMisc", typeof(AutoAccessoryMisc))]
        [System.Xml.Serialization.XmlElementAttribute("AutoPart", typeof(AutoPart))]
        [System.Xml.Serialization.XmlElementAttribute("Helmet", typeof(Helmet))]
        [System.Xml.Serialization.XmlElementAttribute("PowersportsPart", typeof(PowersportsPart))]
        [System.Xml.Serialization.XmlElementAttribute("PowersportsVehicle", typeof(PowersportsVehicle))]
        [System.Xml.Serialization.XmlElementAttribute("ProtectiveGear", typeof(ProtectiveGear))]
        [System.Xml.Serialization.XmlElementAttribute("RidingApparel", typeof(RidingApparel))]
        public object Item
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
    public partial class AutoAccessoryMisc
    {

        private AutoAccessoryMiscVariationData variationDataField;

        private AmperageDimension amperageField;

        private string modelYearField;

        private string seasonField;

        private AutoAccessoryMiscColorSpecification colorSpecificationField;

        private LengthDimension diameterField;

        private string itemPackageQuantityField;

        private string numberOfItemsField;

        private LengthDimension displayLengthField;

        private WeightDimension displayWeightField;

        private VolumeDimension displayVolumeField;

        private string itemShapeField;

        private string materialField;

        private string sizeField;

        private string viscosityField;

        private VolumeDimension volumeField;

        private string voltageField;

        private string wattageField;

        private string numberOfGroovesField;

        private string numberOfHolesField;

        private AutoAccessoryMiscPartInterchangeData partInterchangeDataField;

        private string manufacturerWarrantyDescriptionField;

        public AutoAccessoryMisc()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public AutoAccessoryMiscVariationData VariationData
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
        public AmperageDimension Amperage
        {
            get
            {
                return this.amperageField;
            }
            set
            {
                this.amperageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public AutoAccessoryMiscColorSpecification ColorSpecification
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
        public LengthDimension Diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ItemShape
        {
            get
            {
                return this.itemShapeField;
            }
            set
            {
                this.itemShapeField = value;
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
        public string Viscosity
        {
            get
            {
                return this.viscosityField;
            }
            set
            {
                this.viscosityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfGrooves
        {
            get
            {
                return this.numberOfGroovesField;
            }
            set
            {
                this.numberOfGroovesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfHoles
        {
            get
            {
                return this.numberOfHolesField;
            }
            set
            {
                this.numberOfHolesField = value;
            }
        }

        /// <remarks/>
        public AutoAccessoryMiscPartInterchangeData PartInterchangeData
        {
            get
            {
                return this.partInterchangeDataField;
            }
            set
            {
                this.partInterchangeDataField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoAccessoryMiscVariationData
    {

        private AutoAccessoryMiscVariationDataParentage parentageField;

        private AutoAccessoryMiscVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public AutoAccessoryMiscVariationDataParentage Parentage
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
        public AutoAccessoryMiscVariationDataVariationTheme VariationTheme
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
    public enum AutoAccessoryMiscVariationDataParentage
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
    public enum AutoAccessoryMiscVariationDataVariationTheme
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoAccessoryMiscColorSpecification
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoAccessoryMiscPartInterchangeData
    {

        private string oEManufacturerField;

        private string partInterchangeInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OEManufacturer
        {
            get
            {
                return this.oEManufacturerField;
            }
            set
            {
                this.oEManufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PartInterchangeInfo
        {
            get
            {
                return this.partInterchangeInfoField;
            }
            set
            {
                this.partInterchangeInfoField = value;
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
    public partial class AutoPart
    {

        private AutoPartVariationData variationDataField;

        private AmperageDimension amperageField;

        private string modelYearField;

        private string seasonField;

        private AutoPartColorSpecification colorSpecificationField;

        private LengthDimension diameterField;

        private string itemPackageQuantityField;

        private string itemShapeField;

        private string materialField;

        private string sizeField;

        private string voltageField;

        private string wattageField;

        private string numberOfGroovesField;

        private string numberOfHolesField;

        private string manufacturerWarrantyDescriptionField;

        private AutoPartPosition positionField;

        private bool positionFieldSpecified;

        private AutoPartOrientation orientationField;

        private bool orientationFieldSpecified;

        private AutoPartProfile profileField;

        private bool profileFieldSpecified;

        private AutoPartPulleyType pulleyTypeField;

        private bool pulleyTypeFieldSpecified;

        private AutoPartPartInterchangeData partInterchangeDataField;

        public AutoPart()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public AutoPartVariationData VariationData
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
        public AmperageDimension Amperage
        {
            get
            {
                return this.amperageField;
            }
            set
            {
                this.amperageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public AutoPartColorSpecification ColorSpecification
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
        public LengthDimension Diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ItemShape
        {
            get
            {
                return this.itemShapeField;
            }
            set
            {
                this.itemShapeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfGrooves
        {
            get
            {
                return this.numberOfGroovesField;
            }
            set
            {
                this.numberOfGroovesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfHoles
        {
            get
            {
                return this.numberOfHolesField;
            }
            set
            {
                this.numberOfHolesField = value;
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
        public AutoPartPosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PositionSpecified
        {
            get
            {
                return this.positionFieldSpecified;
            }
            set
            {
                this.positionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AutoPartOrientation Orientation
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrientationSpecified
        {
            get
            {
                return this.orientationFieldSpecified;
            }
            set
            {
                this.orientationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AutoPartProfile Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfileSpecified
        {
            get
            {
                return this.profileFieldSpecified;
            }
            set
            {
                this.profileFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AutoPartPulleyType PulleyType
        {
            get
            {
                return this.pulleyTypeField;
            }
            set
            {
                this.pulleyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PulleyTypeSpecified
        {
            get
            {
                return this.pulleyTypeFieldSpecified;
            }
            set
            {
                this.pulleyTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AutoPartPartInterchangeData PartInterchangeData
        {
            get
            {
                return this.partInterchangeDataField;
            }
            set
            {
                this.partInterchangeDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoPartVariationData
    {

        private AutoPartVariationDataParentage parentageField;

        private AutoPartVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public AutoPartVariationDataParentage Parentage
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
        public AutoPartVariationDataVariationTheme VariationTheme
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
    public enum AutoPartVariationDataParentage
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
    public enum AutoPartVariationDataVariationTheme
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoPartColorSpecification
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
    public enum AutoPartPosition
    {

        /// <remarks/>
        left,

        /// <remarks/>
        left_front,

        /// <remarks/>
        left_rear,

        /// <remarks/>
        left_inner,

        /// <remarks/>
        left_outer,

        /// <remarks/>
        left_center,

        /// <remarks/>
        left_upper,

        /// <remarks/>
        left_lower,

        /// <remarks/>
        left_inside,

        /// <remarks/>
        left_outside,

        /// <remarks/>
        right,

        /// <remarks/>
        right_front,

        /// <remarks/>
        right_rear,

        /// <remarks/>
        right_inner,

        /// <remarks/>
        right_outer,

        /// <remarks/>
        right_center,

        /// <remarks/>
        right_upper,

        /// <remarks/>
        right_lower,

        /// <remarks/>
        right_inside,

        /// <remarks/>
        right_outside,

        /// <remarks/>
        front,

        /// <remarks/>
        front_inner,

        /// <remarks/>
        front_outer,

        /// <remarks/>
        front_center,

        /// <remarks/>
        front_upper,

        /// <remarks/>
        front_lower,

        /// <remarks/>
        front_inside,

        /// <remarks/>
        front_outside,

        /// <remarks/>
        rear,

        /// <remarks/>
        rear_inner,

        /// <remarks/>
        rear_outer,

        /// <remarks/>
        rear_center,

        /// <remarks/>
        rear_upper,

        /// <remarks/>
        rear_lower,

        /// <remarks/>
        rear_inside,

        /// <remarks/>
        rear_outside,

        /// <remarks/>
        inner,

        /// <remarks/>
        outer,

        /// <remarks/>
        upper,

        /// <remarks/>
        lower,

        /// <remarks/>
        top,

        /// <remarks/>
        bottom,

        /// <remarks/>
        inside,

        /// <remarks/>
        inside_center,

        /// <remarks/>
        outside,

        /// <remarks/>
        intermediate,

        /// <remarks/>
        driveline,

        /// <remarks/>
        front_left_inner,

        /// <remarks/>
        front_left_outer,

        /// <remarks/>
        front_right_inner,

        /// <remarks/>
        front_right_outer,

        /// <remarks/>
        rear_left_inner,

        /// <remarks/>
        rear_left_outer,

        /// <remarks/>
        rear_right_inner,

        /// <remarks/>
        rear_right_outer,

        /// <remarks/>
        front_left_upper,

        /// <remarks/>
        front_left_lower,

        /// <remarks/>
        front_right_upper,

        /// <remarks/>
        front_right_lower,

        /// <remarks/>
        rear_left_upper,

        /// <remarks/>
        rear_left_lower,

        /// <remarks/>
        rear_right_lower,

        /// <remarks/>
        rear_right_upper,

        /// <remarks/>
        left_intermediate,

        /// <remarks/>
        right_intermediate,

        /// <remarks/>
        bottom_left,

        /// <remarks/>
        bottom_right,

        /// <remarks/>
        top_left,

        /// <remarks/>
        top_right,

        /// <remarks/>
        front_left,

        /// <remarks/>
        front_right,

        /// <remarks/>
        rear_left,

        /// <remarks/>
        rear_right,

        /// <remarks/>
        center,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AutoPartOrientation
    {

        /// <remarks/>
        passengers_side,

        /// <remarks/>
        drivers_side,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AutoPartProfile
    {

        /// <remarks/>
        high,

        /// <remarks/>
        low,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AutoPartPulleyType
    {

        /// <remarks/>
        serpentine,

        /// <remarks/>
        v_belt,

        /// <remarks/>
        dual_v_belt,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AutoPartPartInterchangeData
    {

        private string oEManufacturerField;

        private string partInterchangeInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OEManufacturer
        {
            get
            {
                return this.oEManufacturerField;
            }
            set
            {
                this.oEManufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PartInterchangeInfo
        {
            get
            {
                return this.partInterchangeInfoField;
            }
            set
            {
                this.partInterchangeInfoField = value;
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
    public partial class Helmet
    {

        private HelmetVariationData variationDataField;

        private string[] departmentField;

        private string[] styleKeywordsField;

        private SafetyRating[] safetyRatingField;

        private string modelNameField;

        private string modelYearField;

        private string seasonField;

        private HelmetColorSpecification colorSpecificationField;

        private string materialField;

        private string innerMaterialField;

        private string outerMaterialField;

        private string[] occasionAndLifestyleField;

        private string[] eventKeywordsField;

        private string styleNameField;

        private string countryOfOriginField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string sizeField;

        private HelmetSizeMap sizeMapField;

        private bool sizeMapFieldSpecified;

        private string[] specialSizeTypeField;

        private string itemPackageQuantityField;

        private string manufacturerWarrantyDescriptionField;

        public Helmet()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public HelmetVariationData VariationData
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
        [System.Xml.Serialization.XmlElementAttribute("Department", DataType = "normalizedString")]
        public string[] Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StyleKeywords", DataType = "normalizedString")]
        public string[] StyleKeywords
        {
            get
            {
                return this.styleKeywordsField;
            }
            set
            {
                this.styleKeywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SafetyRating")]
        public SafetyRating[] SafetyRating
        {
            get
            {
                return this.safetyRatingField;
            }
            set
            {
                this.safetyRatingField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public HelmetColorSpecification ColorSpecification
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string InnerMaterial
        {
            get
            {
                return this.innerMaterialField;
            }
            set
            {
                this.innerMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OuterMaterial
        {
            get
            {
                return this.outerMaterialField;
            }
            set
            {
                this.outerMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OccasionAndLifestyle", DataType = "normalizedString")]
        public string[] OccasionAndLifestyle
        {
            get
            {
                return this.occasionAndLifestyleField;
            }
            set
            {
                this.occasionAndLifestyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventKeywords", DataType = "normalizedString")]
        public string[] EventKeywords
        {
            get
            {
                return this.eventKeywordsField;
            }
            set
            {
                this.eventKeywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string StyleName
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
        public HelmetSizeMap SizeMap
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeMapSpecified
        {
            get
            {
                return this.sizeMapFieldSpecified;
            }
            set
            {
                this.sizeMapFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialSizeType", DataType = "normalizedString")]
        public string[] SpecialSizeType
        {
            get
            {
                return this.specialSizeTypeField;
            }
            set
            {
                this.specialSizeTypeField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HelmetVariationData
    {

        private HelmetVariationDataParentage parentageField;

        private HelmetVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public HelmetVariationDataParentage Parentage
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
        public HelmetVariationDataVariationTheme VariationTheme
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
    public enum HelmetVariationDataParentage
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
    public enum HelmetVariationDataVariationTheme
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum SafetyRating
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BSI 6658 Type A Certified")]
        BSI6658TypeACertified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("DOT Certified")]
        DOTCertified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("EN 22/05 Certified")]
        EN2205Certified,

        /// <remarks/>
        Novelty,

        /// <remarks/>
        Other,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell K2005 Certified")]
        SnellK2005Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell K-98 Certified")]
        SnellK98Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell M2000 Certified")]
        SnellM2000Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell M2005 Certified")]
        SnellM2005Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell M-95 Certified")]
        SnellM95Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell N-94 Certified")]
        SnellN94Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell RS-98 Certified")]
        SnellRS98Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell S-98 Certified")]
        SnellS98Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell SA2000 Certified")]
        SnellSA2000Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell SA2006 Certified")]
        SnellSA2006Certified,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Snell SA-95 Certified")]
        SnellSA95Certified,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class HelmetColorSpecification
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
    public enum HelmetSizeMap
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Small")]
        XXXXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXX-Small")]
        XXXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXX-Small")]
        XXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XX-Small")]
        XXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("X-Small")]
        XSmall,

        /// <remarks/>
        Small,

        /// <remarks/>
        Medium,

        /// <remarks/>
        Large,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("X-Large")]
        XLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XX-Large")]
        XXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXX-Large")]
        XXXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXX-Large")]
        XXXXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Large")]
        XXXXXLarge,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PowersportsPart
    {

        private PowersportsPartVariationData variationDataField;

        private AmperageDimension amperageField;

        private string modelYearField;

        private string seasonField;

        private PowersportsPartColorSpecification colorSpecificationField;

        private LengthDimension diameterField;

        private string itemPackageQuantityField;

        private string materialField;

        private string sizeField;

        private string voltageField;

        private string wattageField;

        private string numberOfGroovesField;

        private string manufacturerWarrantyDescriptionField;

        private PowersportsPartPosition positionField;

        private bool positionFieldSpecified;

        private PowersportsPartOrientation orientationField;

        private bool orientationFieldSpecified;

        private PowersportsPartProfile profileField;

        private bool profileFieldSpecified;

        private PowersportsPartPulleyType pulleyTypeField;

        private bool pulleyTypeFieldSpecified;

        private PowersportsPartPartInterchangeData partInterchangeDataField;

        public PowersportsPart()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public PowersportsPartVariationData VariationData
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
        public AmperageDimension Amperage
        {
            get
            {
                return this.amperageField;
            }
            set
            {
                this.amperageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public PowersportsPartColorSpecification ColorSpecification
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
        public LengthDimension Diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfGrooves
        {
            get
            {
                return this.numberOfGroovesField;
            }
            set
            {
                this.numberOfGroovesField = value;
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
        public PowersportsPartPosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PositionSpecified
        {
            get
            {
                return this.positionFieldSpecified;
            }
            set
            {
                this.positionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PowersportsPartOrientation Orientation
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrientationSpecified
        {
            get
            {
                return this.orientationFieldSpecified;
            }
            set
            {
                this.orientationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PowersportsPartProfile Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfileSpecified
        {
            get
            {
                return this.profileFieldSpecified;
            }
            set
            {
                this.profileFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PowersportsPartPulleyType PulleyType
        {
            get
            {
                return this.pulleyTypeField;
            }
            set
            {
                this.pulleyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PulleyTypeSpecified
        {
            get
            {
                return this.pulleyTypeFieldSpecified;
            }
            set
            {
                this.pulleyTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PowersportsPartPartInterchangeData PartInterchangeData
        {
            get
            {
                return this.partInterchangeDataField;
            }
            set
            {
                this.partInterchangeDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PowersportsPartVariationData
    {

        private PowersportsPartVariationDataParentage parentageField;

        private PowersportsPartVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public PowersportsPartVariationDataParentage Parentage
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
        public PowersportsPartVariationDataVariationTheme VariationTheme
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
    public enum PowersportsPartVariationDataParentage
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
    public enum PowersportsPartVariationDataVariationTheme
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PowersportsPartColorSpecification
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
    public enum PowersportsPartPosition
    {

        /// <remarks/>
        left,

        /// <remarks/>
        left_front,

        /// <remarks/>
        left_rear,

        /// <remarks/>
        left_inner,

        /// <remarks/>
        left_outer,

        /// <remarks/>
        left_center,

        /// <remarks/>
        left_upper,

        /// <remarks/>
        left_lower,

        /// <remarks/>
        left_inside,

        /// <remarks/>
        left_outside,

        /// <remarks/>
        right,

        /// <remarks/>
        right_front,

        /// <remarks/>
        right_rear,

        /// <remarks/>
        right_inner,

        /// <remarks/>
        right_outer,

        /// <remarks/>
        right_center,

        /// <remarks/>
        right_upper,

        /// <remarks/>
        right_lower,

        /// <remarks/>
        right_inside,

        /// <remarks/>
        right_outside,

        /// <remarks/>
        front,

        /// <remarks/>
        front_inner,

        /// <remarks/>
        front_outer,

        /// <remarks/>
        front_center,

        /// <remarks/>
        front_upper,

        /// <remarks/>
        front_lower,

        /// <remarks/>
        front_inside,

        /// <remarks/>
        front_outside,

        /// <remarks/>
        rear,

        /// <remarks/>
        rear_inner,

        /// <remarks/>
        rear_outer,

        /// <remarks/>
        rear_center,

        /// <remarks/>
        rear_upper,

        /// <remarks/>
        rear_lower,

        /// <remarks/>
        rear_inside,

        /// <remarks/>
        rear_outside,

        /// <remarks/>
        inner,

        /// <remarks/>
        outer,

        /// <remarks/>
        upper,

        /// <remarks/>
        lower,

        /// <remarks/>
        top,

        /// <remarks/>
        bottom,

        /// <remarks/>
        inside,

        /// <remarks/>
        inside_center,

        /// <remarks/>
        outside,

        /// <remarks/>
        intermediate,

        /// <remarks/>
        driveline,

        /// <remarks/>
        front_left_inner,

        /// <remarks/>
        front_left_outer,

        /// <remarks/>
        front_right_inner,

        /// <remarks/>
        front_right_outer,

        /// <remarks/>
        rear_left_inner,

        /// <remarks/>
        rear_left_outer,

        /// <remarks/>
        rear_right_inner,

        /// <remarks/>
        rear_right_outer,

        /// <remarks/>
        front_left_upper,

        /// <remarks/>
        front_left_lower,

        /// <remarks/>
        front_right_upper,

        /// <remarks/>
        front_right_lower,

        /// <remarks/>
        rear_left_upper,

        /// <remarks/>
        rear_left_lower,

        /// <remarks/>
        rear_right_lower,

        /// <remarks/>
        rear_right_upper,

        /// <remarks/>
        left_intermediate,

        /// <remarks/>
        right_intermediate,

        /// <remarks/>
        bottom_left,

        /// <remarks/>
        bottom_right,

        /// <remarks/>
        top_left,

        /// <remarks/>
        top_right,

        /// <remarks/>
        front_left,

        /// <remarks/>
        front_right,

        /// <remarks/>
        rear_left,

        /// <remarks/>
        rear_right,

        /// <remarks/>
        center,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum PowersportsPartOrientation
    {

        /// <remarks/>
        passengers_side,

        /// <remarks/>
        drivers_side,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum PowersportsPartProfile
    {

        /// <remarks/>
        high,

        /// <remarks/>
        low,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum PowersportsPartPulleyType
    {

        /// <remarks/>
        serpentine,

        /// <remarks/>
        v_belt,

        /// <remarks/>
        dual_v_belt,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PowersportsPartPartInterchangeData
    {

        private string oEManufacturerField;

        private string partInterchangeInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OEManufacturer
        {
            get
            {
                return this.oEManufacturerField;
            }
            set
            {
                this.oEManufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string PartInterchangeInfo
        {
            get
            {
                return this.partInterchangeInfoField;
            }
            set
            {
                this.partInterchangeInfoField = value;
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
    public partial class PowersportsVehicle
    {

        private PowersportsVehicleVariationData variationDataField;

        private string modelYearField;

        private string seasonField;

        private PowersportsVehicleColorSpecification colorSpecificationField;

        private string manufacturerWarrantyDescriptionField;

        private string oEManufacturerField;

        /// <remarks/>
        public PowersportsVehicleVariationData VariationData
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public PowersportsVehicleColorSpecification ColorSpecification
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
        public string OEManufacturer
        {
            get
            {
                return this.oEManufacturerField;
            }
            set
            {
                this.oEManufacturerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PowersportsVehicleVariationData
    {

        private PowersportsVehicleVariationDataParentage parentageField;

        private PowersportsVehicleVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public PowersportsVehicleVariationDataParentage Parentage
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
        public PowersportsVehicleVariationDataVariationTheme VariationTheme
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
    public enum PowersportsVehicleVariationDataParentage
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
    public enum PowersportsVehicleVariationDataVariationTheme
    {

        /// <remarks/>
        Color,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PowersportsVehicleColorSpecification
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ProtectiveGear
    {

        private ProtectiveGearVariationData variationDataField;

        private string[] departmentField;

        private string[] styleKeywordsField;

        private string modelNameField;

        private string modelYearField;

        private string seasonField;

        private ProtectiveGearColorSpecification colorSpecificationField;

        private string[] fabricField;

        private string materialField;

        private string innerMaterialField;

        private string outerMaterialField;

        private string soleMaterialField;

        private string shoeClosureTypeField;

        private string[] occasionAndLifestyleField;

        private string[] eventKeywordsField;

        private string styleNameField;

        private LengthDimension minimumHeightRecommendedField;

        private LengthDimension maximumHeightRecommendedField;

        private string countryOfOriginField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string sizeField;

        private ProtectiveGearSizeMap sizeMapField;

        private bool sizeMapFieldSpecified;

        private string[] specialSizeTypeField;

        private ClothingSizeDimension waistSizeField;

        private ClothingSizeDimension inseamLengthField;

        private ClothingSizeDimension sleeveLengthField;

        private ClothingSizeDimension neckSizeField;

        private ClothingSizeDimension chestSizeField;

        private ProtectiveGearCupSize cupSizeField;

        private bool cupSizeFieldSpecified;

        private ProtectiveGearShoeWidth shoeWidthField;

        private bool shoeWidthFieldSpecified;

        private LengthDimension heelHeightField;

        private string heelTypeField;

        private StringLengthOptionalDimension shaftHeightField;

        private LengthDimension beltLengthField;

        private LengthDimension beltWidthField;

        private string itemPackageQuantityField;

        private string manufacturerWarrantyDescriptionField;

        public ProtectiveGear()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public ProtectiveGearVariationData VariationData
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
        [System.Xml.Serialization.XmlElementAttribute("Department", DataType = "normalizedString")]
        public string[] Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StyleKeywords", DataType = "normalizedString")]
        public string[] StyleKeywords
        {
            get
            {
                return this.styleKeywordsField;
            }
            set
            {
                this.styleKeywordsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public ProtectiveGearColorSpecification ColorSpecification
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
        [System.Xml.Serialization.XmlElementAttribute("Fabric", DataType = "normalizedString")]
        public string[] Fabric
        {
            get
            {
                return this.fabricField;
            }
            set
            {
                this.fabricField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string InnerMaterial
        {
            get
            {
                return this.innerMaterialField;
            }
            set
            {
                this.innerMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OuterMaterial
        {
            get
            {
                return this.outerMaterialField;
            }
            set
            {
                this.outerMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SoleMaterial
        {
            get
            {
                return this.soleMaterialField;
            }
            set
            {
                this.soleMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ShoeClosureType
        {
            get
            {
                return this.shoeClosureTypeField;
            }
            set
            {
                this.shoeClosureTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OccasionAndLifestyle", DataType = "normalizedString")]
        public string[] OccasionAndLifestyle
        {
            get
            {
                return this.occasionAndLifestyleField;
            }
            set
            {
                this.occasionAndLifestyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventKeywords", DataType = "normalizedString")]
        public string[] EventKeywords
        {
            get
            {
                return this.eventKeywordsField;
            }
            set
            {
                this.eventKeywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string StyleName
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
        public LengthDimension MinimumHeightRecommended
        {
            get
            {
                return this.minimumHeightRecommendedField;
            }
            set
            {
                this.minimumHeightRecommendedField = value;
            }
        }

        /// <remarks/>
        public LengthDimension MaximumHeightRecommended
        {
            get
            {
                return this.maximumHeightRecommendedField;
            }
            set
            {
                this.maximumHeightRecommendedField = value;
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
        public ProtectiveGearSizeMap SizeMap
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeMapSpecified
        {
            get
            {
                return this.sizeMapFieldSpecified;
            }
            set
            {
                this.sizeMapFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialSizeType", DataType = "normalizedString")]
        public string[] SpecialSizeType
        {
            get
            {
                return this.specialSizeTypeField;
            }
            set
            {
                this.specialSizeTypeField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension WaistSize
        {
            get
            {
                return this.waistSizeField;
            }
            set
            {
                this.waistSizeField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension InseamLength
        {
            get
            {
                return this.inseamLengthField;
            }
            set
            {
                this.inseamLengthField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension SleeveLength
        {
            get
            {
                return this.sleeveLengthField;
            }
            set
            {
                this.sleeveLengthField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension NeckSize
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
        public ProtectiveGearCupSize CupSize
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CupSizeSpecified
        {
            get
            {
                return this.cupSizeFieldSpecified;
            }
            set
            {
                this.cupSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProtectiveGearShoeWidth ShoeWidth
        {
            get
            {
                return this.shoeWidthField;
            }
            set
            {
                this.shoeWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShoeWidthSpecified
        {
            get
            {
                return this.shoeWidthFieldSpecified;
            }
            set
            {
                this.shoeWidthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LengthDimension HeelHeight
        {
            get
            {
                return this.heelHeightField;
            }
            set
            {
                this.heelHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HeelType
        {
            get
            {
                return this.heelTypeField;
            }
            set
            {
                this.heelTypeField = value;
            }
        }

        /// <remarks/>
        public StringLengthOptionalDimension ShaftHeight
        {
            get
            {
                return this.shaftHeightField;
            }
            set
            {
                this.shaftHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension BeltLength
        {
            get
            {
                return this.beltLengthField;
            }
            set
            {
                this.beltLengthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension BeltWidth
        {
            get
            {
                return this.beltWidthField;
            }
            set
            {
                this.beltWidthField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProtectiveGearVariationData
    {

        private ProtectiveGearVariationDataParentage parentageField;

        private ProtectiveGearVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public ProtectiveGearVariationDataParentage Parentage
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
        public ProtectiveGearVariationDataVariationTheme VariationTheme
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
    public enum ProtectiveGearVariationDataParentage
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
    public enum ProtectiveGearVariationDataVariationTheme
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProtectiveGearColorSpecification
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
    public enum ProtectiveGearSizeMap
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Small")]
        XXXXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXX-Small")]
        XXXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXX-Small")]
        XXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XX-Small")]
        XXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("X-Small")]
        XSmall,

        /// <remarks/>
        Small,

        /// <remarks/>
        Medium,

        /// <remarks/>
        Large,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("X-Large")]
        XLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XX-Large")]
        XXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXX-Large")]
        XXXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXX-Large")]
        XXXXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Large")]
        XXXXXLarge,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProtectiveGearCupSize
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        DD,

        /// <remarks/>
        DDD,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        FF,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ProtectiveGearShoeWidth
    {

        /// <remarks/>
        AAAA,

        /// <remarks/>
        AAA,

        /// <remarks/>
        AA,

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("E")]
        E1,

        /// <remarks/>
        EE,

        /// <remarks/>
        EEE,

        /// <remarks/>
        EEEE,

        /// <remarks/>
        EEEEE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RidingApparel
    {

        private RidingApparelVariationData variationDataField;

        private RidingApparelClothingType clothingTypeField;

        private string[] departmentField;

        private string[] styleKeywordsField;

        private string modelNameField;

        private string modelYearField;

        private string seasonField;

        private RidingApparelColorSpecification colorSpecificationField;

        private string[] fabricField;

        private string materialField;

        private string innerMaterialField;

        private string outerMaterialField;

        private string soleMaterialField;

        private string shoeClosureTypeField;

        private string[] occasionAndLifestyleField;

        private string[] eventKeywordsField;

        private string styleNameField;

        private LengthDimension minimumHeightRecommendedField;

        private LengthDimension maximumHeightRecommendedField;

        private string countryOfOriginField;

        private bool isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private string sizeField;

        private RidingApparelSizeMap sizeMapField;

        private bool sizeMapFieldSpecified;

        private string[] specialSizeTypeField;

        private ClothingSizeDimension waistSizeField;

        private ClothingSizeDimension inseamLengthField;

        private ClothingSizeDimension sleeveLengthField;

        private ClothingSizeDimension neckSizeField;

        private ClothingSizeDimension chestSizeField;

        private RidingApparelCupSize cupSizeField;

        private bool cupSizeFieldSpecified;

        private RidingApparelShoeWidth shoeWidthField;

        private bool shoeWidthFieldSpecified;

        private LengthDimension heelHeightField;

        private string heelTypeField;

        private StringLengthOptionalDimension shaftHeightField;

        private LengthDimension beltLengthField;

        private LengthDimension beltWidthField;

        private string itemPackageQuantityField;

        private string manufacturerWarrantyDescriptionField;

        public RidingApparel()
        {
            this.itemPackageQuantityField = "1";
        }

        /// <remarks/>
        public RidingApparelVariationData VariationData
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
        public RidingApparelClothingType ClothingType
        {
            get
            {
                return this.clothingTypeField;
            }
            set
            {
                this.clothingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Department", DataType = "normalizedString")]
        public string[] Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StyleKeywords", DataType = "normalizedString")]
        public string[] StyleKeywords
        {
            get
            {
                return this.styleKeywordsField;
            }
            set
            {
                this.styleKeywordsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public RidingApparelColorSpecification ColorSpecification
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
        [System.Xml.Serialization.XmlElementAttribute("Fabric", DataType = "normalizedString")]
        public string[] Fabric
        {
            get
            {
                return this.fabricField;
            }
            set
            {
                this.fabricField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string InnerMaterial
        {
            get
            {
                return this.innerMaterialField;
            }
            set
            {
                this.innerMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string OuterMaterial
        {
            get
            {
                return this.outerMaterialField;
            }
            set
            {
                this.outerMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SoleMaterial
        {
            get
            {
                return this.soleMaterialField;
            }
            set
            {
                this.soleMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ShoeClosureType
        {
            get
            {
                return this.shoeClosureTypeField;
            }
            set
            {
                this.shoeClosureTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OccasionAndLifestyle", DataType = "normalizedString")]
        public string[] OccasionAndLifestyle
        {
            get
            {
                return this.occasionAndLifestyleField;
            }
            set
            {
                this.occasionAndLifestyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventKeywords", DataType = "normalizedString")]
        public string[] EventKeywords
        {
            get
            {
                return this.eventKeywordsField;
            }
            set
            {
                this.eventKeywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string StyleName
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
        public LengthDimension MinimumHeightRecommended
        {
            get
            {
                return this.minimumHeightRecommendedField;
            }
            set
            {
                this.minimumHeightRecommendedField = value;
            }
        }

        /// <remarks/>
        public LengthDimension MaximumHeightRecommended
        {
            get
            {
                return this.maximumHeightRecommendedField;
            }
            set
            {
                this.maximumHeightRecommendedField = value;
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
        public RidingApparelSizeMap SizeMap
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeMapSpecified
        {
            get
            {
                return this.sizeMapFieldSpecified;
            }
            set
            {
                this.sizeMapFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialSizeType", DataType = "normalizedString")]
        public string[] SpecialSizeType
        {
            get
            {
                return this.specialSizeTypeField;
            }
            set
            {
                this.specialSizeTypeField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension WaistSize
        {
            get
            {
                return this.waistSizeField;
            }
            set
            {
                this.waistSizeField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension InseamLength
        {
            get
            {
                return this.inseamLengthField;
            }
            set
            {
                this.inseamLengthField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension SleeveLength
        {
            get
            {
                return this.sleeveLengthField;
            }
            set
            {
                this.sleeveLengthField = value;
            }
        }

        /// <remarks/>
        public ClothingSizeDimension NeckSize
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
        public RidingApparelCupSize CupSize
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CupSizeSpecified
        {
            get
            {
                return this.cupSizeFieldSpecified;
            }
            set
            {
                this.cupSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RidingApparelShoeWidth ShoeWidth
        {
            get
            {
                return this.shoeWidthField;
            }
            set
            {
                this.shoeWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShoeWidthSpecified
        {
            get
            {
                return this.shoeWidthFieldSpecified;
            }
            set
            {
                this.shoeWidthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LengthDimension HeelHeight
        {
            get
            {
                return this.heelHeightField;
            }
            set
            {
                this.heelHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HeelType
        {
            get
            {
                return this.heelTypeField;
            }
            set
            {
                this.heelTypeField = value;
            }
        }

        /// <remarks/>
        public StringLengthOptionalDimension ShaftHeight
        {
            get
            {
                return this.shaftHeightField;
            }
            set
            {
                this.shaftHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension BeltLength
        {
            get
            {
                return this.beltLengthField;
            }
            set
            {
                this.beltLengthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension BeltWidth
        {
            get
            {
                return this.beltWidthField;
            }
            set
            {
                this.beltWidthField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RidingApparelVariationData
    {

        private RidingApparelVariationDataParentage parentageField;

        private RidingApparelVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public RidingApparelVariationDataParentage Parentage
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
        public RidingApparelVariationDataVariationTheme VariationTheme
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
    public enum RidingApparelVariationDataParentage
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
    public enum RidingApparelVariationDataVariationTheme
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
    public enum RidingApparelClothingType
    {

        /// <remarks/>
        Gloves,

        /// <remarks/>
        Jacket,

        /// <remarks/>
        Pants,

        /// <remarks/>
        Shirt,

        /// <remarks/>
        Shoes,

        /// <remarks/>
        Suit,

        /// <remarks/>
        Underwear,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RidingApparelColorSpecification
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
    public enum RidingApparelSizeMap
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Small")]
        XXXXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXX-Small")]
        XXXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXX-Small")]
        XXXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XX-Small")]
        XXSmall,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("X-Small")]
        XSmall,

        /// <remarks/>
        Small,

        /// <remarks/>
        Medium,

        /// <remarks/>
        Large,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("X-Large")]
        XLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XX-Large")]
        XXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXX-Large")]
        XXXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXX-Large")]
        XXXXLarge,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Large")]
        XXXXXLarge,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum RidingApparelCupSize
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        DD,

        /// <remarks/>
        DDD,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        FF,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum RidingApparelShoeWidth
    {

        /// <remarks/>
        AAAA,

        /// <remarks/>
        AAA,

        /// <remarks/>
        AA,

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("E")]
        E1,

        /// <remarks/>
        EE,

        /// <remarks/>
        EEE,

        /// <remarks/>
        EEEE,

        /// <remarks/>
        EEEEE,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AutoAccessoryLithiumBatteryPackaging
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum AutoAccessoryTargetGender
    {

        /// <remarks/>
        male,

        /// <remarks/>
        female,

        /// <remarks/>
        unisex,
    }
}