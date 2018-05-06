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


using Linkup.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.Weixin.TemplateMessage
{
    public class TemplateMessageApi
    {
        private static readonly HttpService _httpService = HttpService.Instance;

        /// <summary>
        /// 小程序登录
        /// </summary>
        public static WeixinRequestApiResult Send(string accessToken, WeixinTemplateMessageSendArgs args)
        {
            WeixinRequestApiResult result = new WeixinRequestApiResult();

            HttpRequestArgs requestArgs = new HttpRequestArgs();
            requestArgs.Method = "POST";
            requestArgs.Url = String.Format(
                "https://api.weixin.qq.com/cgi-bin/message/wxopen/template/send?access_token={0}", accessToken);
            requestArgs.Content = JsonConvert.SerializeObject(args);

            result.HttpRequestArgs = requestArgs;
            result.HttpRequestResult = _httpService.Request(requestArgs);

            if (result.HttpRequestResult.Successful)
            {
                result.ApiError = WeixinApiHelper.Parse(result.HttpRequestResult.Content);
            }

            return result;
        }


    }
}
