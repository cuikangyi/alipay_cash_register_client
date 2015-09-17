/*****************************************************************
 * Copyright (C) Knights Warrior Corporation. All rights reserved.
 * 
 * Author:   圣殿骑士（Knights Warrior） 
 * Email:    KnightsWarrior@msn.com
 * Website:  http://www.cnblogs.com/KnightsWarrior/       http://knightswarrior.blog.51cto.com/
 * Create Date:  5/8/2010 
 * Usage:
 *
 * RevisionHistory
 * Date         Author               Description
 * 
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightsWarriorAutoupdater
{
    public class ConstFile
    {
        public const string TEMPFOLDERNAME = "Temp";
        public const string CONFIGFILEKEY = "config_";
        public const string FILENAME = "AutoUpdater.config";
        public const string ROOLBACKFILE = "Yunfu.exe";
        public const string MESSAGETITLE = "自动更新程序";
        public const string CANCELORNOT = "云付更新中，你确定要取消吗？";
        public const string APPLYTHEUPDATE = "程序需要重新启动来应用更新，请点击确定重启程序!";
        public const string NOTNETWORK = "云付更新失败，程序将重新启动，请再次尝试更新！";
    }
}
