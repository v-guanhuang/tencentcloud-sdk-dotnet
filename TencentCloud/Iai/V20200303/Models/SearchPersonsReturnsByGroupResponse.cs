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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchPersonsReturnsByGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// 搜索的人员库中包含的人员数。若输入图片中所有人脸均不符合质量要求，则返回0。
        /// </summary>
        [JsonProperty("PersonNum")]
        public ulong? PersonNum{ get; set; }

        /// <summary>
        /// 识别结果。
        /// </summary>
        [JsonProperty("ResultsReturnsByGroup")]
        public ResultsReturnsByGroup[] ResultsReturnsByGroup{ get; set; }

        /// <summary>
        /// 人脸识别所用的算法模型版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonNum", this.PersonNum);
            this.SetParamArrayObj(map, prefix + "ResultsReturnsByGroup.", this.ResultsReturnsByGroup);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
