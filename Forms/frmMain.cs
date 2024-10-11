﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Project.Controls;

namespace Project.Forms
{
    public partial class frmMain : Form
    {
        private string position;

        public frmMain(string position)
        {
            this.position = position;
            InitializeComponent();
        }

        private void DeleteActiveControl()
        {
            Control? control = ControlExists();
            if (control != null)
            {
                if (pnlMain.Controls.Contains(control))
                {
                    pnlMain.Controls.Remove(control);
                    control.Dispose();
                    control = null;
                }
            }
        }

        private Control? ControlExists()
        {
            foreach (Control control in pnlMain.Controls)
            {
                if (control is UserControl)
                {
                    return control;
                }
            }
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (position != null && position.ToLower().Equals("gerente"))
            {
                btnReg.Visible = true;
                btnReg.Enabled = true;
            }

            btnControl_Click(sender, e);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            DeleteActiveControl();

            registerPanel? regPanel = new()
            {
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(regPanel);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            DeleteActiveControl();

            ControlPanel? ctrlPanel = new()
            {
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ctrlPanel);
        }
    }
}