using Li.krkrfgformat;
using Li.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Li.krkrfgformat
{
    
    public partial class MainForm : Form
    {
        //public event MainFormImageChangeValue MainFormImageChange;
        private const string name = "合成的文件名字：";

        private string examplePicFullName = "";

        private string saveFullPath = "";

        private string saveFolderName = "输出合成";
        private int SelectedListBoxCount
        {
            get;
            set;
        }

        private int HaveItemListBoxCount
        {
            get;
            set;
        }

        private string RuleFilePath
        {
            get;
            set;
        }

        private ImageViewForm iv;
        public MainForm()
        {
            
            InitializeComponent();
            toolStrip1.Items.Add(new ToolStripControlHost(checkBox2));
            new DataFormat();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            toolTip1.SetToolTip(checkBox2, "如果默认的合成显示有问题，可以尝试勾选这个。");
            toolTip1.SetToolTip(pictureBox1, "双击大窗口查看。");
            SelectedListBoxCount = 0;
            HaveItemListBoxCount = 0;
            toolStripStatusLabel1.Text = "合成的文件名字：";
            RuleFilePath = "";
            examplePicFullName = "";
            saveFullPath = "";
            //pictureBox1.BackgroundImage = Picture.CreatBackImage(pictureBox1.Width, pictureBox1.Height);
        }
        private void SelectTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = (TextPatchShow.Text.Equals(string.Empty) ? "C:\\" : Path.GetFullPath(TextPatchShow.Text)),
                Filter = "文本文档(*.txt)|*.txt|json文件(*.json)|*.json|所有文件 (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Path.GetExtension(openFileDialog.FileName).Equals(".txt") && !Path.GetExtension(openFileDialog.FileName).Equals(".json"))
                {
                    MessageBox.Show("不是txt或者json文件。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    RuleFilePath = openFileDialog.FileName;
                    DataFormat.AddText(openFileDialog.FileName);
                    TextPatchShow.Text = openFileDialog.FileName;
                }
            }
            DataFormat.AddText(TextPatchShow.Text);
        }

        private void FormatOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataFormat.NewPicture != null)
                {
                    if (!Directory.Exists(saveFullPath + "\\" + saveFolderName + "\\"))
                    {
                        Directory.CreateDirectory(saveFullPath + "\\" + saveFolderName + "\\");
                    }
                    DataFormat.NewPicture.Save(saveFullPath + "\\" + saveFolderName + "\\" + DataFormat.SaveFileName + ".png", ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.Items.Count != 0)
            {
                HaveItemListBoxCount--;
            }
            listBox.Items.Clear();
            string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in array)
            {
                if (Path.GetExtension(path).ToLower() == ".png"|| Path.GetExtension(path).ToLower() == ".tlg")
                {
                    if (string.IsNullOrEmpty(examplePicFullName))
                    {
                        examplePicFullName = path;
                    }
                    if (string.IsNullOrEmpty(saveFullPath))
                    {
                        saveFullPath = Path.GetDirectoryName(path);
                        savePathBox.Text = saveFullPath;
                    }
                    listBox.Items.Add(Path.GetFileNameWithoutExtension(path));
                }
            }
            if (listBox.Items.Count != 0)
            {
                HaveItemListBoxCount++;
            }
            //依次打开listbox的限制
            switch (HaveItemListBoxCount)
            {
                case 1:
                    fgPart_2.BackColor = SystemColors.Window;
                    fgPart_2.AllowDrop = true;
                    break;
                case 2:
                    fgPart_3.BackColor = SystemColors.Window;
                    fgPart_3.AllowDrop = true;
                    break;
                case 3:
                    fgPart_4.BackColor = SystemColors.Window;
                    fgPart_4.AllowDrop = true;
                    break;
                case 4:
                    fgPart_5.BackColor = SystemColors.Window;
                    fgPart_5.AllowDrop = true;
                    break;
                case 5:
                    fgPart_6.BackColor = SystemColors.Window;
                    fgPart_6.AllowDrop = true;
                    break;
                case 6:
                    fgPart_7.BackColor = SystemColors.Window;
                    fgPart_7.AllowDrop = true;
                    break;
                case 7:
                    fgPart_8.BackColor = SystemColors.Window;
                    fgPart_8.AllowDrop = true;
                    break;
                case 8:
                    fgPart_9.BackColor = SystemColors.Window;
                    fgPart_9.AllowDrop = true;
                    break;
                case 9:
                    fgPart_10.BackColor = SystemColors.Window;
                    fgPart_10.AllowDrop = true;
                    break;
                case 10:
                    fgPart_11.BackColor = SystemColors.Window;
                    fgPart_11.AllowDrop = true;
                    break;
                case 11:
                    fgPart_12.BackColor = SystemColors.Window;
                    fgPart_12.AllowDrop = true;
                    break;
            }
        }

        private void ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            int key = Convert.ToInt32(listBox.Name.Split('_')[1]);
            int num2 = listBox.SelectedIndex = listBox.IndexFromPoint(e.X, e.Y);

            //尝试自行寻找规则文件。
            if (string.IsNullOrEmpty(RuleFilePath))
            {
                try
                {
                    TryToFindRuleFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (string.IsNullOrEmpty(RuleFilePath))
                    {
                        SelectTextFile_Click(sender, e);
                    }
                }
            }
            if (listBox.SelectedIndex != -1)
            {
                if (File.Exists(Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".png"))
                {
                    DataFormat.AddPicture(key, Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".png");
                }else if (File.Exists(Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".tlg"))
                {
                    DataFormat.AddPicture(key, Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".tlg");
                }
            }
            DataFormat.NowFormat();
            if (DataFormat.NewPicture.Width <= pictureBox1.Width && DataFormat.NewPicture.Height <= pictureBox1.Height)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            pictureBox1.Image = DataFormat.NewPicture;

            if (!(iv == null || iv.IsDisposed))
            {
                iv.PictureChange((Bitmap)pictureBox1.Image);
            }
            
            toolStripStatusLabel1.Text = "合成的文件名字：" + DataFormat.SaveFileName;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            int key = Convert.ToInt32(listBox.Name.Split('_')[1]);
            if (listBox.SelectedIndex != -1)
            {
                if (File.Exists(Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".png"))
                {
                    DataFormat.AddPicture(key, Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".png");
                }
                else if (File.Exists(Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".tlg"))
                {
                    DataFormat.AddPicture(key, Path.GetDirectoryName(RuleFilePath) + "\\" + listBox.SelectedItem.ToString() + ".tlg");
                }
            }
            DataFormat.NowFormat();
            if (DataFormat.NewPicture.Width <= pictureBox1.Width && DataFormat.NewPicture.Height <= pictureBox1.Height)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            pictureBox1.Image = DataFormat.NewPicture;
            if (!(iv == null || iv.IsDisposed))
            {
                iv.PictureChange((Bitmap)pictureBox1.Image);
            }
            toolStripStatusLabel1.Text = "合成的文件名字：" + DataFormat.SaveFileName;
        }

        private void TryToFindRuleFile()
        {
            string directoryName = Path.GetDirectoryName(examplePicFullName);
            string[] array = Path.GetFileNameWithoutExtension(examplePicFullName).Split('_');
            string text = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                text = text + "_" + array[i];
            }
            string str = directoryName + "\\" + text;
            string text2 = "";
            if (File.Exists(str + ".txt"))
            {
                text2 = str + ".txt";
            }
            else if (File.Exists(str + ".json"))
            {
                text2 = str + ".json";
            }
            RuleFilePath = text2;
            TextPatchShow.Text = text2;
            DataFormat.AddText(text2);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Control control3 in freeMix1.Controls)
            {
                if (control3 is ListBox)
                {
                    (control3 as ListBox).ClearSelected();
                }
            }
            foreach (Control control4 in freeMix2.Controls)
            {
                if (control4 is ListBox)
                {
                    (control4 as ListBox).ClearSelected();
                }
            }
            pictureBox1.Image = null;
            DataFormat.NewPicture.Dispose();
            DataFormat.Pictures.Clear();
            toolStripStatusLabel1.Text = "合成的文件名字：";
            if (!(iv == null || iv.IsDisposed))
            { iv.ClearForm(); }
            GC.Collect();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Control control3 in freeMix1.Controls)
            {
                if (control3 is ListBox)
                {
                    ListBox listBox = control3 as ListBox;
                    listBox.Items.Clear();
                    listBox.ClearSelected();
                    if (listBox.Name != "fgPart_1")
                    {
                        listBox.BackColor = SystemColors.Control;
                        listBox.AllowDrop = false;
                    }
                }
            }
            foreach (Control control4 in freeMix2.Controls)
            {
                if (control4 is ListBox)
                {
                    ListBox obj = control4 as ListBox;
                    obj.Items.Clear();
                    obj.ClearSelected();
                    obj.BackColor = SystemColors.Control;
                    obj.AllowDrop = false;
                }
            }
            RuleFilePath = "";
            TextPatchShow.Clear();
            savePathBox.Clear();
            saveFullPath = "";
            toolStripStatusLabel1.Text = "合成的文件名字：";
            examplePicFullName = "";
            checkBox2.Checked = false;
            DataFormat.NewPicture = null;
            pictureBox1.Image = null;
            if (!(iv == null || iv.IsDisposed))
            { iv.Close(); }
            DataFormat.TextDatas = null;
            DataFormat.FilePatch = "";
            DataFormat.SaveFileName = "";
            DataFormat.Pictures.Clear();
            SelectedListBoxCount = 0;
            HaveItemListBoxCount = 0;
            GC.Collect();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "从左往右，从上往下，依次为图片叠加的最底层到最高层。\n" +
                "第二页的规则同上。\n" +
                "\n" +
                "现由于Xmoe的工具自身原因，部分解出来的json有问题，\n" +
                "会导致报错，请重启工具。\n" +
                "\n" +
                "坐标文件支持自己选择，也支持自动选择。\n" +
                "前提是规则跟图片在一个文件夹, 没在一起的会报错甚至崩溃。\n" +
                "\n" +
                "寻找文件是根据坐标文件名字在同一目录寻找的，方式为【[文件名]_[代号]】。\n" +
                "如果有不同于坐标文件的图片在里面会炸。\n" +
                "\n" +
                "更多问题以及bug以后会更新以及修复。\n" +
                "\n" +
                "双击浏览窗口可以大窗口查看。\n" +
                "\n" +
                "联系：inabameguru@vip.qq.com", "帮助", MessageBoxButtons.OK);
        }

        private void OpenOutFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(saveFullPath))
            {
                string arguments = saveFullPath + "\\" + saveFolderName;
                Process.Start("explorer.exe", arguments);
            }
        }

        private void SaveFolderPatch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            savePathBox.Text = folderBrowserDialog.SelectedPath;
            saveFullPath = folderBrowserDialog.SelectedPath;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                DataFormat.usingSizeOnly = true;
                if (DataFormat.Pictures.Count != 0)
                {
                    DataFormat.NowFormat();
                    
                    if (DataFormat.NewPicture.Width <= pictureBox1.Width && DataFormat.NewPicture.Height <= pictureBox1.Height)
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    else
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    pictureBox1.Image = DataFormat.NewPicture;
                    if (!(iv == null || iv.IsDisposed))
                    {
                        iv.PictureChange((Bitmap)pictureBox1.Image);
                    }
                }
                return;
            }
            DataFormat.usingSizeOnly = false;
            if (DataFormat.Pictures.Count != 0)
            {
                DataFormat.NowFormat();
                if (DataFormat.NewPicture.Width <= pictureBox1.Width && DataFormat.NewPicture.Height <= pictureBox1.Height)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                pictureBox1.Image = DataFormat.NewPicture;
            }
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (DataFormat.NewPicture != null)
            {
                if (iv == null || iv.IsDisposed)
                {
                    iv = new ImageViewForm
                    {
                        Picture = pictureBox1.Image
                    };
                    iv.Show();
                }
                else
                {
                    iv.Activate();
                }
            }
        }
    }
}
