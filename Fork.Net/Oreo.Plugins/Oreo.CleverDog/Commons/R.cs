﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Y.Utils.IOUtils.LogUtils;

namespace Oreo.CleverDog.Commons
{
    public static class R
    {
        internal static string AppName = "Oreo.CleverDog";
        internal static DateTime StartTime = DateTime.Now;
        internal static string MachineName = Environment.MachineName;
        internal static Module Module = Assembly.GetExecutingAssembly().GetModules()[0];
        internal static Log Log { get; set; }
        internal static string AesKey = "12345678901234567890123456789012";

        public static class Paths
        {
            public static string App = AppDomain.CurrentDomain.BaseDirectory;
            public static string Frisbee = App + "Frisbee\\";
            //public static string Root = App + "\\" + AppName;
            //public static string Data = Root + "\\Data";//应用根目录
        }
        public static class Files
        {
            public static string App = Application.ExecutablePath;
            //public static string Settings = Paths.Root + "\\Settings.ini";//应用配置信息目录
            public static string Frisbee = Paths.App + "\\Frisbee.ini";
        }
    }
}
