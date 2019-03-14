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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeClusterStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeClusterStatistics_ClusterStatistics> clusterStatisticsList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeClusterStatistics_ClusterStatistics> ClusterStatisticsList
		{
			get
			{
				return clusterStatisticsList;
			}
			set	
			{
				clusterStatisticsList = value;
			}
		}

		public class DescribeClusterStatistics_ClusterStatistics
		{

			private string clusterType;

			private int? count;

			private string clusterStatus;

			public string ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public string ClusterStatus
			{
				get
				{
					return clusterStatus;
				}
				set	
				{
					clusterStatus = value;
				}
			}
		}
	}
}
