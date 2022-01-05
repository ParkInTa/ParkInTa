
namespace rhkwp0909
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.line2defectve1 = new Sunny.UI.UIAnalogMeter();
            this.line2finished1 = new Sunny.UI.UIAnalogMeter();
            this.uiLine1 = new Sunny.UI.UILine();
            this.line1defectve1 = new Sunny.UI.UISymbolLabel();
            this.line1finished1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.line1Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finished1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defectve1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nufinished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudefectve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel8.Location = new System.Drawing.Point(656, 49);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(232, 40);
            this.uiSymbolLabel8.Symbol = 57579;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolLabel8.SymbolSize = 40;
            this.uiSymbolLabel8.TabIndex = 29;
            this.uiSymbolLabel8.Text = "불량품";
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel7.Location = new System.Drawing.Point(449, 49);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(232, 40);
            this.uiSymbolLabel7.Symbol = 57606;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.Red;
            this.uiSymbolLabel7.SymbolSize = 40;
            this.uiSymbolLabel7.TabIndex = 28;
            this.uiSymbolLabel7.Text = "완성품";
            // 
            // line2defectve1
            // 
            this.line2defectve1.BackColor = System.Drawing.Color.White;
            this.line2defectve1.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2defectve1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.line2defectve1.Location = new System.Drawing.Point(720, 107);
            this.line2defectve1.MaxValue = 100D;
            this.line2defectve1.MinimumSize = new System.Drawing.Size(1, 1);
            this.line2defectve1.MinValue = 0D;
            this.line2defectve1.Name = "line2defectve1";
            this.line2defectve1.NeedleColor = System.Drawing.Color.DeepSkyBlue;
            this.line2defectve1.Renderer = null;
            this.line2defectve1.Size = new System.Drawing.Size(168, 159);
            this.line2defectve1.Style = Sunny.UI.UIStyle.Custom;
            this.line2defectve1.TabIndex = 25;
            this.line2defectve1.Text = "uiAnalogMeter2";
            this.line2defectve1.Value = 57D;
            // 
            // line2finished1
            // 
            this.line2finished1.BackColor = System.Drawing.Color.White;
            this.line2finished1.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.line2finished1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.line2finished1.Location = new System.Drawing.Point(505, 119);
            this.line2finished1.MaxValue = 100D;
            this.line2finished1.MinimumSize = new System.Drawing.Size(1, 1);
            this.line2finished1.MinValue = 0D;
            this.line2finished1.Name = "line2finished1";
            this.line2finished1.NeedleColor = System.Drawing.Color.Red;
            this.line2finished1.Renderer = null;
            this.line2finished1.Size = new System.Drawing.Size(176, 159);
            this.line2finished1.Style = Sunny.UI.UIStyle.Custom;
            this.line2finished1.TabIndex = 24;
            this.line2finished1.Text = "uiAnalogMeter1";
            this.line2finished1.Value = 57D;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Red;
            this.uiLine1.Location = new System.Drawing.Point(43, 70);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(294, 2);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 23;
            // 
            // line1defectve1
            // 
            this.line1defectve1.BackColor = System.Drawing.Color.Transparent;
            this.line1defectve1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1defectve1.Location = new System.Drawing.Point(43, 318);
            this.line1defectve1.MinimumSize = new System.Drawing.Size(1, 1);
            this.line1defectve1.Name = "line1defectve1";
            this.line1defectve1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.line1defectve1.Size = new System.Drawing.Size(230, 60);
            this.line1defectve1.Symbol = 57579;
            this.line1defectve1.SymbolColor = System.Drawing.Color.RoyalBlue;
            this.line1defectve1.SymbolSize = 40;
            this.line1defectve1.TabIndex = 21;
            this.line1defectve1.Text = "0 ";
            this.line1defectve1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line1finished1
            // 
            this.line1finished1.BackColor = System.Drawing.Color.Transparent;
            this.line1finished1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1finished1.Location = new System.Drawing.Point(43, 166);
            this.line1finished1.MinimumSize = new System.Drawing.Size(1, 1);
            this.line1finished1.Name = "line1finished1";
            this.line1finished1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.line1finished1.Size = new System.Drawing.Size(230, 60);
            this.line1finished1.Symbol = 57606;
            this.line1finished1.SymbolColor = System.Drawing.Color.Red;
            this.line1finished1.SymbolSize = 40;
            this.line1finished1.TabIndex = 20;
            this.line1finished1.Text = "0 ";
            this.line1finished1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(43, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(54, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(294, 60);
            this.uiSymbolLabel1.Symbol = 61573;
            this.uiSymbolLabel1.SymbolSize = 50;
            this.uiSymbolLabel1.TabIndex = 19;
            this.uiSymbolLabel1.Text = "제조 라인 정보";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.line1Time,
            this.finished1,
            this.defectve1,
            this.nufinished,
            this.nudefectve});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(318, 317);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 199);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // line1Time
            // 
            this.line1Time.Text = "작업 시간";
            this.line1Time.Width = 136;
            // 
            // finished1
            // 
            this.finished1.Text = "완성품";
            this.finished1.Width = 61;
            // 
            // defectve1
            // 
            this.defectve1.Text = "불량품";
            this.defectve1.Width = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "누적 불량품";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 39);
            this.label2.TabIndex = 32;
            this.label2.Text = "누적 완성품";
            // 
            // nufinished
            // 
            this.nufinished.Text = "누적 완성품";
            this.nufinished.Width = 138;
            // 
            // nudefectve
            // 
            this.nudefectve.Text = "누적 불량품";
            this.nudefectve.Width = 158;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.line2defectve1);
            this.Controls.Add(this.line2finished1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.line1defectve1);
            this.Controls.Add(this.line1finished1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UIAnalogMeter line2defectve1;
        private Sunny.UI.UIAnalogMeter line2finished1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolLabel line1defectve1;
        private Sunny.UI.UISymbolLabel line1finished1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader finished1;
        private System.Windows.Forms.ColumnHeader defectve1;
        private System.Windows.Forms.ColumnHeader line1Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader nufinished;
        private System.Windows.Forms.ColumnHeader nudefectve;
    }
}

