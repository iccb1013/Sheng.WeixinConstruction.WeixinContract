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

namespace Sheng.Weixin.OfficialAccount
{
    public static class MenuApi
    {
        private static readonly HttpService _httpService = HttpService.Instance;

        /// <summary>
        /// 自定义菜单创建接口
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="accessToken"></param>
        public static WeixinRequestApiResult Create(ButtonWrapper menu, string accessToken)
        {
            WeixinRequestApiResult result = new WeixinRequestApiResult();

            HttpRequestArgs requestArgs = new HttpRequestArgs();
            requestArgs.Method = "POST";
            requestArgs.Url = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + accessToken;
            requestArgs.Content = JsonConvert.SerializeObject(menu);

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
