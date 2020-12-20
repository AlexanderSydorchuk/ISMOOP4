using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4
{
    public partial class Form1 : Form
    {
        public DriveInfo[] drives = DriveInfo.GetDrives();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b_Refresh_Click(sender, e);
            int num = cmb_Disks.SelectedIndex;
        }

        private void b_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Disks.Items.Clear();
            foreach(DriveInfo drive in drives)
            {
                cmb_Disks.Items.Add(drives[0]);
            }
        }

        private void cmb_Disks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = cmb_Disks.SelectedIndex;

            if (drives[num].IsReady)
            {
                lb_Type.Visible = true;
                lb_Free.Visible = true;
                lb_Amount.Visible = true;


                lb_Type.Text = $"Тип диска: {drives[num].DriveType}";
                lb_Amount.Text = $"Обсяг диска: {drives[num].TotalSize}";
                lb_Free.Text = $"Вільне місце: {drives[num].TotalFreeSpace}";
            }
            else
            {
                lb_Type.Visible = false;
                lb_Free.Visible = false;
                lb_Amount.Visible = false;
            }


            string directory_name = cmb_Disks.SelectedItem.ToString();

            listBox1.Items.Clear();
            if (Directory.Exists(directory_name))
            {
                string[] dir = Directory.GetDirectories(directory_name);
                foreach (string item in dir)
                {
                    listBox1.Items.Add($"{item}");
                }
                string[] files = Directory.GetFiles(directory_name);

                foreach (string item in files)
                {
                    listBox1.Items.Add($"{item}");
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir_name = listBox1.SelectedItem.ToString();
            if (Directory.Exists(dir_name))
            {
                listBox1.Items.Clear();

                string[] dirs = Directory.GetDirectories(dir_name);
                foreach (string d in dirs)
                {
                    listBox1.Items.Add($"{d}");
                }

                string[] files = Directory.GetFiles(dir_name);
                foreach (string file in files)
                { 
                    listBox1.Items.Add($"{file}");
                }
            

            
                DirectoryInfo info = new DirectoryInfo(dir_name);

                lstbox_About.Items.Clear();
                lstbox_About.Items.Add($"Диск: {info.Root}");
                lstbox_About.Items.Add($"Назва папки: {info.Name}");
                lstbox_About.Items.Add($"Дата створення: {info.CreationTime}");
                lstbox_About.Items.Add($"Дата останнього відкриття: {info.LastAccessTime}");

                long directory_size = DirectorySize(info);

                lstbox_About.Items.Add($"Directory size: {directory_size} байт");
            }
        }

        public static long DirectorySize(DirectoryInfo directory)
        {
            long size = 0;
            
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo f in files)
            {
                size += f.Length;
            }
            
            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                size += DirectorySize(d);
            }
            return (size);
        }
    }
}