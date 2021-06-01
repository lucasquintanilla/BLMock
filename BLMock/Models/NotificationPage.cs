using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLMock.Models
{
    public class Properties
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("records")]
        public int Records { get; set; }

        [JsonProperty("current_page")]
        public string CurrentPage { get; set; }
    }

    public class Notification
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oms_id")]
        public int OmsId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("channel_brand_id")]
        public int ChannelBrandId { get; set; }

        [JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        [JsonProperty("is_spu")]
        public bool IsSpu { get; set; }

        [JsonProperty("spu_id")]
        public object SpuId { get; set; }

        [JsonProperty("spu_transaction_id")]
        public object SpuTransactionId { get; set; }

        [JsonProperty("spu_from")]
        public object SpuFrom { get; set; }

        [JsonProperty("spu_to")]
        public object SpuTo { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class NotificationPage
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("notifications")]
        public List<Notification> Notifications { get; set; }
    }
}
