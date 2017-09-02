﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PgSql
{
   public partial class Form1 : Form
   {
      List<string> dataItems = new List<string>();

      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         PostGreSQL pgTest = new PostGreSQL();
         dataItems = pgTest.PostgreSQLtest1();
         tbDataItems.Clear();
         for (int i = 0; i < dataItems.Count; i++)
         {
            tbDataItems.Text += dataItems[i];
            tbDataItems.ScrollToCaret();
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         PostGreSQL pgTest = new PostGreSQL();
         dataItems = pgTest.PostgreSQLtest2();
         tbDataItems.Clear();
         for (int i = 0; i < dataItems.Count; i++)
         {
            tbDataItems.Text += dataItems[i];
            tbDataItems.ScrollToCaret();
         }
      }
   }
}
