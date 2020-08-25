using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.BL_Layer;
using FastFoodDemo.DTO;

namespace FastFoodDemo
{
    public partial class Employee : UserControl
    {
        public Employee(Login l)
        {
            InitializeComponent();
            login = l;
        }
        Login login = new Login();
        DataSet ds = new DataSet();
        List<NhanVien> dsNV = new List<NhanVien>();
        private void Employee_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        BLNhanVien blNV;
        private void LoadData()
        {
            blNV = new BLNhanVien();
            ds = blNV.LoadData();

            dsNV = new List<NhanVien>();
            ds = blNV.LoadData();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                var x = row.ItemArray.ToList();
                NhanVien nv = new NhanVien()
                {
                    MaNV=int.Parse(x[0].ToString()),
                    HoTen=x[1].ToString(),
                    GT=bool.Parse(x[2].ToString()),
                    CMND=int.Parse(x[3].ToString()),
                    SDT=int.Parse(x[4].ToString()),
                    TT_LamViec=bool.Parse(x[5].ToString()),
                    MatKhau=x[6].ToString(),
                    QuanLi=int.Parse(x[7].ToString())
                };
                dsNV.Add(nv);
            }

            dgvNhanVien.Rows.Clear();
            for (int i = 0; i < dsNV.Count; i++)
            {
                if (dsNV[i].TT_LamViec == true)
                    dgvNhanVien.Rows.Add(dsNV[i].MaNV,dsNV[i].HoTen, dsNV[i].GT, dsNV[i].CMND,dsNV[i].SDT,dsNV[i].TT_LamViec,dsNV[i].MatKhau,dsNV[i].QuanLi);
            }
        }
        private int QuanLi()
        {
            for(int i=0; i<dgvNhanVien.Rows.Count; i++)
            {
                DataGridViewRow row = dgvNhanVien.Rows[i];
                if (login.MaNV == int.Parse(row.Cells[0].Value.ToString()))
                    return int.Parse(row.Cells[7].Value.ToString());
            }
            return -1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dgvNhanVien.Rows.Count-1)
                    return;

                DataGridViewRow row = dgvNhanVien.Rows[rowselect];
                int Ma = int.Parse(row.Cells[0].Value.ToString());
                NhanVien nv = dsNV.Find(x => x.MaNV == Ma);

                if (nv.QuanLi == QuanLi() || QuanLi() == 1 || nv.QuanLi == 0)
                {
                    bool kind = QuanLi() == 1;
                    int Bac = QuanLi();
                    DetailEmployee detail = new DetailEmployee(true, kind, nv);
                    var result = detail.ShowDialog();
                }
                else
                    MessageBox.Show("Bạn không có quyền hạn chỉnh sửa thông tin người này","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(QuanLi()==1)
            {
                DetailEmployee detail = new DetailEmployee(true);
                var result = detail.ShowDialog();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                if (rowselect == -1 || rowselect >= dgvNhanVien.Rows.Count - 1 || QuanLi() != 1)
                {
                    MessageBox.Show("Bạn có quyền hạn xoá thông tin người này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int vt = 0;

                for (int i = 0; i < dsNV.Count; i++)
                {
                    if (dsNV[i].MaNV == (int)(dgvNhanVien.Rows[rowselect].Cells[0].Value))
                    {
                        vt = i;
                        break;
                    }
                }
                string message;
                NhanVien nv = new NhanVien();
                nv = dsNV[vt];
                nv.TT_LamViec = false;
                if (QuanLi() == 1)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        bool result = blNV.Delete(nv, out message);
                        if (result == false)
                            MessageBox.Show(message);
                        LoadData();
                    }
                }                  

            }
        }

        int rowselect = 0;
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowselect = e.RowIndex;
        }

        int hang = 0;
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
                LoadData();
            else
            {
                dgvNhanVien.Rows.Clear();
                for (int i = 0; i < dsNV.Count; i++)
                {
                    if (dsNV[i].HoTen.Contains(txtFind.Text) && dsNV[i].TT_LamViec == true)
                        dgvNhanVien.Rows.Add(dsNV[i].MaNV, dsNV[i].HoTen, dsNV[i].GT, dsNV[i].CMND, dsNV[i].SDT, dsNV[i].TT_LamViec, dsNV[i].MatKhau, dsNV[i].QuanLi);
                }

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            for (int i = hang; i < dgvNhanVien.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgvNhanVien.Rows[i];
                if (row.Cells[1].Value.ToString().Contains(txtFind.Text))
                {
                    dgvNhanVien.ClearSelection();
                    row.Selected = true;
                    dgvNhanVien.FirstDisplayedScrollingRowIndex = i;
                    hang = ++i;
                    if (i >= dgvNhanVien.Rows.Count - 2)
                        hang = 0;
                    break;
                }
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
