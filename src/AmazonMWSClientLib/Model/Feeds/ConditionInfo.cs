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
    public partial class ConditionInfo
    {

        private ConditionType conditionTypeField;

        private string conditionNoteField;

        /// <remarks/>
        public ConditionType ConditionType
        {
            get
            {
                return this.conditionTypeField;
            }
            set
            {
                this.conditionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
        public string ConditionNote
        {
            get
            {
                return this.conditionNoteField;
            }
            set
            {
                this.conditionNoteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ConditionType
    {

        /// <remarks/>
        New,

        /// <remarks/>
        UsedLikeNew,

        /// <remarks/>
        UsedVeryGood,

        /// <remarks/>
        UsedGood,

        /// <remarks/>
        UsedAcceptable,

        /// <remarks/>
        CollectibleLikeNew,

        /// <remarks/>
        CollectibleVeryGood,

        /// <remarks/>
        CollectibleGood,

        /// <remarks/>
        CollectibleAcceptable,

        /// <remarks/>
        Refurbished,

        /// <remarks/>
        Club,
    }
}