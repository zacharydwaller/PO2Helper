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
            this.po2Label = new System.Windows.Forms.Label();
            this.shorthandLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.po2Box = new System.Windows.Forms.TextBox();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.decBox = new System.Windows.Forms.TextBox();
            this.shorthandPrefBox = new System.Windows.Forms.ComboBox();
            this.shorthandNumBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // po2Label
            // 
            this.po2Label.AutoSize = true;
            this.po2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po2Label.Location = new System.Drawing.Point(12, 9);
            this.po2Label.Name = "po2Label";
            this.po2Label.Size = new System.Drawing.Size(116, 18);
            this.po2Label.TabIndex = 0;
            this.po2Label.Text = "Bits/Power Of 2:";
            // 
            // shorthandLabel
            // 
            this.shorthandLabel.AutoSize = true;
            this.shorthandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shorthandLabel.Location = new System.Drawing.Point(12, 35);
            this.shorthandLabel.Name = "shorthandLabel";
            this.shorthandLabel.Size = new System.Drawing.Size(80, 18);
            this.shorthandLabel.TabIndex = 1;
            this.shorthandLabel.Text = "Shorthand:";
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.Location = new System.Drawing.Point(12, 61);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(97, 18);
            this.hexLabel.TabIndex = 2;
            this.hexLabel.Text = "Hexadecimal:";
            // 
            // decLabel
            // 
            this.decLabel.AutoSize = true;
            this.decLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decLabel.Location = new System.Drawing.Point(12, 88);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(66, 18);
            this.decLabel.TabIndex = 3;
            this.decLabel.Text = "Decimal:";
            // 
            // po2Box
            // 
            this.po2Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.po2Box.Location = new System.Drawing.Point(134, 7);
            this.po2Box.Name = "po2Box";
            this.po2Box.Size = new System.Drawing.Size(144, 20);
            this.po2Box.TabIndex = 0;
            this.po2Box.TextChanged += new System.EventHandler(this.po2Box_TextChanged);
            // 
            // hexBox
            // 
            this.hexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBox.Location = new System.Drawing.Point(134, 59);
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(144, 20);
            this.hexBox.TabIndex = 3;
            this.hexBox.TextChanged += new System.EventHandler(this.hexBox_TextChanged);
            // 
            // decBox
            // 
            this.decBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decBox.Location = new System.Drawing.Point(134, 89);
            this.decBox.Name = "decBox";
            this.decBox.Size = new System.Drawing.Size(144, 20);
            this.decBox.TabIndex = 4;
            this.decBox.TextChanged += new System.EventHandler(this.decBox_TextChanged);
            // 
            // shorthandPrefBox
            // 
            this.shorthandPrefBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shorthandPrefBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.shorthandPrefBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.shorthandPrefBox.FormattingEnabled = true;
            this.shorthandPrefBox.IntegralHeight = false;
            this.shorthandPrefBox.Items.AddRange(new object[] {
            "",
            "K",
            "M",
            "G",
            "T",
            "P",
            "E"});
            this.shorthandPrefBox.Location = new System.Drawing.Point(228, 32);
            this.shorthandPrefBox.MaxDropDownItems = 7;
            this.shorthandPrefBox.MaxLength = 1;
            this.shorthandPrefBox.MinimumSize = new System.Drawing.Size(50, 0);
            this.shorthandPrefBox.Name = "shorthandPrefBox";
            this.shorthandPrefBox.Size = new System.Drawing.Size(50, 21);
            this.shorthandPrefBox.TabIndex = 2;
            this.shorthandPrefBox.SelectedIndexChanged += new System.EventHandler(this.shorthandPrefBox_SelectedIndexChanged);
            // 
            // shorthandNumBox
            // 
            this.shorthandNumBox.FormattingEnabled = true;
            this.shorthandNumBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512"});
            this.shorthandNumBox.Location = new System.Drawing.Point(134, 32);
            this.shorthandNumBox.MaxDropDownItems = 10;
            this.shorthandNumBox.MaxLength = 4;
            this.shorthandNumBox.Name = "shorthandNumBox";
            this.shorthandNumBox.Size = new System.Drawing.Size(88, 21);
            this.shorthandNumBox.TabIndex = 1;
            this.shorthandNumBox.SelectedIndexChanged += new System.EventHandler(this.shorthandNumBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.shorthandNumBox);
            this.Controls.Add(this.shorthandPrefBox);
            this.Controls.Add(this.decBox);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.po2Box);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.shorthandLabel);
            this.Controls.Add(this.po2Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PO2Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label po2Label;
        private System.Windows.Forms.Label shorthandLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.TextBox po2Box;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.TextBox decBox;
        private System.Windows.Forms.ComboBox shorthandPrefBox;
        private System.Windows.Forms.ComboBox shorthandNumBox;
    }
}

