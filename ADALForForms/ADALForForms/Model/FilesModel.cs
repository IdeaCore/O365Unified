using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ADALForForms.Model
{
    public partial class FilesModel
    {
        public class User2
        {

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("displayName")]
            public string DisplayName { get; set; }
        }
    }

    public partial class FilesModel
    {
        public class CreatedBy2
        {

            [JsonProperty("application")]
            public object Application { get; set; }

            [JsonProperty("user")]
            public User2 User { get; set; }
        }
    }

    public partial class FilesModel
    {
        public class User3
        {

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("displayName")]
            public string DisplayName { get; set; }
        }
    }

    public partial class FilesModel
    {
        public class LastModifiedBy2
        {

            [JsonProperty("application")]
            public object Application { get; set; }

            [JsonProperty("user")]
            public User3 User { get; set; }
        }
    }

    public partial class FilesModel
    {
        public class ParentReference2
        {

            [JsonProperty("driveId")]
            public string DriveId { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("path")]
            public string Path { get; set; }
        }
    }

    public partial class FilesModel
    {
        public class Value2
        {

            [JsonProperty("@odata.type")]
            public string OdataType { get; set; }

            [JsonProperty("createdBy")]
            public CreatedBy2 CreatedBy { get; set; }

            [JsonProperty("eTag")]
            public string ETag { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("lastModifiedBy")]
            public LastModifiedBy2 LastModifiedBy { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("parentReference")]
            public ParentReference2 ParentReference { get; set; }

            [JsonProperty("size")]
            public int Size { get; set; }

            [JsonProperty("dateTimeCreated")]
            public string DateTimeCreated { get; set; }

            [JsonProperty("dateTimeLastModified")]
            public string DateTimeLastModified { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("webUrl")]
            public string WebUrl { get; set; }

            [JsonProperty("childCount")]
            public int ChildCount { get; set; }

            [JsonProperty("contentUrl")]
            public string ContentUrl { get; set; }
        }
    }

    public partial class FilesModel
    {

        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("value")]
        public Value2[] Value { get; set; }
    }
}
