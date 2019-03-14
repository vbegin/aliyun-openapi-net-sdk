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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ModifyClusterTemplateRequest : RpcAcsRequest<ModifyClusterTemplateResponse>
    {
        public ModifyClusterTemplateRequest()
            : base("Emr", "2016-04-08", "ModifyClusterTemplate", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string logPath;

		private string masterPwd;

		private string configurations;

		private bool? ioOptimized;

		private string securityGroupId;

		private bool? sshEnable;

		private bool? easEnable;

		private string securityGroupName;

		private string depositType;

		private string accessKeyId;

		private string machineType;

		private List<BootstrapAction> bootstrapActions;

		private string regionId;

		private bool? useLocalMetaDb;

		private string emrVer;

		private string templateName;

		private string userDefinedEmrEcsRole;

		private bool? isOpenPublicIp;

		private int? period;

		private string instanceGeneration;

		private string vSwitchId;

		private string clusterType;

		private bool? autoRenew;

		private List<string> optionSoftWareLists;

		private string vpcId;

		private string netType;

		private string bizId;

		private List<HostGroup> hostGroups;

		private string zoneId;

		private string chargeType;

		private bool? useCustomHiveMetaDb;

		private List<Config> configs;

		private bool? highAvailabilityEnable;

		private bool? initCustomHiveMetaDb;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string LogPath
		{
			get
			{
				return logPath;
			}
			set	
			{
				logPath = value;
				DictionaryUtil.Add(QueryParameters, "LogPath", value);
			}
		}

		public string MasterPwd
		{
			get
			{
				return masterPwd;
			}
			set	
			{
				masterPwd = value;
				DictionaryUtil.Add(QueryParameters, "MasterPwd", value);
			}
		}

		public string Configurations
		{
			get
			{
				return configurations;
			}
			set	
			{
				configurations = value;
				DictionaryUtil.Add(QueryParameters, "Configurations", value);
			}
		}

		public bool? IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public bool? SshEnable
		{
			get
			{
				return sshEnable;
			}
			set	
			{
				sshEnable = value;
				DictionaryUtil.Add(QueryParameters, "SshEnable", value.ToString());
			}
		}

		public bool? EasEnable
		{
			get
			{
				return easEnable;
			}
			set	
			{
				easEnable = value;
				DictionaryUtil.Add(QueryParameters, "EasEnable", value.ToString());
			}
		}

		public string SecurityGroupName
		{
			get
			{
				return securityGroupName;
			}
			set	
			{
				securityGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupName", value);
			}
		}

		public string DepositType
		{
			get
			{
				return depositType;
			}
			set	
			{
				depositType = value;
				DictionaryUtil.Add(QueryParameters, "DepositType", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string MachineType
		{
			get
			{
				return machineType;
			}
			set	
			{
				machineType = value;
				DictionaryUtil.Add(QueryParameters, "MachineType", value);
			}
		}

		public List<BootstrapAction> BootstrapActions
		{
			get
			{
				return bootstrapActions;
			}

			set
			{
				bootstrapActions = value;
				for (int i = 0; i < bootstrapActions.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Path", bootstrapActions[i].Path);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Arg", bootstrapActions[i].Arg);
					DictionaryUtil.Add(QueryParameters,"BootstrapAction." + (i + 1) + ".Name", bootstrapActions[i].Name);
				}
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public bool? UseLocalMetaDb
		{
			get
			{
				return useLocalMetaDb;
			}
			set	
			{
				useLocalMetaDb = value;
				DictionaryUtil.Add(QueryParameters, "UseLocalMetaDb", value.ToString());
			}
		}

		public string EmrVer
		{
			get
			{
				return emrVer;
			}
			set	
			{
				emrVer = value;
				DictionaryUtil.Add(QueryParameters, "EmrVer", value);
			}
		}

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		public string UserDefinedEmrEcsRole
		{
			get
			{
				return userDefinedEmrEcsRole;
			}
			set	
			{
				userDefinedEmrEcsRole = value;
				DictionaryUtil.Add(QueryParameters, "UserDefinedEmrEcsRole", value);
			}
		}

		public bool? IsOpenPublicIp
		{
			get
			{
				return isOpenPublicIp;
			}
			set	
			{
				isOpenPublicIp = value;
				DictionaryUtil.Add(QueryParameters, "IsOpenPublicIp", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string InstanceGeneration
		{
			get
			{
				return instanceGeneration;
			}
			set	
			{
				instanceGeneration = value;
				DictionaryUtil.Add(QueryParameters, "InstanceGeneration", value);
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
				DictionaryUtil.Add(QueryParameters, "ClusterType", value);
			}
		}

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
			}
		}

		public List<string> OptionSoftWareLists
		{
			get
			{
				return optionSoftWareLists;
			}

			set
			{
				optionSoftWareLists = value;
				for (int i = 0; i < optionSoftWareLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OptionSoftWareList." + (i + 1) , optionSoftWareLists[i]);
				}
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string NetType
		{
			get
			{
				return netType;
			}
			set	
			{
				netType = value;
				DictionaryUtil.Add(QueryParameters, "NetType", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public List<HostGroup> HostGroups
		{
			get
			{
				return hostGroups;
			}

			set
			{
				hostGroups = value;
				for (int i = 0; i < hostGroups.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".Period", hostGroups[i].Period);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".SysDiskCapacity", hostGroups[i].SysDiskCapacity);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskCapacity", hostGroups[i].DiskCapacity);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".SysDiskType", hostGroups[i].SysDiskType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".ClusterId", hostGroups[i].ClusterId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskType", hostGroups[i].DiskType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupName", hostGroups[i].HostGroupName);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".VSwitchId", hostGroups[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".DiskCount", hostGroups[i].DiskCount);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".AutoRenew", hostGroups[i].AutoRenew);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupId", hostGroups[i].HostGroupId);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".NodeCount", hostGroups[i].NodeCount);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".InstanceType", hostGroups[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".Comment", hostGroups[i].Comment);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".ChargeType", hostGroups[i].ChargeType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".MultiInstanceTypes", hostGroups[i].MultiInstanceTypes);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".CreateType", hostGroups[i].CreateType);
					DictionaryUtil.Add(QueryParameters,"HostGroup." + (i + 1) + ".HostGroupType", hostGroups[i].HostGroupType);
				}
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public bool? UseCustomHiveMetaDb
		{
			get
			{
				return useCustomHiveMetaDb;
			}
			set	
			{
				useCustomHiveMetaDb = value;
				DictionaryUtil.Add(QueryParameters, "UseCustomHiveMetaDb", value.ToString());
			}
		}

		public List<Config> Configs
		{
			get
			{
				return configs;
			}

			set
			{
				configs = value;
				for (int i = 0; i < configs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ConfigKey", configs[i].ConfigKey);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".FileName", configs[i].FileName);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Encrypt", configs[i].Encrypt);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Replace", configs[i].Replace);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ConfigValue", configs[i].ConfigValue);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ServiceName", configs[i].ServiceName);
				}
			}
		}

		public bool? HighAvailabilityEnable
		{
			get
			{
				return highAvailabilityEnable;
			}
			set	
			{
				highAvailabilityEnable = value;
				DictionaryUtil.Add(QueryParameters, "HighAvailabilityEnable", value.ToString());
			}
		}

		public bool? InitCustomHiveMetaDb
		{
			get
			{
				return initCustomHiveMetaDb;
			}
			set	
			{
				initCustomHiveMetaDb = value;
				DictionaryUtil.Add(QueryParameters, "InitCustomHiveMetaDb", value.ToString());
			}
		}

		public class BootstrapAction
		{

			private string path;

			private string arg;

			private string name;

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string Arg
			{
				get
				{
					return arg;
				}
				set	
				{
					arg = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}

		public class HostGroup
		{

			private int? period;

			private int? sysDiskCapacity;

			private int? diskCapacity;

			private string sysDiskType;

			private string clusterId;

			private string diskType;

			private string hostGroupName;

			private string vSwitchId;

			private int? diskCount;

			private bool? autoRenew;

			private string hostGroupId;

			private int? nodeCount;

			private string instanceType;

			private string comment;

			private string chargeType;

			private string multiInstanceTypes;

			private string createType;

			private string hostGroupType;

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public int? SysDiskCapacity
			{
				get
				{
					return sysDiskCapacity;
				}
				set	
				{
					sysDiskCapacity = value;
				}
			}

			public int? DiskCapacity
			{
				get
				{
					return diskCapacity;
				}
				set	
				{
					diskCapacity = value;
				}
			}

			public string SysDiskType
			{
				get
				{
					return sysDiskType;
				}
				set	
				{
					sysDiskType = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			public string HostGroupName
			{
				get
				{
					return hostGroupName;
				}
				set	
				{
					hostGroupName = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public int? DiskCount
			{
				get
				{
					return diskCount;
				}
				set	
				{
					diskCount = value;
				}
			}

			public bool? AutoRenew
			{
				get
				{
					return autoRenew;
				}
				set	
				{
					autoRenew = value;
				}
			}

			public string HostGroupId
			{
				get
				{
					return hostGroupId;
				}
				set	
				{
					hostGroupId = value;
				}
			}

			public int? NodeCount
			{
				get
				{
					return nodeCount;
				}
				set	
				{
					nodeCount = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			public string MultiInstanceTypes
			{
				get
				{
					return multiInstanceTypes;
				}
				set	
				{
					multiInstanceTypes = value;
				}
			}

			public string CreateType
			{
				get
				{
					return createType;
				}
				set	
				{
					createType = value;
				}
			}

			public string HostGroupType
			{
				get
				{
					return hostGroupType;
				}
				set	
				{
					hostGroupType = value;
				}
			}
		}

		public class Config
		{

			private string configKey;

			private string fileName;

			private string encrypt;

			private string replace;

			private string configValue;

			private string serviceName;

			public string ConfigKey
			{
				get
				{
					return configKey;
				}
				set	
				{
					configKey = value;
				}
			}

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public string Encrypt
			{
				get
				{
					return encrypt;
				}
				set	
				{
					encrypt = value;
				}
			}

			public string Replace
			{
				get
				{
					return replace;
				}
				set	
				{
					replace = value;
				}
			}

			public string ConfigValue
			{
				get
				{
					return configValue;
				}
				set	
				{
					configValue = value;
				}
			}

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}
		}

        public override ModifyClusterTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyClusterTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
