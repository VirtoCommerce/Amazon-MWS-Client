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
    [System.Xml.Serialization.XmlRootAttribute("Amazon-Vendor-Only", Namespace = "", IsNullable = false)]
    public partial class AmazonVendorOnly
    {

        private CurrencyAmount costField;

        /// <remarks/>
        public CurrencyAmount Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }
    }
}