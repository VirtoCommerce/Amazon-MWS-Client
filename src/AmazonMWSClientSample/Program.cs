using AmazonMWSClientLib.Implementation.Mws;
using AmazonMWSClientLib.Model.Feeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSClientSample
{
    class Program
    {
        private const string serviceUrl = "https://mws.amazonservices.com";
        private const string accessKeyId = "";
        private const string merchantId = "";
        private const string marketplaceId = "";
        private const string secretAccessKey = "";

        static void Main(string[] args)
        {
            var amazonProduct = new Product();

            amazonProduct.DescriptionData = new ProductDescriptionData
            {
                Brand = "Brand",
                Description = "Product description"
            };

            amazonProduct.Condition = new ConditionInfo { ConditionType = ConditionType.New };
            amazonProduct.ExternalProductUrl = "http://demo.virtocommerce.com";
            amazonProduct.SKU = "SKU987654321";
            amazonProduct.StandardProductID = new StandardProductID { Value = amazonProduct.SKU, Type = StandardProductIDType.ASIN };
            amazonProduct.ProductData = new ProductProductData { Item = new Home() };

            SubmitFeedSender.SendAmazonFeeds(new List<Product> { amazonProduct }, AmazonEnvelopeMessageType.Product, AmazonFeedType._POST_PRODUCT_DATA_, merchantId, marketplaceId, serviceUrl, accessKeyId, secretAccessKey);
        }

        private Product GenerateProduct()
        {
            var amazonProduct = new Product();

            amazonProduct.DescriptionData =  new ProductDescriptionData
                {
                    Brand = "Brand",
                    Description = "Product description",

                };

            amazonProduct.Condition = new ConditionInfo { ConditionType = ConditionType.New };
            amazonProduct.ExternalProductUrl = "http://demo.virtocommerce.com";
            amazonProduct.SKU = "SKU987654321";
            amazonProduct.StandardProductID = new StandardProductID { Value = amazonProduct.SKU, Type = StandardProductIDType.ASIN };
            amazonProduct.ProductData = new ProductProductData { Item = new Home() };
            
            return amazonProduct;
        }
    }
}
