﻿namespace RBtn_Msg
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
            this.gpOption2 = new System.Windows.Forms.GroupBox();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.gpOption1 = new System.Windows.Forms.GroupBox();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gpOption2.SuspendLayout();
            this.gpOption1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOption2
            // 
            this.gpOption2.Controls.Add(this.rbQuestion);
            this.gpOption2.Controls.Add(this.rbInformation);
            this.gpOption2.Controls.Add(this.rbError);
            this.gpOption2.Location = new System.Drawing.Point(125, 12);
            this.gpOption2.Name = "gpOption2";
            this.gpOption2.Size = new System.Drawing.Size(106, 110);
            this.gpOption2.TabIndex = 1;
            this.gpOption2.TabStop = false;
            this.gpOption2.Text = "Icon";
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(7, 21);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(38, 16);
            this.rbOk.TabIndex = 0;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "Ok";
            this.rbOk.UseVisualStyleBackColor = true;
            // 
            // gpOption1
            // 
            this.gpOption1.Controls.Add(this.rbYesNo);
            this.gpOption1.Controls.Add(this.rbOkCancel);
            this.gpOption1.Controls.Add(this.rbOk);
            this.gpOption1.Location = new System.Drawing.Point(13, 13);
            this.gpOption1.Name = "gpOption1";
            this.gpOption1.Size = new System.Drawing.Size(106, 110);
            this.gpOption1.TabIndex = 0;
            this.gpOption1.TabStop = false;
            this.gpOption1.Text = "Type";
            this.gpOption1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbOkCancel
            // 
            this.rbOkCancel.AutoSize = true;
            this.rbOkCancel.Location = new System.Drawing.Point(7, 44);
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.Size = new System.Drawing.Size(78, 16);
            this.rbOkCancel.TabIndex = 1;
            this.rbOkCancel.TabStop = true;
            this.rbOkCancel.Text = "OkCancel";
            this.rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(7, 67);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(61, 16);
            this.rbYesNo.TabIndex = 2;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(7, 22);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(50, 16);
            this.rbError.TabIndex = 0;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Location = new System.Drawing.Point(7, 44);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(85, 16);
            this.rbInformation.TabIndex = 1;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Location = new System.Drawing.Point(7, 67);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(73, 16);
            this.rbQuestion.TabIndex = 2;
            this.rbQuestion.TabStop = true;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(13, 130);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(218, 41);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 203);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gpOption2);
            this.Controls.Add(this.gpOption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메시지 박스 보기";
            this.gpOption2.ResumeLayout(false);
            this.gpOption2.PerformLayout();
            this.gpOption1.ResumeLayout(false);
            this.gpOption1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpOption2;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.GroupBox gpOption1;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.Button btnShow;
    }
}

