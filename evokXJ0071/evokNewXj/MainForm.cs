﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xjplc;

namespace evokNew0071
{

    
    public partial class MainForm : Form
    {
        private static Queue<Control> allCtrls = new Queue<Control>();

        //List<string> errorList = new List<string>();
        //int errorId = 0;
        CsvStreamReader csvop;
        OptSize optsize;

        OptSize op1;
        OptSize op0;
        private EvokXJWork evokWork0;
        private EvokXJWork evokWork1;
        private EvokXJWork evokWork2;

        workManager workMan;
        //private OptSize optSize;
        //private WatchForm wForm;
        doorTypeInfo doorLst;
      
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            PortParam p0 = new PortParam();
            PortParam p1 = new PortParam();
            PortParam p2 = new PortParam();
            p0 = ConstantMethod.LoadPortParam(Constant.ConfigSerialportFilePath);
            p1 = ConstantMethod.LoadPortParam(Constant.ConfigSerialportFilePath1);
            p2 = ConstantMethod.LoadPortParam(Constant.ConfigSerialportFilePath2);

            //初始化设备
            List<string> strDataFormPath0 = new List<string>();

            strDataFormPath0.Add(Constant.PlcDataFilePathAuto);
            strDataFormPath0.Add(Constant.PlcDataFilePathHand);
            strDataFormPath0.Add(Constant.PlcDataFilePathParam);
            strDataFormPath0.Add(Constant.PlcDataFilePathIO);

            List<string> strDataFormPath1 = new List<string>();

            strDataFormPath1.Add(Constant.PlcDataFilePathAuto1);
            strDataFormPath1.Add(Constant.PlcDataFilePathHand1);
            strDataFormPath1.Add(Constant.PlcDataFilePathParam1);
            strDataFormPath1.Add(Constant.PlcDataFilePathIO1);

            List<string> strDataFormPath2 = new List<string>();
            strDataFormPath2.Add(Constant.PlcDataFilePathAuto2);
            strDataFormPath2.Add(Constant.PlcDataFilePathHand2);
            strDataFormPath2.Add(Constant.PlcDataFilePathParam2);
            strDataFormPath2.Add(Constant.PlcDataFilePathIO2);


            evokWork0 = new EvokXJWork(strDataFormPath0,p0);
             

           // evokWork1 = new EvokXJWork(strDataFormPath1, p1);

            //evokWork2 = new EvokXJWork(strDataFormPath1, p2);
            csvop = new CsvStreamReader();
            optsize = new OptSize();
            op1 = new OptSize();
            op0 = new OptSize();
            InitWork();
            evokWork0.SetRtbWork(rtbResult);
           // evokWork1.SetRtbWork(rtbResult);
            UpdateTimer.Enabled = true;

            doorLst = new doorTypeInfo();

            workMan = new workManager();
        }


        public void InitWork()
        {
         
            evokWork0.InitDgvParam(dgvParam);
            evokWork0.InitDgvIO(dgvIO);
            ConstantMethod.Delay(1000);
           
            //evokWork1.InitDgvParam(dgvParam1);
           // evokWork1.InitDgvIO(dgvIO1);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            evokWork0.ShiftPage(Constant.IOPage);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            //evokWork1.ShiftPage(Constant.IOPage);
        }

