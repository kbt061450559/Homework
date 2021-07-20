
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kextuka = new System.Windows.Forms.Label();
            this.tukaikata = new System.Windows.Forms.ComboBox();
            this.cckatu = new System.Windows.Forms.ComboBox();
            this.kakutei = new System.Windows.Forms.Button();
            this.kyanseru = new System.Windows.Forms.Button();
            this.nendo = new System.Windows.Forms.RadioButton();
            this.kikan = new System.Windows.Forms.RadioButton();
            this.kikan2 = new System.Windows.Forms.DateTimePicker();
            this.kikan3 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數/馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(23, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(223, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "從";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(432, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "至";
            this.label6.Visible = false;
            // 
            // kextuka
            // 
            this.kextuka.AutoSize = true;
            this.kextuka.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kextuka.Location = new System.Drawing.Point(223, 264);
            this.kextuka.Name = "kextuka";
            this.kextuka.Size = new System.Drawing.Size(15, 19);
            this.kextuka.TabIndex = 6;
            this.kextuka.Text = "-";
            // 
            // tukaikata
            // 
            this.tukaikata.FormattingEnabled = true;
            this.tukaikata.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.tukaikata.Location = new System.Drawing.Point(227, 159);
            this.tukaikata.Name = "tukaikata";
            this.tukaikata.Size = new System.Drawing.Size(334, 20);
            this.tukaikata.TabIndex = 7;
            this.tukaikata.SelectedIndexChanged += new System.EventHandler(this.tukaikata_SelectedIndexChanged);
            // 
            // cckatu
            // 
            this.cckatu.FormattingEnabled = true;
            this.cckatu.Items.AddRange(new object[] {
            "150以下/12HP以下(12.2PS以下)",
            "151-250/12.1-20HP(12.3-20.3PS)",
            "251-500/20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.cckatu.Location = new System.Drawing.Point(227, 216);
            this.cckatu.Name = "cckatu";
            this.cckatu.Size = new System.Drawing.Size(334, 20);
            this.cckatu.TabIndex = 8;
            this.cckatu.SelectedIndexChanged += new System.EventHandler(this.cckatu_SelectedIndexChanged);
            // 
            // kakutei
            // 
            this.kakutei.Location = new System.Drawing.Point(647, 156);
            this.kakutei.Name = "kakutei";
            this.kakutei.Size = new System.Drawing.Size(75, 23);
            this.kakutei.TabIndex = 9;
            this.kakutei.Text = "確定送出";
            this.kakutei.UseVisualStyleBackColor = true;
            this.kakutei.Click += new System.EventHandler(this.kakutei_Click);
            // 
            // kyanseru
            // 
            this.kyanseru.Location = new System.Drawing.Point(647, 213);
            this.kyanseru.Name = "kyanseru";
            this.kyanseru.Size = new System.Drawing.Size(75, 23);
            this.kyanseru.TabIndex = 10;
            this.kyanseru.Text = "取消重填";
            this.kyanseru.UseVisualStyleBackColor = true;
            this.kyanseru.Click += new System.EventHandler(this.kyanseru_Click);
            // 
            // nendo
            // 
            this.nendo.AutoSize = true;
            this.nendo.Checked = true;
            this.nendo.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nendo.Location = new System.Drawing.Point(227, 78);
            this.nendo.Name = "nendo";
            this.nendo.Size = new System.Drawing.Size(84, 23);
            this.nendo.TabIndex = 11;
            this.nendo.TabStop = true;
            this.nendo.Text = "全年度";
            this.nendo.UseVisualStyleBackColor = true;
            // 
            // kikan
            // 
            this.kikan.AutoSize = true;
            this.kikan.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kikan.Location = new System.Drawing.Point(355, 78);
            this.kikan.Name = "kikan";
            this.kikan.Size = new System.Drawing.Size(84, 23);
            this.kikan.TabIndex = 12;
            this.kikan.Text = "依年間";
            this.kikan.UseVisualStyleBackColor = true;
            this.kikan.CheckedChanged += new System.EventHandler(this.kikan_CheckedChanged);
            // 
            // kikan2
            // 
            this.kikan2.Location = new System.Drawing.Point(279, 112);
            this.kikan2.Name = "kikan2";
            this.kikan2.Size = new System.Drawing.Size(123, 22);
            this.kikan2.TabIndex = 13;
            this.kikan2.Visible = false;
            // 
            // kikan3
            // 
            this.kikan3.Location = new System.Drawing.Point(487, 112);
            this.kikan3.Name = "kikan3";
            this.kikan3.Size = new System.Drawing.Size(138, 22);
            this.kikan3.TabIndex = 14;
            this.kikan3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kikan3);
            this.Controls.Add(this.kikan2);
            this.Controls.Add(this.kikan);
            this.Controls.Add(this.nendo);
            this.Controls.Add(this.kyanseru);
            this.Controls.Add(this.kakutei);
            this.Controls.Add(this.cckatu);
            this.Controls.Add(this.tukaikata);
            this.Controls.Add(this.kextuka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "用途";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label kextuka;
        private System.Windows.Forms.ComboBox tukaikata;
        private System.Windows.Forms.ComboBox cckatu;
        private System.Windows.Forms.Button kakutei;
        private System.Windows.Forms.Button kyanseru;
        private System.Windows.Forms.RadioButton nendo;
        private System.Windows.Forms.RadioButton kikan;
        private System.Windows.Forms.DateTimePicker kikan2;
        private System.Windows.Forms.DateTimePicker kikan3;
    }
}

