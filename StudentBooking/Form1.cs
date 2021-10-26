using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using advanceEnterface;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;

namespace StudentBooking
{
   
    public partial class Form1 : Form
    {
        DataSet dSet = new DataSet();
        OleDbCommand command;
        MemoryStream mStream;
        BindingManagerBase bindBase;
        DataTable dTable;

        public Form1()
        {
            InitializeComponent();
            Program.con.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Program.dataAdep = new OleDbDataAdapter("select * from Collages", Program.con);
            Program.dataAdep.Fill(dSet, "collage");
            Program.bindingSource = new BindingSource(dSet, "collage");
            cmbCollage.DataSource = Program.bindingSource;
            cmbCollage.ValueMember = "collage_id";
            cmbCollage.DisplayMember = "collage";
            Program.dataAdep1 = new OleDbDataAdapter("select * from  Department", Program.con);
            Program.dataAdep1.Fill(dSet, "dept");
            dSet.Relations.Add("collageWithDept",
                dSet.Tables["collage"].Columns["collage_id"],
                dSet.Tables["dept"].Columns["collage_Id"]
                );
            Program.bindingSource1 = new BindingSource(Program.bindingSource, "collageWithDept");
            cmbDepartment.DataSource = Program.bindingSource1;
            cmbDepartment.ValueMember = "dept_Id";
            cmbDepartment.DisplayMember = "dept_name";
            cmbDepartment.DataSource = Program.bindingSource1;
            loadData();
        }
        private void cmbCollage_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = Program.bindingSource1;
            cmbDepartment.ValueMember = "dept_Id";
            cmbDepartment.DisplayMember = "dept_name";
        }

        private void ehabBUttons10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //drag form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn= new OpenFileDialog();
            opn.Filter= "Image files(*.jpg; *.jpeg; *.png; *.bmp)| *.jpg; *.jpeg; *.png; *.bmp";
            if(opn.ShowDialog()==DialogResult.OK)
            {
                
                photo.Image =new Bitmap(opn.FileName);
            }
        }

       

        private void ehabTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumber(e);
        }

        private void ehabTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumber(e);
        }

        private void ehabTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumber(e);
        }

        private void ehabTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumber(e);
        }

        //private method
        protected void isNumber(KeyPressEventArgs e)
        {
            if (!((e.KeyChar <= '9' && e.KeyChar >= '0') || e.KeyChar == 8))
                e.Handled = true;
        }
        void jpgimge()
        {
            mStream = new MemoryStream();
            photo.Image.Save(mStream,ImageFormat.Jpeg);
            mStream.ToArray();
        }
        void loadData()
        {
            Program.stuDataAdep = new OleDbDataAdapter("select * from Student", Program.con);
            Program.stuDataAdep.Fill(dSet, "stud");
            DataColumn[] depart = new DataColumn[2];
            depart[0] = dSet.Tables["dept"].Columns["dept_id"];
            depart[1] = dSet.Tables["dept"].Columns["collage_id"];
            DataColumn[] student = new DataColumn[2];
            student[0] = dSet.Tables["stud"].Columns["dept_id"];
            student[1]= dSet.Tables["stud"].Columns["collage_id"];
            dSet.Relations.Add("stuWithDeptColl",depart, student);
            Program.stuBindingSource = new BindingSource(Program.bindingSource1, "stuWithDeptColl");
            txtID.DataBindings.Add("Texts", Program.stuBindingSource, "stu_id");
            txtName.DataBindings.Add("Texts", Program.stuBindingSource, "stu_name");
            txtCardID.DataBindings.Add("Texts", Program.stuBindingSource, "stu_cardNumber");
            male.DataBindings.Add("Checked", Program.stuBindingSource, "gender");
            txtNational.DataBindings.Add("Texts", Program.stuBindingSource, "nationalty");
            txtPlaceOFPirth.DataBindings.Add("Texts", Program.stuBindingSource, "birth_place");
            dateTimeOfPirth.DataBindings.Add("text", Program.stuBindingSource, "briyh_date",true);
            txtAddrees.DataBindings.Add("Texts", Program.stuBindingSource, "address");
            txtPhone.DataBindings.Add("Texts", Program.stuBindingSource, "phone");
            txtGraduate.DataBindings.Add("Texts", Program.stuBindingSource, "graduate");
            txtAvrage.DataBindings.Add("Texts", Program.stuBindingSource, "avrage");
            dateTimeBooking.DataBindings.Add("text", Program.stuBindingSource, "book_date",true);
            photo.DataBindings.Add("Image", Program.stuBindingSource, "photo",true);
          
          //  bindBase = this.BindingContext[Program.stuBindingSource];
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Texts = null;
            txtName.Focus();
            txtCardID.Texts = "";
            txtNational.Texts = "";
            txtAddrees.Texts = "";
            txtPlaceOFPirth.Texts = "";
            txtGraduate.Texts = "";
            txtAvrage.Texts = "";
            txtID.Texts = "";
            photo.Image = null;
            txtPhone.Texts = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {

                jpgimge();
                 command = new OleDbCommand("", Program.con);
                 command.Parameters.AddWithValue("@id", txtID.Texts);
                 command.Parameters.AddWithValue("@card_num", txtCardID.Texts);
                 command.Parameters.AddWithValue("@name", txtName.Texts);
                 command.Parameters.AddWithValue("@sex", male.Checked);
                 command.Parameters.AddWithValue("@nati", txtNational.Texts);
                 command.Parameters.AddWithValue("@place", txtPlaceOFPirth.Texts);
                 command.Parameters.AddWithValue("@birth", dateTimeOfPirth.Value.ToOADate());
                 command.Parameters.AddWithValue("@add", txtAddrees.Texts);
                 command.Parameters.AddWithValue("@phone", txtPhone.Texts);
                 command.Parameters.AddWithValue("@grad", txtGraduate.Texts);
                 command.Parameters.AddWithValue("@avr", txtAvrage.Texts);
                 command.Parameters.AddWithValue("@book", dateTimeBooking.Value.ToOADate());
                 command.Parameters.AddWithValue("@Photo", mStream);

                // command.Parameters.AddWithValue("@dept", cmbDepartment.SelectedIndex);
                command.CommandText = "insert into Student(stu_id,stu_cardNumber,stu_name,gender,nationalty,birth_place,briyh_date,address,phone,graduate,avrage,book_date,photo)"
                   + "values(@id,@card_num,@name,@sex,@nati,@place,@birth,@add,@phone,@grad,@avr,@book,@Photo)";
                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtID.Texts == ""))
                {
                    command = new OleDbCommand("delete from Student where stu_id=" + txtID.Texts + "", Program.con);
                    command.ExecuteNonQuery();
                }
                else
                    MessageBox.Show( "ادخل رقم الطالب", "عذرأ");

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Program.stuBindingSource.MoveFirst();
        }

        private void ehabBUttons7_Click(object sender, EventArgs e)
        {
            if (bindBase.Position < bindBase.Count - 1)
                bindBase.Position++;
            else
                MessageBox.Show("اخر سجل");

        }

        private void ehabBUttons8_Click(object sender, EventArgs e)
        {
            if (bindBase.Position > 0)
                bindBase.Position--;
            else
                MessageBox.Show("اول سجل");
        }

        private void ehabBUttons9_Click(object sender, EventArgs e)
        {
            bindBase.Position = bindBase.Count - 1;        }
    }
}
