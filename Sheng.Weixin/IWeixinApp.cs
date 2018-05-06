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
using System.Text;
using System.Threading.Tasks;

namespace Sheng.Weixin
{
    public interface IWeixinApp
    {
        string AppId { get; }

        string AppSecret { get; }

        string AccessToken { get; }

        string Token { get; }

        string EncodingAESKey { get; }

        string WeixinId { get; }
    }
}
