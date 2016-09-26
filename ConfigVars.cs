using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFAppliance
{
    public sealed class ConfigVars
    {
        public string AppID = string.Empty;
        public string IOTToken = string.Empty;
        public string EnpointUrl = string.Empty;
        public string IronMQUrl = string.Empty;
        public string IronMQProjectID = string.Empty;
        public string IronMQToken = string.Empty;
        private ConfigVars()
        {
            AppID = Environment.GetEnvironmentVariable("appID");
            IOTToken = Environment.GetEnvironmentVariable("iotToken");
            EnpointUrl = Environment.GetEnvironmentVariable("endpointURL");
            IronMQUrl = Environment.GetEnvironmentVariable("queueURL");
            IronMQProjectID = Environment.GetEnvironmentVariable("IRON_MQ_PROJECT_ID");
            IronMQToken = Environment.GetEnvironmentVariable("IRON_MQ_TOKEN");

            //for local testing
            //AppID = "APP000909A";
            //IOTToken = "Bearer iguZgpnIwr8N60cD7cYgSMbYQm9QZXEY9AaqmeD6f4d2DoyvZNEhcQdzGSSFivDylWcXR5ShTu1AfMSCJi9sAj";
            //EnpointUrl = "https://dashboard.us3.sfdcnow.com/clusters/xcdvudaz0dz3/inputstreams/appliance_sales_e001/connections/appliance_sales_i001/event";
            //IronMQUrl = "https://mq-aws-eu-west-1-1.iron.io/3/projects/57e6c63b0e8c650007ec1f00/queues/appliance_messages";
            //IronMQToken = "0FVb95I4FXy95vuUt3t4";
        }
        public static ConfigVars Instance { get { return ConfigVarInstance.Instance; } }

        private class ConfigVarInstance
        {
            static ConfigVarInstance()
            {
            }

            internal static readonly ConfigVars Instance = new ConfigVars();
        }
    }
}
