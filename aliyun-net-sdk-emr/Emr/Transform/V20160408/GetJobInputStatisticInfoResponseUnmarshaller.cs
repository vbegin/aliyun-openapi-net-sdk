/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class GetJobInputStatisticInfoResponseUnmarshaller
    {
        public static GetJobInputStatisticInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobInputStatisticInfoResponse getJobInputStatisticInfoResponse = new GetJobInputStatisticInfoResponse();

			getJobInputStatisticInfoResponse.HttpResponse = context.HttpResponse;
			getJobInputStatisticInfoResponse.RequestId = context.StringValue("GetJobInputStatisticInfo.RequestId");
			getJobInputStatisticInfoResponse.Total = context.IntegerValue("GetJobInputStatisticInfo.Total");
			getJobInputStatisticInfoResponse.PageNumber = context.IntegerValue("GetJobInputStatisticInfo.PageNumber");
			getJobInputStatisticInfoResponse.PageSize = context.IntegerValue("GetJobInputStatisticInfo.PageSize");

			List<GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput> getJobInputStatisticInfoResponse_jobInputList = new List<GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput>();
			for (int i = 0; i < context.Length("GetJobInputStatisticInfo.JobInputList.Length"); i++) {
				GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput clusterStatJobInput = new GetJobInputStatisticInfoResponse.GetJobInputStatisticInfo_ClusterStatJobInput();
				clusterStatJobInput.ApplicationId = context.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].ApplicationId");
				clusterStatJobInput.JobId = context.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].JobId");
				clusterStatJobInput.StartTime = context.LongValue("GetJobInputStatisticInfo.JobInputList["+ i +"].StartTime");
				clusterStatJobInput.FinishTime = context.LongValue("GetJobInputStatisticInfo.JobInputList["+ i +"].FinishTime");
				clusterStatJobInput.Name = context.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].Name");
				clusterStatJobInput.Queue = context.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].Queue");
				clusterStatJobInput.User = context.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].User");
				clusterStatJobInput.State = context.StringValue("GetJobInputStatisticInfo.JobInputList["+ i +"].State");
				clusterStatJobInput.BytesInput = context.LongValue("GetJobInputStatisticInfo.JobInputList["+ i +"].BytesInput");

				getJobInputStatisticInfoResponse_jobInputList.Add(clusterStatJobInput);
			}
			getJobInputStatisticInfoResponse.JobInputList = getJobInputStatisticInfoResponse_jobInputList;
        
			return getJobInputStatisticInfoResponse;
        }
    }
}
