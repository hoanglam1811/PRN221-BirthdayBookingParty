﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MomoService
{
    public class MomoConfig
    {
        public string PartnerCode { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = string.Empty;

        public string IpnUrl { get; set; } = string.Empty;

        public string AccessKey { get; set; } = string.Empty;

        public string SecretKey { get; set; } = string.Empty;

        public string PaymentUrl { get; set; } = string.Empty;
    }
}