        private void UpdataError(EvokXJWork evokWork,ToolStripStatusLabel statusLabel)
        {
            if (evokWork.DeviceStatus)
            {
                statusLabel.Text = Constant.MachineWorking;
                statusLabel.BackColor = Color.Green;
            }
            else
            {
                statusLabel.Text = Constant.ConnectMachineFail;
                statusLabel.BackColor = Color.Red;
            }

            foreach (PlcInfoSimple p in evokWork.PsLstAuto)
            {
                if (p.Name.Contains(Constant.Alarm) && p.ShowStr != null && p.ShowStr.Count > 0)
                {
                    for (int i = 0; i < p.ShowStr.Count; i++)
                    {
                        int index = evokWork.ErrorList.IndexOf(p.ShowStr[i]);
                        if (p.ShowValue == Constant.M_ON && index < 0)
                        {
                            evokWork.ErrorList.Add(p.ShowStr[i]);
                        }
                        if (p.ShowValue == Constant.M_OFF && index > -1 && index < evokWork.ErrorList.Count)
                        {
                            evokWork.ErrorList.RemoveAt(index);
                        }
                    }
                }
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdataError(evokWork0, statusLabel1);
           // UpdataError(evokWork1, statusLabel2);
          //  UpdataError(evokWork2, statusLabel3);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否继续关闭程序？", "关闭提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//触发事件进行提示
            if (dr == DialogResult.No)
            {
                e.Cancel = true;//就不退了
                return;
            }
            else
            {
                e.Cancel = false;//退了
            }

            UpdateTimer.Enabled = false;

            //FileSaveTimer.Enabled = false;
            if (evokWork0 != null)
            {
                evokWork0.Dispose();
            }
            if (evokWork1 != null)
            {
                evokWork1.Dispose();
            }
            if (evokWork2 != null)
            {
                evokWork2.Dispose();
            }

            ConstantMethod.Delay(100);

            Environment.Exit(0);
        }

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            evokWork0.ShiftPage(Constant.ParamPage);
        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            evokWork1.ShiftPage(Constant.ParamPage);
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            evokWork1.ShiftPage(Constant.IOPage);
        }
     
        private void work0IO_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (work0Tab.SelectedIndex == 0)
            {
                if (!evokWork0.ShiftPage(Constant.IOPage))
                {
                    e.Cancel = true;
                }
                
            }
            if (work0Tab.SelectedIndex == 1)
            {
                if (!evokWork0.ShiftPage(Constant.ParamPage))
                {
                    e.Cancel = true;
                }
                
            }
        }

        private void tabControl3_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (work1Tab.SelectedIndex == 0)
            {
                if (!evokWork1.ShiftPage(Constant.IOPage))
                {
                    e.Cancel = true;
                }
                
            }
            if (work1Tab.SelectedIndex == 1)
            {
                if (!evokWork1.ShiftPage(Constant.ParamPage))
                {
                    e.Cancel = true;
                }
                
            }
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {

            if (workMan.LoadData())
            {
                workMan.ShowResult(listBox1);
                //ConstantMethod.ShowInfo(rtbResult, workMan.);
            }

           // fileConvert.ReadSplitTypeFromCsvData() ;
        }


        private void optBtn_Click(object sender, EventArgs e)
        {

            op0.DtData = csvop.OpenCSV(Constant.PlcDataFilehqj);
            op1.DtData = csvop.OpenCSV(Constant.PlcDataFilezhj);

            dgSize.DataSource = op0.DtData;
            dgDoorBan.DataSource = op1.DtData;
            evokWork0.SetOptSize(op0);
            evokWork1.SetOptSize(op1);


        }

        private void stbtn_Click(object sender, EventArgs e)
        {
            //启动流程
            evokWork0.optReady(Constant.optNormal);
            evokWork1.optReady(Constant.optNormal);
            //确定设备处于电脑控制状态
            //发送启动信号
            //进行数据统计

            ConstantMethod.ShowInfo(rtbResult, op0.OptNormal(rtbResult));
            ConstantMethod.ShowInfo(rtbResult, op1.OptNormal(rtbResult));


            evokWork0.CutDoorStartNormal(Constant.CutNormalMode);
            evokWork1.CutDoorStartNormal(Constant.CutNormalDoorMode);
            //evokWork0.CutStartNormal(Constant.CutNormalMode);
            //evokWork1.CutStartNormal(Constant.CutNormalMode);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                workMan.
                ShowDoor(listBox1.SelectedIndex, dgSize, dgDoorBan, dgDoorShell);
            }
        }
    }
}
