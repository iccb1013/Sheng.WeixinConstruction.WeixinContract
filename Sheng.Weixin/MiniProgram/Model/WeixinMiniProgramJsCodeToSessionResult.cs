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

namespace Sheng.Weixin.MiniProgram
{
    /*
     * 小程序登录
     * https://developers.weixin.qq.com/miniprogram/dev/api/api-login.html#wxloginobject
     */

    [DataContract]
    public class WeixinMiniProgramJsCodeToSessionResult
    {
        [DataMember(Name = "openid")]
        public string OpenId
        {
            get;
            set;
        }

        [DataMember(Name = "session_key")]
        public string SessionKey
        {
            get;
            set;
        }

    }
}
