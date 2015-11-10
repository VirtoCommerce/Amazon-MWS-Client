using AmazonMWSClientLib.Implementation.Mws;
using AmazonMWSClientLib.Model.Feeds;
using MarketplaceWebService;
using MarketplaceWebService.Mock;
using MarketplaceWebService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSClientSample
{
    class Program
    {
        //private const string serviceUrl = "https://mws.amazonservices.com";
        //private const string accessKeyId = "accessKey";
        //private const string merchantId = "merchant";
        //private const string marketplaceId = "marketplace";
        //private const string secretAccessKey = "secretKey";

        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to Marketplace Web Service Samples!");
            Console.WriteLine("===========================================");

            Console.WriteLine("To get started:");
            Console.WriteLine("===========================================");
            Console.WriteLine("  - Fill in your AWS credentials");
            Console.WriteLine("  - Uncomment sample you're interested in trying");
            Console.WriteLine("  - Set request with desired parameters");
            Console.WriteLine("  - Hit F5 to run!");
            Console.WriteLine();

            Console.WriteLine("===========================================");
            Console.WriteLine("Samples Output");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            /************************************************************************
             * Access Key ID and Secret Acess Key ID, obtained from:
             * http://aws.amazon.com
             * 
             * IMPORTANT: Your Secret Access Key is a secret, and should be known 
             * only by you and AWS. You should never include your Secret Access Key 
             * in your requests to AWS. You should never e-mail your Secret Access Key 
             * to anyone. It is important to keep your Secret Access Key confidential 
             * to protect your account.
             ***********************************************************************/
            String accessKeyId = "<Your AWS Access Key>";
            String secretAccessKey = "<Your AWS Secret Key>";

            /************************************************************************
            * Instantiate  Implementation of Marketplace Web Service 
            ***********************************************************************/

            //MarketplaceWebServiceConfig config = new MarketplaceWebServiceConfig();

            /************************************************************************
             * The application name and version are included in each MWS call's
             * HTTP User-Agent field. These are required fields.
             ***********************************************************************/

            const string applicationName = "<Your Application Name>";
            const string applicationVersion = "<Your Application Version>";

            //MarketplaceWebService service =
            //    new MarketplaceWebServiceClient(
            //        accessKeyId,
            //        secretAccessKey,
            //        applicationName,
            //        applicationVersion,
            //        config);


            /************************************************************************
             * All MWS requests must contain the seller's merchant ID and 
             * marketplace ID.
             ***********************************************************************/
            const string merchantId = "<Your Merchant ID>";
            const string marketplaceId = "<Your Marketplace ID>";

            /************************************************************************
             * Uncomment to configure the client instance. Configuration settings
             * include:
             *
             *  - MWS Service endpoint URL
             *  - Proxy Host and Proxy Port
             *  - User Agent String to be sent to Marketplace Web Service  service
             *
             ***********************************************************************/
            MarketplaceWebServiceConfig config = new MarketplaceWebServiceConfig();
            //config.ProxyHost = "https://PROXY_URL";
            //config.ProxyPort = 9090;
            //
            // IMPORTANT: Uncomment out the appropiate line for the country you wish 
            // to sell in:
            // 
            // United States:
             config.ServiceURL = "https://mws.amazonservices.com";
            //
            // United Kingdom:
            // config.ServiceURL = "https://mws.amazonservices.co.uk";
            //
            // Germany:
            // config.ServiceURL = "https://mws.amazonservices.de";
            //
            // France:
            // config.ServiceURL = "https://mws.amazonservices.fr";
            //
            // Japan:
            // config.ServiceURL = "https://mws.amazonservices.jp";
            //
            // China:
            // config.ServiceURL = "https://mws.amazonservices.com.cn";
            //
            // Canada:
            // config.ServiceURL = "https://mws.amazonservices.ca";
            //
            // Italy:
            // config.ServiceURL = "https://mws.amazonservices.it";
            //
            //config.SetUserAgentHeader(
            //    applicationName,
            //    applicationVersion,
            //    "C#",
            //    "<Parameter 1>", "<Parameter 2>");
            //MarketplaceWebService service = new MarketplaceWebServiceClient(accessKeyId, secretAccessKey, config);


            /************************************************************************
             * Uncomment to try out Mock Service that simulates Marketplace Web Service 
             * responses without calling Marketplace Web Service  service.
             *
             * Responses are loaded from local XML files. You can tweak XML files to
             * experiment with various outputs during development
             *
             * XML files available under MarketplaceWebService\Mock tree
             *
             ***********************************************************************/
            IMarketplaceWebServiceClient service = new MockMarketplaceWebServiceClient();


            /************************************************************************
             * Uncomment to invoke Get Report Action
             ***********************************************************************/
            {
                //GetReportRequest request = new GetReportRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional

                ////Note that depending on the type of report being downloaded, a report can reach
                ////sizes greater than 1GB.For this reason we recommend that you _always_ program to
                //// MWS in a streaming fashion.Otherwise, as your business grows you may silently reach
                //// the in-memory size limit and have to re-work your solution.
                //// NOTE: Due to Content - MD5 validation, the stream must be read / write.
                //   request.ReportId = "REPORT_ID";
                //request.Report = File.Open("report.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //GetReportSample.InvokeGetReport(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report Schedule Count Action
             ***********************************************************************/
            {
                //GetReportScheduleCountRequest request = new GetReportScheduleCountRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //// @TODO: set additional request parameters here
                //GetReportScheduleCountSample.InvokeGetReportScheduleCount(service, request);
            }


            /************************************************************************
             * Uncomment to invoke Get Report Request List By Next Token Action
             ***********************************************************************/
            {
                //GetReportRequestListByNextTokenRequest request = new GetReportRequestListByNextTokenRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.NextToken = "NextToken from GetReportRequestList";
                // @TODO: set additional request parameters here
                //GetReportRequestListByNextTokenSample.InvokeGetReportRequestListByNextToken(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Update Report Acknowledgements Action
             ***********************************************************************/
            {
                //UpdateReportAcknowledgementsRequest request = new UpdateReportAcknowledgementsRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.WithReportIdList(new IdList().WithId("REPORT_ID"));
                // @TODO: set additional request parameters here
                //UpdateReportAcknowledgementsSample.InvokeUpdateReportAcknowledgements(service, request);
            }


            /************************************************************************
             * Uncomment to invoke Submit Feed Action
             ***********************************************************************/
            {               

                // MWS exclusively offers a streaming interface for uploading your feeds. This is because 
                // feed sizes can grow to the 1GB+ range - and as your business grows you could otherwise 
                // silently reach the feed size where your in-memory solution will no longer work, leaving you 
                // puzzled as to why a solution that worked for a long time suddenly stopped working though 
                // you made no changes. For the same reason, we strongly encourage you to generate your feeds to 
                // local disk then upload them directly from disk to MWS.
                
                var amazonProduct = GenerateProduct();
                var response = SubmitFeedSender.SendAmazonFeeds(new List<Product> { amazonProduct }, AmazonEnvelopeMessageType.Product, AmazonFeedType._POST_PRODUCT_DATA_, merchantId, marketplaceId, config.ServiceURL, accessKeyId, secretAccessKey);
                
                if (response.IsSetResponseMetadata())
                {
                    Console.WriteLine("            ResponseMetadata");
                    ResponseMetadata responseMetadata = response.ResponseMetadata;
                    if (responseMetadata.IsSetRequestId())
                    {
                        Console.WriteLine("                RequestId");
                        Console.WriteLine("                    {0}", responseMetadata.RequestId);
                    }                    
                }

                if (response.IsSetSubmitFeedResult())
                {
                    Console.WriteLine("            SubmitFeedResult");
                    var submitFeedResult = response.SubmitFeedResult;
                    if (submitFeedResult.FeedSubmissionInfo.IsSetFeedSubmissionId())
                    {
                        Console.WriteLine("                SubmissionId");
                        Console.WriteLine("                    {0}", submitFeedResult.FeedSubmissionInfo.FeedSubmissionId);
                    }
                }

                Console.WriteLine("            ResponseHeaderMetadata");
                Console.WriteLine("                RequestId");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.RequestId);
                Console.WriteLine("                ResponseContext");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.ResponseContext);
                Console.WriteLine("                Timestamp");
                Console.WriteLine("                    " + response.ResponseHeaderMetadata.Timestamp);
            }


            /************************************************************************
             * Uncomment to invoke Get Report Count Action
             ***********************************************************************/
            {
                // GetReportCountRequest request = new GetReportCountRequest();
                // request.Merchant = merchantId;
                // request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                // GetReportCountSample.InvokeGetReportCount(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Feed Submission List By Next Token Action
             ***********************************************************************/
            {
                //GetFeedSubmissionListByNextTokenRequest request = new GetFeedSubmissionListByNextTokenRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.NextToken = "NextToken from GetFeedSubmissionList";
                // @TODO: set additional request parameters here
                //GetFeedSubmissionListByNextTokenSample.InvokeGetFeedSubmissionListByNextToken(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Cancel Feed Submissions Action
             ***********************************************************************/
            {
                //CancelFeedSubmissionsRequest request = new CancelFeedSubmissionsRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //CancelFeedSubmissionsSample.InvokeCancelFeedSubmissions(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Request Report Action
             ***********************************************************************/
            {
                //RequestReportRequest request = new RequestReportRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.MarketplaceIdList = new IdList();
                //request.MarketplaceIdList.Id = new List<string>( new string [] { marketplaceId } );

                //request.ReportType = "Desired Report Type";
                // @TODO: set additional request parameters here
                //request.ReportOptions = "ShowSalesChannel=true"; 
                //RequestReportSample.InvokeRequestReport(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Feed Submission Count Action
             ***********************************************************************/
            {
                //GetFeedSubmissionCountRequest request = new GetFeedSubmissionCountRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //GetFeedSubmissionCountSample.InvokeGetFeedSubmissionCount(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Cancel Report Requests Action
             ***********************************************************************/
            {
                //CancelReportRequestsRequest request = new CancelReportRequestsRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //CancelReportRequestsSample.InvokeCancelReportRequests(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report List Action
             ***********************************************************************/
            {
                //GetReportListRequest request = new GetReportListRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //GetReportListSample.InvokeGetReportList(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Feed Submission Result Action
             ***********************************************************************/
            {
                //GetFeedSubmissionResultRequest request = new GetFeedSubmissionResultRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional

                // Note that depending on the size of the feed sent in, and the number of errors and warnings,
                // the result can reach sizes greater than 1GB. For this reason we recommend that you _always_ 
                // program to MWS in a streaming fashion. Otherwise, as your business grows you may silently reach
                // the in-memory size limit and have to re-work your solution.
                // NOTE: Due to Content-MD5 validation, the stream must be read/write.
                //request.FeedSubmissionId = "FEED_SUBMISSION_ID";
                //request.FeedSubmissionResult = File.Open("feedSubmissionResult.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                //GetFeedSubmissionResultSample.InvokeGetFeedSubmissionResult(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Feed Submission List Action
             ***********************************************************************/
            {
                //GetFeedSubmissionListRequest request = new GetFeedSubmissionListRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //GetFeedSubmissionListSample.InvokeGetFeedSubmissionList(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report Request List Action
             ***********************************************************************/
            {
                //GetReportRequestListRequest request = new GetReportRequestListRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //GetReportRequestListSample.InvokeGetReportRequestList(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report Schedule List By Next Token Action
             ***********************************************************************/
            {
                //GetReportScheduleListByNextTokenRequest request = new GetReportScheduleListByNextTokenRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.NextToken = "NextToken from GetReportScheduleList";
                // @TODO: set additional request parameters here
                //GetReportScheduleListByNextTokenSample.InvokeGetReportScheduleListByNextToken(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report List By Next Token Action
             ***********************************************************************/
            {
                // GetReportListByNextTokenRequest request = new GetReportListByNextTokenRequest();
                // request.Merchant = merchantId;
                // request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.NextToken = "NextToken from GetReportList";
                // @TODO: set additional request parameters here
                // GetReportListByNextTokenSample.InvokeGetReportListByNextToken(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Manage Report Schedule Action
             ***********************************************************************/
            {
                //ManageReportScheduleRequest request = new ManageReportScheduleRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                //request.ReportType = "Report Type";
                //request.Schedule = "Schedule";
                // @TODO: set additional request parameters here
                //ManageReportScheduleSample.InvokeManageReportSchedule(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report Request Count Action
             ***********************************************************************/
            {
                //GetReportRequestCountRequest request = new GetReportRequestCountRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //GetReportRequestCountSample.InvokeGetReportRequestCount(service, request);
            }

            /************************************************************************
             * Uncomment to invoke Get Report Schedule List Action
             ***********************************************************************/
            {
                //GetReportScheduleListRequest request = new GetReportScheduleListRequest();
                //request.Merchant = merchantId;
                //request.MWSAuthToken = "<Your MWS Auth Token>"; // Optional
                // @TODO: set additional request parameters here
                //GetReportScheduleListSample.InvokeGetReportScheduleList(service, request);
            }


            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("End of output. You can close this window");
            Console.WriteLine("===========================================");

            System.Threading.Thread.Sleep(50000);
        }

        //{
        //    var amazonProduct = new Product();

        //    amazonProduct.DescriptionData = new ProductDescriptionData
        //    {
        //        Brand = "Brand",
        //        Description = "Product description"
        //    };

        //    amazonProduct.Condition = new ConditionInfo { ConditionType = ConditionType.New };
        //    amazonProduct.ExternalProductUrl = "http://demo.virtocommerce.com";
        //    amazonProduct.SKU = "SKU987654321";
        //    amazonProduct.StandardProductID = new StandardProductID { Value = amazonProduct.SKU, Type = StandardProductIDType.ASIN };
        //    amazonProduct.ProductData = new ProductProductData { Item = new Home() };

        //    var response = SubmitFeedSender.SendAmazonFeeds(new List<Product> { amazonProduct, amazonProduct }, AmazonEnvelopeMessageType.Product, AmazonFeedType._POST_PRODUCT_DATA_, merchantId, marketplaceId, serviceUrl, accessKeyId, secretAccessKey);
        //    (response as List<string>).ForEach(line => Console.WriteLine(line));
        //    Console.ReadLine();
        //}

        private static Product GenerateProduct()
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
