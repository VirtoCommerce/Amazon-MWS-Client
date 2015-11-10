﻿using AmazonMWSClientLib.Model.Feeds;
using MarketplaceWebService;
using MarketplaceWebService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace AmazonMWSClientLib.Implementation.Mws
{
    /// <summary>
    /// The class can be used to send feeds to amazon using MarkteplaceWebServiceClient
    /// </summary>
    public static class SubmitFeedSender
    {
        public static IEnumerable<string> SendAmazonFeeds(IEnumerable<Product> amazonUpdateList, AmazonEnvelopeMessageType messageType, AmazonFeedType feedType, string AmazonMerchantId, string AmazonMarketplaceId, string AmazonServiceUrl, string AmazonAccessKeyId, string AmazonSecretAccessKey)
        {
            var requestResponse = new List<string>();
            
            var amazonEnvelope = new AmazonEnvelope { Header = new Header { DocumentVersion = "1.01", MerchantIdentifier = AmazonMerchantId, }, MessageType = messageType };
            var updates = new List<AmazonEnvelopeMessage>();
            var counter = 1;
            foreach (var amazonUpdate in amazonUpdateList)
            {
                var curUpdate = new AmazonEnvelopeMessage { MessageID = counter.ToString(), Item = amazonUpdate };
                updates.Add(curUpdate);
                counter++;
            }

            //add all update products to envelope's message
            amazonEnvelope.Message = updates.ToArray();

            var serializer = new XmlSerializer(amazonEnvelope.GetType());

            using (MemoryStream feedStream = new MemoryStream())
            {
                serializer.Serialize(feedStream, amazonEnvelope);

                var feedRequest = new SubmitFeedRequest
                {
                    Merchant = AmazonMerchantId,
                    MarketplaceIdList = new IdList { Id = new List<string>(new[] { AmazonMarketplaceId }) },
                    FeedType = feedType.ToString(),
                    ContentType = new ContentType(MediaType.OctetStream),
                    FeedContent = feedStream
                };

                feedRequest.ContentMD5 = MarketplaceWebServiceClient.CalculateContentMD5(feedRequest.FeedContent);
                var feedConfig = new MarketplaceWebServiceConfig { ServiceURL = AmazonServiceUrl };
                var feedService = new MarketplaceWebServiceClient(AmazonAccessKeyId, AmazonSecretAccessKey, "Virto", "1.01", feedConfig);
                var uploadSuccess = false;
                var retryCount = 0;

                while (!uploadSuccess)
                {
                    try
                    {
                        var feedResponse = feedService.SubmitFeed(feedRequest);
                        var submissionId = feedResponse.SubmitFeedResult.FeedSubmissionInfo.FeedSubmissionId;
                        requestResponse.Add(submissionId);
                        uploadSuccess = true;
                        Thread.Sleep(120000);
                    }
                    catch (Exception ex)
                    {
                        retryCount++;
                        if (retryCount == 3) break;
                        Thread.Sleep(18000);
                        if (ex.ToString().ToLowerInvariant().Contains("request is throttled")) continue;
                        requestResponse.Add(string.Format("ERROR: {0}", ex));
                    }
                }
            }
            return requestResponse;
        }
    }
}
