using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLMock.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Payment
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("base_amount")]
        public string BaseAmount { get; set; }

        [JsonProperty("interest_amount")]
        public string InterestAmount { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("creditcard_firstdigits")]
        public object CreditcardFirstdigits { get; set; }

        [JsonProperty("creditcard_lastdigits")]
        public object CreditcardLastdigits { get; set; }

        [JsonProperty("installments")]
        public int Installments { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("gateway_name")]
        public string GatewayName { get; set; }

        [JsonProperty("channel_created_at")]
        public DateTime ChannelCreatedAt { get; set; }

        [JsonProperty("channel_updated_at")]
        public DateTime ChannelUpdatedAt { get; set; }
    }

    public class ItemsStatu
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submitted")]
        public bool Submitted { get; set; }
    }

    public class Discount
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class OrdersItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        [JsonProperty("items_status")]
        public List<ItemsStatu> ItemsStatus { get; set; }

        [JsonProperty("required_qty")]
        public int RequiredQty { get; set; }

        [JsonProperty("confirmed_qty")]
        public string ConfirmedQty { get; set; }

        [JsonProperty("discounts")]
        public List<Discount> Discounts { get; set; }

        [JsonProperty("warehouse_id")]
        public object WarehouseId { get; set; }
    }

    public class Shipping
    {
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("address_id")]
        public string AddressId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("courier")]
        public string Courier { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("label_url")]
        public List<object> LabelUrl { get; set; }
    }

    public class OrderAddress
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_number_1")]
        public string AddressNumber1 { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_iso")]
        public string StateIso { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        [JsonProperty("receiver_phone")]
        public object ReceiverPhone { get; set; }
    }

    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("phone_1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone_2")]
        public string Phone2 { get; set; }

        [JsonProperty("doc_type")]
        public string DocType { get; set; }

        [JsonProperty("doc_number")]
        public string DocNumber { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("corporate")]
        public List<object> Corporate { get; set; }
    }

    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("is_corporate")]
        public bool IsCorporate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sub_status")]
        public string SubStatus { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("order_amount")]
        public string OrderAmount { get; set; }

        [JsonProperty("shipping_amount")]
        public string ShippingAmount { get; set; }

        [JsonProperty("channel_brand")]
        public int ChannelBrand { get; set; }

        [JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        [JsonProperty("channel_created_at")]
        public DateTime ChannelCreatedAt { get; set; }

        [JsonProperty("channel_updated_at")]
        public DateTime ChannelUpdatedAt { get; set; }

        [JsonProperty("payments")]
        public List<Payment> Payments { get; set; }

        [JsonProperty("orders_item")]
        public List<OrdersItem> OrdersItem { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        [JsonProperty("order_address")]
        public List<OrderAddress> OrderAddress { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }


}
