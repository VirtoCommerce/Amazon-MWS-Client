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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Battery
    {

        private bool areBatteriesIncludedField;

        private bool areBatteriesIncludedFieldSpecified;

        private bool areBatteriesRequiredField;

        private bool areBatteriesRequiredFieldSpecified;

        private BatteryBatterySubgroup[] batterySubgroupField;

        /// <remarks/>
        public bool AreBatteriesIncluded
        {
            get
            {
                return this.areBatteriesIncludedField;
            }
            set
            {
                this.areBatteriesIncludedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreBatteriesIncludedSpecified
        {
            get
            {
                return this.areBatteriesIncludedFieldSpecified;
            }
            set
            {
                this.areBatteriesIncludedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool AreBatteriesRequired
        {
            get
            {
                return this.areBatteriesRequiredField;
            }
            set
            {
                this.areBatteriesRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AreBatteriesRequiredSpecified
        {
            get
            {
                return this.areBatteriesRequiredFieldSpecified;
            }
            set
            {
                this.areBatteriesRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatterySubgroup")]
        public BatteryBatterySubgroup[] BatterySubgroup
        {
            get
            {
                return this.batterySubgroupField;
            }
            set
            {
                this.batterySubgroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BatteryBatterySubgroup
    {

        private BatteryBatterySubgroupBatteryType batteryTypeField;

        private string numberOfBatteriesField;

        /// <remarks/>
        public BatteryBatterySubgroupBatteryType BatteryType
        {
            get
            {
                return this.batteryTypeField;
            }
            set
            {
                this.batteryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NumberOfBatteries
        {
            get
            {
                return this.numberOfBatteriesField;
            }
            set
            {
                this.numberOfBatteriesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum BatteryBatterySubgroupBatteryType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("battery_type_2/3A")]
        battery_type_23A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("battery_type_4/3A")]
        battery_type_43A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("battery_type_4/5A")]
        battery_type_45A,

        /// <remarks/>
        battery_type_9v,

        /// <remarks/>
        battery_type_12v,

        /// <remarks/>
        battery_type_a,

        /// <remarks/>
        battery_type_a76,

        /// <remarks/>
        battery_type_aa,

        /// <remarks/>
        battery_type_aaa,

        /// <remarks/>
        battery_type_aaaa,

        /// <remarks/>
        battery_type_c,

        /// <remarks/>
        battery_type_cr123a,

        /// <remarks/>
        battery_type_cr2,

        /// <remarks/>
        battery_type_cr5,

        /// <remarks/>
        battery_type_d,

        /// <remarks/>
        battery_type_lithium_ion,

        /// <remarks/>
        battery_type_lithium_metal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("battery_type_L-SC")]
        battery_type_LSC,

        /// <remarks/>
        battery_type_p76,

        /// <remarks/>
        battery_type_product_specific,

        /// <remarks/>
        battery_type_SC,
    }
}