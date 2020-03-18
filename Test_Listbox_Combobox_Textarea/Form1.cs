using System;
using System.Windows.Forms;

namespace Test_Listbox_Combobox_Textarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Controls controls = new Controls();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTimKiem.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMahang.Enabled = false;
            txtTenHang.Enabled = false;
            txtNhaSX.Enabled = false;
            cbTuyChon.Enabled = false;
            controls.LoadToListBox(lbxThongTinMH, Application.StartupPath + "/Mathang.txt");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMahang.Enabled = true;
            txtTenHang.Enabled = true;
            txtNhaSX.Enabled = true;
            txtMahang.Text = "";
            txtTenHang.Text = "";
            txtNhaSX.Text = "";
            txtMahang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            lbxThongTinMH.Items.Insert(lbxThongTinMH.SelectedIndex, "| Mã hàng: " + txtMahang.Text + " | Tên hàng: " + txtTenHang.Text + " | Nhà sản xuất: " + txtNhaSX.Text + " |");
            lbxThongTinMH.Items.RemoveAt(lbxThongTinMH.SelectedIndex);
            controls.WriteListBoxToFile(lbxThongTinMH, Application.StartupPath + "/Mathang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 1, 10, Application.StartupPath + "/Mahang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 2, 11, Application.StartupPath + "/Tenhang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 3, 15, Application.StartupPath + "/NhaSX.txt");

            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Mahang.txt");
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Tenhang.txt");
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/NhaSX.txt");
            txtMahang.Text = "";
            txtTenHang.Text = "";
            txtNhaSX.Text = "";
            txtMahang.Enabled = false;
            txtTenHang.Enabled = false;
            txtNhaSX.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMahang.Text = "";
            txtTenHang.Text = "";
            txtNhaSX.Text = "";
            txtMahang.Enabled = false;
            txtTenHang.Enabled = false;
            txtNhaSX.Enabled = false;
            lbxThongTinMH.Items.RemoveAt(lbxThongTinMH.SelectedIndex);            
            controls.WriteListBoxToFile(lbxThongTinMH, Application.StartupPath + "/Mathang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 1, 10, Application.StartupPath + "/Mahang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 2, 11, Application.StartupPath + "/Tenhang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 3, 15, Application.StartupPath + "/NhaSX.txt");

            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Mahang.txt");
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Tenhang.txt");
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/NhaSX.txt");

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lbxThongTinMH.Items.Add("| Mã hàng: " + txtMahang.Text + " | Tên hàng: " + txtTenHang.Text + " | Nhà sản xuất: " + txtNhaSX.Text + " |");
            controls.WriteListBoxToFile(lbxThongTinMH, Application.StartupPath + "/Mathang.txt");

            controls.WriteDirectlyToFile(lbxThongTinMH, 1, 10, Application.StartupPath + "/Mahang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 2, 11, Application.StartupPath + "/Tenhang.txt");
            controls.WriteDirectlyToFile(lbxThongTinMH, 3, 15, Application.StartupPath + "/NhaSX.txt");

            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Mahang.txt");
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Tenhang.txt");
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/NhaSX.txt");

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMahang.Text = "";
            txtTenHang.Text = "";
            txtNhaSX.Text = "";
            txtMahang.Enabled = false;
            txtTenHang.Enabled = false;
            txtNhaSX.Enabled = false;
            btnThem.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMahang.Text = "";
            txtTenHang.Text = "";
            txtNhaSX.Text = "";
            txtMahang.Enabled = false;
            txtTenHang.Enabled = false;
            txtNhaSX.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Focus();
        }

        private void lbxThongTinMH_Click(object sender, EventArgs e)
        {
            string Line;
            if (lbxThongTinMH.SelectedItem != null)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
                txtMahang.Enabled = false;
                txtTenHang.Enabled = true;
                txtNhaSX.Enabled = true;
                Line = lbxThongTinMH.SelectedItem.ToString();
                string[] chuoi = Line.Split('|');
                txtMahang.Text = chuoi[1].Substring(10).Trim();
                txtTenHang.Text = chuoi[2].Substring(11).Trim();
                txtNhaSX.Text = chuoi[3].Substring(15).Trim();
            }
            else
            {
                MessageBox.Show("Bạn đã không chọn chính xác một dòng hoặc không có dữ liệu nào trong ListBox!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void rdbTimtheoMH_CheckedChanged(object sender, EventArgs e)
        {
            lblTuyChon.Text = "Mã hàng";
            cbTuyChon.Enabled = true;
            cbTuyChon.Focus();
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Mahang.txt");
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
            cbTuyChon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTuyChon.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void rdbTimtheoTH_CheckedChanged(object sender, EventArgs e)
        {
            lblTuyChon.Text = "Tên hàng";
            cbTuyChon.Enabled = true;
            cbTuyChon.Focus();
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/Tenhang.txt");
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
            cbTuyChon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTuyChon.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void rdbTimtheoNSX_CheckedChanged(object sender, EventArgs e)
        {
            lblTuyChon.Text = "Nhà sản xuất";
            cbTuyChon.Enabled = true;
            cbTuyChon.Focus();
            controls.AdddatainCb(cbTuyChon, Application.StartupPath + "/NhaSX.txt");
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
            cbTuyChon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTuyChon.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Line;
            int flag = 0, count = 0;
            if (rdbTimtheoMH.Checked == true)
            {
                for (int i = 0; i < lbxThongTinMH.Items.Count; ++i)
                {
                    Line = lbxThongTinMH.Items[i].ToString();
                    string[] chuoi = Line.Split('|');
                    if (cbTuyChon.Text == chuoi[1].Substring(10).Trim())
                    {
                        flag = 1;
                        txtThongtinTK.Text = lbxThongTinMH.Items[i].ToString();
                        count++;
                    }
                }
                if (flag == 1)
                {
                    lblKetquaTK.Text = "Có " + count + " kết quả được tìm thấy!!!";
                }
                else
                    if (flag == 0)
                    {
                    lblKetquaTK.Text = "Không có kết quả nào được tìm thấy!!!";
                    txtThongtinTK.Clear();
                    }

            }

            if (rdbTimtheoTH.Checked == true)
            {
                string str = "";
                for (int i = 0; i < lbxThongTinMH.Items.Count; ++i)
                {
                    Line = lbxThongTinMH.Items[i].ToString();
                    string[] chuoi = Line.Split('|');
                    if (cbTuyChon.Text == chuoi[2].Substring(11).Trim())
                    {
                        flag = 1;
                        str += lbxThongTinMH.Items[i].ToString() + "\r\n";
                        /*cách 2
                        str += lbxThongTinMH.Items[i].ToString() + Environment.NewLine;
                        */
                        count++;
                    }
                }
                if (flag == 1)
                {
                    lblKetquaTK.Text = "Có " + count + " kết quả được tìm thấy!!!";
                    txtThongtinTK.Text = str.Trim();
                }
                else
                    if(flag == 0)
                    {
                    lblKetquaTK.Text = "Không có kết quả nào được tìm thấy!!!";
                    txtThongtinTK.Clear();
                    }
            }

            if (rdbTimtheoNSX.Checked == true)
            {
                string str = "";
                for (int i = 0; i < lbxThongTinMH.Items.Count; ++i)
                {
                    Line = lbxThongTinMH.Items[i].ToString();
                    string[] chuoi = Line.Split('|');
                    if (cbTuyChon.Text == chuoi[3].Substring(15).Trim())
                    {
                        flag = 1;
                        str += lbxThongTinMH.Items[i].ToString() + Environment.NewLine;
                        count++;
                    }
                }
                if (flag == 1)
                {
                    lblKetquaTK.Text = "Có " + count + " kết quả được tìm thấy!!!";
                    txtThongtinTK.Text = str.Trim();
                }
                else
                    if (flag == 0)
                    {
                        lblKetquaTK.Text = "Không có kết quả nào được tìm thấy!!!";
                        txtThongtinTK.Clear();
                    }
            }
        }

        private void cbTuyChon_TextChanged(object sender, EventArgs e)
        {
            if (cbTuyChon.Text != "")
            {
                btnTimKiem.Enabled = true;
            }
            else
            {
                btnTimKiem.Enabled = false;
            }
        }

        private void txtMahang_Leave(object sender, EventArgs e)
        {
            string Line;
            for(int i=0; i < lbxThongTinMH.Items.Count; ++i)
            {
                Line = lbxThongTinMH.Items[i].ToString();
                string[] chuoi = Line.Split('|');
                if (txtMahang.Text == chuoi[1].Substring(10).Trim())
                {
                    MessageBox.Show("Mã hàng này đã có rồi, hãy nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMahang.Focus();
                    return;
                }
            }
            if (controls.TestMaHang(txtMahang.Text) == 2)
            {
                MessageBox.Show("Mã hàng phải gồm 4 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahang.Focus();
                return;
            }
            else
                if (controls.TestMaHang(txtMahang.Text) == 1)
                {
                    MessageBox.Show("Mã hàng phải có 2 ký tự đầu là chữ và 2 ký tự cuối là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMahang.Focus();
                    return;
                }

        }

        private void cbTuyChon_Click(object sender, EventArgs e)
        {
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
        }

        private void rdbTimtheoMH_Leave(object sender, EventArgs e)
        {
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
        }

        private void rdbTimtheoTH_Leave(object sender, EventArgs e)
        {
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
        }

        private void rdbTimtheoNSX_Leave(object sender, EventArgs e)
        {
            lblKetquaTK.Text = "";
            txtThongtinTK.Text = "";
        }

    }
}
