namespace _02CourseModules
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
      this.LinkTitle = new System.Windows.Forms.TextBox();
      this.LinkUrl = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.createList = new System.Windows.Forms.Button();
      this.listNameBox = new System.Windows.Forms.TextBox();
      this.nomeLista = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
      this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button1.Location = new System.Drawing.Point(583, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(205, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "CreateSite";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // LinkTitle
      // 
      this.LinkTitle.Location = new System.Drawing.Point(253, 102);
      this.LinkTitle.Name = "LinkTitle";
      this.LinkTitle.Size = new System.Drawing.Size(285, 20);
      this.LinkTitle.TabIndex = 1;
      // 
      // LinkUrl
      // 
      this.LinkUrl.Location = new System.Drawing.Point(253, 139);
      this.LinkUrl.Name = "LinkUrl";
      this.LinkUrl.Size = new System.Drawing.Size(285, 20);
      this.LinkUrl.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(197, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Link Title";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(197, 142);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Link Url";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.LightCoral;
      this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.button2.Location = new System.Drawing.Point(583, 107);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(205, 38);
      this.button2.TabIndex = 5;
      this.button2.Text = "Add Items to Quick Launch";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // createList
      // 
      this.createList.BackColor = System.Drawing.Color.Wheat;
      this.createList.Location = new System.Drawing.Point(583, 215);
      this.createList.Name = "createList";
      this.createList.Size = new System.Drawing.Size(205, 38);
      this.createList.TabIndex = 6;
      this.createList.Text = "Create List";
      this.createList.UseVisualStyleBackColor = false;
      this.createList.Click += new System.EventHandler(this.createList_Click);
      // 
      // listNameBox
      // 
      this.listNameBox.Location = new System.Drawing.Point(253, 225);
      this.listNameBox.Name = "listNameBox";
      this.listNameBox.Size = new System.Drawing.Size(285, 20);
      this.listNameBox.TabIndex = 7;
      // 
      // nomeLista
      // 
      this.nomeLista.AutoSize = true;
      this.nomeLista.Location = new System.Drawing.Point(172, 228);
      this.nomeLista.Name = "nomeLista";
      this.nomeLista.Size = new System.Drawing.Size(75, 13);
      this.nomeLista.TabIndex = 8;
      this.nomeLista.Text = "Nome da Lista";
      this.nomeLista.Click += new System.EventHandler(this.label3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 386);
      this.Controls.Add(this.nomeLista);
      this.Controls.Add(this.listNameBox);
      this.Controls.Add(this.createList);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.LinkUrl);
      this.Controls.Add(this.LinkTitle);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox LinkTitle;
    private System.Windows.Forms.TextBox LinkUrl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button createList;
    private System.Windows.Forms.TextBox listNameBox;
    private System.Windows.Forms.Label nomeLista;
  }
}

