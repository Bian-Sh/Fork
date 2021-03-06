﻿using Azylee.WinformSkin.FormUI.Toast;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Y.Test.Commons;
using Y.Utils.DataUtils.Collections;

namespace Y.Test.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            simpleClockControl1.Start(timeShift: 0);
            simpleClockControl2.Start(timeShift: 4.5);
            simpleClockControl3.Start(timeShift: -1);
            simpleClockControl4.Start(timeShift: 10);
        }
        private void ChineseCalendarForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<ChineseCalendarForm>().Show();
        }
        private void TestComputerInfoForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestComputerInfoForm>().Show();
        }

        private void TestUpdateForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestUpdateForm>().Show();
        }

        private void TestPackForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestPackForm>().Show();
        }

        private void TestIconGroupForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestIconGroupForm>().Show();
        }

        private void TestShadowForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestShadowForm>().Show();
        }

        private void TestIrrForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestIrrForm>().Show();
        }

        private void BTCheckYUtils_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                ListTool.HasElements(a);
            }
        }

        private void TestCrossForm_Click(object sender, EventArgs e)
        {
            R.Forms.GetUnique<TestCrossForm>().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToastForm.Display("测试测试", "测试内容，测试内容123,456七八九十！", 'i', 2000);
        }
    }
}
