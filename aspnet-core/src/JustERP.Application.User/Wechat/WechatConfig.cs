using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.Threads;

namespace JustERP.Application.User.Wechat
{
    public class WechatConfig
    {
        public const string AppId = "wxd1e9929bab5029ce";
        public const string AppSecret = "644f585ce47f569406447cef3ebb04cf";
        public const string MerchantId = "1489631162";
        public const string PaySecret = "LianHeZixun586742POITFCijneik845";
        public const string TenpayNotify = "https://api.advisors-ally.com/api/Wechat/PayNotify/";

        /// <summary>
        /// ΢�ų�ʼ��
        /// </summary>
        public static void Init()
        {
            InitWeixinCache();
            InitWeixinLog();
            InitWeixin();
        }

        private static void InitWeixin()
        {
            AccessTokenContainer.Register(AppId, AppSecret);
        }

        static void InitWeixinCache()
        {
            ThreadUtility.Register();
        }

        static void InitWeixinLog()
        {
            //�Զ�����־��¼�ص�
            Senparc.Weixin.WeixinTrace.OnLogFunc = () =>
            {
                //����ÿ�δ���Log����Ҫִ�еĴ���
            };

            //����������WeixinException���쳣ʱ����
            Senparc.Weixin.WeixinTrace.OnWeixinExceptionFunc = ex =>
            {
                
            };
        }
    }
}