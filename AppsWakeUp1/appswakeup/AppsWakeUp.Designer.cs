namespace appswakeup
{
    partial class AppsWakeUp
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWake = new System.Windows.Forms.Button();
            this.cmbAppList = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbSerch = new System.Windows.Forms.TextBox();
            this.btnSerchStart = new System.Windows.Forms.Button();
            this.tbfile = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnWake
            // 
            this.btnWake.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWake.Location = new System.Drawing.Point(600, 1);
            this.btnWake.Name = "btnWake";
            this.btnWake.Size = new System.Drawing.Size(78, 41);
            this.btnWake.TabIndex = 1;
            this.btnWake.TabStop = false;
            this.btnWake.Text = "起動";
            this.btnWake.UseVisualStyleBackColor = true;
            this.btnWake.Click += new System.EventHandler(this.btnWake_Click);
            // 
            // cmbAppList
            // 
            this.cmbAppList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppList.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbAppList.FormattingEnabled = true;
            this.cmbAppList.Location = new System.Drawing.Point(22, 1);
            this.cmbAppList.Name = "cmbAppList";
            this.cmbAppList.Size = new System.Drawing.Size(572, 39);
            this.cmbAppList.TabIndex = 2;
            this.cmbAppList.TabStop = false;
            this.cmbAppList.SelectedIndexChanged += new System.EventHandler(this.cmbAppList_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(684, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "終了";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbSerch
            // 
            this.tbSerch.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSerch.Location = new System.Drawing.Point(22, 90);
            this.tbSerch.Name = "tbSerch";
            this.tbSerch.Size = new System.Drawing.Size(762, 39);
            this.tbSerch.TabIndex = 4;
            this.tbSerch.Text = "C:\\直下のディレクトリ名";
            this.tbSerch.TextChanged += new System.EventHandler(this.tbSerch_TextChanged);
            // 
            // btnSerchStart
            // 
            this.btnSerchStart.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSerchStart.Location = new System.Drawing.Point(605, 45);
            this.btnSerchStart.Name = "btnSerchStart";
            this.btnSerchStart.Size = new System.Drawing.Size(179, 39);
            this.btnSerchStart.TabIndex = 6;
            this.btnSerchStart.TabStop = false;
            this.btnSerchStart.Text = "検索開始";
            this.btnSerchStart.UseVisualStyleBackColor = true;
            this.btnSerchStart.Click += new System.EventHandler(this.btnSerchStart_Click);
            // 
            // tbfile
            // 
            this.tbfile.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbfile.Location = new System.Drawing.Point(22, 135);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(762, 39);
            this.tbfile.TabIndex = 8;
            this.tbfile.Text = "拡張子名（不明可）";
            this.tbfile.TextChanged += new System.EventHandler(this.tbfile_TextChanged);
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClick.Location = new System.Drawing.Point(22, 46);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(572, 38);
            this.btnClick.TabIndex = 9;
            this.btnClick.TabStop = false;
            this.btnClick.Text = "ディレクトリ不明：クリック";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // cmbResult
            // 
            this.cmbResult.Font = new System.Drawing.Font("メイリオ", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Location = new System.Drawing.Point(22, 180);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(762, 39);
            this.cmbResult.TabIndex = 10;
            this.cmbResult.TabStop = false;
            this.cmbResult.SelectedIndexChanged += new System.EventHandler(this.cmbResult_SelectedIndexChanged);
            // 
            // AppsWakeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(796, 235);
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.tbfile);
            this.Controls.Add(this.btnSerchStart);
            this.Controls.Add(this.tbSerch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbAppList);
            this.Controls.Add(this.btnWake);
            this.Name = "AppsWakeUp";
            this.Text = "アプリ起動";
            this.Load += new System.EventHandler(this.AppsWakeUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.ComboBox cmbAppList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSerch;
        private System.Windows.Forms.Button btnSerchStart;
        private System.Windows.Forms.TextBox tbfile;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ComboBox cmbResult;
    }
}

