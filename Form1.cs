﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentMigrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            StoretypeBox.Items.Add("Trees");
            StoretypeBox.Items.Add("Pools");
            StoretypeBox.Items.Add("International");

            EnvironmentBox.Items.Add("Production");
            EnvironmentBox.Items.Add("Staging");
            EnvironmentBox.Items.Add("Development");

            DatabasetypeBox.Items.Add("Main");
            DatabasetypeBox.Items.Add("History");
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (ServerBox.Text == String.Empty
                || DatabaseBox.Text == String.Empty
                || StoretypeBox.Text == String.Empty
                || EnvironmentBox.Text == String.Empty
                || DatabasetypeBox.Text == String.Empty
                || (rollback.Checked == false && migrate.Checked == false))
            {
                Validate.Visible = true;
            }
            else
            {
                Validate.Visible = false;
                string store = StoretypeBox.SelectedItem.ToString();
                string environment = EnvironmentBox.SelectedItem.ToString();
                string datatype = DatabasetypeBox.SelectedItem.ToString();
                string cast = "";

                if (migrate.Checked)
                    cast = "migrate";
                else
                    cast = "rollback";

                Process migraterun = new Process();
                ProcessStartInfo StartInfo = new ProcessStartInfo();
                StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                StartInfo.CreateNoWindow = true;
                StartInfo.RedirectStandardOutput = true;
                StartInfo.RedirectStandardError = true;
                StartInfo.UseShellExecute = false;
                StartInfo.FileName = "C:\\Code\\warehouse-manager-web\\packages\\FluentMigrator.1.3.0.0\\tools\\Migrate.exe";
                StartInfo.Arguments = " /connection " + "\"Data Source=" + ServerBox.Text +
                                      ";Initial Catalog=" + DatabaseBox.Text +
                                      ";User ID=wmuser;Password='b@ls@m-h1ll;';\"" +
                                      " /db sqlserver /target C:\\Code\\warehouse-manager-web\\Migrations\\bin\\Debug\\Migrations.dll /task " + cast
                                      +" /context Development /tag " + store + " /tag " + environment + " /tag " + datatype;
                migraterun.StartInfo = StartInfo;
                migraterun.Start();

                string output = "";

                while (!migraterun.HasExited)
                {
                    output += migraterun.StandardOutput.ReadToEnd() + migraterun.StandardError.ReadToEnd();
                    OutputBox.Text = output;
                }
            }
        }

        private void ServerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Server_Click(object sender, EventArgs e)
        {

        }

        private void StoretypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatabaseBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnvironmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatabasetypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Database_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Validate_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void migrate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rollback_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}