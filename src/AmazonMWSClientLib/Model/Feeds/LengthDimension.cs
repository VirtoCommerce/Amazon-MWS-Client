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
    [System.Xml.Serialization.XmlRootAttribute("ScreenSize", Namespace = "", IsNullable = false)]
    public partial class LengthDimension
    {

        private LengthUnitOfMeasure unitOfMeasureField;

        private decimal valueField;

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
    public enum LengthUnitOfMeasure
    {

        /// <remarks/>
        MM,

        /// <remarks/>
        CM,

        /// <remarks/>
        M,

        /// <remarks/>
        IN,

        /// <remarks/>
        FT,

        /// <remarks/>
        inches,

        /// <remarks/>
        feet,

        /// <remarks/>
        meters,

        /// <remarks/>
        decimeters,

        /// <remarks/>
        centimeters,

        /// <remarks/>
        millimeters,

        /// <remarks/>
        micrometers,

        /// <remarks/>
        nanometers,

        /// <remarks/>
        picometers,
    }
}