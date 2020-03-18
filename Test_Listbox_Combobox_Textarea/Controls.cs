using System.Windows.Forms;
using System.IO;

namespace Test_Listbox_Combobox_Textarea
{
    class Controls
    {
        //load du lieu tu file text len listbox
        public void LoadToListBox(ListBox lbx, string TenFile)
        {
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();
            while (Line != null && Line != " ")
            {
                lbx.Items.Add(Line);
                Line = sr.ReadLine();
            }
            sr.Close();
        }

        //ghi du lieu vao file tu listbox
        public void WriteListBoxToFile(ListBox lbx, string pathFile)
        {
            StreamWriter sw = new StreamWriter(pathFile);
            string Line;
            for (int i = 0; i < lbx.Items.Count; ++i)
            {
                Line = "";
                Line += lbx.Items[i];
                sw.WriteLine(Line);
            }
            sw.Close();
        }

        //ghi truc tiep vao file.
        public void WriteDirectlyToFile(ListBox lbx, int n, int m, string pathFile)
        {
            StreamWriter sw = new StreamWriter(pathFile);
            string Line, street = "";
            for (int i = 0; i < lbx.Items.Count; ++i)
            {
                Line = "";
                street = lbx.Items[i].ToString();
                string[] chuoi = street.Split('|');
                Line += chuoi[n].Substring(m).Trim();
                sw.WriteLine(Line);
            }
            sw.Close();
        }

        //ghi noi du lieu
        //public void SavedataToFile(string TenFile, string Dulieu)
        //{
        //    StreamWriter sw = File.AppendText(TenFile);
        //    sw.WriteLine(Dulieu);
        //    sw.Close();
        //}

        //chen du lieu vao combobox
        public void AdddatainCb(ComboBox cb, string TenFile)
        {

            cb.Items.Clear();
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();
            while (Line != null && Line != " ")
            {
                cb.Items.Add(Line);
                Line = sr.ReadLine();
            }
            LocDuLieuTrung(cb);
            sr.Close();
        }

        //loc du lieu trung trong listbox va xoa du lieu bi trung trong listbox
        //public static void LocListBox(DataGridView dgr, ComboBox cb, byte chiso)
        //{
        //    for (int i = dgr.RowCount - 2; i >= 0; i--)
        //    {
        //        string a = dgr[chiso, i].Value.ToString().ToLower().Trim();
        //        if (cb.Text.ToLower().Trim() != a)
        //        {
        //            dgr.Rows.RemoveAt(i);
        //        }
        //    }
        //}

        //loc du lieu trung trong combobox
        public void LocDuLieuTrung(ComboBox cb)
        {
            int flag;
            for (int j = 0; j < cb.Items.Count; ++j)
            {
                for (int i = j + 1; i < cb.Items.Count; ++i)
                {
                    flag = 0;
                    if (cb.Items[j].ToString() == cb.Items[i].ToString())
                    {
                        flag = 1;
                    }
                    if (flag == 1)
                    {
                        cb.Items.RemoveAt(i);
                    }
                }
            }
        }
        public int TestMaHang (string mh)
        {
            int value = 0;
            int flag = 0, flag1 = 0, flag2 = 0, flag3 = 0;
            char[] wl = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] wu = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (mh.Length == 4)
            {
                for(int i = 0; i < wl.Length; ++i)
                {
                    if (wl[i] == mh.ToCharArray()[0] || wu[i] == mh.ToCharArray()[0])
                    {
                        flag = 1;
                        break;
                    }
                }

                for (int i = 0; i < wu.Length; ++i)
                {
                    if (wl[i] == mh.ToCharArray()[1] || wu[i] == mh.ToCharArray()[1])
                    {
                        flag1 = 1;
                        break;
                    }
                }

                for (int i = 0; i < numbers.Length; ++i)
                {
                    if (numbers[i] == mh.ToCharArray()[2])
                    {
                        flag2 = 1;
                        break;
                    }
                }

                for (int i = 0; i < numbers.Length; ++i)
                {
                    if (numbers[i] == mh.ToCharArray()[3])
                    {
                        flag3 = 1;
                        break;
                    }
                }

                if (flag == 0 || flag1 == 0 || flag2 == 0 || flag3 == 0)
                {
                    value = 1;
                }
            }
            else
            {
                value = 2;
            }
            return value;
        }

    }
}
