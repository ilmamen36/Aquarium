namespace Aquarium2
{
    partial class Aqua
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aqua));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьАквариумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРыбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рыбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.улиткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светВклвыклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регулировкаТемпературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сюрпризToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeForGrowing = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.сюрпризToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьАквариумToolStripMenuItem,
            this.добавитьРыбуToolStripMenuItem,
            this.светВклвыклToolStripMenuItem,
            this.регулировкаТемпературыToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // включитьАквариумToolStripMenuItem
            // 
            this.включитьАквариумToolStripMenuItem.Name = "включитьАквариумToolStripMenuItem";
            this.включитьАквариумToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.включитьАквариумToolStripMenuItem.Text = "Включить аквариум";
            this.включитьАквариумToolStripMenuItem.Click += new System.EventHandler(this.включитьАквариумToolStripMenuItem_Click);
            // 
            // добавитьРыбуToolStripMenuItem
            // 
            this.добавитьРыбуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рыбуToolStripMenuItem,
            this.улиткуToolStripMenuItem});
            this.добавитьРыбуToolStripMenuItem.Enabled = false;
            this.добавитьРыбуToolStripMenuItem.Name = "добавитьРыбуToolStripMenuItem";
            this.добавитьРыбуToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.добавитьРыбуToolStripMenuItem.Text = "Добавить";
            // 
            // рыбуToolStripMenuItem
            // 
            this.рыбуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рыбуToolStripMenuItem.Image")));
            this.рыбуToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.рыбуToolStripMenuItem.Name = "рыбуToolStripMenuItem";
            this.рыбуToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.рыбуToolStripMenuItem.Text = "Рыбу";
            this.рыбуToolStripMenuItem.Click += new System.EventHandler(this.рыбуToolStripMenuItem_Click);
            // 
            // улиткуToolStripMenuItem
            // 
            this.улиткуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("улиткуToolStripMenuItem.Image")));
            this.улиткуToolStripMenuItem.Name = "улиткуToolStripMenuItem";
            this.улиткуToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.улиткуToolStripMenuItem.Text = "Улитку";
            this.улиткуToolStripMenuItem.Click += new System.EventHandler(this.улиткуToolStripMenuItem_Click);
            // 
            // светВклвыклToolStripMenuItem
            // 
            this.светВклвыклToolStripMenuItem.Name = "светВклвыклToolStripMenuItem";
            this.светВклвыклToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.светВклвыклToolStripMenuItem.Text = "Свет вкл/выкл";
            this.светВклвыклToolStripMenuItem.Click += new System.EventHandler(this.светВклвыклToolStripMenuItem_Click);
            // 
            // регулировкаТемпературыToolStripMenuItem
            // 
            this.регулировкаТемпературыToolStripMenuItem.Enabled = false;
            this.регулировкаТемпературыToolStripMenuItem.Name = "регулировкаТемпературыToolStripMenuItem";
            this.регулировкаТемпературыToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.регулировкаТемпературыToolStripMenuItem.Text = "Регулировка температуры";
            this.регулировкаТемпературыToolStripMenuItem.Click += new System.EventHandler(this.регулировкаТемпературыToolStripMenuItem_Click);
            // 
            // сюрпризToolStripMenuItem
            // 
            this.сюрпризToolStripMenuItem.Enabled = false;
            this.сюрпризToolStripMenuItem.Name = "сюрпризToolStripMenuItem";
            this.сюрпризToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.сюрпризToolStripMenuItem.Text = "Сюрприз";
            this.сюрпризToolStripMenuItem.Click += new System.EventHandler(this.сюрпризToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Температура : 20 °C";
            // 
            // timeForGrowing
            // 
            this.timeForGrowing.Interval = 5000;
            this.timeForGrowing.Tick += new System.EventHandler(this.timeForGrowing_Tick);
            // 
            // Aqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Aqua";
            this.Text = "Аквариум";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРыбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рыбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem улиткуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьАквариумToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem светВклвыклToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регулировкаТемпературыToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem сюрпризToolStripMenuItem;
        private System.Windows.Forms.Timer timeForGrowing;
    }
}

