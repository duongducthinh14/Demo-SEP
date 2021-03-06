﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Demo.GUI
{
    public partial class GUI_Program_CreateProgram : Form
    {
        public GUI_Program_CreateProgram()
        {
            InitializeComponent();
        }
        AccountBLL ac = new AccountBLL();
        ProgramBLL p = new ProgramBLL();
        DicBLL dc = new DicBLL();
        private void GUI_Program_CreateProgram_Load(object sender, EventArgs e)
        {
            cboProgramMaster.DataSource = ac.LoadAccount();
            cboProgramMaster.DisplayMember = "name";
            cboProgramMaster.ValueMember = "id";
        }

        private void btnProgramSave_Click(object sender, EventArgs e)
        {
            string name = txtProgramName.Text;
            string ida = cboProgramMaster.SelectedValue.ToString();
            if (p.CreateProgram(ida, name) == true)
            {
                dc.successCreateProgram("createprogram");
            }
            else
            {
                dc.errorCreateProgram("else");
            }
        }
    }
}
