/*
 * 升讯威软件
 * http://shengxunwei.com/
 * 更多产品及技术支持，定制化服务
 * QQ:      279060597
 * Email:   cao.silhouette@msn.com
 * 
 * 开源分享:  https://github.com/iccb1013
 * 博客:      http://blog.shengxunwei.com/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.Weixin.Pay
{
    /// <summary>
    /// 订单状态  和微信接口的 TradeState 一致
    /// </summary>
    public enum EnumPayTradeState
    {
        /// <summary>
        /// 支付成功
        /// </summary>
        SUCCESS = 0,
        /// <summary>
        /// 转入退款
        /// </summary>
        REFUND = 1,
        /// <summary>
        /// 未支付
        /// </summary>
        NOTPAY = 2,
        /// <summary>
        /// 已关闭
        /// </summary>
        CLOSED = 3,
        /// <summary>
        /// 已撤销（刷卡支付）
        /// </summary>
        REVOKED = 4,
        /// <summary>
        /// 用户支付中
        /// </summary>
        USERPAYING = 5,
        /// <summary>
        /// 支付失败(其他原因，如银行返回失败)
        /// </summary>
        PAYERROR = 6
    }
}
