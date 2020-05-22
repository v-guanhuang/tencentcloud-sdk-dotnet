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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMediaRecognitionRequest : AbstractModel
    {
        
        /// <summary>
        /// 公共参数Common类
        /// </summary>
        [JsonProperty("MessageCommon")]
        public MessageCommonGjh MessageCommon{ get; set; }

        /// <summary>
        /// 内容相关参数
        /// </summary>
        [JsonProperty("MessageContent")]
        public MessageContentGjh MessageContent{ get; set; }

        /// <summary>
        /// 内容ID参数
        /// </summary>
        [JsonProperty("MessageId")]
        public MessageIdGjh MessageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MessageCommon.", this.MessageCommon);
            this.SetParamObj(map, prefix + "MessageContent.", this.MessageContent);
            this.SetParamObj(map, prefix + "MessageId.", this.MessageId);
        }
    }
}
