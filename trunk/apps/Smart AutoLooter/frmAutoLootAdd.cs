﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_AutoLooter
{
    public partial class frmAutoLootAdd : Form
    {
        public frmAutoLootAdd()
        {
            InitializeComponent();
        }

        public ushort ItemId
        {
            get { return (ushort)numericUpDownItemId.Value; }
            set { numericUpDownItemId.Value = value; }
        }

        public byte ContainerNumber
        {
            get { return (byte)(numericUpDownContainer.Value - 1); }
            set { numericUpDownContainer.Value = value + 1; }
        }

        public string Comment
        {
            get { return textBoxComment.Text; }
            set { textBoxComment.Text = value; }
        }

        private void frmAutoLootAdd_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}