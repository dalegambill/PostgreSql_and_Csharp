﻿namespace PgSql
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.button1 = new System.Windows.Forms.Button();
         this.tbDataItems = new System.Windows.Forms.TextBox();
         this.button2 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.Location = new System.Drawing.Point(29, 22);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(268, 59);
         this.button1.TabIndex = 0;
         this.button1.Text = "Get data from bike_route.points table";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // tbDataItems
         // 
         this.tbDataItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbDataItems.Location = new System.Drawing.Point(1, 87);
         this.tbDataItems.Multiline = true;
         this.tbDataItems.Name = "tbDataItems";
         this.tbDataItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.tbDataItems.Size = new System.Drawing.Size(665, 333);
         this.tbDataItems.TabIndex = 1;
         // 
         // button2
         // 
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button2.Location = new System.Drawing.Point(334, 22);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(301, 59);
         this.button2.TabIndex = 2;
         this.button2.Text = "Get filtered data from bike_route.points table";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(671, 432);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.tbDataItems);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox tbDataItems;
      private System.Windows.Forms.Button button2;
   }
}

