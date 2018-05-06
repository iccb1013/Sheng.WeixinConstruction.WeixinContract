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

namespace Sheng.Weixin.MiniProgram
{
    public class WeixinMiniProgramApi
    {
        private static readonly HttpService _httpService = HttpService.Instance;

        /// <summary>
        /// 小程序登录
        /// </summary>
        public static WeixinRequestApiResult<WeixinMiniProgramJsCodeToSessionResult> JsCodeToSession(
            WeixinMiniProgramJsCodeToSessionArgs args)
        {
            WeixinRequestApiResult<WeixinMiniProgramJsCodeToSessionResult> result =
                new WeixinRequestApiResult<WeixinMiniProgramJsCodeToSessionResult>();

            HttpRequestArgs requestArgs = new HttpRequestArgs();
            requestArgs.Method = "POST";
            requestArgs.Url = String.Format(
                "https://api.weixin.qq.com/sns/jscode2session?appid={0}&secret={1}&js_code={2}&grant_type=authorization_code",
                args.AppId, args.AppSecret, args.JsCode);
            requestArgs.Content = JsonConvert.SerializeObject(args);

            result.HttpRequestArgs = requestArgs;
            result.HttpRequestResult = _httpService.Request(requestArgs);

            if (result.HttpRequestResult.Successful)
            {
                result.ApiResult = WeixinApiHelper.Parse<WeixinMiniProgramJsCodeToSessionResult>(
                    result.HttpRequestResult.Content, ref result.ApiError);
            }

            return result;
        }

    }
}
