
namespace Winformassemfind
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
            this.first = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.rentp = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.rent = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.returnp = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.infop = new System.Windows.Forms.Panel();
            this.listView3 = new System.Windows.Forms.ListView();
            this.info = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.first.SuspendLayout();
            this.main.SuspendLayout();
            this.rentp.SuspendLayout();
            this.returnp.SuspendLayout();
            this.infop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.Info;
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.first.Controls.Add(this.checkBox1);
            this.first.Controls.Add(this.label3);
            this.first.Controls.Add(this.textBox2);
            this.first.Controls.Add(this.textBox1);
            this.first.Controls.Add(this.label2);
            this.first.Controls.Add(this.label1);
            this.first.Controls.Add(this.sign);
            this.first.Controls.Add(this.log);
            this.first.Location = new System.Drawing.Point(161, 98);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(486, 244);
            this.first.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show PW";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(148, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(239, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(290, 180);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(102, 43);
            this.sign.TabIndex = 1;
            this.sign.Text = "Sign in";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(94, 180);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(102, 43);
            this.log.TabIndex = 0;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.main.Controls.Add(this.rentp);
            this.main.Controls.Add(this.returnp);
            this.main.Controls.Add(this.infop);
            this.main.Controls.Add(this.pictureBox2);
            this.main.Controls.Add(this.pictureBox1);
            this.main.Controls.Add(this.button4);
            this.main.Controls.Add(this.button3);
            this.main.Controls.Add(this.button2);
            this.main.Controls.Add(this.button1);
            this.main.Location = new System.Drawing.Point(10, 5);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(778, 439);
            this.main.TabIndex = 1;
            this.main.Visible = false;
            this.main.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            // 
            // rentp
            // 
            this.rentp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentp.Controls.Add(this.button7);
            this.rentp.Controls.Add(this.listView1);
            this.rentp.Controls.Add(this.label5);
            this.rentp.Controls.Add(this.rent);
            this.rentp.Controls.Add(this.monthCalendar1);
            this.rentp.Location = new System.Drawing.Point(172, 7);
            this.rentp.Name = "rentp";
            this.rentp.Size = new System.Drawing.Size(598, 426);
            this.rentp.TabIndex = 5;
            this.rentp.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(393, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 42);
            this.button7.TabIndex = 15;
            this.button7.Text = "Look Up \r\nrental available book list";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 197);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(360, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select a book to rent.\r\n";
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(377, 322);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(124, 59);
            this.rent.TabIndex = 10;
            this.rent.Text = "rent";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 208);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // returnp
            // 
            this.returnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.returnp.Controls.Add(this.listView2);
            this.returnp.Controls.Add(this.label7);
            this.returnp.Controls.Add(this.button6);
            this.returnp.Location = new System.Drawing.Point(172, 10);
            this.returnp.Name = "returnp";
            this.returnp.Size = new System.Drawing.Size(598, 405);
            this.returnp.TabIndex = 6;
            this.returnp.Visible = false;
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(17, 17);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(552, 218);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Please choose a book to return";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(224, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 52);
            this.button6.TabIndex = 9;
            this.button6.Text = "RETURN";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // infop
            // 
            this.infop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infop.Controls.Add(this.listView3);
            this.infop.Controls.Add(this.info);
            this.infop.Controls.Add(this.button5);
            this.infop.Location = new System.Drawing.Point(176, 14);
            this.infop.Name = "infop";
            this.infop.Size = new System.Drawing.Size(598, 405);
            this.infop.TabIndex = 6;
            this.infop.Visible = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(14, 13);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(552, 194);
            this.listView3.TabIndex = 12;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // info
            // 
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.Location = new System.Drawing.Point(14, 217);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(290, 169);
            this.info.TabIndex = 11;
            this.info.Text = "info";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 55);
            this.button5.TabIndex = 10;
            this.button5.Text = "Membership Withdrawal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "MY INFO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "RETURN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "RENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 376);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 80);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "LIBRARY";
            this.first.ResumeLayout(false);
            this.first.PerformLayout();
            this.main.ResumeLayout(false);
            this.rentp.ResumeLayout(false);
            this.rentp.PerformLayout();
            this.returnp.ResumeLayout(false);
            this.returnp.PerformLayout();
            this.infop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel first;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel rentp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel returnp;
        private System.Windows.Forms.Panel infop;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

