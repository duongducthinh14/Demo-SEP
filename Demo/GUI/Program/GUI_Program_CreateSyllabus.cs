﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
namespace Demo.GUI.Program
{
    public partial class GUI_Program_CreateSyllabus : Form
    {
        public GUI_Program_CreateSyllabus()
        {
            InitializeComponent();
        }
        SyllabusBLL s = new SyllabusBLL();
        public string idPrg;
        public void loadData()
        {
            gcCourse.DataSource = s.loadSyllabus(idPrg);
        }
        private void GUI_Program_CreateSyllabus_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
