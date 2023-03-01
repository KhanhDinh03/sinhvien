using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinhvien
{
    public partial class Form1 : Form
    {
        int dongdangchon;
        string gioitinh = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu vừa nhập trên form đưa vào datagridview
            if (rb_nam.Checked)
            {
                gioitinh = rb_nam.Text;
            }else if (rb_nu.Checked)
            {
                gioitinh = rb_nu.Text;
            }
            dataGridView_dssv.Rows.Add(tb_msv.Text, tb_ht.Text, dt_ns.Text, gioitinh, cb_qq.Text, cb_k.Text, cb_l.Text);
            Reset();
        }

        private void Reset()
        {
            tb_ht.Clear();
            tb_msv.Clear();
            dt_ns.ResetText();
            cb_k.ResetText();
            cb_l.ResetText();
            cb_qq.ResetText();
            tb_msv.Focus();
        }

        private void dataGridView_dssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // xác định dòng đang chọn
            dongdangchon = e.RowIndex;

            // lấy dữ liệu từ dòng đang chọn lên form
            tb_msv.Text = dataGridView_dssv.Rows[dongdangchon].Cells[0].Value.ToString();
            tb_ht.Text = dataGridView_dssv.Rows[dongdangchon].Cells[1].Value.ToString();
            dt_ns.Text = dataGridView_dssv.Rows[dongdangchon].Cells[2].Value.ToString();
            if (dataGridView_dssv.Rows[dongdangchon].Cells[3].Value.ToString() == "Nam")
            {
                rb_nam.Enabled = true;
            }
            else if (dataGridView_dssv.Rows[dongdangchon].Cells[3].Value.ToString() == "Nu")
            {
                rb_nu.Enabled = true;
            }
            cb_qq.Text = dataGridView_dssv.Rows[dongdangchon].Cells[4].Value.ToString();
            cb_k.Text = dataGridView_dssv.Rows[dongdangchon].Cells[5].Value.ToString();
            cb_l.Text = dataGridView_dssv.Rows[dongdangchon].Cells[6].Value.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            // thực hiện việc sửa dữ liệu bằng cách lấy dữ liệu trên form lại về các dòng để sửa
                dataGridView_dssv.Rows[dongdangchon].Cells[0].Value = tb_msv.Text;
                dataGridView_dssv.Rows[dongdangchon].Cells[1].Value = tb_ht.Text;
                dataGridView_dssv.Rows[dongdangchon].Cells[2].Value = dt_ns.Text;
                if (rb_nam.Checked)
                {
                    dataGridView_dssv.Rows[dongdangchon].Cells[3].Value = rb_nam.Text;
                }
                else if (rb_nu.Checked)
                {
                    dataGridView_dssv.Rows[dongdangchon].Cells[3].Value = rb_nu.Text;
                }
                dataGridView_dssv.Rows[dongdangchon].Cells[4].Value = cb_qq.Text;
                dataGridView_dssv.Rows[dongdangchon].Cells[5].Value = cb_k.Text;
                dataGridView_dssv.Rows[dongdangchon].Cells[6].Value = cb_l.Text;
        }
    }
}
