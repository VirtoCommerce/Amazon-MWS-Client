using System;
using System.Xml.Serialization;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true)]
    public enum AmazonEnvelopeMessageOperationType
    {

        /// <remarks/>
        Update,

        /// <remarks/>
        Delete,

        /// <remarks/>
        PartialUpdate,
    }
}