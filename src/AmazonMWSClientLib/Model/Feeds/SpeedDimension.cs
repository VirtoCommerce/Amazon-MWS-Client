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
    public partial class SpeedDimension
    {

        private SpeedUnitOfMeasure unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SpeedUnitOfMeasure unitOfMeasure
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
    public enum SpeedUnitOfMeasure
    {

        /// <remarks/>
        feet_per_minute,

        /// <remarks/>
        miles_per_hour,

        /// <remarks/>
        kilometers_per_hour,

        /// <remarks/>
        RPM,

        /// <remarks/>
        RPS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("meters per second")]
        meterspersecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("centimeters per second")]
        centimeterspersecond,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("millimeters per second")]
        millimeterspersecond,
    }
}
