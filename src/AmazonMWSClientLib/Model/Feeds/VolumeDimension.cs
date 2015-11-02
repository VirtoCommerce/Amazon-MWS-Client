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
    public partial class VolumeDimension
    {

        private VolumeUnitOfMeasure unitOfMeasureField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VolumeUnitOfMeasure unitOfMeasure
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
    public enum VolumeUnitOfMeasure
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic-cm")]
        cubiccm,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic-ft")]
        cubicft,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic-in")]
        cubicin,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic-m")]
        cubicm,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cubic-yd")]
        cubicyd,

        /// <remarks/>
        cup,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("fluid-oz")]
        fluidoz,

        /// <remarks/>
        gallon,

        /// <remarks/>
        liter,

        /// <remarks/>
        milliliter,

        /// <remarks/>
        ounce,

        /// <remarks/>
        pint,

        /// <remarks/>
        quart,

        /// <remarks/>
        liters,

        /// <remarks/>
        deciliters,

        /// <remarks/>
        centiliters,

        /// <remarks/>
        milliliters,

        /// <remarks/>
        microliters,

        /// <remarks/>
        nanoliters,

        /// <remarks/>
        picoliters,
    }
}