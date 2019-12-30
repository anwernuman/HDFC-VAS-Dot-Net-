﻿using Razorpay.Api;
using System;
using System.Collections.Generic;

namespace RazorpaySampleApp
{
    public partial class Charge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string paymentId = Request.Form["razorpay_payment_id"];

            //Dictionary<string, object> input = new Dictionary<string, object>();
            //input.Add("amount", 100); // this amount should be same as transaction amount

            string key = "rzp_test_jkjdcTeJ3h1C5I";
            string secret = "n9RUof02el0Bp5S2acmW55it";
            //string razorpay_signature["razorpay_signature"];

            RazorpayClient client = new RazorpayClient(key, secret);
            

            Dictionary<string, string> attributes = new Dictionary<string, string>();

            attributes.Add("razorpay_payment_id", paymentId);
            attributes.Add("razorpay_order_id", Request.Form["razorpay_order_id"]);
            attributes.Add("razorpay_signature", Request.Form["razorpay_signature"]);

            Utils.verifyPaymentSignature(attributes);

            Console.WriteLine("razorpay_signature");
           

            //Refund refund = new Razorpay.Api.Payment((string) paymentId).Refund();

           // Console.WriteLine(refund["id"]);
        }
    }
}