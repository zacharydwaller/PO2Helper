/* GENERATED CODE */
namespace PO2Helper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.po2Box = new System.Windows.Forms.TextBox();
            this.shorthandBox = new System.Windows.Forms.TextBox();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.decBox = new System.Windows.Forms.TextBox();
            this.shortHandComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bits/Power Of 2:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shorthand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hexadecimal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decimal:";
            // 
            // po2Box
            // 
            this.po2Box.Location = new System.Drawing.Point(134, 7);
            this.po2Box.Name = "po2Box";
            this.po2Box.Size = new System.Drawing.Size(144, 20);
            this.po2Box.TabIndex = 0;
            this.po2Box.TextChanged += new System.EventHandler(this.po2Box_TextChanged);
            // 
            // shorthandBox
            // 
            this.shorthandBox.Location = new System.Drawing.Point(134, 33);
            this.shorthandBox.Name = "shorthandBox";
            this.shorthandBox.Size = new System.Drawing.Size(91, 20);
            this.shorthandBox.TabIndex = 1;
            this.shorthandBox.TextChanged += new System.EventHandler(this.shortHandBox_TextChanged);
            // 
            // hexBox
            // 
            this.hexBox.Location = new System.Drawing.Point(134, 59);
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(144, 20);
            this.hexBox.TabIndex = 3;
            this.hexBox.TextChanged += new System.EventHandler(this.hexBox_TextChanged);
            // 
            // decBox
            // 
            this.decBox.Location = new System.Drawing.Point(134, 89);
            this.decBox.Name = "decBox";
            this.decBox.Size = new System.Drawing.Size(144, 20);
            this.decBox.TabIndex = 4;
            this.decBox.TextChanged += new System.EventHandler(this.decBox_TextChanged);
            // 
            // shortHandComboBox
            // 
            this.shortHandComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.shortHandComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.shortHandComboBox.FormattingEnabled = true;
            this.shortHandComboBox.IntegralHeight = false;
            this.shortHandComboBox.Items.AddRange(new object[] {
            "",
            "K",
            "M",
            "G",
            "T",
            "P",
            "E"});
            this.shortHandComboBox.Location = new System.Drawing.Point(228, 32);
            this.shortHandComboBox.MaxDropDownItems = 7;
            this.shortHandComboBox.MaxLength = 1;
            this.shortHandComboBox.Name = "shortHandComboBox";
            this.shortHandComboBox.Size = new System.Drawing.Size(50, 21);
            this.shortHandComboBox.TabIndex = 2;
            this.shortHandComboBox.SelectedIndexChanged += new System.EventHandler(this.shortHandComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.shortHandComboBox);
            this.Controls.Add(this.decBox);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.shorthandBox);
            this.Controls.Add(this.po2Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "PO2Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox po2Box;
        private System.Windows.Forms.TextBox shorthandBox;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.TextBox decBox;
        private System.Windows.Forms.ComboBox shortHandComboBox;
    }
}

