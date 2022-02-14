
namespace ModeConnecte203
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(785, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 30);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(80, 101);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 404);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(785, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(411, 101);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 404);
            this.listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(13, 101);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(59, 404);
            this.listBox3.TabIndex = 6;
            this.listBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 542);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

