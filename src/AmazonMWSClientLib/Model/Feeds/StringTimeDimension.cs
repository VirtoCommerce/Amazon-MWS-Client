using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class StringTimeDimension
    {

        private TimeUnitOfMeasure unitOfMeasureField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TimeUnitOfMeasure unitOfMeasure
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
    public enum TimeUnitOfMeasure
    {

        /// <remarks/>
        sec,

        /// <remarks/>
        min,

        /// <remarks/>
        hr,

        /// <remarks/>
        days,

        /// <remarks/>
        hours,

        /// <remarks/>
        minutes,

        /// <remarks/>
        seconds,

        /// <remarks/>
        milliseconds,

        /// <remarks/>
        microseconds,

        /// <remarks/>
        nanoseconds,

        /// <remarks/>
        picoseconds,
    }
}
