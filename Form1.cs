﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_boxes_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxshopping_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            listBoxshopping.Items.Add(txt_New_Item.Text);
        }
    }
}
