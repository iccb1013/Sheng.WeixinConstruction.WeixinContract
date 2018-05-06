/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com
*
*    © Copyright 2017
*
********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.Weixin.TemplateMessage
{
    [DataContract]
    public class WeixinTemplateMessageSendArgs
    {
        /// <summary>
        /// 接收者（用户）的 openid
        /// </summary>
        [DataMember(Name = "touser")]
        public string Touser
        {
            get;set;
        }

        /// <summary>
        /// 所需下发的模板消息的id
        /// </summary>
        [DataMember(Name = "template_id")]
        public string TemplateId
        {
            get; set;
        }

        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转。
        /// </summary>
        [DataMember(Name = "page")]
        public string Page
        {
            get;set;
        }

        /// <summary>
        /// 表单提交场景下，为 submit 事件带上的 formId；支付场景下，为本次支付的 prepay_id
        /// </summary>
        [DataMember(Name = "form_id")]
        public string FormId
        {
            get;set;
        }

        [DataMember(Name = "data")]
        public Dictionary<string, WeixinTemplateMessageSendArgs_Keyword> Data
        {
            get; set;
        }

        /// <summary>
        /// 模板内容字体的颜色，不填默认黑色
        /// </summary>
        [DataMember(Name = "color")]
        public string Color
        {
            get;set;
        }

        /// <summary>
        /// 模板需要放大的关键词，不填则默认无放大
        /// </summary>
        [DataMember(Name = "EmphasisKeyword")]
        public string emphasis_keyword
        {
            get;set;
        }

        public WeixinTemplateMessageSendArgs()
        {
            Data = new Dictionary<string, WeixinTemplateMessageSendArgs_Keyword>();
        }
    }

    [DataContract]
    public class WeixinTemplateMessageSendArgs_Keyword
    {
        [DataMember(Name = "value")]
        public string Value
        {
            get; set;
        }

        [DataMember(Name = "color")]
        public string Color
        {
            get; set;
        }
    }

}
