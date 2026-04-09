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
            this.option = new System.Windows.Forms.GroupBox();
            this.order = new System.Windows.Forms.GroupBox();
            this.order_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.hamburger = new System.Windows.Forms.RadioButton();
            this.bulgogi = new System.Windows.Forms.RadioButton();
            this.chicken = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.ListBox();
            this.total = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.coke = new System.Windows.Forms.CheckBox();
            this.cheese = new System.Windows.Forms.CheckBox();
            this.source = new System.Windows.Forms.CheckBox();
            this.burger_photo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.option.SuspendLayout();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burger_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.Color.Blue;
            this.Title.Location = new System.Drawing.Point(21, 29);
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
            this.Menu.Controls.Add(this.chicken);
            this.Menu.Controls.Add(this.bulgogi);
            this.Menu.Controls.Add(this.hamburger);
            this.Menu.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu.ForeColor = System.Drawing.Color.Red;
            this.Menu.Location = new System.Drawing.Point(12, 98);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(201, 290);
            this.Menu.TabIndex = 1;
            this.Menu.TabStop = false;
            this.Menu.Text = "메뉴 선택";
            // 
            // option
            // 
            this.option.Controls.Add(this.source);
            this.option.Controls.Add(this.cheese);
            this.option.Controls.Add(this.coke);
            this.option.Controls.Add(this.checkBox1);
            this.option.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.option.ForeColor = System.Drawing.Color.Red;
            this.option.Location = new System.Drawing.Point(230, 98);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(149, 210);
            this.option.TabIndex = 1;
            this.option.TabStop = false;
            this.option.Text = "추가 옵션";
            // 
            // order
            // 
            this.order.Controls.Add(this.total);
            this.order.Controls.Add(this.list);
            this.order.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order.ForeColor = System.Drawing.Color.Red;
            this.order.Location = new System.Drawing.Point(396, 98);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(245, 220);
            this.order.TabIndex = 1;
            this.order.TabStop = false;
            this.order.Text = "주문 내역";
            // 
            // order_button
            // 
            this.order_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.order_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_button.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_button.ForeColor = System.Drawing.Color.White;
            this.order_button.Location = new System.Drawing.Point(349, 341);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(145, 47);
            this.order_button.TabIndex = 2;
            this.order_button.Text = "주문하기";
            this.order_button.UseVisualStyleBackColor = false;
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
            // 
            // hamburger
            // 
            this.hamburger.AutoSize = true;
            this.hamburger.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hamburger.ForeColor = System.Drawing.Color.Black;
            this.hamburger.Location = new System.Drawing.Point(6, 53);
            this.hamburger.Name = "hamburger";
            this.hamburger.Size = new System.Drawing.Size(72, 24);
            this.hamburger.TabIndex = 0;
            this.hamburger.TabStop = true;
            this.hamburger.Text = "햄버거";
            this.hamburger.UseVisualStyleBackColor = true;
            // 
            // bulgogi
            // 
            this.bulgogi.AutoSize = true;
            this.bulgogi.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bulgogi.ForeColor = System.Drawing.Color.Black;
            this.bulgogi.Location = new System.Drawing.Point(6, 142);
            this.bulgogi.Name = "bulgogi";
            this.bulgogi.Size = new System.Drawing.Size(102, 24);
            this.bulgogi.TabIndex = 0;
            this.bulgogi.TabStop = true;
            this.bulgogi.Text = "불고기버거";
            this.bulgogi.UseVisualStyleBackColor = true;
            this.bulgogi.CheckedChanged += new System.EventHandler(this.bulgogi_CheckedChanged);
            // 
            // chicken
            // 
            this.chicken.AutoSize = true;
            this.chicken.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chicken.ForeColor = System.Drawing.Color.Black;
            this.chicken.Location = new System.Drawing.Point(6, 219);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(87, 24);
            this.chicken.TabIndex = 0;
            this.chicken.TabStop = true;
            this.chicken.Text = "치킨버거";
            this.chicken.UseVisualStyleBackColor = true;
            this.chicken.CheckedChanged += new System.EventHandler(this.bulgogi_CheckedChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 21;
            this.list.Location = new System.Drawing.Point(17, 30);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(212, 151);
            this.list.TabIndex = 0;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total.Location = new System.Drawing.Point(16, 187);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(105, 21);
            this.total.TabIndex = 1;
            this.total.Text = "총 금액 : 0원";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(14, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "감자튀김";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // coke
            // 
            this.coke.AutoSize = true;
            this.coke.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.coke.ForeColor = System.Drawing.Color.Black;
            this.coke.Location = new System.Drawing.Point(14, 82);
            this.coke.Name = "coke";
            this.coke.Size = new System.Drawing.Size(58, 24);
            this.coke.TabIndex = 1;
            this.coke.Text = "콜라";
            this.coke.UseVisualStyleBackColor = true;
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cheese.ForeColor = System.Drawing.Color.Black;
            this.cheese.Location = new System.Drawing.Point(14, 119);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(93, 24);
            this.cheese.TabIndex = 1;
            this.cheese.Text = "치즈 추가";
            this.cheese.UseVisualStyleBackColor = true;
            // 
            // source
            // 
            this.source.AutoSize = true;
            this.source.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.source.ForeColor = System.Drawing.Color.Black;
            this.source.Location = new System.Drawing.Point(14, 155);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(93, 24);
            this.source.TabIndex = 1;
            this.source.Text = "소스 추가";
            this.source.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 404);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.order);
            this.Controls.Add(this.option);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.option.ResumeLayout(false);
            this.option.PerformLayout();
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burger_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.GroupBox option;
        private System.Windows.Forms.GroupBox order;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.RadioButton bulgogi;
        private System.Windows.Forms.RadioButton hamburger;
        private System.Windows.Forms.RadioButton chicken;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox source;
        private System.Windows.Forms.CheckBox cheese;
        private System.Windows.Forms.CheckBox coke;
        private System.Windows.Forms.PictureBox burger_photo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

