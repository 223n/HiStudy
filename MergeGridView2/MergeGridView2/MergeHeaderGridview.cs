﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MergeGridView2
{
    public class MergeHeaderGridview : DataGridView
    {

        #region Const

        /// <summary>
        /// ヘッダの文字
        /// </summary>
        private readonly string[] HeaderTexts = { "Header1", string.Empty, "Header3", string.Empty, "Header5" };

        #endregion

        #region Property

        /// <summary>
        /// 行ヘッダ用の開始日付
        /// </summary>
        public DateTime StartDate { get; set; }

        #endregion

        #region Initialize

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MergeHeaderGridview()
        {
            InitializeProperty();
            InitializeEventHandler();
        }

        /// <summary>
        /// プロパティを初期化
        /// </summary>
        private void InitializeProperty()
        {
            StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            ColumnHeadersHeight = ColumnHeadersHeight * 2;
        }

        /// <summary>
        /// イベントの紐付けを初期化
        /// </summary>
        private void InitializeEventHandler()
        {
            CellPainting += MergeHeaderGridview_CellPainting;
            Paint += MergeHeaderGridview_Paint;
            Scroll += MergeHeaderGridview_Scroll;
            ColumnWidthChanged += MergeHeaderGridview_ColumnWidthChanged;
            SizeChanged += MergeHeaderGridview_SizeChanged;
        }

        #endregion

        #region Event

        private void MergeHeaderGridview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UpdateCell(e);
        }

        private void MergeHeaderGridview_Paint(object sender, PaintEventArgs e)
        {
            UpdateHeader(e.Graphics);
        }

        private void MergeHeaderGridview_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateInvalidate();
        }

        private void MergeHeaderGridview_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            UpdateInvalidate();
        }

        private void MergeHeaderGridview_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        #endregion

        #region Method

        /// <summary>
        /// ヘッダを描画します
        /// </summary>
        private void UpdateHeader(Graphics g)
        {
            using (var backBrush = new SolidBrush(ColumnHeadersDefaultCellStyle.BackColor))
            using (var foreBrush = new SolidBrush(ColumnHeadersDefaultCellStyle.ForeColor))
                for (int j = 0; j < Columns.Count; j += 2)
                {
                    var r1 = GetCellDisplayRectangle(j, -1, true);
                    int w2 = GetCellDisplayRectangle(j + 1, -1, true).Width;
                    r1.X++;
                    r1.Y++;
                    r1.Width += w2 - 2;
                    r1.Height = r1.Height / 2 - 2;
                    g.FillRectangle(backBrush, r1);
                    var format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    g.DrawString(HeaderTexts[j / 2], ColumnHeadersDefaultCellStyle.Font, foreBrush, r1, format);
                }
        }

        /// <summary>
        /// セルを描画します
        /// </summary>
        private void UpdateCell(DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && 0 <= e.ColumnIndex)
            {
                SuspendLayout();
                var r2 = e.CellBounds;
                r2.Y += r2.Height / 2;
                r2.Height = r2.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
                ResumeLayout();
            }
            if (e.ColumnIndex < 0 && 0 <= e.RowIndex)
            {
                var d = StartDate.AddDays(e.RowIndex);
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                var r1 = e.CellBounds;
                var rH = e.CellStyle.Padding.Top;
                var rL = e.CellStyle.Padding.Left;
                r1.Inflate(rL, rH);
                var fc = e.CellStyle.ForeColor;
                switch (d.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        fc = Color.Red;
                        break;
                    case DayOfWeek.Saturday:
                        fc = Color.Blue;
                        break;
                }
                TextRenderer.DrawText(
                    e.Graphics,
                    string.Format("{0:dd}日({0:ddd})", d),
                    e.CellStyle.Font,
                    r1,
                    fc,
                    e.CellStyle.BackColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                e.Handled = true;
            }
        }

        /// <summary>
        /// 再描画を促す
        /// </summary>
        private void UpdateInvalidate()
        {
            var header = DisplayRectangle;
            header.Height = ColumnHeadersHeight / 2;
            Invalidate(header);
        }

        #endregion

    }
}
