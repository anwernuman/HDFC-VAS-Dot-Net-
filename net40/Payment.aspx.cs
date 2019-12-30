﻿using Razorpay.Api;
using System;
using System.Collections.Generic;

namespace RazorpaySampleApp
{
    public partial class Payment : System.Web.UI.Page
    {
        public string orderId;
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", 100); // this amount should be same as transaction amount
            input.Add("currency", "INR");
            input.Add("receipt", "12121");
            input.Add("payment_capture", 1);

            string key = "rzp_test_jkjdcTeJ3h1C5I";
            string secret = "n9RUof02el0Bp5S2acmW55it";

            RazorpayClient client = new RazorpayClient(key, secret);

            Razorpay.Api.Order order = client.Order.Create(input);
            orderId = order["id"].ToString();


        }
    }
}