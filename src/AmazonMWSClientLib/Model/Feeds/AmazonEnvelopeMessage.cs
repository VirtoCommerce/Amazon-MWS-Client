using System;
using System.Xml.Serialization;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class AmazonEnvelopeMessage
    {

        private string messageIDField;

        private AmazonEnvelopeMessageOperationType operationTypeField;

        private bool operationTypeFieldSpecified;

        private object itemField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }

        /// <remarks/>
        public AmazonEnvelopeMessageOperationType OperationType
        {
            get
            {
                return this.operationTypeField;
            }
            set
            {
                this.operationTypeField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore]
        public bool OperationTypeSpecified
        {
            get
            {
                return this.operationTypeFieldSpecified;
            }
            set
            {
                this.operationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement("CatPIL", typeof(CatPIL))]
        [XmlElement("Customer", typeof(Customer1))]
        [XmlElement("FulfillmentCenter", typeof(FulfillmentCenter))]
        [XmlElement("FulfillmentOrderCancellationRequest", typeof(FulfillmentOrderCancellationRequest))]
        [XmlElement("FulfillmentOrderRequest", typeof(FulfillmentOrderRequest))]
        [XmlElement("Image", typeof(Image))]
        [XmlElement("Inventory", typeof(Inventory))]
        [XmlElement("Item", typeof(Item))]
        [XmlElement("Listings", typeof(Listings))]
        [XmlElement("Loyalty", typeof(Loyalty))]
        [XmlElement("MultiChannelOrderReport", typeof(MultiChannelOrderReport))]
        [XmlElement("NavigationReport", typeof(NavigationReport))]
        [XmlElement("Offer", typeof(Offer))]
        [XmlElement("OrderAcknowledgement", typeof(OrderAcknowledgement))]
        [XmlElement("OrderAdjustment", typeof(OrderAdjustment))]
        [XmlElement("OrderFulfillment", typeof(OrderFulfillment))]
        [XmlElement("OrderNotificationReport", typeof(OrderNotificationReport))]
        [XmlElement("OrderReport", typeof(OrderReport))]
        [XmlElement("Override", typeof(Override))]
        [XmlElement("Price", typeof(Price))]
        [XmlElement("ProcessingReport", typeof(ProcessingReport))]
        [XmlElement("Product", typeof(Product))]
        [XmlElement("ProductImage", typeof(ProductImage))]
        [XmlElement("Relationship", typeof(Relationship))]
        [XmlElement("ReverseItem", typeof(ReverseItem))]
        [XmlElement("SettlementReport", typeof(SettlementReport))]
        [XmlElement("Store", typeof(Store))]
        [XmlElement("WebstoreItem", typeof(WebstoreItem))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}