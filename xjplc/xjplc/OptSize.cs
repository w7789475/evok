﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xjplc
{
    //单个尺寸类 含 尺寸 条码 预留1~5
    public class SingleSize
    {
        DataTable dtUser;
        public System.Data.DataTable DtUser
        {
            get { return dtUser; }
            set { dtUser = value; }
        }
        private  string barc;  //条码
        public string Barc
        {
            get { return barc; }
            set { barc = value; }
        }

        
        private int cut;    //切割长度
        public int Cut
        {
            get { return cut; }
            set { cut = value; }
        }
        private string paramStr1;
        public string ParamStr1
        {
            get { return paramStr1; }
            set { paramStr1 = value; }
        }
        private string paramStr2;
        public string ParamStr2
        {
            get { return paramStr2; }
            set { paramStr2 = value; }
        }
        private string paramStr3;
        public string ParamStr3
        {
            get { return paramStr3; }
            set { paramStr3 = value; }
        }
        private string paramStr4;
        public string ParamStr4
        {
            get { return paramStr4; }
            set { paramStr4 = value; }
        }
        private string paramStr5;
        public string ParamStr5
        {
            get { return paramStr5; }
            set { paramStr5 = value; }
        }
        private string paramStr6;
        public string ParamStr6
        {
            get { return paramStr6; }
            set { paramStr6 = value; }
        }
        private string paramStr7;
        public string ParamStr7
        {
            get { return paramStr7; }
            set { paramStr7 = value; }
        }
        private string paramStr8;
        public string ParamStr8
        {
            get { return paramStr8; }
            set { paramStr8 = value; }
        }
        private string paramStr9;
        public string ParamStr9
        {
            get { return paramStr9; }
            set { paramStr9 = value; }
        }
        private string paramStr10;
        public string ParamStr10
        {
            get { return paramStr10; }
            set { paramStr10 = value; }
        }
        private string paramStr11;
        public string ParamStr11
        {
            get { return paramStr11; }
            set { paramStr11 = value; }
        }
        private string paramStr12;
        public string ParamStr12
        {
            get { return paramStr12; }
            set { paramStr12 = value; }
        }
        private string paramStr13;
        public string ParamStr13
        {
            get { return paramStr13; }
            set { paramStr13 = value; }
        }
        private string paramStr14;
        public string ParamStr14
        {
            get { return paramStr14; }
            set { paramStr14 = value; }
        }
        private string paramStr15;
        public string ParamStr15
        {
            get { return paramStr15; }
            set { paramStr15 = value; }
        }
        private string paramStr16;
        public string ParamStr16
        {
            get { return paramStr16; }
            set { paramStr16 = value; }
        }
        private string paramStr17;
        public string ParamStr17
        {
            get { return paramStr17; }
            set { paramStr17 = value; }
        }
        private string paramStr18;
        public string ParamStr18
        {
            get { return paramStr18; }
            set { paramStr18 = value; }
        }
        private string paramStr19;
        public string ParamStr19
        {
            get { return paramStr19; }
            set { paramStr19 = value; }
        }
        private string paramStr20;
        public string ParamStr20
        {
            get { return paramStr20; }
            set { paramStr20 = value; }
        }

        private string paramStr21;
        public string ParamStr21
        {
            get { return paramStr21; }
            set { paramStr21 = value; }
        }
        private string paramStr22;
        public string ParamStr22
        {
            get { return paramStr22; }
            set { paramStr22 = value; }
        }
        private string paramStr23;
        public string ParamStr23
        {
            get { return paramStr23; }
            set { paramStr23 = value; }
        }
        private string paramStr24;
        public string ParamStr24
        {
            get { return paramStr24; }
            set { paramStr24 = value; }
        }
        private string paramStr25;
        public string ParamStr25
        {
            get { return paramStr25; }
            set { paramStr25 = value; }
        }
        private string paramStr26;
        public string ParamStr26
        {
            get { return paramStr26; }
            set { paramStr26 = value; }
        }
        private string paramStr27;
        public string ParamStr27
        {
            get { return paramStr27; }
            set { paramStr27 = value; }
        }
        private string paramStr28;
        public string ParamStr28
        {
            get { return paramStr28; }
            set { paramStr28 = value; }
        }
        private string paramStr29;
        public string ParamStr29
        {
            get { return paramStr29; }
            set { paramStr29 = value; }
        }
        private string paramStr30;
        public string ParamStr30
        {
            get { return paramStr30; }
            set { paramStr30 = value; }
        }
        private string paramStr31;
        public string ParamStr31
        {
            get { return paramStr31; }
            set { paramStr31 = value; }
        }

        public int Xuhao; //在dttable里是哪个行号

        private List<string> paramStrLst;
        public List<string> ParamStrLst
        {
            get
            {
                /***
                paramStrLst.Clear();
                paramStrLst.Add(Barc);
                paramStrLst.Add(ParamStr1);
                paramStrLst.Add(ParamStr2);
                paramStrLst.Add(ParamStr3);
                paramStrLst.Add(ParamStr4);
                paramStrLst.Add(ParamStr5);
                paramStrLst.Add(ParamStr6);
                paramStrLst.Add(ParamStr7);
                paramStrLst.Add(ParamStr8);
                paramStrLst.Add(ParamStr9);
                paramStrLst.Add(ParamStr10);
                paramStrLst.Add(ParamStr11);
                paramStrLst.Add(ParamStr12);
                paramStrLst.Add(ParamStr12);
                paramStrLst.Add(ParamStr13);
                paramStrLst.Add(ParamStr14);
                paramStrLst.Add(ParamStr15);
                paramStrLst.Add(ParamStr16);
                paramStrLst.Add(ParamStr17);
                paramStrLst.Add(ParamStr18);
                paramStrLst.Add(ParamStr19);
                paramStrLst.Add(ParamStr20);
                paramStrLst.Add(ParamStr21);
                paramStrLst.Add(ParamStr22);
                paramStrLst.Add(ParamStr23);
                paramStrLst.Add(ParamStr24);
                paramStrLst.Add(ParamStr25);
                paramStrLst.Add(ParamStr26);
                paramStrLst.Add(ParamStr27);
                paramStrLst.Add(ParamStr28);
                paramStrLst.Add(ParamStr29);
                paramStrLst.Add(ParamStr30);
                paramStrLst.Add(ParamStr31);
                ***/
                return paramStrLst;
            }
            set
            {
                paramStrLst = value;
            }
        }
        public SingleSize()
        {
            Barc = "";
            Cut = 0;      //切割长度
            Xuhao = 0;
            ParamStr1 = "";
            ParamStr2 = "";
            ParamStr3 = "";
            ParamStr4 = "";
            ParamStr5 = "";
            ParamStr6 = "";
            ParamStr7 = "";
            ParamStr8 = "";
            ParamStr9 = "";
            ParamStr10 = "";
            ParamStr11 = "";
            ParamStr12 = "";
            ParamStr13 = "";
            ParamStr14 = "";
            ParamStr15 = "";
            ParamStr16 = "";
            ParamStr17 = "";
            ParamStr18 = "";
            ParamStr19 = "";
            ParamStr20 = "";
            ParamStr21 = "";
            ParamStr22 = "";
            ParamStr23 = "";
            ParamStr24 = "";
            ParamStr25 = "";
            ParamStr26 = "";
            ParamStr27 = "";
            ParamStr28 = "";
            ParamStr29 = "";
            ParamStr30 = "";
            ParamStr31 = "";
            paramStrLst = new List<string>();
            paramStrLst.Add(Barc);
            paramStrLst.Add(ParamStr1);
            paramStrLst.Add(ParamStr2);
            paramStrLst.Add(ParamStr3);
            paramStrLst.Add(ParamStr4);
            paramStrLst.Add(ParamStr5);
            paramStrLst.Add(ParamStr6);
            paramStrLst.Add(ParamStr7);
            paramStrLst.Add(ParamStr8);
            paramStrLst.Add(ParamStr9);
            paramStrLst.Add(ParamStr10);
            paramStrLst.Add(ParamStr11);
            paramStrLst.Add(ParamStr12);
            paramStrLst.Add(ParamStr12);
            paramStrLst.Add(ParamStr13);
            paramStrLst.Add(ParamStr14);
            paramStrLst.Add(ParamStr15);
            paramStrLst.Add(ParamStr16);
            paramStrLst.Add(ParamStr17);
            paramStrLst.Add(ParamStr18);
            paramStrLst.Add(ParamStr19);
            paramStrLst.Add(ParamStr20);
            paramStrLst.Add(ParamStr21);
            paramStrLst.Add(ParamStr22);
            paramStrLst.Add(ParamStr23);
            paramStrLst.Add(ParamStr24);
            paramStrLst.Add(ParamStr25);
            paramStrLst.Add(ParamStr26);
            paramStrLst.Add(ParamStr27);
            paramStrLst.Add(ParamStr28);
            paramStrLst.Add(ParamStr29);
            paramStrLst.Add(ParamStr30);
            paramStrLst.Add(ParamStr31);

        }
        public SingleSize(DataTable dt,int xuhao0)
        {
            Barc = "";
            Cut = 0;      //切割长度
            Xuhao = 0;
            ParamStr1 = "";
            ParamStr2 = "";
            ParamStr3 = "";
            ParamStr4 = "";
            ParamStr5 = "";
            ParamStr6 = "";
            ParamStr7 = "";
            ParamStr8 = "";
            ParamStr9 = "";
            ParamStr10 = "";
            ParamStr11 = "";
            ParamStr12 = "";
            ParamStr13 = "";
            ParamStr14 = "";
            ParamStr15 = "";
            ParamStr16 = "";
            ParamStr17 = "";
            ParamStr18 = "";
            ParamStr19 = "";
            ParamStr20 = "";
            ParamStr21 = "";
            ParamStr22 = "";
            ParamStr23 = "";
            ParamStr24 = "";
            ParamStr25 = "";
            ParamStr26 = "";
            ParamStr27 = "";
            ParamStr28 = "";
            ParamStr29 = "";
            ParamStr30 = "";
            ParamStr31 = "";
            paramStrLst = new List<string>();
            paramStrLst.Add(Barc);
            paramStrLst.Add(ParamStr1);
            paramStrLst.Add(ParamStr2);
            paramStrLst.Add(ParamStr3);
            paramStrLst.Add(ParamStr4);
            paramStrLst.Add(ParamStr5);
            paramStrLst.Add(ParamStr6);
            paramStrLst.Add(ParamStr7);
            paramStrLst.Add(ParamStr8);
            paramStrLst.Add(ParamStr9);
            paramStrLst.Add(ParamStr10);
            paramStrLst.Add(ParamStr11);
            paramStrLst.Add(ParamStr12);
            paramStrLst.Add(ParamStr12);
            paramStrLst.Add(ParamStr13);
            paramStrLst.Add(ParamStr14);
            paramStrLst.Add(ParamStr15);
            paramStrLst.Add(ParamStr16);
            paramStrLst.Add(ParamStr17);
            paramStrLst.Add(ParamStr18);
            paramStrLst.Add(ParamStr19);
            paramStrLst.Add(ParamStr20);
            paramStrLst.Add(ParamStr21);
            paramStrLst.Add(ParamStr22);
            paramStrLst.Add(ParamStr23);
            paramStrLst.Add(ParamStr24);
            paramStrLst.Add(ParamStr25);
            paramStrLst.Add(ParamStr26);
            paramStrLst.Add(ParamStr27);
            paramStrLst.Add(ParamStr28);
            paramStrLst.Add(ParamStr29);
            paramStrLst.Add(ParamStr30);
            paramStrLst.Add(ParamStr31);


            DtUser = dt;
            Xuhao = xuhao0;

        }
    }

    //针对打孔的 在继承 切片带角度的
    public class SingleSizeWithHoleAngle : SingleSize
    {
        public SingleSizeWithHoleAngle(DataTable dt, int xuhao) : base(dt, xuhao)
        {

        }
        public SingleSizeWithHoleAngle() : base()
        {

        }



        int holeCount = 0;
        public int HoleCount
        {
            get
            {

                for (int i = 0; i < hole.Count(); i = i + 3)
                {
                    if (hole[i] > 0)
                        holeCount++;
                }
                return holeCount;
            }

        }
        int[] hole;
        public int[] Hole
        {
            get
            {
                List<string> strparam = new List<string>();
                string nullHoleSre = "0";

                //
                
                strparam.Add(ParamStrLst[3]);
                strparam.Add(ParamStrLst[4]);
                strparam.Add(ParamStrLst[5]);
                strparam.Add(ParamStrLst[6]);
                strparam.Add(ParamStrLst[7]);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);               

                strparam.Add(ParamStrLst[8]);
                strparam.Add(ParamStrLst[9]);
                strparam.Add(ParamStrLst[10]);
                strparam.Add(ParamStrLst[11]);
                strparam.Add(ParamStrLst[12]);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);
                strparam.Add(nullHoleSre);


                hole = getHoleData(strparam.ToArray());


                return hole;
            }
        }
        int[] angle;
        public int[] Angle
        {
            get
            {
                angle = getAngleData(ParamStrLst[2]);

                return angle;
            }

        }



        #region 涉及打孔的一些参数函数
        //孔的格式 55-80-60 参数3 ~ 参数10
        private int[] getHoleData(string[] s)
        {
            List<int> data = new List<int>();

            int holeX = -1;
            int holeY = -1;
            int holeZ = -1;

            for (int i = 0; i < s.Count(); i++)
            {
                string[] sArray = Regex.Split(s[i], "-", RegexOptions.IgnoreCase);
                if (sArray.Count() != 3)
                {
                    data.Add(0);
                    data.Add(0);
                    data.Add(0);
                    continue;
                }
                else
                {
                    //孔乘以100
                    if (!int.TryParse(sArray[0], out holeX)) data.Add(0);
                    else data.Add(holeX*100);
                    if (!int.TryParse(sArray[1], out holeY)) data.Add(0);
                    else data.Add(holeY*100);
                    if (!int.TryParse(sArray[2], out holeZ)) data.Add(0);
                    else data.Add(holeZ*100);

                }
            }

            return data.ToArray();

        }
        //角度格式 L/45_R\45 参数2
        private int[] getAngleData(string s)
        {
            List<int> data = new List<int>();
            if (s.Count() != 9)
            {
                goto Last;
            }

            string strAngle =
             Regex.Replace(s, @"[^0-9]+", "");

            if (strAngle.Count() != 4) goto Last; //这里得出的角度暂时没有用起来
            //角度乘以1000
            int intLAngle = getAngleDirectionFromStr(s[1], strAngle.Substring(0, 2))*1000;
            int intRAngle = getAngleDirectionFromStr(s[6], strAngle.Substring(2, 2))*1000;

            if ((intLAngle > 0) && (intRAngle > 0))
            {
                data.Add(intLAngle);
                data.Add(intRAngle);
                return data.ToArray();
            }

            Last:
            {
                data.Add(Constant.Angle90Int);
                data.Add(Constant.Angle90Int);
                return data.ToArray();
            }

        }

        /// <summary>
        /// 通过字符 得出是 几度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private int getAngleDirectionFromStr(char s, string strangle)
        {
            if (s.Equals(Constant.Angle90)) return 90;
            if (s.Equals(Constant.Angle135)) return (int.Parse(strangle) + 90);
            if (s.Equals(Constant.Angle45)) return int.Parse(strangle);
            return -1;

        }
        #endregion 涉及打孔的一些参数函数

    }
    public  class ProdInfo
    {

        int id;              //方案序号
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        int len;            //整料长度
        public int Len
        {
            set { len = value; }
            get { return len; }
        }
        int dbc;            //刀补偿
        public int DBC
        {
            set { dbc = value; }
            get
            {
                return dbc;
            }
        }
        int lbc;            //料补偿 
        public int LBC
        {
            set { lbc = value; }
            get { return lbc; }
        }

        int wl;            //尾料长度= 料长-刀补偿*总尺寸个数（含齐头）-料补偿
        public int WL
        {
            get
            {
                if ((len > 0) && (Cut.Count > 0))
                {
                    //因为结巴 已经算了刀补 看下 有结巴的话 不能算刀补
                    int realSizeCnt = 0;
                    for (int i = 0; i < Cut.Count; i++)
                    {
                        if (i < Barc.Count && !Barc[i].Equals(Constant.ScarId))
                        {
                            realSizeCnt++;
                        }
                    }
                    //刀补 要看 料头是不是为0
                    int jfbc = (realSizeCnt + 1) * dbc;
                    if (lbc==0) jfbc= (realSizeCnt) * dbc;
                    //所有尺寸和
                    int ladd = 0;
                    ladd = Cut.Sum();                 
                    wl = len - ladd - jfbc - lbc;
                }
                return wl;
            }
        }

        public List<int> Xuhao;    //如果存在Userdata 这个控件 那切割时需要统计已切数量
        public List<string> Barc;  //条码
        public List<int> Cut;      //切割长度

        public List<string> Param1; //参数1
        public List<string> Param2; //参数2
        public List<string> Param3; //参数3
        public List<string> Param4; //参数4
        public List<string> Param5; //参数5
        public List<string> Param6; //参数6
        public List<string> Param7; //参数7
        public List<string> Param8; //参数8
        public List<string> Param9; //参数9
        public List<string> Param10;    //参数10
        public List<string> Param11;    //参数11
        public List<string> Param12;    //参数12
        public List<string> Param13;    //参数13
        public List<string> Param14;    //参数14
        public List<string> Param15;    //参数15
        public List<string> Param16;    //参数16
        public List<string> Param17;    //参数17
        public List<string> Param18;    //参数18
        public List<string> Param19;    //参数19
        public List<string> Param20;    //参数20
        public List<string> Param21;
        public List<string> Param22;
        public List<string> Param23;
        public List<string> Param24;
        public List<string> Param25;
        public List<string> Param26;
        public List<string> Param27;
        public List<string> Param28;
        public List<string> Param29;
        public List<string> Param30;
        public List<string> Param31;

        public List<int[]> angle;
        public List<int[]> hole;

        public List<int> scarLst;
        public ProdInfo()
        {
            Barc = new List<string>();  //条码
            Xuhao = new List<int>();   //在dataform中的位置 方便切割的时候统计
            Cut = new List<int>();      //切割长度
            Param1 = new List<string>();    //参数1
            Param2 = new List<string>();    //参数2
            Param3 = new List<string>();    //参数3
            Param4 = new List<string>();    //参数4
            Param5 = new List<string>();    //参数5
            Param6 = new List<string>();    //参数6
            Param7 = new List<string>();    //参数7
            Param8 = new List<string>();    //参数8
            Param9 = new List<string>();    //参数9
            Param10 = new List<string>();   //参数10
            Param11 = new List<string>();   //参数11
            Param12 = new List<string>();   //参数12
            Param13 = new List<string>();   //参数13
            Param14 = new List<string>();   //参数14
            Param15 = new List<string>();   //参数15
            Param16 = new List<string>();   //参数16
            Param17 = new List<string>();   //参数17
            Param18 = new List<string>();   //参数18
            Param19 = new List<string>();   //参数19
            Param20 = new List<string>();   //参数20
            Param21 = new List<string>();   //参数21
            Param22 = new List<string>();   //参数22
            Param23 = new List<string>();   //参数23
            Param24 = new List<string>();   //参数24
            Param25 = new List<string>();   //参数25
            Param26 = new List<string>();   //参数26
            Param27 = new List<string>();   //参数27
            Param28 = new List<string>();   //参数28
            Param29 = new List<string>();   //参数29
            Param30 = new List<string>();   //参数30
            Param31 = new List<string>();   //参数31


            angle = new List<int[]>();
            hole = new List<int[]>();

            scarLst = new List<int>();

        }
        public ProdInfo(List<SingleSize> ssLst)
        {
            Barc = new List<string>();  //条码
            Xuhao = new List<int>();   //在dataform中的位置 方便切割的时候统计
            Cut = new List<int>();      //切割长度
            Param1 = new List<string>();    //参数1
            Param2 = new List<string>();    //参数2
            Param3 = new List<string>();    //参数3
            Param4 = new List<string>();    //参数4
            Param5 = new List<string>();    //参数5
            Param6 = new List<string>();    //参数6
            Param7 = new List<string>();    //参数7
            Param8 = new List<string>();    //参数8
            Param9 = new List<string>();    //参数9
            Param10 = new List<string>();   //参数10
            Param11 = new List<string>();   //参数11
            Param12 = new List<string>();   //参数12
            Param13 = new List<string>();   //参数13
            Param14 = new List<string>();   //参数14
            Param15 = new List<string>();   //参数15
            Param16 = new List<string>();   //参数16
            Param17 = new List<string>();   //参数17
            Param18 = new List<string>();   //参数18
            Param19 = new List<string>();   //参数19
            Param20 = new List<string>();   //参数20
            Param21 = new List<string>();   //参数21
            Param22 = new List<string>();   //参数22
            Param23 = new List<string>();   //参数23
            Param24 = new List<string>();   //参数24
            Param25 = new List<string>();   //参数25
            Param26 = new List<string>();   //参数26
            Param27 = new List<string>();   //参数27
            Param28 = new List<string>();   //参数28
            Param29 = new List<string>();   //参数29
            Param30 = new List<string>();   //参数30
            Param31 = new List<string>();   //参数31


            angle = new List<int[]>();
            hole = new List<int[]>();

            scarLst = new List<int>();
            List<List<string>> ParamLstLst = new List<List<string>>();
            ParamLstLst.Add(Param1);
            ParamLstLst.Add(Param2);
            ParamLstLst.Add(Param3);
            ParamLstLst.Add(Param4);
            ParamLstLst.Add(Param5);
            ParamLstLst.Add(Param6);
            ParamLstLst.Add(Param7);
            ParamLstLst.Add(Param8);
            ParamLstLst.Add(Param9);
            ParamLstLst.Add(Param10);
            ParamLstLst.Add(Param11);
            ParamLstLst.Add(Param12);
            ParamLstLst.Add(Param13);
            ParamLstLst.Add(Param14);
            ParamLstLst.Add(Param15);
            ParamLstLst.Add(Param16);
            ParamLstLst.Add(Param17);
            ParamLstLst.Add(Param18);
            ParamLstLst.Add(Param19);
            ParamLstLst.Add(Param20);
            ParamLstLst.Add(Param21);
            ParamLstLst.Add(Param22);
            ParamLstLst.Add(Param23);
            ParamLstLst.Add(Param24);
            ParamLstLst.Add(Param25);
            ParamLstLst.Add(Param26);
            ParamLstLst.Add(Param27);
            ParamLstLst.Add(Param28);
            ParamLstLst.Add(Param29);
            ParamLstLst.Add(Param30);
            ParamLstLst.Add(Param31);
            if (ssLst.Count > 0)
            {
                foreach (SingleSize s in ssLst)
                {
                    Cut.Add(s.Cut);
                    Barc.Add(s.Barc);
                    Xuhao.Add(s.Xuhao);
                    //barc 去除 所有要从1开始
                    for (int i = 1; i < s.ParamStrLst.Count; i++)
                    {
                        if((i-1)< ParamLstLst.Count)
                        ParamLstLst[i-1].Add(s.ParamStrLst[i]);
                    }
                    /****
                    Param1.Add(s.ParamStr1);
                    Param2.Add(s.ParamStr2);
                    Param3.Add(s.ParamStr3);
                    Param4.Add(s.ParamStr4);
                    Param5.Add(s.ParamStr5);
                    Param6.Add(s.ParamStr6);
                    Param7.Add(s.ParamStr7);
                    Param8.Add(s.ParamStr8);
                    Param9.Add(s.ParamStr9);
                    Param10.Add(s.ParamStr10);
                    Param11.Add(s.ParamStr11);
                    Param12.Add(s.ParamStr12);
                    Param13.Add(s.ParamStr13);
                    Param14.Add(s.ParamStr14);
                    Param15.Add(s.ParamStr15);
                    Param16.Add(s.ParamStr16);
                    Param17.Add(s.ParamStr17);
                    Param18.Add(s.ParamStr18);
                    Param19.Add(s.ParamStr19);
                    Param20.Add(s.ParamStr20);
                    Param21.Add(s.ParamStr21);
                    Param22.Add(s.ParamStr22);
                    Param23.Add(s.ParamStr23);
                    Param24.Add(s.ParamStr24);
                    Param25.Add(s.ParamStr25);
                    Param26.Add(s.ParamStr26);
                    Param27.Add(s.ParamStr27);
                    Param28.Add(s.ParamStr28);
                    Param29.Add(s.ParamStr29);
                    Param30.Add(s.ParamStr30);
                    Param31.Add(s.ParamStr31);
                    *****/
                }
            }

        }

        public int delete(int id)
        {
            if (Cut.Count > id)
            {
                Cut.RemoveAt(id);
                Barc.RemoveAt(id);
                Param1.RemoveAt(id);
                Param2.RemoveAt(id);
                Param3.RemoveAt(id);
                Param4.RemoveAt(id);
                Param5.RemoveAt(id);
                Param6.RemoveAt(id);
                Param7.RemoveAt(id);
                Param8.RemoveAt(id);
                Param9.RemoveAt(id);
                Param10.RemoveAt(id);
                Param11.RemoveAt(id);
                Param12.RemoveAt(id);
                Param13.RemoveAt(id);
                Param14.RemoveAt(id);
                Param15.RemoveAt(id);
                Param16.RemoveAt(id);
                Param17.RemoveAt(id);
                Param18.RemoveAt(id);
                Param19.RemoveAt(id);
                Param20.RemoveAt(id);
                Param21.RemoveAt(id);
                Param22.RemoveAt(id);
                Param23.RemoveAt(id);
                Param24.RemoveAt(id);
                Param25.RemoveAt(id);
                Param26.RemoveAt(id);
                Param27.RemoveAt(id);
                Param28.RemoveAt(id);
                Param29.RemoveAt(id);
                Param30.RemoveAt(id);

                Xuhao.RemoveAt(id);

                return 0;
            }
            else
            {
                return -1;
            }
        }

    }
    
    public class OptSize
    {
        CsvStreamReader CSVop;

        ExcelNpoi Excelop;

        DataGridView userDataView;
        public System.Windows.Forms.DataGridView UserDataView
        {
            get { return userDataView; }
            set { userDataView = value; }
        }
        DataTable dtData;

        bool IsLoadData;
        List<int> valueAbleRow;
        public List<int> ValueAbleRow
        {
            get { return valueAbleRow; }
            set { valueAbleRow = value; }
        }
        //表格里 还剩余多少数据 20181019
        private int sizeLeft;
        public int SizeLeft
        {
            get { return sizeLeft; }
            set { sizeLeft = value; }
        }
        bool IsSaving;
        public DataTable DtData
        {
            get { return dtData; }
            set { dtData = value; }
        }
        int dbc;  //刀补偿
        public int Dbc
        {
            get { return dbc; }
            set { dbc = value; }
        }
        int ltbc;//料头补偿
        public int Ltbc
        {
            get { return ltbc; }
            set { ltbc = value; }
        }
        int len; //料补偿
        public int Len
        {
            get { return len; }
            set { len = value; }
        }

        public void checkIsDone(int row)
        {
            int cntdone = 0;
            int setcnt = 0;
            if (UserDataView == null) return;
            if (UserDataView.DataSource == null) return;
            if (UserDataView.Rows.Count < row) return;
            if (UserDataView.ColumnCount < 3) return;
         
            if (int.TryParse(UserDataView.Rows[row].Cells[1].Value.ToString(), out cntdone) 
                && int.TryParse(UserDataView.Rows[row].Cells[2].Value.ToString(), out setcnt))
            {
                if(cntdone>0 && setcnt >0 && cntdone ==setcnt)
                UserDataView.Rows[row].DefaultCellStyle.BackColor = Color.Green;
            }
            
        }
        int wlMiniValue = 0;
        public int WlMiniValue
        {
            get { return wlMiniValue; }
            set { wlMiniValue = value; }
        }
        List<int> scarLst;
        public System.Collections.Generic.List<int> ScarLst
        {
            get { return scarLst; }
            set { scarLst = value; }
        }
        //要切的尺寸都在里面了
        List<List<SingleSize>> singleSizeLst;
        //上面的类 组合成一个二维表格List 下发
        List<ProdInfo> prodInfoLst;
        public List<ProdInfo> ProdInfoLst
        {
            get { return prodInfoLst; }
            set { prodInfoLst = value; }
        }
        public List<List<SingleSize>> SingleSizeLst
        {
            get { return singleSizeLst; }
            set { singleSizeLst = value; }
        }

        //导入规则
        List<int> valueCol = new List<int>();

        private  
        int optRealLen;//真实可用原料
        public int OptRealLen
        {
            get {

                if(ltbc>0)
                 optRealLen=Len -dbc - ltbc - safe;
                else
                    optRealLen = Len  - safe;
                return optRealLen; }
           
        }
        int safe;  //安全距离
        public int Safe
        {
            get { return safe; }
            set { safe = value; }
        }

        int optParam1 = 0;
        public int OptParam1
        {
            get { return optParam1; }
            set { optParam1 = value; }
        }
        #region 优化

        /// <summary>
        /// 测量结果显示
        /// </summary>
        /// <param name="resultOpt 数据结果"></param>
        /// <param name="prodLst 单行数据的总和 "></param>
        /// <param name="rt1"></param>
        private void ShowMeasureResult(List<int> resultOpt, List<SingleSize> prodLst, RichTextBox rt1)
        {
            List<SingleSize> resultSingleSize = new List<SingleSize>();
            resultOpt.Sort();
            for (int i = 0; i < resultOpt.Count; i++)
            {
                for (int k = 0; k < prodLst.Count; k++)
                {
                    if (prodLst[k].Cut == resultOpt[i])
                    {
                        resultSingleSize.Add(prodLst[k]);
                        ConstantMethod.ShowInfo(rt1, "第" + (i + 1).ToString() + "刀:" + resultOpt[i].ToString() + "---------条码：" + prodLst[k].Barc);
                        prodLst.RemoveAt(k);
                        break;
                    }

                }
            }
            //一根 一根进行汇总
            if (resultSingleSize.Count > 0)
            {
                ProdInfo prodInfo = new ProdInfo(resultSingleSize);
                prodInfo.DBC = dbc;
                prodInfo.LBC = ltbc;
                prodInfo.Len = len;
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "尾料：" + prodInfo.WL.ToString());
                ProdInfoLst.Add(prodInfo);
                singleSizeLst.Add(resultSingleSize);
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
            }
        }
        //20181026 tata 切割
        //数据汇总到一起 一次性下发
        public bool  dataGetTogether()
        {
          
            List<SingleSize> sLst = new List<SingleSize>();

            if (ProdInfoLst.Count == SingleSizeLst.Count && ProdInfoLst.Count > 0)
            {
                for (int i = 0; i < SingleSizeLst.Count; i++)
                {
                    if (SingleSizeLst[i].Count > 0)
                        sLst.AddRange(SingleSizeLst[i]);
                }
            }
            else return false;

            if (sLst.Count > 0)
            {
                ProdInfo prodInfo = new ProdInfo(sLst);
                prodInfo.DBC = dbc;
                prodInfo.LBC = ltbc;
                prodInfo.Len = len;
                ProdInfoLst.Clear();
                ProdInfoLst.Add(prodInfo);
                SingleSizeLst.Clear();
                singleSizeLst.Add(sLst);

            }
            else return false;

            return true;
        } 
        //ltcheck  是否要加刀补
        private void ShowMeasureResultWithCheck(List<int> resultOpt, List<SingleSize> prodLst, RichTextBox rt1,int ltcheck)
        {
            List<SingleSize> resultSingleSize = new List<SingleSize>();

            //这里增加一个限制 料头如果计算出来 太长的话 机械上不好切 20181003
            int ltbc0 = resultOpt[0];

            if (ltbc0 < Constant.LTBCMax )
            {
                if (ltcheck == Constant.LTBCAddDbc)
                    ltbc = ltbc0 + dbc;
                else
                {
                    ltbc = ltbc0;
                }
                resultOpt.RemoveAt(0);
            }
            else
            {
                ltbc = 0;
            }            

            ConstantMethod.ShowInfo(rt1, "料头:" + ltbc.ToString());

            // resultOpt.Sort();

            for (int i = 0; i < resultOpt.Count; i++)
            {
                bool isScar = true;

                for (int k = 0; k < prodLst.Count; k++)
                {
                    if (prodLst[k].Cut == resultOpt[i])
                    {
                        resultSingleSize.Add(prodLst[k]);
                        ConstantMethod.ShowInfo(rt1, "第" + (i + 1).ToString() + "刀:" + resultOpt[i].ToString() + "---------条码：" + prodLst[k].Barc);
                        prodLst.RemoveAt(k);
                        isScar = false;
                        break;
                    }
                }

                if(isScar)
                {
                        //是结疤    20180904 小莫 减去刀补                     
                    SingleSize scar = new SingleSize();
                  
                    scar.Cut = resultOpt[i]-dbc;
                    
                    //结巴如果比刀补还小 那就不切了
                    if (scar.Cut > 0)
                    {                       
                        scar.Barc = Constant.ScarId;
                        scar.ParamStrLst.Insert(0, Constant.ScarId);
                        resultSingleSize.Add(scar);
                        ConstantMethod.ShowInfo(rt1, "第" + (i + 1).ToString() + "刀结疤:" + scar.Cut.ToString() + "---------条码：" + scar.Barc);
                    }                

                }
            }
            //一根 一根进行汇总
            if (resultSingleSize.Count > 0)
            {
                ProdInfo prodInfo = new ProdInfo(resultSingleSize);
                prodInfo.DBC = dbc;
                prodInfo.LBC = ltbc;
                prodInfo.Len = len;
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "尾料：" + prodInfo.WL.ToString());
                ProdInfoLst.Add(prodInfo);
                singleSizeLst.Add(resultSingleSize);
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
            }
        }

        /// <summary>
        /// 演变从 ShowMeasureResultWithChec 料头不能放入尺寸里了
        /// </summary>
        /// <param name="resultOpt"></param>
        /// <param name="prodLst"></param>
        /// <param name="rt1"></param>
        ComboBox cbResultCnt;
        public System.Windows.Forms.ComboBox CbResultCnt
        {
            get { return cbResultCnt; }
            set { cbResultCnt = value; }
        }
        /// <summary>
        /// 测量结果显示
        /// </summary>
        /// <param name="resultOpt 数据结果"></param>
        /// <param name="prodLst 单行数据的总和 "></param>
        /// <param name="rt1"></param>
        private void ShowNormalResult(List<List<int>> resultOpt, List<SingleSize> prodLst, RichTextBox rt1,int id)
        {
            ConstantMethod.ShowInfo(rt1, "--------------");
            if (resultOpt.Count > Constant.MaxShowCount)
            {
                ConstantMethod.ShowInfo(rt1, "总料数超出最大显示数值！");
                goto Next;
            }         
            for (int i = 0; i < resultOpt.Count; i++)
            {
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "第" + (i + 1).ToString() + "根：");
                List<SingleSize> resultSingleSize = new List<SingleSize>();
                //排个序
               if(id!=Constant.optNo) resultOpt[i].Sort();
                for (int j = 0; j < resultOpt[i].Count; j++)
                {
                    for (int k = 0; k < prodLst.Count; k++)
                    {
                        if (prodLst[k].Cut == resultOpt[i][j])
                        {
                            resultSingleSize.Add(prodLst[k]);
                            if(prodLst[k].ParamStrLst.Count>0)
                            ConstantMethod.ShowInfoNoScrollEnd(rt1, "第" + (j + 1).ToString() + "刀:" + resultOpt[i][j].ToString() + "---------条码：" + prodLst[k].ParamStrLst[0]);
                            prodLst.RemoveAt(k);
                            break;
                        }
                    }

                }

                if (resultSingleSize.Count > 0)
                {
                    ProdInfo prodInfo = new ProdInfo(resultSingleSize);
                    prodInfo.DBC = dbc;
                    prodInfo.LBC = ltbc;
                    prodInfo.Len = len;
                    ConstantMethod.ShowInfoNoScrollEnd(rt1, "尾料：" + prodInfo.WL.ToString());
                    ProdInfoLst.Add(prodInfo);
                    singleSizeLst.Add(resultSingleSize);
                    ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
                    ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
                }

            }
          
                if (CbResultCnt != null)
                {
                    CbResultCnt.Items.Clear();
                    for (int i = 0; i < resultOpt.Count; i++)
                    {
                        CbResultCnt.Items.Add((i + 1).ToString());
                    }
                }
            Next:
            {
                ConstantMethod.ShowInfo(rt1, "需要料数：" + resultOpt.Count.ToString() + "根");
                ConstantMethod.ShowInfo(rt1, "材料利用率：" + ration(resultOpt));
            }
        }
        #region 导入规则
        CsvStreamReader csvSaveDemo;
        public bool ReadFileDemo(string filename)
        {
            if (!File.Exists(filename)) return false;

            DataTable dt = new DataTable();
            if (string.IsNullOrWhiteSpace(filename))
                dt = csvSaveDemo.OpenCSV(Constant.SaveFileDemo);
            else
            {
                dt = csvSaveDemo.OpenCSV(filename);
            }

            if (dt.Rows.Count == 1)
            {
                valueCol.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < dr.ItemArray.Length; i++)
                    {
                        int s = 0;
                        if (int.TryParse(dr.ItemArray[i].ToString(), out s))
                        {
                            valueCol.Add(s);
                        }
                        else
                        {
                            MessageBox.Show("指定列错误，错误列号：" + (i + 1).ToString());
                            return false;
                        }
                    }
                }
                          
            }
            else
            {
                //MessageBox.Show("加载模板数据错误！");
                return false;
            }

            return true;


        }

        #endregion
        private string ration(List<List<int>> valueLst)
        {
            Int64 sizeSum = 0;           
            Int64 lenSum = (Int64) len * valueLst.Count ;
            foreach (List<int> sLst in valueLst)
            {
                foreach (int s in sLst)
                {
                    sizeSum = sizeSum + s;
                }
            }

            double r = ((double)sizeSum / lenSum) * 100;

            return (r.ToString("0.00")+"%");
                       
        }
        private void ShowNormalResultNoSort(List<List<int>> resultOpt, List<SingleSize> prodLst, RichTextBox rt1)
        {
            ConstantMethod.ShowInfo(rt1, "--------------");

            for (int i = 0; i < resultOpt.Count; i++)
            {
                ConstantMethod.ShowInfoNoScrollEnd(rt1, "第" + (i + 1).ToString() + "根：");
                List<SingleSize> resultSingleSize = new List<SingleSize>();
                //排个序
               // resultOpt[i].Sort();
                for (int j = 0; j < resultOpt[i].Count; j++)
                {
                    for (int k = 0; k < prodLst.Count; k++)
                    {
                        if (prodLst[k].Cut == resultOpt[i][j])
                        {
                            resultSingleSize.Add(prodLst[k]);
                            ConstantMethod.ShowInfoNoScrollEnd(rt1, "第" + (j + 1).ToString() + "刀:" + resultOpt[i][j].ToString() + "---------条码：" + prodLst[k].Barc);
                            prodLst.RemoveAt(k);
                            break;
                        }
                    }

                }

                if (resultSingleSize.Count > 0)
                {
                    ProdInfo prodInfo = new ProdInfo(resultSingleSize);
                    prodInfo.DBC = dbc;
                    prodInfo.LBC = ltbc;
                    prodInfo.Len = len;
                    ConstantMethod.ShowInfoNoScrollEnd(rt1, "尾料：" + prodInfo.WL.ToString());
                    ProdInfoLst.Add(prodInfo);
                    singleSizeLst.Add(resultSingleSize);
                    ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
                    ConstantMethod.ShowInfoNoScrollEnd(rt1, "--------------");
                }

            }

            ConstantMethod.ShowInfo(rt1, "需要料数：" + resultOpt.Count.ToString() + "根");

        }

        public OptSize(DataGridView UserData0)
        {
       
            UserDataView = UserData0;

            Init();

        }
        void Init()
        {
            CSVop = new CsvStreamReader();
            SingleSizeLst = new List<List<SingleSize>>();
            ProdInfoLst = new List<ProdInfo>();
            Excelop = new ExcelNpoi();
            ScarLst = new List<int>();
            valueAbleRow = new List<int>();

            csvSaveDemo = new CsvStreamReader();

           
        }
        public OptSize()
        {
         
            dtData = new DataTable();
            Init();

        }
        #region 优化DLL 引用


        #endregion
        public void SaveExcel()
        {
            if (this == null) return;
            if (!IsLoadData
                && !string.IsNullOrWhiteSpace(Excelop.FileName)
                && File.Exists(Excelop.FileName)
                && dtData != null
                && dtData.Rows.Count > 0)
            {
                IsSaving = true;
                Excelop.ExportDataToExcelNoDialog(dtData, Excelop.FileName, null, null);
                IsSaving = false;
            }
        }

        public void SaveCsv()
        {
         
            if (this == null) return;
            if (CSVop == null) return;
            if (dtData == null) return;
            while (IsSaving)
            {
                Application.DoEvents();
            }

            try
            {
                if (!IsLoadData
                    && !string.IsNullOrWhiteSpace(CSVop.FileName)
                    && File.Exists(CSVop.FileName)
                    && dtData != null
                    && dtData.Rows.Count > 0)
                {
                    IsSaving = true;
                    //20181005增加一组函数 如果读取回来为空 那就再保存一次
                    CSVop.SaveCSV(dtData, CSVop.FileName);
                    DataTable dtIsNull = CSVop.OpenCSV(CSVop.FileName);
                    if (dtIsNull == null || dtIsNull.Rows.Count == 0)
                    {
                        CSVop.SaveCSV(dtData, CSVop.FileName);
                    }
                    IsSaving = false;
                }
                else
                {
                    //如果CSVop 文件名为空 那就保存到默认文件名里
                    if (string.IsNullOrWhiteSpace(CSVop.FileName))
                    {
                        IsSaving = true;
                        //20181005增加一组函数 如果读取回来为空 那就再保存一次
                        CSVop.SaveCSV(dtData, Constant.userdata);
                        DataTable dtIsNull = CSVop.OpenCSV(Constant.userdata);
                        if (dtIsNull == null || dtIsNull.Rows.Count == 0)
                        {
                            CSVop.SaveCSV(dtData, Constant.userdata);
                        }
                        IsSaving = false;
                    }
                }
            }
            catch { }
        }
       
        public void ShowErrorRow()
        {
            List<int> errorId = new List<int>();
            valueAbleRow.Clear();
            //检查datagridview数据是否违法 得出错误列
            errorId = CheckDataGridViewData(OptRealLen, DtData);

            if (UserDataView != null)
            {
                for (int i = 0; i < UserDataView.Rows.Count; i++)
                {
                    UserDataView.Rows[i].DefaultCellStyle.BackColor = UserDataView.RowsDefaultCellStyle.ForeColor;
                   
                }

                for (int i = errorId.Count - 1; i >= 0; i--)
                {
                    UserDataView.Rows[errorId[i]].DefaultCellStyle.BackColor = Color.Red;
                 
                }
            }

        }

        /// <summary>
        /// 在写测结巴时 函数需要独立出来 针对datatable 进行效果显示 提示用户哪些数据错误 如果控件没有 就不显示 没有用
        /// </summary>
        public void ShowErrorRow1(int OptRealLen0,DataTable dtdata0,DataGridView UserDataView0)
        {
            List<int> errorId = new List<int>();
            //检查datagridview数据是否违法 得出错误列
            errorId = CheckDataGridViewData(OptRealLen0, dtdata0);

            if(UserDataView0 != null)
            {
                for (int i = 0; i < UserDataView.Rows.Count; i++)
                {
                    UserDataView0.Rows[i].DefaultCellStyle.BackColor = UserDataView.RowsDefaultCellStyle.ForeColor;
                   
                }

                for (int i = errorId.Count - 1; i >= 0; i--)
                {
                    UserDataView0.Rows[errorId[i]].DefaultCellStyle.BackColor = Color.Red;
                
                }
            }
         

        }

        /// <summary>
        /// 针对CSV 格式 在 CheckDataGridViewData0  stirngZH时不同了 此处可在未来 进行参数化 变成同一个函数
        /// </summary>
        public void ShowErrorRow0()
        {
            List<int> errorId = new List<int>();
            //检查datagridview数据是否违法 得出错误列
            errorId = CheckDataGridViewData(OptRealLen, DtData);
            for (int i = 0; i < UserDataView.Rows.Count; i++)
            {
                UserDataView.Rows[i].DefaultCellStyle.BackColor = UserDataView.RowsDefaultCellStyle.ForeColor;
                
            }

            for (int i = errorId.Count - 1; i >= 0; i--)
            {
                UserDataView.Rows[errorId[i]].DefaultCellStyle.BackColor = Color.Red;
                
            }
        }
        #region 加载数据

        public bool LoadExcelData(string filename)
        {
            LogManager.WriteProgramLog(Constant.LoadFileSt+filename);
            while (IsSaving)
            {
                Application.DoEvents();
            }
            IsLoadData = true;
            dtData = Excelop.ImportExcel(filename);

            if (dtData.Rows.Count < 2) return false;

            string[] str = ConstantMethod.GetColumnsByDataTable(dtData);

            if (str == null) return false;

            if ((! ConstantMethod.compareString(str, Constant.strformatZh))&&(!ConstantMethod.compareString(str, Constant.strformatEh)))
            {
                return false;
            }
            CSVop.FileName =null;

            Excelop.FileName = filename;

            UserDataView.DataSource = dtData;
            ShowErrorRow();

            IsLoadData = false;

            LogManager.WriteProgramLog(Constant.LoadFileEd);
            return true;
        }
        //如果文件为空 那就重新建立一个
        public void buildDefaultCsvFile(string filename)
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < Constant.strformatZh.Length; i++)
            {
                DataColumn dc = new DataColumn(Constant.strformatZh[i]);
                dt.Columns.Add(dc);          
            }
            for (int i = 0; i<10; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = 600;
                dr[1] = 0;
                dr[2] = 0;
                dt.Rows.Add(dr);
            }
            CSVop.SaveCSV(dt, filename);

        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadCsvData(string filename)
        {
            LogManager.WriteProgramLog(Constant.LoadFileSt+filename);
            while (IsSaving)
            {
                Application.DoEvents();
            }

            IsLoadData = true;
            CSVop.DataClear(); 
            if(dtData != null)          
            dtData.Clear();

            if (ReadFileDemo(Constant.SaveFileDemoConfigPath))
            {
                DataTable dtTemp =
                 CSVop.OpenCSV(filename);
                if (valueCol.Max() >= dtTemp.Columns.Count) goto Default;

                dtData = ConstantMethod.convertDataTableByRule(dtTemp,valueCol);
                if (dtData.Rows.Count > 0) goto Next;
                else goto Default;

            }
            Default:
            {
                CSVop.FileName = filename;
                if ((!CSVop.CheckCSVFile(Constant.strformatZh)) && (!CSVop.CheckCSVFile(Constant.strformatEh)))
                {
                    return false;
                }

                dtData = CSVop.OpenCSV(filename);
            }

            Next:
            if (dtData.Rows.Count < 1)
            {
                return false;
            }
            Excelop.FileName = null;
            UserDataView.DataSource = dtData;
            ShowErrorRow();
            IsLoadData = false;
            LogManager.WriteProgramLog(Constant.LoadFileEd);

            return true;

        }
        //分号
        public bool LoadCsvData0(string filename)
        {
            LogManager.WriteProgramLog(Constant.LoadFileSt + filename);

            while (IsSaving)
            {
                Application.DoEvents();
            }

            IsLoadData = true;
            CSVop.DataClear();
            if (dtData != null)
                dtData.Clear();

            CSVop.FileName = filename;
           //这里回去改 现场不好改 
           //if (!CSVop.CheckCSVFile(Constant.strformatEh)) return false;
           
            dtData = CSVop.OpenCSV0(filename);

            if (dtData.Rows.Count < 2) return false;
            Excelop.FileName = null;
            UserDataView.DataSource = dtData;
            ShowErrorRow0();
            IsLoadData = false;
            LogManager.WriteProgramLog(Constant.LoadFileEd);
            return true;
        }
        #endregion
        public void prodClear()
        {
            if (DtData != null && DtData.Rows.Count > 0)
                foreach (DataRow dr in DtData.Rows)
                {
                    if ((dr[0] != null) && (!string.IsNullOrWhiteSpace(dr[0].ToString())))
                    {
                       dr[2] = 0;
                    }                  
                }
        }
       
        public string OptMeasure(RichTextBox rt1)
        {

            //干活之前 先清空数据 做好准备工作
            if (rt1 != null) rt1.Clear();
            singleSizeLst.Clear();
            ProdInfoLst.Clear();                     
                       
            if (dtData == null || dtData.Rows.Count < 1) return Constant.prodLstNoData;

            //检查错误行
            ShowErrorRow();
            //获取数据
            List<SingleSize> prodLst = new List<SingleSize>();

            GetDataFromDt(DtData, prodLst);
           
            //如果无数据 则返回-1
            if (prodLst.Count < 1) //
                return Constant.prodLstNoData;


            //进行优化 变成单个模块
            List<int> resultOpt = new List<int>();
            List<int> dataOpt = new List<int>();

            //进行完整的优化
            if (prodLst.Count > 0)
                foreach (SingleSize sss in prodLst)
                {
                    dataOpt.Add(sss.Cut);
                }

            if(optParam1==0)
            //----返回的结果 只有一组数据
            resultOpt = OptModuleMeasure(dataOpt.ToList<int>(), len, dbc, ltbc, safe);
            else
            resultOpt = OptModuleMeasure(dataOpt.ToList<int>(), len, dbc, ltbc, safe, optParam1);




            if (resultOpt.Count > 0)
            {
                 ShowMeasureResult(resultOpt, prodLst, rt1);
            }
            else return Constant.optResultNoData;

            resultOpt = null;
            prodLst = null;
            dataOpt = null;
            
               
            return Constant.optSuccess;
        }

        /// <summary>
        /// 第一个参数为返回的结果 取了几个数据
        /// prodlst 为传入的尺寸数据
        /// </summary>
        /// <param name="resultOpt"></param>
        /// <param name="len0"></param>
        /// <param name="dbc0"></param>
        /// <param name="ltbc0"></param>
        /// <param name="safe0"></param>
        /// <param name="prodLst"></param>
        private void GetResultOpt(List<int> resultOpt,int len0,int dbc0,int ltbc0,int safe0, List<SingleSize> prodLst)
        {

            List<int> dataOpt = new List<int>();

            if (prodLst.Count > 0)
                foreach (SingleSize sss in prodLst)
                {
                    dataOpt.Add(sss.Cut);
                }

            //----返回的结果 只有一组数据
            resultOpt = OptModuleMeasure(dataOpt.ToList<int>(), len, dbc, ltbc, safe);
        }

     
        public void ShowLenAndScarAndSize(RichTextBox rt1,int len,int scar,int[] size)
        {
            //显示一下
            ConstantMethod.ShowInfo(rt1, "料长：" + len.ToString() + "  结疤：" + scar.ToString());
            string s = "";
            for (int j = 0; j < size.Count(); j++)
            {
                if(j==size.Length-1)
                s += size[j].ToString();
                else
                s += size[j].ToString() + "--";
            }
                      
            ConstantMethod.ShowInfo(rt1, "  尺寸：" + s);
        }

        /// <summary>
        /// 20180305 修改值2239 需要进一步完善
        /// </summary>
        /// <param name="resultOpt"></param>
        /// <param name="len0"></param>
        /// <param name="dbc0"></param>
        /// <param name="ltbc0"></param>
        /// <param name="safe0"></param>
        /// <param name="prodLst"></param>
        /// <param name="scarLst0"></param>
        /// <returns></returns>
        private int GetResultOptWithScar(bool split, RichTextBox rt1,List<int> resultOpt, int len0, int dbc0, int ltbc0, int safe0, List<SingleSize> prodLst,List<int> scarLst0)
        {

            //验证结巴的合理性 结巴条数 是偶数 升序，每个数值小于料长 不为0；          
            if (scarLst0.Count < 1) return Constant.GetScarWrongScar;

            //不是偶数
            if (scarLst0.Count % 2 !=0)
            {
                return Constant.GetScarScarNoEven;
            }
            //不是升序
            for(int i=0;i<scarLst0.Count-1;i++)
            {
                if (scarLst0[i + 1] <= scarLst0[i])
                    return Constant.GetScarScarNoAscend;

                if (scarLst0[i] <= 0 || scarLst0[i] >= len)
                {
                    return Constant.GetScarScarValueError;
                }
            }
            
            //收集数据进行优化准备
            List<int> dataOpt = new List<int>();
            List<int> resultOpt0 = new List<int>();
            if (prodLst.Count > 0)
                foreach (SingleSize sss in prodLst)
                {
                    dataOpt.Add(sss.Cut);
                }
            List<int> dataOptTemp = new List<int>();
            //全部转化为料长坐标 起始点为0 ，安全距离起始点插入 插入料长 这里的尺寸集合都是带料头补偿的
            //把头插入缓冲
            //把料长插入缓冲
            scarLst0.Insert(0,0);
            scarLst0.Add(len0-safe);
            scarLst0.Add(len0);

            //只有一条结巴  没有结巴 多条结巴 
            if (scarLst0.Count == 5)
            {
                 //第一刀要特别对待       
                //结巴在料头内 或者安全距离内
                if (scarLst0[2] < ltbc || scarLst0[1] > (len0 - safe))
                {
                    resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), len0, dbc0, ltbc0, safe0);
                    ConstantMethod.ShowInfo(rt1, "结疤在料头内或者结疤在安全距离内！");
                    resultOpt.Add(ltbc0);
                    if(resultOpt0.Count>0)
                    resultOpt.AddRange(resultOpt0);                   
                }
                else
                //结巴与料头有交集
                if (scarLst0[2] > ltbc && scarLst0[1] < ltbc)
                {
                    resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), len0, dbc0, scarLst0[2], safe0);
                    resultOpt.Add(scarLst0[2]);
                    ConstantMethod.ShowInfo(rt1, "结疤为料头！");
                    if (resultOpt0.Count > 0)
                       resultOpt.AddRange(resultOpt0);
                }
                else //结巴与安全距离有交集
                if (scarLst0[2] > (len0 - safe0) && scarLst0[1] < (len0 - safe0))          
                {
                    resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), len0, dbc0, ltbc0, len0 - scarLst0[1]);
                    resultOpt.Add(ltbc0);
                    ConstantMethod.ShowInfo(rt1, "结疤在尾部，且大于安全距离！");
                    if (resultOpt0.Count > 0)
                    {
                        resultOpt.AddRange(resultOpt0);
                        //安全距离就是0点到1点的距离
                        if(split)
                        resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[1] - scarLst0[0], dbc0, 0, 0));
                    }
                    else
                    {

                        //没有尺寸 就把结巴这里切掉 剩下扔了 因为安全距离 和 结巴交叉了
                        resultOpt.Add(scarLst0[1] - scarLst0[0]);                       
                    }

                }
                else
                {
                    //取偶数位置 结巴合理 没在料头也在没料尾 结巴要加到尺寸里
                    for (int i = 0; i < scarLst0.Count; i++)
                    {
                        if (i == 2)  //把安全距离用结巴参数传进去 那就是每段料长 都有一个安全距离了  其他一样
                        {
                            resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), scarLst0[2], dbc0, ltbc0, scarLst0[2] - scarLst0[1]);
                            
                            if (resultOpt0.Count > 0)
                            {
                                resultOpt.Add(ltbc0);
                                resultOpt.AddRange(resultOpt0);
                                if (split)
                                {

                                    resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[2] - scarLst0[0], dbc0, ltbc0, scarLst0[2] - scarLst0[1]));
                                    resultOpt.Add(scarLst0[2] - scarLst0[1]);
                                }
                                else
                                {
                                    resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[2] - scarLst0[0], dbc0, ltbc0, 0));

                                }

                            }
                            else
                            {
                                if (split)
                                {
                                    resultOpt.Add(scarLst0[1] - scarLst0[0] );
                                    resultOpt.Add(scarLst0[2] - scarLst0[1] );

                                }
                                else
                                {
                                    resultOpt.Add(scarLst0[2] - scarLst0[0] );
                                }
                            }
                                                                            
                            dataOpt = ConstantMethod.DeleteDataFromARefB(dataOpt, resultOpt0);
                            //显示一下
                            ShowLenAndScarAndSize(rt1, scarLst0[2], (scarLst0[2] - scarLst0[1]), resultOpt0.ToArray());                           
                           
                        }
                        else
                        if (i == 4)   //料头为0
                        {
                            //这里不需要分了 结巴已经过去了
                            resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), scarLst0[4]- scarLst0[2], dbc0, dbc0, safe);
                            //去掉已经选中的数据
                            if (resultOpt0.Count > 0)
                            {
                                resultOpt.AddRange(resultOpt0);                          

                                dataOpt = ConstantMethod.DeleteDataFromARefB(dataOpt, resultOpt0);
                            }
                            else
                            {
                                resultOpt.Add(scarLst0[4] - scarLst0[2]);
                            }  
                                                                           
                        }                       
                    }
                }                                                        
            }
            else
            {
                if (scarLst0.Count > 5 )
                {
                    //第一个有效料长 考虑料头补偿
                    //最后一个有效料长 考虑安全距离

                    for (int i = 0; i < scarLst0.Count; i++)
                    {
                        if (i == 2)  //把结巴当做安全距离来看待 那优化和原先的都一样了  第一段有效原料 考虑料头
                        {                        
                            resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), scarLst0[2]- scarLst0[0], dbc0, ltbc0, scarLst0[2] - scarLst0[1]);
                            if (resultOpt0.Count > 0)
                            {
                                resultOpt.Add(ltbc0);

                                resultOpt.AddRange(resultOpt0);

                                if (split)
                                {

                                    resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[2] - scarLst0[0], dbc0, ltbc0, scarLst0[2] - scarLst0[1]));
                                    resultOpt.Add(scarLst0[2] - scarLst0[1]);
                                }
                                else
                                {
                                    resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[2] - scarLst0[0], dbc0, ltbc0,0));
                                   
                                }
                                dataOpt = ConstantMethod.DeleteDataFromARefB(dataOpt, resultOpt0);

                                ShowLenAndScarAndSize(rt1, scarLst0[2] - scarLst0[0], scarLst0[2] - scarLst0[1], resultOpt0.ToArray());

                            }
                            else
                            {
                                if (split)
                                {
                                    resultOpt.Add(scarLst0[1] - scarLst0[0]);
                                    resultOpt.Add(scarLst0[2] - scarLst0[1]);

                                }
                                else
                                {
                                    resultOpt.Add(scarLst0[2] - scarLst0[0]);
                                }
                            }                           
                        }
                        else
                        if (i%2 ==0  && i!=0 )   //料头为0 剩下的有效原料 料头是刀补偿
                        {
                            if (dataOpt.Count > 0)
                            {                       
                                
                                resultOpt0 = OptModuleMeasure(dataOpt.ToList<int>(), scarLst0[i] - scarLst0[i - 2] ,dbc0, dbc0, scarLst0[i] - scarLst0[i - 1]);

                                if (resultOpt0.Count > 0)
                                {
                                    resultOpt.AddRange(resultOpt0);

                                    //已经选中的 在缓存中去掉
                                    dataOpt = ConstantMethod.DeleteDataFromARefB(dataOpt, resultOpt0);
                                    ShowLenAndScarAndSize(rt1, scarLst0[i] - scarLst0[i - 2], scarLst0[i] - scarLst0[i - 1], resultOpt0.ToArray());
                                    //如果不是部 安全距离 不需要分开
                                    if (i != (scarLst0.Count - 1))
                                    {
                                        if (split)
                                        {
                                            resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[i] - scarLst0[i - 2], dbc0,0, scarLst0[i] - scarLst0[i - 1]));
                                            resultOpt.Add(scarLst0[i] - scarLst0[i - 1]);
                                        }
                                        else
                                        {
                                            resultOpt.Add(CaculateWL(resultOpt0.ToArray(), scarLst0[i] - scarLst0[i - 2], dbc0,0, 0));
                                        }
                                    }
                   
                                }
                                else
                                {
                                    if (split)
                                    {
                                        resultOpt.Add(scarLst0[i-1] - scarLst0[i-2]);
                                        resultOpt.Add(scarLst0[i] - scarLst0[i-1]);

                                    }
                                    else
                                    {
                                        resultOpt.Add(scarLst0[i] - scarLst0[i-2]);
                                    }                                   
                                }
                            }
                            else
                            //没有数据了
                            {                            
                                //如果不是尾部  安全距离 不需要分开
                                if (i != (scarLst0.Count - 1))
                                {
                                    if (split)
                                    {

                                        resultOpt.Add(scarLst0[i - 1] - scarLst0[i - 2] );
                                        resultOpt.Add(scarLst0[i] - scarLst0[i - 1] );
                                    }
                                    else
                                    {
                                        resultOpt.Add(scarLst0[i] - scarLst0[i - 2]);
                                    }
                                }                               
                            }
                        }
                    }
                }
            }

            if (resultOpt.Count > 0 && WlMiniValue > 0 && WlMiniValue < len0)
                //20181114 按照要求 所有优化 需要考虑机械的限制 尾料太短不行
                while (resultOpt.Count > 0 && (CaculateWL(resultOpt.ToArray(), len0, dbc0, ltbc0, safe0) + resultOpt[resultOpt.Count - 1]) <= WlMiniValue)
                {

                    resultOpt.RemoveAt(resultOpt.Count - 1);
                }

            return Constant.GetScarSuccess;
        }

        private int CaculateWL(int[] Cut,int len0,int dbc0,int ltbc0,int safe0)
        {

            int wl = -1;
            if ((len0 > 0) && (Cut.Count() > 0))
            {
                int jfbc = (Cut.Count()) * dbc0;
                int ladd = 0;
                for (int i = 0; i < Cut.Count(); i++)
                {
                    ladd = ladd + Cut[i];
                }
                if (ltbc0 > 0)
                {
                    ltbc0 = ltbc0 + dbc0;
                }    
                wl = len0 - ladd - jfbc - ltbc0;

            }
            
            return (wl-safe0);

        }
        public void ShowLen()
        {
           

        }
        //料头
        public string OptMeasureWithScarCheckAndNoSize(bool split, RichTextBox rt1, DataTable dtData0)
        {

            //干活之前 先清空数据 做好准备工作
            singleSizeLst.Clear();
            ProdInfoLst.Clear();          
            #region 数据获取
            //检查错误行
            //ShowErrorRow1(OptRealLen, dtData0, UserDataView);
            //获取数据
            List<SingleSize> prodLst = new List<SingleSize>();

           // GetDataFromDtByDoorType(dtData0, prodLst);

            //如果无数据 则返回-1
            #endregion


            List<int> resultOpt = new List<int>();

            int scarResult = GetResultOptWithScar(split, rt1, resultOpt, len, dbc, ltbc, safe, prodLst, ScarLst);

            if (resultOpt.Count > 0)
            {
                
                ShowMeasureResultWithCheck(resultOpt, prodLst, rt1,0);
            }
            else
            {
                switch (scarResult)
                {
                    case Constant.GetScarScarNoAscend:
                        {
                            MessageBox.Show(Constant.GetScarScarNoAscendStr);
                            break;
                        }
                    case Constant.GetScarScarNoEven:
                        {
                            MessageBox.Show(Constant.GetScarScarNoEvenStr);
                            break;
                        }
                    case Constant.GetScarWrongScar:
                        {
                            MessageBox.Show(Constant.GetScarWrongScarStr);
                            break;
                        }
                    case Constant.GetScarScarValueError:
                        {
                            MessageBox.Show(Constant.GetScarScarValueErrorStr);
                            break;
                        }

                }


                return Constant.optResultNoData;
            }

            resultOpt = null;
            prodLst = null;


            return Constant.optSuccess;
        }
        //split代表是否结疤也要分离
        public string OptMeasureWithScarCheck(bool split,RichTextBox rt1,DataTable dtData0)
        {

            //干活之前 先清空数据 做好准备工作
            
            singleSizeLst.Clear();
            ProdInfoLst.Clear();         
            if (dtData0 == null || dtData0.Rows.Count < 1) return Constant.prodLstNoData;
            #region 数据获取
            //检查错误行
            ShowErrorRow1(OptRealLen, dtData0, UserDataView);
            //获取数据
            List<SingleSize> prodLst = new List<SingleSize>();

            GetDataFromDt(dtData0, prodLst);

            //如果无数据 则返回-1
            if (prodLst.Count < 1) 
                return Constant.prodLstNoData;
            #endregion


            List<int> resultOpt = new List<int>();


            int scarResult= GetResultOptWithScar(split,rt1, resultOpt, len, dbc, ltbc, safe, prodLst, ScarLst);

            if (resultOpt.Count > 0)
            {
                ShowMeasureResultWithCheck(resultOpt, prodLst, rt1,0);
            }
            else
            {
                switch (scarResult)
                {
                    case Constant.GetScarScarNoAscend:
                        {
                            MessageBox.Show(Constant.GetScarScarNoAscendStr);
                            break;
                        }
                    case Constant.GetScarScarNoEven:
                        {
                            MessageBox.Show(Constant.GetScarScarNoEvenStr);
                            break;
                        }
                    case Constant.GetScarWrongScar:
                        {
                            MessageBox.Show(Constant.GetScarWrongScarStr);
                            break;
                        }
                    case Constant.GetScarScarValueError:
                        {
                            MessageBox.Show(Constant.GetScarScarValueErrorStr);
                            break;
                        }

                }


                return Constant.optResultNoData;
            }

            resultOpt = null;
            prodLst = null;


            return Constant.optSuccess;
        }
        public string NoOpt(RichTextBox rt1)
        {
            //干活之前 先清空数据 做好准备工作          
            singleSizeLst.Clear();
              ProdInfoLst.Clear();

            if (dtData == null || dtData.Rows.Count < 1) return Constant.prodLstNoData;

            //检查错误行
            ShowErrorRow();
            List<SingleSize> prodLst = new List<SingleSize>();
            GetDataFromDt(DtData, prodLst);

            //如果无数据 则返回-1
            if (prodLst.Count < 1) //
                return Constant.prodLstNoData;


            //进行优化 变成单个模块
            List<List<int>> resultOpt = new List<List<int>>();
            List<int> dataOpt = new List<int>();


            //进行完整的优化
            if (prodLst.Count > 0)
                foreach (SingleSize sss in prodLst)
                {
                    dataOpt.Add(sss.Cut);
                }

            //----
            resultOpt = NoOptModule(dataOpt.ToList<int>(), len, dbc, ltbc, safe); 


            if (resultOpt.Count > 0)
            {
                ShowNormalResultNoSort(resultOpt, prodLst, rt1);
            }
            else return Constant.optResultNoData;

            resultOpt = null;
            prodLst = null;
            dataOpt = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();     
            return Constant.optSuccess;

        }
        //在正常优化模式下 可以选择优化模型 这里测试EXCEL
        public string OptNormal(RichTextBox rt1,int id)
        {
            //干活之前 先清空数据 做好准备工作          
            singleSizeLst.Clear();
            ProdInfoLst.Clear();

            if (dtData == null || dtData.Rows.Count < 1) return Constant.prodLstNoData;

            //检查错误行
            ShowErrorRow();
            List<SingleSize> prodLst = new List<SingleSize>();
            GetDataFromDt(DtData, prodLst);

            //如果无数据 则返回-1
            if (prodLst.Count < 1) //
                return Constant.prodLstNoData;


            //进行优化 变成单个模块
            List<List<int>> resultOpt = new List<List<int>>();
            List<int> dataOpt = new List<int>();


            //进行完整的优化
            if (prodLst.Count > 0)
                foreach (SingleSize sss in prodLst)
                {
                    dataOpt.Add(sss.Cut);
                }

            switch(id)
            {
                case Constant.optNormalExcel:
                    {
                        if (sizeTypeCount(dataOpt.ToList<int>()) < Constant.optNormalMax)
                        {
                            if (!File.Exists(Constant.ConfigExcelOpt)) goto default;
                            resultOpt = OptModuleExcel(dataOpt.ToList<int>(), len, dbc, ltbc, safe);
                        }
                        else goto default;
                        break;
                    }
                case Constant.optNo:
                    {
                        //----
                        resultOpt = NoOptModule(dataOpt.ToList<int>(), len, dbc, ltbc, safe);
                        break;
                    }
                default:
                    {
                        resultOpt = OptModuleNormal(dataOpt.ToList<int>(), len, dbc, ltbc, safe);
                        break;
                    }

            }


            if (resultOpt.Count > 0)
            {
                ShowNormalResult(resultOpt, prodLst, rt1, id);
            }
            else return Constant.optResultNoData;

            resultOpt = null;
            prodLst = null;
            dataOpt = null;
            //GC.Collect();
            //GC.WaitForPendingFinalizers();     
            return Constant.optSuccess;

        }
        public string OptNormal(RichTextBox rt1)
        {
            //干活之前 先清空数据 做好准备工作          
            singleSizeLst.Clear();
            ProdInfoLst.Clear();          
           
            if (dtData == null || dtData.Rows.Count < 1) return Constant.prodLstNoData;

            //检查错误行
            ShowErrorRow();
            List<SingleSize> prodLst = new List<SingleSize>();
            GetDataFromDt(DtData,prodLst);

            //如果无数据 则返回-1
            if (prodLst.Count < 1) //
                return Constant.prodLstNoData;


            //进行优化 变成单个模块
            List<List<int>> resultOpt = new List<List<int>>();
            List<int> dataOpt = new List<int>();


            //进行完整的优化
            if (prodLst.Count > 0)
            foreach (SingleSize sss in prodLst)
            {
               dataOpt.Add(sss.Cut);
            }

            //----
            resultOpt = OptModuleNormal(dataOpt.ToList<int>(),len, dbc, ltbc, safe);

                    
            if (resultOpt.Count > 0 )
            {
                ShowNormalResult(resultOpt, prodLst, rt1,Constant.optNormal);              
            }
            else return Constant.optResultNoData;

            resultOpt = null;
            prodLst = null;
            dataOpt = null;

            return Constant.optSuccess;

        }
       
        private void GetSmallBigData(int c, List<int> data, List<int> dataBig, List<int> dataSmall, double index)
        {
            int len = (int)(c * index);

            if (len > -1)
            {
                foreach (int dataSize in data)
                {
                    if (dataSize > len && dataSize < c)
                    {
                        dataBig.Add(dataSize);
                    }
                    else
                    {
                        if (dataSize > 0 && dataSize < c) dataSmall.Add(dataSize);
                    }
                }
            }

        }
        //索菲亚 余料优化 最保证至少两刀 小尺寸先添加 20181011
        private List<int> OptModuleMeasure(List<int> data, int c, int dbc_tmp, int ltbc_tmp, int safe_tmp,int cutCount)
        {
            List<int> dataTmp = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] < (c - safe_tmp-ltbc_tmp-dbc))
                {
                    int s = data[i];
                    dataTmp.Add(s);
                }
            }
            List<int> dataResult = new List<int>();

            if (dataTmp.Count < 1) return dataResult.ToList();

            //设置一个参数 如果数据在上面都没有 也就是大家都是小类 尺寸  也没有必要再进行优化了 都是同一类尺寸
            //double indexBigDouble = (double)dataTmp.ToArray().Max() / c + 0.1;

            List<int> dataBig = new List<int>();
            List<int> dataSmall = new List<int>();
            List<int> dataRes = new List<int>();
            int[] dataResL = null;

            if (cutCount == 0)//如果是0 还是原来那种模式
            {
                dataBig.Add(dataTmp.ToArray().Max());

                if (dataBig.Count > 0)
                    dataTmp.Remove(dataBig[0]);


                //剩下全是短料
                dataSmall = dataTmp.ToList();

                //只进行一次优化
                if (dataSmall.Count > 0 && dataSmall.Min() < (c - dataBig[0] - dbc_tmp))
                    dataResL = OptModule0(dataSmall, c - dataBig[0] - dbc_tmp, dbc_tmp, ltbc_tmp, safe_tmp);
                //统计结果
                if (dataResL != null)
                    dataResult.AddRange(dataResL);
                //把长料增加进去
                if (dataBig.Count > 0)
                    dataResult.Add(dataBig[0]);
            }
            else
            {
                int len = c-dbc_tmp-ltbc_tmp-safe_tmp; 
                //索菲亚希望有两根
                //找到最靠近料长的尺寸
                for (int i = 0; i < cutCount; i++)
                {
                    
                    int sizetmp = dataTmp.ToArray().Min();                   
                    len=len - sizetmp - dbc_tmp;
                    if (len <= 0) break;
                    dataBig.Add(sizetmp);
                    dataTmp.Remove(sizetmp);
                    if (dataTmp.Count == 0) break;
                }

                //剩下全是短料
                dataSmall = dataTmp.ToList();

                //只进行一次优化
                if (dataSmall.Count > 0 && dataSmall.Min() < len)
                    dataResL = OptModule0(dataSmall, len, dbc_tmp, ltbc_tmp, safe_tmp);
                //统计结果
                if (dataResL != null)
                    dataResult.AddRange(dataResL);
                //把长料增加进去
                if (dataBig.Count > 0)
                    dataResult.AddRange(dataBig) ;

            }

            return dataResult.ToList();
        }
        /// <summary>
        /// //自动测长情况下 只优化一根出来就可以了 
        //选一个最靠近料长的 尺寸
        //剩下的拿来优化
        /// </summary>
        /// <param name="data"></param>
        /// <param name="c"></param>
        /// <param name="dbc_tmp"></param>
        /// <param name="ltbc_tmp"></param>
        /// <param name="safe_tmp"></param>
        /// <returns></returns>=
        private List<int> OptModuleMeasure(List<int> data, int c, int dbc_tmp, int ltbc_tmp, int safe_tmp)
        {
            List<int> dataTmp = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] < (c-safe_tmp-ltbc_tmp-dbc_tmp))
                {
                    int s = data[i];
                    dataTmp.Add(s);
                }
            }
            
            
            List<int> dataResult = new List<int>();

            if(dataTmp.Count<1) return dataResult.ToList();


            //设置一个参数 如果数据在上面都没有 也就是大家都是小类 尺寸  也没有必要再进行优化了 都是同一类尺寸
            double indexBigDouble = (double)dataTmp.ToArray().Max() / c + 0.1;

            List<int> dataBig = new List<int>();
            List<int> dataSmall = new List<int>();
            List<int> dataRes = new List<int>();
            int[] dataResL=null;
            //找到最靠近料长的尺寸
            
            dataBig.Add(dataTmp.ToArray().Max());

            if(dataBig.Count>0)
            dataTmp.Remove(dataBig[0]);
            //剩下全是短料
            dataSmall = dataTmp.ToList();

            //只进行一次优化
            if (dataSmall.Count>0 && dataSmall.Min() < (c - dataBig[0] - dbc_tmp))           
            dataResL = OptModule0(dataSmall, c - dataBig[0] - dbc_tmp, dbc_tmp, ltbc_tmp, safe_tmp);
            //统计结果
            if(dataResL !=null)
            dataResult.AddRange(dataResL);
            //把长料增加进去
            if (dataBig.Count > 0)
            dataResult.Add(dataBig[0]);

            if (dataResult.Count > 0 && WlMiniValue > 0 && WlMiniValue < c)
                //20181114 按照要求 所有优化 需要考虑机械的限制 尾料太短不行
                while (dataResult.Count > 0 && (CaculateWL(dataResult.ToArray(), c, dbc_tmp, ltbc_tmp, safe_tmp) + dataResult[dataResult.Count - 1]) <= WlMiniValue)
                {

                    dataResult.RemoveAt(dataResult.Count - 1);
                }
            /***
            if (dataRes.Count > 0 && WlMiniValue > 0 && WlMiniValue < c)
                //20181114 按照要求所有优化,需要考虑机械的限制 尾料太短不行 
                if (CaculateWL(dataResult.ToArray(), c, dbc_tmp, ltbc_tmp, safe_tmp) <= WlMiniValue && dataResult.Count() > 0)
            {
                dataResult.RemoveAt(dataResult.Count - 1);
            }
            ****/
            return dataResult.ToList();
        }

        public int sizeTypeCount(List<int> data)
        {
            List<int> dataTmp = data.ToList<int>();
            //统计数据 之前因为是乘以一个系数了 所以要修改回去
            Dictionary<double, int> dataDic = new Dictionary<double, int>();

            foreach (int s in dataTmp)
            {
                double size = (double)s / Constant.dataMultiple;
                int i = 1;
                if (dataDic.TryGetValue(size, out i))
                {
                    dataDic[size] = dataDic[size] + 1;
                }
                else
                {
                    dataDic.Add(size, 1);
                }
            }

            return dataDic.Count();


        }

        //根据EXCEL 优化引擎进行排版
        private List<List<int>> OptModuleExcel(List<int> data, int c, int dbc_tmp, int ltbc_tmp, int safe_tmp)
        {
            List<int> dataTmp = data.ToList<int>();

            List<List<int>> dataResult = new List<List<int>>();
            for (int i = 0; i < data.Count; i++)
            {
                if (((data[i]+dbc_tmp) <= optRealLen))
                {
                    data[i] = data[i]; //这里加一个刀补偿 后面要减掉
                    
                }
            }
            //统计数据 之前因为是乘以一个系数了 所以要修改回去
            Dictionary<double, int> dataDic = new Dictionary<double, int>();

            foreach (int s in dataTmp)
            {
                double size = (double)s / Constant.dataMultiple;
                int i = 1;
                if (dataDic.TryGetValue(size, out i))
                {
                    dataDic[size] = dataDic[size] + 1;
                }
                else
                {
                    dataDic.Add(size,1);
                }
            }

            
            //加载EXCEL 文件
            ConstantMethod.KillProcess("EXCEL");
            ExcelObject eop = new ExcelObject();
           // MessageBox.Show("开始优化！");
            try
            {
                eop.Open(Constant.ConfigExcelOpt);
                //清空原有数据
                int rowId = 2;
                int colId = 2;
                while (!String.IsNullOrWhiteSpace(eop.GetStrCellValue(eop.ws, rowId, colId)))
                {
                    Application.DoEvents();
                    eop.SetCellValue(eop.ws, rowId, colId,"");
                    eop.SetCellValue(eop.ws, rowId+1, colId, "");
                    colId++;
                }       
                //设置数据
                List<double> test = new List<double>(dataDic.Keys);
                for (int m = 0; m < dataDic.Count; m++)
                {
                    eop.SetCellValue(eop.ws, 2, 2 + m, test[m].ToString());
                    eop.SetCellValue(eop.ws, 3, 2 + m, dataDic[test[m]].ToString());
                }

                //设置料长
                double len = (double)OptRealLen / Constant.dataMultiple;
                double dbc0 = (double)dbc_tmp / Constant.dataMultiple;
                eop.SetCellValue(eop.ws, 13, 6, Constant.strParam1);
                eop.SetCellValue(eop.ws, 6, 2, len.ToString());
                eop.SetCellValue(eop.ws, 7, 2, dbc0.ToString());
                eop.ExcelRunMacro();

                //等待排版
                for (int i = 0; i < 1200; i++)
                {
                   ConstantMethod.Delay(100);
                   # region 开始提取数据
                    if (eop.GetStrCellValue(eop.ws, 13, 6).Equals(len.ToString()))
                    {
                        int row = 12;// 数据在表格中的位置
                        int col = 5;
                        #region//获取到数据了 开始解析
                        while (!String.IsNullOrWhiteSpace(eop.GetStrCellValue(eop.ws, row, col)))
                        {
                            row++;
                            Application.DoEvents();
                                                                                 
                            int count = eop.GetIntCellValue(eop.ws, row, 7);
                            if (count > 0)
                            {
                                List<int> r = new List<int>();
                                string sizeLst = eop.GetStrCellValue(eop.ws, row, 11);
                                for (int x = 0; x < count; x++)
                                {
                                    double[] value = splitStrToSizeLst(sizeLst);
                                    dataResult.Add((double2Int(value)).ToList<int>());
                                }
                            }

                        }
                        #endregion
                        break;
                    }
                    #endregion                 
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                eop.Close0();
            }
            //输入数据
            //检测是否完成


            return dataResult;

        }

        int[] double2Int(double[] value)
        {
            List<int> intvalue = new List<int>();
            for (int i = 0; i < value.Count(); i++)
            {
                int temp = 0;
                temp = Convert.ToInt32(value[i]*Constant.dataMultiple);
                //这里减一个刀补偿               
                intvalue.Add(temp);
            }

            return intvalue.ToArray();

        }
        //1603*1+769*1 字符分解
        double[] splitStrToSizeLst(string str)
        {
            int count = 0;
            double size = 0;
            List<double> sizeLst = new List<double>();
            string[] sLst = str.Split('+');
            if (sLst.Count() == 0) return sizeLst.ToArray();
            for (int i = 0; i < sLst.Count(); i++)
            {
                string[] ss = sLst[i].Split('*');
                if (ss.Count() == 2)
                {
                   
                  if(int.TryParse(ss[1],out count) &&double.TryParse(ss[0],out size))
                  {
                    for (int x = 0; x < count; x++)
                    {
                       sizeLst.Add(size);
                    }
                  }
               }
            }


            return sizeLst.ToArray();            
        }
        /// <summary>
        /// 优化主程序
        /// 先进行大小分类，再进行优化排版 
        /// 分类
        ///  排版
        /// 统计根数
        //选择最优根数和其他参数
        /// </summary>
        /// <param name="data"></param>
        /// <param name="selectedData"></param>
        /// <param name="c"></param>
        /// <param name="dbc_tmp"></param>
        /// <param name="ltbc_tmp"></param>
        /// <param name="safe_tmp"></param>
        private List<List<int>> OptModuleNormal(List<int> data, int c, int dbc_tmp, int ltbc_tmp, int safe_tmp)
        {        
            double index = 0;//取值是0~1 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0.9 
                                
            List<int> dataTmp = new List<int>();
            List<int> dataOrgin = new List<int>();
            List<List<int>> dataResult = new List<List<int>>();

            for (int i = 0; i < data.Count; i++)
            {
              
                    if (((data[i] + dbc_tmp) < optRealLen))
                    {
                        int s = data[i];
                        dataTmp.Add(s);
                       dataOrgin.Add(s);
                    }
                
            }
            //设置一个参数 如果数据在上面都没有 也就是大家都是小类 尺寸  也没有必要再进行优化了 都是同一类尺寸
            double indexBigDouble = (double)dataTmp.ToArray().Max() / c + 0.1;

            
            //优化9次
            for (int i = 1; i <10; i++)
            {
                              
                index = 0.1 * i;
                if (index > indexBigDouble) break;

                dataTmp = dataOrgin.ToList<int>();  //这里反了一个致命错误 数据源 居然没筛选 直接就把data 这个list拿来用 导致排版不出来

                List<List<int>> dataResultM = new List<List<int>>();

                //每次优化把数据优化完
                while (dataTmp.Count > 0)
                {
                    Application.DoEvents();
                    List<int> dataBig = new List<int>();
                    List<int> dataSmall = new List<int>();
                    List<int> dataRes = new List<int>();
                    int[] dataResL;
                    //区分长短料
                    GetSmallBigData(c, dataTmp, dataBig, dataSmall, index);
                    //分三种情况 1.长料 短料 都有 2.长料有 短料无 3.短料有 长料无
                    if (dataBig.Count > 0 && dataSmall.Count > 0)
                    {
                        //短料优化
                        dataResL=OptModule0(dataSmall, c - dataBig[0] - dbc_tmp, dbc_tmp, ltbc_tmp, safe_tmp);
                        dataRes.AddRange(dataResL);
                        dataRes.Add(dataBig[0]);
                    }
                    else
                    {
                        //长料有 短料无
                        if (dataBig.Count > 0)
                        {
                            dataResL=OptModule0(dataBig, c, dbc_tmp, ltbc_tmp, safe_tmp);
                            dataRes.AddRange(dataResL);         
                        }
                        else
                        {
                            //短料有 长料无
                            if (dataSmall.Count > 0)
                            {
                                dataResL = OptModule0(dataSmall, c, dbc_tmp, ltbc_tmp, safe_tmp);
                                dataRes.AddRange(dataResL);
                            }
                        }
                    }

                    if (dataRes.Count > 0 && WlMiniValue>0 && WlMiniValue<c)                    
                        //20181114 按照要求 所有优化 需要考虑机械的限制 尾料太短不行
                     while (dataRes.Count > 0&&(CaculateWL(dataRes.ToArray(), c, dbc_tmp, ltbc_tmp, safe_tmp)+ dataRes[dataRes.Count-1]) <= WlMiniValue )
                    {
                           
                            dataRes.RemoveAt(dataRes.Count - 1); 
                    }
                    //每一根的优化结果 然后在 datatmp中删除已经选中的数据
                    if (dataRes.Count > 0)
                    {
                       
                        dataResultM.Add(dataRes.ToList<int>());
                        //删除已经选中的数据
                        for (int j = 0; j < dataRes.Count; j++)
                        {
                            int FindSize = dataTmp.IndexOf(dataRes[j]);
                            if (FindSize > -1)
                                dataTmp.RemoveAt(FindSize);
                        }
                    }
                    //
                    dataBig = null;
                    dataSmall = null;
                    dataRes = null;

                }
               
                dataTmp = null;
                if (dataResultM.Count > 0)
                {
                    if (dataResult.Count > 0)
                    {
                        if (dataResult.Count >= dataResultM.Count)
                        {
                            dataResult = dataResultM.ToList();
                        }
                    }
                    else
                    {
                        dataResult = dataResultM.ToList();
                    }                                       
                }

                dataResultM = null;

            }
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            return dataResult.ToList();          
          
        }

        [DllImport("opt3.dll", EntryPoint = "Optimize", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        private static extern int Optimize(int n, int c, int[] w, int[] v, int[] x);
        private List<List<int>> NoOptModule(List<int> data, int c, int dbc_tmp, int ltbc_tmp, int safe_tmp)
        {
            double index = 0;//取值是0~1 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0.9 

        
            List<List<int>> dataResult = new List<List<int>>();

            List<List<int>> dataResultM = new List<List<int>>();

            List<int> dataTmp = new List<int>();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] < (c - safe_tmp - ltbc_tmp - dbc))
                {
                    int s = data[i];
                    dataTmp.Add(s);
                }
            }

            while (dataTmp.Count > 0)
            {
                List<int> dataRes = new List<int>();

                int sum = 0;
                for (int i = 0; i < dataTmp.Count; i++)
                {
                    sum += dataTmp[i];
                    if (sum < (c - ltbc_tmp - dbc_tmp - safe_tmp))
                    {
                        dataRes.Add(dataTmp[i]);
                    }
                    else
                        break;
                }
                if (dataRes.Count > 0)
                {
                    dataResultM.Add(dataRes.ToList<int>());
                    //删除已经选中的数据
                    for (int j = 0; j < dataRes.Count; j++)
                    {
                        int FindSize = dataTmp.IndexOf(dataRes[j]);
                        if (FindSize > -1)
                            dataTmp.RemoveAt(FindSize);
                    }
                }
            }
                    
               
                if (dataResultM.Count > 0)
                {
                    if (dataResult.Count > 0)
                    {
                        if (dataResult.Count > dataResultM.Count)
                        {
                            dataResult = dataResultM.ToList();
                        }
                    }
                    else
                    {
                        dataResult = dataResultM.ToList();
                    }
                }

            dataResultM = null;
            dataTmp = null;

            //GC.Collect();
            //GC.WaitForPendingFinalizers();


            return dataResult.ToList();

        }


        //单个模块进行排版
        private int[] OptModule0(List<int> data,  int c, int dbc_tmp, int ltbc_tmp, int safe_tmp)
        {
            
            List<int> selectedData = new List<int>();
            data.Insert(0, 0);
            int n = data.Count();
            int[] w = data.ToArray();// data.ToArray();//new int[15]{0,34000,20000,7000,15000,12000,2000,25000,25000,10000,18000,16000,12000,15000,14000};
            int[] x = new int[n];
            int[] v = new int[n];
            double valuedouble;
            n = data.Count();//有效数据个数

            valuedouble = (c - dbc_tmp - ltbc_tmp - safe_tmp) / 100;
            c = (int)(Math.Floor(valuedouble));
           
            //参与运算的尺寸减去刀补偿
            for (int i = 1; i < n; i++)
            {
                w[i] = w[i] + dbc_tmp;
                valuedouble = ((double)w[i]) / 100;
                w[i] = (int)Math.Ceiling(valuedouble); ;
            }
            for (int i = 0; i < n; i++)
            {
                v[i] = w[i];
            }
            try
            {
               // ConstantMethod.
               Optimize(n, c,w, v, x);//UserData.RowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Optimize(n, w, v, x, c);
            }
            finally
            {
                
            }
           
            for (int i = 1; i < x.Count(); i++)
            {
                int k = i;

                if (x[i] == 1)
                {
                    selectedData.Add(data[k]);
                }

            }

            w = null;
            x = null;
            v = null;

            data.RemoveAt(0);
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            return selectedData.ToArray();                        
                       
        }        
        #endregion
        //主要针对第一列数据进行检查TaT
        /// <summary>
        /// 第一列尺寸 第二列设定数量 第三列 已切数量
        /// </summary>
        /// <param name="reallen"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<int> CheckDataGridViewData(int reallen,DataTable dt)
        {
            List<int> errRow = new List<int>();
            double dblevaluesize; //尺寸
            int intcounttocut; //要切的数量
            int intcountdone;//已切数量
            ValueAbleRow.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int m = i;
                                        
                if (dt.Rows[i][0] == null)
                {
                    errRow.Add(m);
                    continue;
                }
                if (dt.Rows[i][0] == null)
                {
                    errRow.Add(m);
                    continue;
                }
                if (dt.Rows[i][2] == null)
                {
                    errRow.Add(m);
                    continue;
                }
                if (!Double.TryParse(dt.Rows[i][0].ToString(), out dblevaluesize))
                {
                    errRow.Add(m);
                    continue;
                }
                if (!int.TryParse(dt.Rows[i][1].ToString(), out intcounttocut))
                {
                    errRow.Add(m);
                    continue;
                }
                //已切数量没有 默认为0
                if (!int.TryParse(dt.Rows[i][2].ToString(), out intcountdone))
                {
                    dt.Rows[i][2] = 0;
                    intcountdone = 0;
                    // errRow.Add(m);
                }

                if (intcounttocut < intcountdone)
                {
                    errRow.Add(m);
                    continue;
                }

                if ((dblevaluesize > 0) && (intcounttocut > -1) && (intcountdone > -1))
                {

                    int size = (int)(dblevaluesize * 100);
                    if (size > reallen )
                    {
                        errRow.Add(m);                                               
                    }

                   if(intcounttocut>intcountdone)
                    ValueAbleRow.Add(m);

                }
                else
                {
                    errRow.Add(m);
                    continue;
                }
            }

            return errRow;
        }      
        /// <summary>
        /// 在给定的dt里寻找数据
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ProdLst"></param>
        private void GetDataFromDt(DataTable dt, List<SingleSize> ProdLst)
        {
            double dblevaluesize; //尺寸
            int intcounttocut; //要切的数量
            int intcountdone;//已切数量

            ProdLst.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //判断尺寸 设定数量 已切数量
                if (!Double.TryParse(dt.Rows[i][0].ToString(), out dblevaluesize)) continue;
                if (!int.TryParse(dt.Rows[i][1].ToString(), out intcounttocut)) continue;
                if (!int.TryParse(dt.Rows[i][2].ToString(), out intcountdone)) continue;

                if (intcounttocut <= intcountdone) continue;

                //尺寸需要扩大一下 有精度要求 小数点后面两位            
                int size = (int)(dblevaluesize * 100);

                if (!(size < OptRealLen)) continue;

                if ((dblevaluesize > 0) && (intcounttocut > 0) && (intcountdone > -1))
                {
                    for (int j = 0; j < (intcounttocut - intcountdone); j++)
                    {                    
                        SingleSize pi = new SingleSize(dt,i);
                        ProdLst.Add(pi);
                        
                        //设定尺寸 条码
                        pi.Cut = size;                       
                        pi.Barc = dt.Rows[i][3].ToString();
                        pi.DtUser = dt;
                        //添加参数   
                        List<string> paramLst = new List<string>();                   
                        for (int m = 0; m < pi.ParamStrLst.Count; m++)
                        {
                            if ((m + 4) < dt.Rows[i].ItemArray.Count() && dt.Rows[i][4 + m] != null)
                            //参数
                            {
                                paramLst.Add(dt.Rows[i][4 + m].ToString());
                                
                            }
                        }
                        pi.ParamStrLst.Clear();
                        pi.ParamStrLst.AddRange(paramLst) ;
                        pi.ParamStrLst.Insert(0,pi.Barc);
                    }
                }

            }

            SizeLeft = ProdLst.Count();
        }        
    }
}
