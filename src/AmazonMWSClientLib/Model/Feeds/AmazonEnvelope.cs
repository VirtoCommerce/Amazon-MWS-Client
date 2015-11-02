using System;
using System.Xml.Serialization;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AmazonEnvelope
    {

        private Header headerField;

        private AmazonEnvelopeMessageType messageTypeField;

        private string marketplaceNameField;

        private bool purgeAndReplaceField;

        private bool purgeAndReplaceFieldSpecified;

        private System.DateTime effectiveDateField;

        private bool effectiveDateFieldSpecified;

        private AmazonEnvelopeMessage[] messageField;

        /// <remarks/>
        public Header Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public AmazonEnvelopeMessageType MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string MarketplaceName
        {
            get
            {
                return this.marketplaceNameField;
            }
            set
            {
                this.marketplaceNameField = value;
            }
        }

        /// <remarks/>
        public bool PurgeAndReplace
        {
            get
            {
                return this.purgeAndReplaceField;
            }
            set
            {
                this.purgeAndReplaceField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore]
        public bool PurgeAndReplaceSpecified
        {
            get
            {
                return this.purgeAndReplaceFieldSpecified;
            }
            set
            {
                this.purgeAndReplaceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement("Message")]
        public AmazonEnvelopeMessage[] Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
}