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

namespace TencentCloud.Bm.V20180423
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bm.V20180423.Models;

   public class BmClient : AbstractClient{

       private const string endpoint = "bm.tencentcloudapi.com";
       private const string version = "2018-04-23";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public BmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public BmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 为预授权规则绑定标签
        /// </summary>
        /// <param name="req">参考<see cref="BindPsaTagRequest"/></param>
        /// <returns>参考<see cref="BindPsaTagResponse"/>实例</returns>
        public async Task<BindPsaTagResponse> BindPsaTag(BindPsaTagRequest req)
        {
             JsonResponseModel<BindPsaTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindPsaTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindPsaTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建预授权规则
        /// </summary>
        /// <param name="req">参考<see cref="CreatePsaRegulationRequest"/></param>
        /// <returns>参考<see cref="CreatePsaRegulationResponse"/>实例</returns>
        public async Task<CreatePsaRegulationResponse> CreatePsaRegulation(CreatePsaRegulationRequest req)
        {
             JsonResponseModel<CreatePsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建黑石竞价实例
        /// </summary>
        /// <param name="req">参考<see cref="CreateSpotDeviceRequest"/></param>
        /// <returns>参考<see cref="CreateSpotDeviceResponse"/>实例</returns>
        public async Task<CreateSpotDeviceResponse> CreateSpotDevice(CreateSpotDeviceRequest req)
        {
             JsonResponseModel<CreateSpotDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSpotDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSpotDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="CreateUserCmdRequest"/></param>
        /// <returns>参考<see cref="CreateUserCmdResponse"/>实例</returns>
        public async Task<CreateUserCmdResponse> CreateUserCmd(CreateUserCmdRequest req)
        {
             JsonResponseModel<CreateUserCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除预授权规则
        /// </summary>
        /// <param name="req">参考<see cref="DeletePsaRegulationRequest"/></param>
        /// <returns>参考<see cref="DeletePsaRegulationResponse"/>实例</returns>
        public async Task<DeletePsaRegulationResponse> DeletePsaRegulation(DeletePsaRegulationRequest req)
        {
             JsonResponseModel<DeletePsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="DeleteUserCmdsRequest"/></param>
        /// <returns>参考<see cref="DeleteUserCmdsResponse"/>实例</returns>
        public async Task<DeleteUserCmdsResponse> DeleteUserCmds(DeleteUserCmdsRequest req)
        {
             JsonResponseModel<DeleteUserCmdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserCmds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserCmdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务器价格信息，支持设备的批量查找，支持标准机型和弹性机型的混合查找
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicePriceInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicePriceInfoResponse"/>实例</returns>
        public async Task<DescribeDevicePriceInfoResponse> DescribeDevicePriceInfo(DescribeDevicePriceInfoRequest req)
        {
             JsonResponseModel<DescribeDevicePriceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePriceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePriceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询物理服务器，可以按照实例，业务IP等过滤
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDevicesRequest"/></param>
        /// <returns>参考<see cref="DescribeDevicesResponse"/>实例</returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取预授权规则列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribePsaRegulationsRequest"/></param>
        /// <returns>参考<see cref="DescribePsaRegulationsResponse"/>实例</returns>
        public async Task<DescribePsaRegulationsResponse> DescribePsaRegulations(DescribePsaRegulationsRequest req)
        {
             JsonResponseModel<DescribePsaRegulationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePsaRegulations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePsaRegulationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 维修任务配置获取
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRepairTaskConstantRequest"/></param>
        /// <returns>参考<see cref="DescribeRepairTaskConstantResponse"/>实例</returns>
        public async Task<DescribeRepairTaskConstantResponse> DescribeRepairTaskConstant(DescribeRepairTaskConstantRequest req)
        {
             JsonResponseModel<DescribeRepairTaskConstantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRepairTaskConstant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRepairTaskConstantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户维修任务列表及详细信息<br>
        /// <br>
        /// TaskStatus（任务状态ID）与状态中文名的对应关系如下：<br>
        /// 1：未授权<br>
        /// 2：处理中<br>
        /// 3：待确认<br>
        /// 4：未授权-暂不处理<br>
        /// 5：已恢复<br>
        /// 6：待确认-未恢复<br>
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskInfoResponse"/>实例</returns>
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取维修任务操作日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskOperationLogRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskOperationLogResponse"/>实例</returns>
        public async Task<DescribeTaskOperationLogResponse> DescribeTaskOperationLog(DescribeTaskOperationLogRequest req)
        {
             JsonResponseModel<DescribeTaskOperationLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskOperationLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskOperationLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义脚本任务详细信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserCmdTaskInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeUserCmdTaskInfoResponse"/>实例</returns>
        public async Task<DescribeUserCmdTaskInfoResponse> DescribeUserCmdTaskInfo(DescribeUserCmdTaskInfoRequest req)
        {
             JsonResponseModel<DescribeUserCmdTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCmdTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义脚本任务列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserCmdTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeUserCmdTasksResponse"/>实例</returns>
        public async Task<DescribeUserCmdTasksResponse> DescribeUserCmdTasks(DescribeUserCmdTasksRequest req)
        {
             JsonResponseModel<DescribeUserCmdTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCmdTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取自定义脚本信息列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUserCmdsRequest"/></param>
        /// <returns>参考<see cref="DescribeUserCmdsResponse"/>实例</returns>
        public async Task<DescribeUserCmdsResponse> DescribeUserCmds(DescribeUserCmdsRequest req)
        {
             JsonResponseModel<DescribeUserCmdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCmds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserCmdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改服务器名称
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDeviceAliasesRequest"/></param>
        /// <returns>参考<see cref="ModifyDeviceAliasesResponse"/>实例</returns>
        public async Task<ModifyDeviceAliasesResponse> ModifyDeviceAliases(ModifyDeviceAliasesRequest req)
        {
             JsonResponseModel<ModifyDeviceAliasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDeviceAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将设备的预付费模式修改为后付费计费模式，支持批量转换。（前提是客户要加入黑石物理机后付费计费的白名单，申请黑石物理机后付费可以联系腾讯云客服）
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPayModePre2PostRequest"/></param>
        /// <returns>参考<see cref="ModifyPayModePre2PostResponse"/>实例</returns>
        public async Task<ModifyPayModePre2PostResponse> ModifyPayModePre2Post(ModifyPayModePre2PostRequest req)
        {
             JsonResponseModel<ModifyPayModePre2PostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPayModePre2Post");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPayModePre2PostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 允许修改规则信息及关联故障类型
        /// </summary>
        /// <param name="req">参考<see cref="ModifyPsaRegulationRequest"/></param>
        /// <returns>参考<see cref="ModifyPsaRegulationResponse"/>实例</returns>
        public async Task<ModifyPsaRegulationResponse> ModifyPsaRegulation(ModifyPsaRegulationRequest req)
        {
             JsonResponseModel<ModifyPsaRegulationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPsaRegulation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPsaRegulationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="ModifyUserCmdRequest"/></param>
        /// <returns>参考<see cref="ModifyUserCmdResponse"/>实例</returns>
        public async Task<ModifyUserCmdResponse> ModifyUserCmd(ModifyUserCmdRequest req)
        {
             JsonResponseModel<ModifyUserCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启机器
        /// </summary>
        /// <param name="req">参考<see cref="RebootDevicesRequest"/></param>
        /// <returns>参考<see cref="RebootDevicesResponse"/>实例</returns>
        public async Task<RebootDevicesResponse> RebootDevices(RebootDevicesRequest req)
        {
             JsonResponseModel<RebootDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebootDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebootDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于操作维修任务<br>
        /// 入参TaskId为维修任务ID<br>
        /// 入参Operate表示对维修任务的操作，支持如下取值：<br>
        /// AuthorizeRepair（授权维修）<br>
        /// Ignore（暂不提醒）<br>
        /// ConfirmRecovered（维修完成后，确认故障恢复）<br>
        /// ConfirmUnRecovered（维修完成后，确认故障未恢复）<br>
        /// <br>
        /// 操作约束（当前任务状态(TaskStatus)->对应可执行的操作）：<br>
        /// 未授权(1)->授权维修；暂不处理<br>
        /// 暂不处理(4)->授权维修<br>
        /// 待确认(3)->确认故障恢复；确认故障未恢复<br>
        /// 未恢复(6)->确认故障恢复<br>
        /// <br>
        /// 对于Ping不可达故障的任务，还允许：<br>
        /// 未授权->确认故障恢复<br>
        /// 暂不处理->确认故障恢复<br>
        /// <br>
        /// 处理中与已恢复状态的任务不允许进行操作。<br>
        /// <br>
        /// 详细信息请访问：https://cloud.tencent.com/document/product/386/18190
        /// </summary>
        /// <param name="req">参考<see cref="RepairTaskControlRequest"/></param>
        /// <returns>参考<see cref="RepairTaskControlResponse"/>实例</returns>
        public async Task<RepairTaskControlResponse> RepairTaskControl(RepairTaskControlRequest req)
        {
             JsonResponseModel<RepairTaskControlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RepairTaskControl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RepairTaskControlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置服务器密码
        /// </summary>
        /// <param name="req">参考<see cref="ResetDevicePasswordRequest"/></param>
        /// <returns>参考<see cref="ResetDevicePasswordResponse"/>实例</returns>
        public async Task<ResetDevicePasswordResponse> ResetDevicePassword(ResetDevicePasswordRequest req)
        {
             JsonResponseModel<ResetDevicePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDevicePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDevicePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行自定义脚本
        /// </summary>
        /// <param name="req">参考<see cref="RunUserCmdRequest"/></param>
        /// <returns>参考<see cref="RunUserCmdResponse"/>实例</returns>
        public async Task<RunUserCmdResponse> RunUserCmd(RunUserCmdRequest req)
        {
             JsonResponseModel<RunUserCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunUserCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunUserCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除标签与预授权规则的绑定
        /// </summary>
        /// <param name="req">参考<see cref="UnbindPsaTagRequest"/></param>
        /// <returns>参考<see cref="UnbindPsaTagResponse"/>实例</returns>
        public async Task<UnbindPsaTagResponse> UnbindPsaTag(UnbindPsaTagRequest req)
        {
             JsonResponseModel<UnbindPsaTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindPsaTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindPsaTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}