﻿using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace JustERP.Core.User.Wechat
{
    /// <summary>
    /// 用户的微信资料信息
    /// </summary>
    public class LhzxExpertWechatInfo : CreationAuditedEntity<long>
    {
        /// <summary>
        /// openid
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string Openid { get; set; }
        /// <summary>
        /// nickname
        /// </summary>
        [Required]
        [MaxLength(32)]
        public string Nickname { get; set; }
        /// <summary>
        /// sex
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// province
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string Province { get; set; }
        /// <summary>
        /// city
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string City { get; set; }
        /// <summary>
        /// country
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string Country { get; set; }
        /// <summary>
        /// headimgurl
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string Headimgurl { get; set; }
        /// <summary>
        /// unionid
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string Unionid { get; set; }
    }
}
