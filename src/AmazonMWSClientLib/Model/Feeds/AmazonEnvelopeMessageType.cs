using System;
using System.Xml.Serialization;

namespace  AmazonMWSClientLib.Model.Feeds
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true)]
    public enum AmazonEnvelopeMessageType
    {

        /// <remarks/>
        CatPIL,

        /// <remarks/>
        Customer,

        /// <remarks/>
        FulfillmentCenter,

        /// <remarks/>
        FulfillmentOrderCancellationRequest,

        /// <remarks/>
        FulfillmentOrderRequest,

        /// <remarks/>
        Image,

        /// <remarks/>
        Inventory,

        /// <remarks/>
        Item,

        /// <remarks/>
        Listings,

        /// <remarks/>
        Loyalty,

        /// <remarks/>
        MultiChannelOrderReport,

        /// <remarks/>
        NavigationReport,

        /// <remarks/>
        Offer,

        /// <remarks/>
        OrderAcknowledgement,

        /// <remarks/>
        OrderAdjustment,

        /// <remarks/>
        OrderFulfillment,

        /// <remarks/>
        OrderNotificationReport,

        /// <remarks/>
        OrderReport,

        /// <remarks/>
        Override,

        /// <remarks/>
        Price,

        /// <remarks/>
        ProcessingReport,

        /// <remarks/>
        Product,

        /// <remarks/>
        ProductImage,

        /// <remarks/>
        Relationship,

        /// <remarks/>
        ReverseItem,

        /// <remarks/>
        SettlementReport,

        /// <remarks/>
        Store,

        /// <remarks/>
        WebstoreItem,
    }
}