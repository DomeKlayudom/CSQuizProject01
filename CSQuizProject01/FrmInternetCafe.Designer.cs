namespace CSQuizProject01
{
    partial class FrmInternetCafe
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbIdCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.rbGuest = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbPayCheck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.Label();
            this.lbUserService = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbIdCardNumber = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรม Internet Cafe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbIdCardNumber);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Controls.Add(this.rbGuest);
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.Controls.Add(this.rbMember);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mcDate);
            this.groupBox1.Location = new System.Drawing.Point(11, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(470, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // mtbIdCardNumber
            // 
            this.mtbIdCardNumber.Location = new System.Drawing.Point(373, 27);
            this.mtbIdCardNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbIdCardNumber.Mask = "0.0000.00000.00.0";
            this.mtbIdCardNumber.Name = "mtbIdCardNumber";
            this.mtbIdCardNumber.Size = new System.Drawing.Size(83, 20);
            this.mtbIdCardNumber.TabIndex = 9;
            this.mtbIdCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(302, 57);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(137, 20);
            this.tbFullName.TabIndex = 8;
            this.tbFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFullName_KeyPress);
            // 
            // rbGuest
            // 
            this.rbGuest.AutoSize = true;
            this.rbGuest.Location = new System.Drawing.Point(258, 187);
            this.rbGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbGuest.Name = "rbGuest";
            this.rbGuest.Size = new System.Drawing.Size(131, 17);
            this.rbGuest.TabIndex = 7;
            this.rbGuest.TabStop = true;
            this.rbGuest.Text = "บุคคลทั่วไปไม่มีส่วนลด";
            this.rbGuest.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(258, 153);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(139, 17);
            this.rbStudent.TabIndex = 6;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "นักเรียนนักศึกษาลด 5%";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Location = new System.Drawing.Point(258, 120);
            this.rbMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(93, 17);
            this.rbMember.TabIndex = 5;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "สมาชิคลด 10%";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ชื่อ-สกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "รหัสประจำตัวประชาชน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "วันที่ใช้บริการ";
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(22, 42);
            this.mcDate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHour);
            this.groupBox2.Controls.Add(this.cbbService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(269, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลการใช้บริการ";
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(115, 50);
            this.tbHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(84, 20);
            this.tbHour.TabIndex = 10;
            // 
            // cbbService
            // 
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกมส์ Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกมส์ Online  ชั่วโมงละ 25.50 บาท"});
            this.cbbService.Location = new System.Drawing.Point(115, 19);
            this.cbbService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(131, 21);
            this.cbbService.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ชั่วโมง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "จำนวนการใช้บริการ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ประเภทการบริการ";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(284, 335);
            this.btReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(160, 19);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "เริ่มใหม่";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btCal
            // 
            this.btCal.Location = new System.Drawing.Point(384, 360);
            this.btCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(60, 19);
            this.btCal.TabIndex = 4;
            this.btCal.Text = "คำนวณ";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(284, 383);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(160, 19);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "จบโปรแกรม";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbPayCheck
            // 
            this.cbPayCheck.AutoSize = true;
            this.cbPayCheck.Location = new System.Drawing.Point(284, 362);
            this.cbPayCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPayCheck.Name = "cbPayCheck";
            this.cbPayCheck.Size = new System.Drawing.Size(97, 17);
            this.cbPayCheck.TabIndex = 7;
            this.cbPayCheck.Text = "ยืนยันชำระเงิน";
            this.cbPayCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbHour);
            this.groupBox3.Controls.Add(this.lbService);
            this.groupBox3.Controls.Add(this.lbUserService);
            this.groupBox3.Controls.Add(this.lbFullName);
            this.groupBox3.Controls.Add(this.lbIdCardNumber);
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Controls.Add(this.lbResult);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(485, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(264, 313);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lbHour
            // 
            this.lbHour.BackColor = System.Drawing.Color.Aqua;
            this.lbHour.Location = new System.Drawing.Point(129, 197);
            this.lbHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(117, 13);
            this.lbHour.TabIndex = 20;
            this.lbHour.Text = "-";
            // 
            // lbService
            // 
            this.lbService.BackColor = System.Drawing.Color.Aqua;
            this.lbService.Location = new System.Drawing.Point(129, 169);
            this.lbService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(117, 13);
            this.lbService.TabIndex = 19;
            this.lbService.Text = "-";
            // 
            // lbUserService
            // 
            this.lbUserService.BackColor = System.Drawing.Color.Aqua;
            this.lbUserService.Location = new System.Drawing.Point(129, 141);
            this.lbUserService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserService.Name = "lbUserService";
            this.lbUserService.Size = new System.Drawing.Size(117, 13);
            this.lbUserService.TabIndex = 18;
            this.lbUserService.Text = "-";
            // 
            // lbFullName
            // 
            this.lbFullName.BackColor = System.Drawing.Color.Aqua;
            this.lbFullName.Location = new System.Drawing.Point(129, 113);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(117, 13);
            this.lbFullName.TabIndex = 17;
            this.lbFullName.Text = "-";
            // 
            // lbIdCardNumber
            // 
            this.lbIdCardNumber.BackColor = System.Drawing.Color.Aqua;
            this.lbIdCardNumber.Location = new System.Drawing.Point(129, 85);
            this.lbIdCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdCardNumber.Name = "lbIdCardNumber";
            this.lbIdCardNumber.Size = new System.Drawing.Size(117, 13);
            this.lbIdCardNumber.TabIndex = 16;
            this.lbIdCardNumber.Text = "-";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Aqua;
            this.lbDate.Location = new System.Drawing.Point(129, 57);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(117, 13);
            this.lbDate.TabIndex = 15;
            this.lbDate.Text = "-";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Aqua;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(29, 274);
            this.lbResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(178, 28);
            this.lbResult.TabIndex = 10;
            this.lbResult.Text = "0.00";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CSQuizProject01.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_48;
            this.pictureBox1.Location = new System.Drawing.Point(97, 223);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 199);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "จำนวนการใช้บริการ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "ประเภทการบริการ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "ชื่อ-สกุล";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "รหัสประจำตัวประชาชน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "วันที่ใช้บริการ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(34, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "ข้อมูลการชำระเงิน";
            // 
            // FrmInternetCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbPayCheck);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInternetCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรม Quiz1";
            this.Load += new System.EventHandler(this.FrmInternetCafe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.RadioButton rbGuest;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.MaskedTextBox mtbIdCardNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.CheckBox cbPayCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label lbUserService;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbIdCardNumber;
    }
}