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
    public partial class TorqueType
    {

        private TorqueUnitOfMeasure unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TorqueUnitOfMeasure unitOfMeasure
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
    public enum TorqueUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("foot-lbs")]
        footlbs,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("inch-lbs")]
        inchlbs,

        /// <remarks/>
        centimeter_kilograms,

        /// <remarks/>
        foot_pounds,

        /// <remarks/>
        inch_ounces,

        /// <remarks/>
        inch_pounds,

        /// <remarks/>
        kilonewtons,

        /// <remarks/>
        kilograms_per_millimeter,

        /// <remarks/>
        newton_meters,

        /// <remarks/>
        newton_millimeters,

        /// <remarks/>
        newtons,
    }
}
