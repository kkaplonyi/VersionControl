﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            label1.Text = Resource.FullName;
            button2.Text = Resource.ExportToFile;
            button1.Text = Resource.Add;
            button3.Text = Resource.Delete;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "Fullname";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text,
                
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                Stream FileST = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(FileST);

                foreach (var item in users)
                {
                    sw.WriteLine(item.ID + ", " + item.FullName);
                }
                sw.Close();
                FileST.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var todel = users.Where(a => a.FullName == textBox1.Text).ToList();

            foreach (User item in todel)
            {
                users.Remove(item);
            }
        }
    }
}
