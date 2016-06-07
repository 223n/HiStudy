namespace Sample
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainGrid = new MergeGridView2.MergeHeaderGridview();
            this.Win1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeaderGroups = ((System.Collections.Generic.List<string>)(resources.GetObject("mainGrid.ColumnHeaderGroups")));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGrid.ColumnHeadersHeight = 46;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Win1,
            this.Loss1,
            this.Win2,
            this.Loss2,
            this.Win3,
            this.Loss3,
            this.Win4,
            this.Loss4,
            this.Win5,
            this.Loss5});
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 0);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 21;
            this.mainGrid.Size = new System.Drawing.Size(400, 343);
            this.mainGrid.TabIndex = 0;
            // 
            // Win1
            // 
            this.Win1.HeaderText = "Win";
            this.Win1.Name = "Win1";
            // 
            // Loss1
            // 
            this.Loss1.HeaderText = "Los";
            this.Loss1.Name = "Loss1";
            // 
            // Win2
            // 
            this.Win2.HeaderText = "Win";
            this.Win2.Name = "Win2";
            // 
            // Loss2
            // 
            this.Loss2.HeaderText = "Loss";
            this.Loss2.Name = "Loss2";
            // 
            // Win3
            // 
            this.Win3.HeaderText = "Win";
            this.Win3.Name = "Win3";
            // 
            // Loss3
            // 
            this.Loss3.HeaderText = "Loss";
            this.Loss3.Name = "Loss3";
            // 
            // Win4
            // 
            this.Win4.HeaderText = "Win";
            this.Win4.Name = "Win4";
            // 
            // Loss4
            // 
            this.Loss4.HeaderText = "Loss";
            this.Loss4.Name = "Loss4";
            // 
            // Win5
            // 
            this.Win5.HeaderText = "Win";
            this.Win5.Name = "Win5";
            // 
            // Loss5
            // 
            this.Loss5.HeaderText = "Loss";
            this.Loss5.Name = "Loss5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 343);
            this.Controls.Add(this.mainGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MergeGridView2.MergeHeaderGridview mainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss5;
    }
}

