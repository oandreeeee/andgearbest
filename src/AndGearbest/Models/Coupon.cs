﻿namespace AndGearbest.Models
{
    using System;
    using Newtonsoft.Json;

    public class Coupon
    {
        [JsonProperty("coupon_name")]
        public string CouponName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("coupon_code")]
        public string CouponCode { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("coupon_url")]
        public string CouponUrl { get; set; }

        [JsonProperty("promotion_url")]
        public string PromotionUrl { get; set; }
    }
}