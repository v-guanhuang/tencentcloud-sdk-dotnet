/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mvj.V20190926
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mvj.V20190926.Models;

   public class MvjClient : AbstractClient{

       private const string endpoint = "mvj.tencentcloudapi.com";
       private const string version = "2019-09-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MvjClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MvjClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 欢迎使用营销价值判断（Marketing Value Judgement，简称 MVJ）。
        /// 
        /// 营销价值判断（MVJ）是针对零售场景的风控服务，通过识别高价值顾客，以帮助零售商保障营销资金
        /// </summary>
        /// <param name="req"><see cref="MarketingValueJudgementRequest"/></param>
        /// <returns><see cref="MarketingValueJudgementResponse"/></returns>
        public async Task<MarketingValueJudgementResponse> MarketingValueJudgement(MarketingValueJudgementRequest req)
        {
             JsonResponseModel<MarketingValueJudgementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MarketingValueJudgement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MarketingValueJudgementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 欢迎使用营销价值判断（Marketing Value Judgement，简称 MVJ）。
        /// 
        /// 营销价值判断（MVJ）是针对零售场景的风控服务，通过识别高价值顾客，以帮助零售商保障营销资金
        /// </summary>
        /// <param name="req"><see cref="MarketingValueJudgementRequest"/></param>
        /// <returns><see cref="MarketingValueJudgementResponse"/></returns>
        public MarketingValueJudgementResponse MarketingValueJudgementSync(MarketingValueJudgementRequest req)
        {
             JsonResponseModel<MarketingValueJudgementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MarketingValueJudgement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MarketingValueJudgementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
