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
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.Weixin
{
    public class WeixinConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("miniProgram", IsRequired = false)]
        public WeixinMiniProgramConfigurationElement MiniProgram
        {
            get { return base["miniProgram"] as WeixinMiniProgramConfigurationElement; }
            set { base["miniProgram"] = value; }
        }
    }

    #region MiniProgram

    public class WeixinMiniProgramConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("appId", IsRequired = true)]
        public string AppId
        {
            get { return base["appId"].ToString(); }
            set { base["appId"] = value; }
        }

        [ConfigurationProperty("appSecret", IsRequired = true)]
        public string AppSecret
        {
            get { return base["appSecret"].ToString(); }
            set { base["appSecret"] = value; }
        }

        [ConfigurationProperty("mchid", IsRequired = true)]
        public string MchId
        {
            get { return base["mchid"].ToString(); }
            set { base["mchid"] = value; }
        }

        [ConfigurationProperty("key", IsRequired = true)]
        public string Key
        {
            get { return base["key"].ToString(); }
            set { base["key"] = value; }
        }

        [ConfigurationProperty("weixinPayNotifyUrl", IsRequired = true)]
        public string WeixinPayNotifyUrl
        {
            get { return base["weixinPayNotifyUrl"].ToString(); }
            set { base["weixinPayNotifyUrl"] = value; }
        }

        [ConfigurationProperty("certificatePath", IsRequired = true)]
        public string CertificatePath
        {
            get { return base["certificatePath"].ToString(); }
            set { base["certificatePath"] = value; }
        }

        [ConfigurationProperty("certificatePassword", IsRequired = true)]
        public string CertificatePassword
        {
            get { return base["certificatePassword"].ToString(); }
            set { base["certificatePassword"] = value; }
        }
    }

    #endregion

}
