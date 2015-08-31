using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ADALForForms.Model
{
    public partial class UserModel
    {
        public class AssignedLicens
        {

            [JsonProperty("disabledPlans")]
            public object[] DisabledPlans { get; set; }

            [JsonProperty("skuId")]
            public string SkuId { get; set; }
        }
    }

    public partial class UserModel
    {
        public class AssignedPlan
        {

            [JsonProperty("assignedTimestamp")]
            public string AssignedTimestamp { get; set; }

            [JsonProperty("capabilityStatus")]
            public string CapabilityStatus { get; set; }

            [JsonProperty("service")]
            public string Service { get; set; }

            [JsonProperty("servicePlanId")]
            public string ServicePlanId { get; set; }
        }
    }

    public partial class UserModel
    {
        public class ProvisionedPlan
        {

            [JsonProperty("capabilityStatus")]
            public string CapabilityStatus { get; set; }

            [JsonProperty("provisioningStatus")]
            public string ProvisioningStatus { get; set; }

            [JsonProperty("service")]
            public string Service { get; set; }
        }
    }

    public partial class UserModel
    {

        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("deletionTimestamp")]
        public object DeletionTimestamp { get; set; }

        [JsonProperty("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonProperty("assignedLicenses")]
        public AssignedLicens[] AssignedLicenses { get; set; }

        [JsonProperty("assignedPlans")]
        public AssignedPlan[] AssignedPlans { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("department")]
        public object Department { get; set; }

        [JsonProperty("dirSyncEnabled")]
        public object DirSyncEnabled { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("facsimileTelephoneNumber")]
        public object FacsimileTelephoneNumber { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("immutableId")]
        public object ImmutableId { get; set; }

        [JsonProperty("jobTitle")]
        public object JobTitle { get; set; }

        [JsonProperty("lastDirSyncTime")]
        public object LastDirSyncTime { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public object OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("otherMails")]
        public string[] OtherMails { get; set; }

        [JsonProperty("passwordPolicies")]
        public object PasswordPolicies { get; set; }

        [JsonProperty("passwordProfile")]
        public object PasswordProfile { get; set; }

        [JsonProperty("physicalDeliveryOfficeName")]
        public object PhysicalDeliveryOfficeName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("provisionedPlans")]
        public ProvisionedPlan[] ProvisionedPlans { get; set; }

        [JsonProperty("provisioningErrors")]
        public object[] ProvisioningErrors { get; set; }

        [JsonProperty("proxyAddresses")]
        public string[] ProxyAddresses { get; set; }

        [JsonProperty("sipProxyAddress")]
        public string SipProxyAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber { get; set; }

        [JsonProperty("usageLocation")]
        public string UsageLocation { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("userType")]
        public object UserType { get; set; }
    }
}
