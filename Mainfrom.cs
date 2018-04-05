using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using JQICU.code;
using System.IO;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraTab;
using System.Reflection;
using CommonModule;
using CommonModule.bll;
using CommonModule.model;
using JQICU.Properties;
using CommonModule.dao;

namespace PatientRound
{
    public partial class Mainfrom : DevExpress.XtraEditors.XtraForm
    {
        public Mainfrom()
        {
            InitializeComponent();
        }
        BLL_Brxx bll_brxx = new BLL_Brxx();
        private void gridControl1_Load(object sender, EventArgs e)
        {
            //PatientForm getbq = new PatientForm();
            //string bq = getbq.get_bq();                             //获取病区
            //Result<List<TB_BRXX>> result = bll_brxx.listAll1(bq, "");
        }

        private void dockPanel6_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
