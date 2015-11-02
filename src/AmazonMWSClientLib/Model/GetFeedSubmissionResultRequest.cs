/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MarketplaceWebService.Attributes;


namespace MarketplaceWebService.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebService(RequestType = RequestType.DEFAULT, ResponseType = ResponseType.STREAMING)]
    public class GetFeedSubmissionResultRequest
    {
    
        
        private String merchantField;
        private String mwsAuthTokenField;

        private String feedSubmissionIdField;

        private Stream feedSubmissionResultField;

        [MarketplaceWebServiceStream(StreamType = StreamType.RECEIVE_STREAM)]
        public Stream FeedSubmissionResult
        {
            get { return this.feedSubmissionResultField; }
            set { this.feedSubmissionResultField = value; }
        }

        public GetFeedSubmissionResultRequest WithFeedSubmissionResult(Stream feedSubmissionResult)
        {
            this.feedSubmissionResultField = feedSubmissionResult;
            return this;
        }
        
        /// <summary>
        /// Gets and sets the Merchant property.
        /// </summary>
        [XmlElement(ElementName = "Merchant")]
        public String Merchant
        {
            get { return this.merchantField ; }
            set { this.merchantField= value; }
        }



        /// <summary>
        /// Sets the Merchant property
        /// </summary>
        /// <param name="merchant">Merchant property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionResultRequest WithMerchant(String merchant)
        {
            this.merchantField = merchant;
            return this;
        }



        /// <summary>
        /// Checks if Merchant property is set
        /// </summary>
        /// <returns>true if Merchant property is set</returns>
        public Boolean IsSetMerchant()
        {
            return  this.merchantField != null;

        }


        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElement(ElementName = "MWSAuthToken")]
        public String MWSAuthToken
        {
            get { return this.mwsAuthTokenField; }
            set { this.mwsAuthTokenField = value; }
        }



        /// <summary>
        /// Sets the MWSAuthToken property
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionResultRequest WithMWSAuthToken(String mwsAuthToken)
        {
            this.mwsAuthTokenField = mwsAuthToken;
            return this;
        }



        /// <summary>
        /// Checks if MWSAuthToken property is set
        /// </summary>
        /// <returns>true if MWSAuthToken property is set</returns>
        public Boolean IsSetMWSAuthToken()
        {
            return this.mwsAuthTokenField != null;
        }


        /// <summary>
        /// Gets and sets the FeedSubmissionId property.
        /// </summary>
        [XmlElement(ElementName = "FeedSubmissionId")]
        public String FeedSubmissionId
        {
            get { return this.feedSubmissionIdField ; }
            set { this.feedSubmissionIdField= value; }
        }



        /// <summary>
        /// Sets the FeedSubmissionId property
        /// </summary>
        /// <param name="feedSubmissionId">FeedSubmissionId property</param>
        /// <returns>this instance</returns>
        public GetFeedSubmissionResultRequest WithFeedSubmissionId(String feedSubmissionId)
        {
            this.feedSubmissionIdField = feedSubmissionId;
            return this;
        }



        /// <summary>
        /// Checks if FeedSubmissionId property is set
        /// </summary>
        /// <returns>true if FeedSubmissionId property is set</returns>
        public Boolean IsSetFeedSubmissionId()
        {
            return  this.feedSubmissionIdField != null;

        }





    }

}
