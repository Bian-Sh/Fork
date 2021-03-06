﻿//************************************************************************
//      https://github.com/yuzhengyang
//      author:     yuzhengyang
//      date:       2017.10.12 - 2017.10.12
//      desc:       启动进程工具
//      Copyright (c) yuzhengyang. All rights reserved.
//************************************************************************
using Azylee.Core.DataUtils.CollectionUtils;
using System;
using System.Diagnostics;
using System.IO;

namespace Azylee.Core.ProcessUtils
{
    public static class ProcessTool
    {
        public static void StartProcess(string appFile)
        {
            try
            {
                if (File.Exists(appFile))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = appFile;
                    //p.StartInfo.Arguments = "";
                    p.StartInfo.UseShellExecute = true;
                    p.Start();
                    p.WaitForInputIdle(3000);
                }
            }
            catch (Exception ex) { }
        }
        public static bool CheckProcessExists(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process p in processes)
            {
                return true;
            }
            return false;
        }
        public static void KillProcess(string name)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(name);
                foreach (Process p in processes)
                {
                    p.Kill();
                    p.Close();
                }
            }
            catch (Exception e) { }
        }
        public static void KillCurrentProcess()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id == current.Id)
                {
                    process.Kill();
                }
            }
        }

        public static bool Start(string file, string args = "")
        {
            try
            {
                if (File.Exists(file))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = file;
                    p.StartInfo.Arguments = "";
                    p.StartInfo.UseShellExecute = true;
                    p.Start();
                    p.WaitForInputIdle(3000);
                    return true;
                }
            }
            catch (Exception ex) { }
            return false;
        }
        public static bool SimpleStart(string file, string args = "")
        {
            if (File.Exists(file))
            {
                try
                {
                    Process.Start(file, args);
                    return true;
                }
                catch { }
            }
            return false;
        }
        public static void Starts(string[] files)
        {
            if (ListTool.HasElements(files))
            {
                foreach (var f in files)
                {
                    if (!string.IsNullOrWhiteSpace(f))
                        StartProcess(f);
                }
            }
        }
        public static void Kills(string[] pro)
        {
            if (ListTool.HasElements(pro))
            {
                foreach (var p in pro)
                {
                    if (!string.IsNullOrWhiteSpace(p))
                        KillProcess(p);
                }
            }
        }
    }
}
