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
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.Weixin.OfficialAccount.ThirdParty
{
    /// <summary>
    /// ToString 已重载
    /// </summary>
    public class WeixinThirdPartyFuncscopeCategoryCollection : Collection<WeixinThirdPartyFuncscopeCategory>
    {
        public override string ToString()
        {
            string str = String.Empty;
            foreach (var item in this)
            {
                str += item.Content.Id + ",";
            }

            return str.Substring(0, str.Length - 1);
        }
    }
}
