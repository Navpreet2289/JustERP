﻿using System;
using Abp.Domain.Entities.Auditing;

namespace JustERP.Core.User.Payments
{
    public class LhzxExpertOrderPayment : FullAuditedEntity<long>
    {
        public long? ExpertId { get; set; }
        public long? ExpertOrderId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentTime { get; set; }
    }
}
