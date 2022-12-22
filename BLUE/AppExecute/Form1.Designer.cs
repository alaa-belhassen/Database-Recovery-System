
namespace AppExecute
{
    partial class FrmExecute
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdExecute = new System.Windows.Forms.Button();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.cmdOuvrir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dbname = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExecute
            // 
            this.cmdExecute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdExecute.ForeColor = System.Drawing.Color.BlueViolet;
            this.cmdExecute.Location = new System.Drawing.Point(373, 191);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(105, 49);
            this.cmdExecute.TabIndex = 2;
            this.cmdExecute.Text = "Execute";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdFermer.ForeColor = System.Drawing.Color.BlueViolet;
            this.cmdFermer.Location = new System.Drawing.Point(525, 191);
            this.cmdFermer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(111, 49);
            this.cmdFermer.TabIndex = 3;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(33, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(38, 136);
            this.user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(249, 30);
            this.user.TabIndex = 0;
            this.user.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            this.user.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.txtFile_ChangeUICues);
            // 
            // cmdOuvrir
            // 
            this.cmdOuvrir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdOuvrir.ForeColor = System.Drawing.Color.BlueViolet;
            this.cmdOuvrir.Location = new System.Drawing.Point(594, 66);
            this.cmdOuvrir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdOuvrir.Name = "cmdOuvrir";
            this.cmdOuvrir.Size = new System.Drawing.Size(42, 34);
            this.cmdOuvrir.TabIndex = 0;
            this.cmdOuvrir.Text = "...";
            this.cmdOuvrir.UseVisualStyleBackColor = true;
            this.cmdOuvrir.Click += new System.EventHandler(this.cmdOuvrir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(38, 206);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(249, 30);
            this.pass.TabIndex = 7;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // dir
            // 
            this.dir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dir.Location = new System.Drawing.Point(373, 66);
            this.dir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(215, 30);
            this.dir.TabIndex = 8;
            this.dir.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(373, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "BackUp Directory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hostname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // host
            // 
            this.host.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.host.Location = new System.Drawing.Point(38, 66);
            this.host.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(249, 30);
            this.host.TabIndex = 20;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(373, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Database Name to Backup";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dbname
            // 
            this.dbname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dbname.Location = new System.Drawing.Point(373, 136);
            this.dbname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(263, 30);
            this.dbname.TabIndex = 13;
            this.dbname.TextChanged += new System.EventHandler(this.dbname_TextChanged);
            // 
            // FrmExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 426);
            this.Controls.Add(this.dbname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.host);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdOuvrir);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdExecute);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmExecute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Postgres";
            this.Load += new System.EventHandler(this.FrmExecute_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExecute;
        private System.Windows.Forms.Button cmdFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button cmdOuvrir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dbname;
    }
}

