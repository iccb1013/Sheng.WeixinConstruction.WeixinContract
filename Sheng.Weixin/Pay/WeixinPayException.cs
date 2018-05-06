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
using System.Web;

namespace Sheng.Weixin.Pay
{
    public class WeixinPayException : Exception 
    {
        public WeixinPayException(string msg) : base(msg) 
        {

        }
     }
}