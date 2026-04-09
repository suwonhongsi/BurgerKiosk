namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.burger_photo = new System.Windows.Forms.PictureBox();
            this.rdoChickenBurger = new System.Windows.Forms.RadioButton();
            this.rdoBulgogiBurger = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.option = new System.Windows.Forms.GroupBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkCoke = new System.Windows.Forms.CheckBox();
            this.chkFried = new System.Windows.Forms.CheckBox();
            this.order = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger_photo)).BeginInit();
            this.option.SuspendLayout();
            this.order.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.Color.Blue;
            this.Title.Location = new System.Drawing.Point(21, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(324, 47);
            this.Title.TabIndex = 0;
            this.Title.Text = "버거 주문 키오스크";
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.pictureBox2);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.burger_photo);
            this.Menu.Controls.Add(this.rdoChickenBurger);
            this.Menu.Controls.Add(this.rdoBulgogiBurger);
            this.Menu.Controls.Add(this.rdoHamburger);
            this.Menu.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu.ForeColor = System.Drawing.Color.Red;
            this.Menu.Location = new System.Drawing.Point(12, 98);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(201, 290);
            this.Menu.TabIndex = 1;
            this.Menu.TabStop = false;
            this.Menu.Text = "메뉴 선택";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // burger_photo
            // 
            this.burger_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.burger_photo.Image = ((System.Drawing.Image)(resources.GetObject("burger_photo.Image")));
            this.burger_photo.Location = new System.Drawing.Point(104, 28);
            this.burger_photo.Name = "burger_photo";
            this.burger_photo.Size = new System.Drawing.Size(89, 78);
            this.burger_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burger_photo.TabIndex = 1;
            this.burger_photo.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            this.rdoChickenBurger.AutoSize = true;
            this.rdoChickenBurger.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoChickenBurger.ForeColor = System.Drawing.Color.Black;
            this.rdoChickenBurger.Location = new System.Drawing.Point(6, 219);
            this.rdoChickenBurger.Name = "rdoChickenBurger";
            this.rdoChickenBurger.Size = new System.Drawing.Size(87, 24);
            this.rdoChickenBurger.TabIndex = 0;
            this.rdoChickenBurger.TabStop = true;
            this.rdoChickenBurger.Text = "치킨버거";
            this.rdoChickenBurger.UseVisualStyleBackColor = true;
            this.rdoChickenBurger.CheckedChanged += new System.EventHandler(this.bulgogi_CheckedChanged);
            // 
            // rdoBulgogiBurger
            // 
            this.rdoBulgogiBurger.AutoSize = true;
            this.rdoBulgogiBurger.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoBulgogiBurger.ForeColor = System.Drawing.Color.Black;
            this.rdoBulgogiBurger.Location = new System.Drawing.Point(6, 142);
            this.rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            this.rdoBulgogiBurger.Size = new System.Drawing.Size(102, 24);
            this.rdoBulgogiBurger.TabIndex = 0;
            this.rdoBulgogiBurger.TabStop = true;
            this.rdoBulgogiBurger.Text = "불고기버거";
            this.rdoBulgogiBurger.UseVisualStyleBackColor = true;
            this.rdoBulgogiBurger.CheckedChanged += new System.EventHandler(this.bulgogi_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoHamburger.ForeColor = System.Drawing.Color.Black;
            this.rdoHamburger.Location = new System.Drawing.Point(6, 53);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(72, 24);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "햄버거";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.hamburger_CheckedChanged);
            // 
            // option
            // 
            this.option.Controls.Add(this.chkSauce);
            this.option.Controls.Add(this.chkCheese);
            this.option.Controls.Add(this.chkCoke);
            this.option.Controls.Add(this.chkFried);
            this.option.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.option.ForeColor = System.Drawing.Color.Red;
            this.option.Location = new System.Drawing.Point(230, 98);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(149, 210);
            this.option.TabIndex = 1;
            this.option.TabStop = false;
            this.option.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            this.chkSauce.AutoSize = true;
            this.chkSauce.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkSauce.ForeColor = System.Drawing.Color.Black;
            this.chkSauce.Location = new System.Drawing.Point(14, 155);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(93, 24);
            this.chkSauce.TabIndex = 1;
            this.chkSauce.Text = "소스 추가";
            this.chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkCheese.ForeColor = System.Drawing.Color.Black;
            this.chkCheese.Location = new System.Drawing.Point(14, 119);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(93, 24);
            this.chkCheese.TabIndex = 1;
            this.chkCheese.Text = "치즈 추가";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCoke
            // 
            this.chkCoke.AutoSize = true;
            this.chkCoke.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkCoke.ForeColor = System.Drawing.Color.Black;
            this.chkCoke.Location = new System.Drawing.Point(14, 82);
            this.chkCoke.Name = "chkCoke";
            this.chkCoke.Size = new System.Drawing.Size(58, 24);
            this.chkCoke.TabIndex = 1;
            this.chkCoke.Text = "콜라";
            this.chkCoke.UseVisualStyleBackColor = true;
            // 
            // chkFried
            // 
            this.chkFried.AutoSize = true;
            this.chkFried.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkFried.ForeColor = System.Drawing.Color.Black;
            this.chkFried.Location = new System.Drawing.Point(14, 43);
            this.chkFried.Name = "chkFried";
            this.chkFried.Size = new System.Drawing.Size(88, 24);
            this.chkFried.TabIndex = 1;
            this.chkFried.Text = "감자튀김";
            this.chkFried.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Controls.Add(this.lblTotalCost);
            this.order.Controls.Add(this.lstOrder);
            this.order.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order.ForeColor = System.Drawing.Color.Red;
            this.order.Location = new System.Drawing.Point(396, 98);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(245, 220);
            this.order.TabIndex = 1;
            this.order.TabStop = false;
            this.order.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalCost.Location = new System.Drawing.Point(16, 187);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(105, 21);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 21;
            this.lstOrder.Location = new System.Drawing.Point(17, 30);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(212, 151);
            this.lstOrder.TabIndex = 0;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Location = new System.Drawing.Point(349, 341);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(145, 47);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "주문하기";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Red;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(500, 341);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(145, 47);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "초기화";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 404);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.order);
            this.Controls.Add(this.option);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burger_photo)).EndInit();
            this.option.ResumeLayout(false);
            this.option.PerformLayout();
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.GroupBox option;
        private System.Windows.Forms.GroupBox order;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.RadioButton rdoBulgogiBurger;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.RadioButton rdoChickenBurger;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.CheckBox chkFried;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkCoke;
        private System.Windows.Forms.PictureBox burger_photo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

