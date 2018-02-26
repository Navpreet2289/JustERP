﻿using System.Threading.Tasks;
using Abp.Dependency;
using JustERP.Application.User.Wechat.Dto;
using Senparc.Weixin.MP.AdvancedAPIs.OAuth;
using Senparc.Weixin.MP.Helpers;
using Senparc.Weixin.MP.TenPayLibV3;

namespace JustERP.Application.User.Wechat
{
    public interface IExpertWechatAppService : ITransientDependency
    {
        string GetAuthenticateUrl(string returnUrl);

        Task<OAuthAccessTokenResult> GetToken(string code);

        Task<OAuthAccessTokenResult> RefreshToken(string refreshToken);

        Task<OAuthUserInfo> GetUserInfo(string accessToken, string openId);

        Task<JsSdkUiPackage> GetJsSdkConfig(string requestUrl);

        Task<string> GetMediaAndSaveAsync(string mediaId, string fileName);

        Task<UnifiedOrderDto> Unifiedorder(CreateUnifiedOrderInput input);

        Task<OrderQueryResult> QueryOrder(QueryOrderInput input);

        bool CheckNotify(ResponseHandler handler, out PayNotifyInfoDto info);

        Task<bool> SendNewOrderMessage(SendOrderMessageInput input);
        Task<bool> SendOrderConfirmMessage(SendOrderMessageInput input);
        Task<bool> SendPayedSuccessMessage(SendOrderMessageInput input);
    }
}