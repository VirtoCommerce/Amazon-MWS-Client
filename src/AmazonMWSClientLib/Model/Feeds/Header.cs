using System;
using System.Xml.Serialization;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [Serializable]    
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Header
    {

        private string documentVersionField;

        private string merchantIdentifierField;

        private string overrideReleaseIdField;

        /// <remarks/>
        public string DocumentVersion
        {
            get
            {
                return this.documentVersionField;
            }
            set
            {
                this.documentVersionField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "normalizedString")]
        public string MerchantIdentifier
        {
            get
            {
                return this.merchantIdentifierField;
            }
            set
            {
                this.merchantIdentifierField = value;
            }
        }

        /// <remarks/>
        public string OverrideReleaseId
        {
            get
            {
                return this.overrideReleaseIdField;
            }
            set
            {
                this.overrideReleaseIdField = value;
            }
        }
    }
}