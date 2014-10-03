namespace FluentMigrator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Run = new System.Windows.Forms.Button();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.Label();
            this.DatabaseBox = new System.Windows.Forms.TextBox();
            this.StoretypeBox = new System.Windows.Forms.ComboBox();
            this.Storetype = new System.Windows.Forms.Label();
            this.Environment = new System.Windows.Forms.Label();
            this.EnvironmentBox = new System.Windows.Forms.ComboBox();
            this.Databasetype = new System.Windows.Forms.Label();
            this.DatabasetypeBox = new System.Windows.Forms.ComboBox();
            this.Validation = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rollback = new System.Windows.Forms.RadioButton();
            this.migrate = new System.Windows.Forms.RadioButton();
            this.Browse = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.Label();
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(375, 87);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // ServerBox
            // 
            this.ServerBox.Location = new System.Drawing.Point(9, 75);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(160, 20);
            this.ServerBox.TabIndex = 1;
            this.ServerBox.TextChanged += new System.EventHandler(this.ServerBox_TextChanged);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.BackColor = System.Drawing.Color.Transparent;
            this.Server.Location = new System.Drawing.Point(6, 59);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(41, 13);
            this.Server.TabIndex = 2;
            this.Server.Text = "Server:";
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.BackColor = System.Drawing.Color.Transparent;
            this.Database.Location = new System.Drawing.Point(6, 108);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(56, 13);
            this.Database.TabIndex = 3;
            this.Database.Text = "Database:";
            this.Database.Click += new System.EventHandler(this.Database_Click);
            // 
            // DatabaseBox
            // 
            this.DatabaseBox.Location = new System.Drawing.Point(9, 124);
            this.DatabaseBox.Name = "DatabaseBox";
            this.DatabaseBox.Size = new System.Drawing.Size(160, 20);
            this.DatabaseBox.TabIndex = 4;
            this.DatabaseBox.TextChanged += new System.EventHandler(this.DatabaseBox_TextChanged);
            // 
            // StoretypeBox
            // 
            this.StoretypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoretypeBox.FormattingEnabled = true;
            this.StoretypeBox.Location = new System.Drawing.Point(194, 25);
            this.StoretypeBox.Name = "StoretypeBox";
            this.StoretypeBox.Size = new System.Drawing.Size(157, 21);
            this.StoretypeBox.TabIndex = 6;
            this.StoretypeBox.SelectedIndexChanged += new System.EventHandler(this.StoretypeBox_SelectedIndexChanged);
            // 
            // Storetype
            // 
            this.Storetype.AutoSize = true;
            this.Storetype.BackColor = System.Drawing.Color.Transparent;
            this.Storetype.Location = new System.Drawing.Point(191, 9);
            this.Storetype.Name = "Storetype";
            this.Storetype.Size = new System.Drawing.Size(62, 13);
            this.Storetype.TabIndex = 7;
            this.Storetype.Text = "Store Type:";
            // 
            // Environment
            // 
            this.Environment.AutoSize = true;
            this.Environment.BackColor = System.Drawing.Color.Transparent;
            this.Environment.Location = new System.Drawing.Point(191, 58);
            this.Environment.Name = "Environment";
            this.Environment.Size = new System.Drawing.Size(69, 13);
            this.Environment.TabIndex = 8;
            this.Environment.Text = "Environment:";
            // 
            // EnvironmentBox
            // 
            this.EnvironmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentBox.FormattingEnabled = true;
            this.EnvironmentBox.Location = new System.Drawing.Point(194, 75);
            this.EnvironmentBox.Name = "EnvironmentBox";
            this.EnvironmentBox.Size = new System.Drawing.Size(157, 21);
            this.EnvironmentBox.TabIndex = 9;
            this.EnvironmentBox.SelectedIndexChanged += new System.EventHandler(this.EnvironmentBox_SelectedIndexChanged);
            // 
            // Databasetype
            // 
            this.Databasetype.AutoSize = true;
            this.Databasetype.BackColor = System.Drawing.Color.Transparent;
            this.Databasetype.Location = new System.Drawing.Point(191, 107);
            this.Databasetype.Name = "Databasetype";
            this.Databasetype.Size = new System.Drawing.Size(80, 13);
            this.Databasetype.TabIndex = 10;
            this.Databasetype.Text = "DatabaseType:";
            // 
            // DatabasetypeBox
            // 
            this.DatabasetypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabasetypeBox.FormattingEnabled = true;
            this.DatabasetypeBox.Location = new System.Drawing.Point(194, 123);
            this.DatabasetypeBox.Name = "DatabasetypeBox";
            this.DatabasetypeBox.Size = new System.Drawing.Size(157, 21);
            this.DatabasetypeBox.TabIndex = 11;
            this.DatabasetypeBox.SelectedIndexChanged += new System.EventHandler(this.DatabasetypeBox_SelectedIndexChanged);
            // 
            // Validation
            // 
            this.Validation.AutoSize = true;
            this.Validation.Location = new System.Drawing.Point(15, 305);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(0, 13);
            this.Validation.TabIndex = 12;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(375, 116);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.OutputBox.Location = new System.Drawing.Point(9, 176);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(441, 180);
            this.OutputBox.TabIndex = 15;
            this.OutputBox.TabStop = false;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Location = new System.Drawing.Point(9, 160);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel.TabIndex = 16;
            this.OutputLabel.Text = "Output:";
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rollback);
            this.panel1.Controls.Add(this.migrate);
            this.panel1.Location = new System.Drawing.Point(357, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 71);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rollback
            // 
            this.rollback.AutoSize = true;
            this.rollback.Location = new System.Drawing.Point(18, 39);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(62, 17);
            this.rollback.TabIndex = 1;
            this.rollback.TabStop = true;
            this.rollback.Text = "rollback";
            this.rollback.UseVisualStyleBackColor = true;
            this.rollback.CheckedChanged += new System.EventHandler(this.rollback_CheckedChanged);
            // 
            // migrate
            // 
            this.migrate.AutoSize = true;
            this.migrate.Location = new System.Drawing.Point(18, 16);
            this.migrate.Name = "migrate";
            this.migrate.Size = new System.Drawing.Size(59, 17);
            this.migrate.TabIndex = 0;
            this.migrate.TabStop = true;
            this.migrate.Text = "migrate";
            this.migrate.UseVisualStyleBackColor = true;
            this.migrate.CheckedChanged += new System.EventHandler(this.migrate_CheckedChanged);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(145, 23);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(24, 24);
            this.Browse.TabIndex = 18;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.BackColor = System.Drawing.Color.Transparent;
            this.FilePath.Location = new System.Drawing.Point(6, 9);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(51, 13);
            this.FilePath.TabIndex = 20;
            this.FilePath.Text = "File Path:";
            // 
            // FilePathText
            // 
            this.FilePathText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FilePathText.Location = new System.Drawing.Point(9, 25);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(137, 20);
            this.FilePathText.TabIndex = 21;
            this.FilePathText.Text = "C:\\Code\\warehouse-manager-web\\packages\\FluentMigrator.1.3.0.0\\tools\\Migrate.exe";
            this.FilePathText.TextChanged += new System.EventHandler(this.FileBoxText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 367);
            this.Controls.Add(this.FilePathText);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Validation);
            this.Controls.Add(this.DatabasetypeBox);
            this.Controls.Add(this.Databasetype);
            this.Controls.Add(this.EnvironmentBox);
            this.Controls.Add(this.Environment);
            this.Controls.Add(this.Storetype);
            this.Controls.Add(this.StoretypeBox);
            this.Controls.Add(this.DatabaseBox);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.Run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FluentMigrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.TextBox DatabaseBox;
        private System.Windows.Forms.ComboBox StoretypeBox;
        private System.Windows.Forms.Label Storetype;
        private System.Windows.Forms.Label Environment;
        private System.Windows.Forms.ComboBox EnvironmentBox;
        private System.Windows.Forms.Label Databasetype;
        private System.Windows.Forms.ComboBox DatabasetypeBox;
        private System.Windows.Forms.Label Validation;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rollback;
        private System.Windows.Forms.RadioButton migrate;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.TextBox FilePathText;
    }
}

