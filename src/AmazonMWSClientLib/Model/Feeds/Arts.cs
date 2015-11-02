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
    public partial class Arts
    {

        private ArtsProductType productTypeField;

        private ArtsVariationData variationDataField;

        /// <remarks/>
        public ArtsProductType ProductType
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
        public ArtsVariationData VariationData
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArtsProductType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FineArt", typeof(FineArt))]
        [System.Xml.Serialization.XmlElementAttribute("FineArtEditioned", typeof(FineArtEditioned))]
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
    public partial class FineArt
    {

        private string artworkTypeField;

        private string artistField;

        private string artistBiographyField;

        private string artworkMediumField;

        private System.DateTime dateField;

        private string artworkSubMediumField;

        private string archivalGradingField;

        private string signedByField;

        private string signatureLocationField;

        private string certificateOfAuthenticityField;

        private string certificateOfAuthenticityNumberField;

        private string frameMaterialField;

        private string hangingHardwareIncludedField;

        private string glassTypeField;

        private string mattingDescriptionField;

        private bool framedField;

        private string[] subjectField;

        private string subjectLocationField;

        private string[] colorField;

        private string colorFamilyField;

        private bool adultField;

        private bool adultFieldSpecified;

        private string[] styleField;

        private string periodField;

        private string exhibitionHistoryField;

        private string literatureField;

        private string provenanceField;

        private string countryOfOriginField;

        private string regionOfOriginField;

        private string sizeNameField;

        private LengthDimension framedHeightField;

        private LengthDimension framedWidthField;

        private LengthDimension framedDepthField;

        private string shapeField;

        private string orientationField;

        private string saleTypeField;

        private string isCratedField;

        private bool isVeryHighValueField;

        private bool isVeryHighValueFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtworkType
        {
            get
            {
                return this.artworkTypeField;
            }
            set
            {
                this.artworkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Artist
        {
            get
            {
                return this.artistField;
            }
            set
            {
                this.artistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtistBiography
        {
            get
            {
                return this.artistBiographyField;
            }
            set
            {
                this.artistBiographyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtworkMedium
        {
            get
            {
                return this.artworkMediumField;
            }
            set
            {
                this.artworkMediumField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtworkSubMedium
        {
            get
            {
                return this.artworkSubMediumField;
            }
            set
            {
                this.artworkSubMediumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArchivalGrading
        {
            get
            {
                return this.archivalGradingField;
            }
            set
            {
                this.archivalGradingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SignedBy
        {
            get
            {
                return this.signedByField;
            }
            set
            {
                this.signedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SignatureLocation
        {
            get
            {
                return this.signatureLocationField;
            }
            set
            {
                this.signatureLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CertificateOfAuthenticity
        {
            get
            {
                return this.certificateOfAuthenticityField;
            }
            set
            {
                this.certificateOfAuthenticityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CertificateOfAuthenticityNumber
        {
            get
            {
                return this.certificateOfAuthenticityNumberField;
            }
            set
            {
                this.certificateOfAuthenticityNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FrameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HangingHardwareIncluded
        {
            get
            {
                return this.hangingHardwareIncludedField;
            }
            set
            {
                this.hangingHardwareIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string GlassType
        {
            get
            {
                return this.glassTypeField;
            }
            set
            {
                this.glassTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MattingDescription
        {
            get
            {
                return this.mattingDescriptionField;
            }
            set
            {
                this.mattingDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool Framed
        {
            get
            {
                return this.framedField;
            }
            set
            {
                this.framedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subject", DataType = "normalizedString")]
        public string[] Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SubjectLocation
        {
            get
            {
                return this.subjectLocationField;
            }
            set
            {
                this.subjectLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Color", DataType = "normalizedString")]
        public string[] Color
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
        public string ColorFamily
        {
            get
            {
                return this.colorFamilyField;
            }
            set
            {
                this.colorFamilyField = value;
            }
        }

        /// <remarks/>
        public bool Adult
        {
            get
            {
                return this.adultField;
            }
            set
            {
                this.adultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdultSpecified
        {
            get
            {
                return this.adultFieldSpecified;
            }
            set
            {
                this.adultFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Style", DataType = "normalizedString")]
        public string[] Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ExhibitionHistory
        {
            get
            {
                return this.exhibitionHistoryField;
            }
            set
            {
                this.exhibitionHistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Literature
        {
            get
            {
                return this.literatureField;
            }
            set
            {
                this.literatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Provenance
        {
            get
            {
                return this.provenanceField;
            }
            set
            {
                this.provenanceField = value;
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
        public LengthDimension FramedHeight
        {
            get
            {
                return this.framedHeightField;
            }
            set
            {
                this.framedHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension FramedWidth
        {
            get
            {
                return this.framedWidthField;
            }
            set
            {
                this.framedWidthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension FramedDepth
        {
            get
            {
                return this.framedDepthField;
            }
            set
            {
                this.framedDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SaleType
        {
            get
            {
                return this.saleTypeField;
            }
            set
            {
                this.saleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string IsCrated
        {
            get
            {
                return this.isCratedField;
            }
            set
            {
                this.isCratedField = value;
            }
        }

        /// <remarks/>
        public bool IsVeryHighValue
        {
            get
            {
                return this.isVeryHighValueField;
            }
            set
            {
                this.isVeryHighValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsVeryHighValueSpecified
        {
            get
            {
                return this.isVeryHighValueFieldSpecified;
            }
            set
            {
                this.isVeryHighValueFieldSpecified = value;
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
    public partial class FineArtEditioned
    {

        private string artworkTypeField;

        private string artistField;

        private string artistBiographyField;

        private string artworkMediumField;

        private System.DateTime dateField;

        private string artworkSubMediumField;

        private string archivalGradingField;

        private string signedByField;

        private string signatureLocationField;

        private string certificateOfAuthenticityField;

        private string certificateOfAuthenticityNumberField;

        private string frameMaterialField;

        private string hangingHardwareIncludedField;

        private string glassTypeField;

        private string mattingDescriptionField;

        private bool framedField;

        private string[] subjectField;

        private string subjectLocationField;

        private string[] colorField;

        private string colorFamilyField;

        private bool adultField;

        private bool adultFieldSpecified;

        private string[] styleField;

        private string periodField;

        private string exhibitionHistoryField;

        private string literatureField;

        private string provenanceField;

        private string countryOfOriginField;

        private string regionOfOriginField;

        private string limitedEditionSizeField;

        private string limitedEditionRangeStartField;

        private string limitedEditionRangeEndField;

        private System.DateTime printDateField;

        private bool printDateFieldSpecified;

        private string sizeNameField;

        private LengthDimension framedHeightField;

        private LengthDimension framedWidthField;

        private LengthDimension framedDepthField;

        private string shapeField;

        private string orientationField;

        private string saleTypeField;

        private string isCratedField;

        private bool isVeryHighValueField;

        private bool isVeryHighValueFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtworkType
        {
            get
            {
                return this.artworkTypeField;
            }
            set
            {
                this.artworkTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Artist
        {
            get
            {
                return this.artistField;
            }
            set
            {
                this.artistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtistBiography
        {
            get
            {
                return this.artistBiographyField;
            }
            set
            {
                this.artistBiographyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtworkMedium
        {
            get
            {
                return this.artworkMediumField;
            }
            set
            {
                this.artworkMediumField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArtworkSubMedium
        {
            get
            {
                return this.artworkSubMediumField;
            }
            set
            {
                this.artworkSubMediumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ArchivalGrading
        {
            get
            {
                return this.archivalGradingField;
            }
            set
            {
                this.archivalGradingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SignedBy
        {
            get
            {
                return this.signedByField;
            }
            set
            {
                this.signedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SignatureLocation
        {
            get
            {
                return this.signatureLocationField;
            }
            set
            {
                this.signatureLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CertificateOfAuthenticity
        {
            get
            {
                return this.certificateOfAuthenticityField;
            }
            set
            {
                this.certificateOfAuthenticityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string CertificateOfAuthenticityNumber
        {
            get
            {
                return this.certificateOfAuthenticityNumberField;
            }
            set
            {
                this.certificateOfAuthenticityNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string FrameMaterial
        {
            get
            {
                return this.frameMaterialField;
            }
            set
            {
                this.frameMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string HangingHardwareIncluded
        {
            get
            {
                return this.hangingHardwareIncludedField;
            }
            set
            {
                this.hangingHardwareIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string GlassType
        {
            get
            {
                return this.glassTypeField;
            }
            set
            {
                this.glassTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string MattingDescription
        {
            get
            {
                return this.mattingDescriptionField;
            }
            set
            {
                this.mattingDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool Framed
        {
            get
            {
                return this.framedField;
            }
            set
            {
                this.framedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subject", DataType = "normalizedString")]
        public string[] Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SubjectLocation
        {
            get
            {
                return this.subjectLocationField;
            }
            set
            {
                this.subjectLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Color", DataType = "normalizedString")]
        public string[] Color
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
        public string ColorFamily
        {
            get
            {
                return this.colorFamilyField;
            }
            set
            {
                this.colorFamilyField = value;
            }
        }

        /// <remarks/>
        public bool Adult
        {
            get
            {
                return this.adultField;
            }
            set
            {
                this.adultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdultSpecified
        {
            get
            {
                return this.adultFieldSpecified;
            }
            set
            {
                this.adultFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Style", DataType = "normalizedString")]
        public string[] Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ExhibitionHistory
        {
            get
            {
                return this.exhibitionHistoryField;
            }
            set
            {
                this.exhibitionHistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Literature
        {
            get
            {
                return this.literatureField;
            }
            set
            {
                this.literatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Provenance
        {
            get
            {
                return this.provenanceField;
            }
            set
            {
                this.provenanceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string LimitedEditionSize
        {
            get
            {
                return this.limitedEditionSizeField;
            }
            set
            {
                this.limitedEditionSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string LimitedEditionRangeStart
        {
            get
            {
                return this.limitedEditionRangeStartField;
            }
            set
            {
                this.limitedEditionRangeStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string LimitedEditionRangeEnd
        {
            get
            {
                return this.limitedEditionRangeEndField;
            }
            set
            {
                this.limitedEditionRangeEndField = value;
            }
        }

        /// <remarks/>
        public System.DateTime PrintDate
        {
            get
            {
                return this.printDateField;
            }
            set
            {
                this.printDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintDateSpecified
        {
            get
            {
                return this.printDateFieldSpecified;
            }
            set
            {
                this.printDateFieldSpecified = value;
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
        public LengthDimension FramedHeight
        {
            get
            {
                return this.framedHeightField;
            }
            set
            {
                this.framedHeightField = value;
            }
        }

        /// <remarks/>
        public LengthDimension FramedWidth
        {
            get
            {
                return this.framedWidthField;
            }
            set
            {
                this.framedWidthField = value;
            }
        }

        /// <remarks/>
        public LengthDimension FramedDepth
        {
            get
            {
                return this.framedDepthField;
            }
            set
            {
                this.framedDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string Shape
        {
            get
            {
                return this.shapeField;
            }
            set
            {
                this.shapeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string SaleType
        {
            get
            {
                return this.saleTypeField;
            }
            set
            {
                this.saleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string IsCrated
        {
            get
            {
                return this.isCratedField;
            }
            set
            {
                this.isCratedField = value;
            }
        }

        /// <remarks/>
        public bool IsVeryHighValue
        {
            get
            {
                return this.isVeryHighValueField;
            }
            set
            {
                this.isVeryHighValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsVeryHighValueSpecified
        {
            get
            {
                return this.isVeryHighValueFieldSpecified;
            }
            set
            {
                this.isVeryHighValueFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArtsVariationData
    {

        private ArtsVariationDataParentage parentageField;

        private ArtsVariationDataVariationTheme variationThemeField;

        private bool variationThemeFieldSpecified;

        /// <remarks/>
        public ArtsVariationDataParentage Parentage
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
        public ArtsVariationDataVariationTheme VariationTheme
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
    public enum ArtsVariationDataParentage
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
    public enum ArtsVariationDataVariationTheme
    {

        /// <remarks/>
        SizeName,

        /// <remarks/>
        FrameMaterial,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Size-Material")]
        SizeMaterial,
    }
}