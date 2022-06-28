using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TVP_projekat1.Models;

namespace TVP_projekat1
{
    public partial class FrmGuest : Form
    {
        List<Guest> listaGostiju = new List<Guest>();
        string imeDatoteke = "gost";
        public int guestID;

        public FrmGuest()
        {
            InitializeComponent();
            //Guest gost = new Guest();
            //gost.Guest_Name = "Nikola";
            //listaGostiju.Add(gost);


            Console.WriteLine(listaGostiju.Count);
            dateTimePicker1.MaxDate = DateTime.Now;
            FileStream tok = File.Open(imeDatoteke, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            listaGostiju = bf.Deserialize(tok) as List<Guest>;
            tok.Dispose();

            Console.WriteLine(listaGostiju.Count);

            dataGridView1.DataSource = listaGostiju;


            FileStream tok2 = File.Open("GuestId", FileMode.OpenOrCreate);
            BinaryFormatter bf2 = new BinaryFormatter();
            string temp = bf2.Deserialize(tok2) as string;
            Console.WriteLine(temp);
            tok2.Dispose();
            guestID = int.Parse(temp);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Guest gost = new Guest();

            //provera uslova
            
            bool checkIfAllNumbers = txtPhone.Text.Trim().All(char.IsDigit);
            if (txtName.Text.Trim().Length > 0 && Regex.IsMatch(txtName.Text, @"\d") == false
                && txtSurname.Text.Trim().Length > 0 && Regex.IsMatch(txtSurname.Text, @"\d") == false
                && txtBday.Text.Trim().Length > 0
                && txtPhone.Text.Trim().Length > 0 && txtPhone.Text.Trim().Length < 12 && checkIfAllNumbers)
            {
                //dodaje gosta u dvg i serijalizuje ako su uslovi ispunjeni
                gost.Guest_Name = txtName.Text.Trim();
                gost.Guest_Surname = txtSurname.Text.Trim();
                gost.Guest_Birthday = txtBday.Text.Trim();
                gost.Guest_Phone = txtPhone.Text.Trim();
                gost.Guest_Id = guestID;

                guestID++;
                listaGostiju.Add(gost);
                //serilizacije
                GuestIdSerialization();
                GuestSerilization();

                //dodaje u dgv
                BindingList<Guest> bindingList = new BindingList<Guest>(listaGostiju);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                txtPhone.Text = txtName.Text = txtSurname.Text = txtBday.Text = "";
                MessageBox.Show("Guest added!");

            }

            else MessageBox.Show("One or more fields are incorrect! Try again.");


        }

        private void FrmGuest_Load(object sender, EventArgs e)
        {

        }

        //serilizuje id gosta
        public void GuestIdSerialization()
        {

            FileStream tok = File.Open("GuestId", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(tok, guestID.ToString());

            tok.Dispose();
        }

        //seriluje goste
        public void GuestSerilization()
        {
            FileStream tok = File.Open(imeDatoteke, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(tok, listaGostiju);

            tok.Dispose();
        }

        //vreme u txtbox
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtBday.Text = dateTimePicker1.Text;
        }

        //selekcija gosta za izmenu
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "guest_id";
            foreach (Guest guest in listaGostiju)
            {
                if (dataGridView1.CurrentRow.Index != -1
                    && guest.Guest_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["guest_id"].Value))
                {
                    txtName.Text = guest.Guest_Name;
                    txtSurname.Text = guest.Guest_Surname;
                    txtBday.Text = guest.Guest_Birthday;
                    txtPhone.Text = guest.Guest_Phone;



                }
            }

            btnAdd.Visible = false;
            btnDelete.Visible = true;

            btnUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool checkIfAllNumbers = txtPhone.Text.Trim().All(char.IsDigit);

            dataGridView1.Columns[0].Name = "guest_id";
            var filteredGuest = listaGostiju.Where(guest => guest.Guest_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["guest_id"].Value));
            foreach (Guest guest in filteredGuest)
            {

                if (txtName.Text.Trim().Length > 0 && Regex.IsMatch(txtName.Text, @"\d") == false
                    && txtSurname.Text.Trim().Length > 0 && Regex.IsMatch(txtSurname.Text, @"\d") == false
                    && txtBday.Text.Trim().Length > 0
                    && txtPhone.Text.Trim().Length > 0 && txtPhone.Text.Trim().Length < 12 && checkIfAllNumbers)
                {
                    guest.Guest_Name = txtName.Text.Trim();
                    guest.Guest_Surname = txtSurname.Text.Trim();
                    guest.Guest_Birthday = txtBday.Text.Trim();
                    guest.Guest_Phone = txtPhone.Text.Trim();
                    GuestSerilization();

                    BindingList<Guest> bindingList = new BindingList<Guest>(listaGostiju);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    txtPhone.Text = txtName.Text = txtSurname.Text = txtBday.Text = "";
                    MessageBox.Show("Guest updated!");

                    btnAdd.Visible = true;
                    btnDelete.Visible = false;

                    btnUpdate.Visible = false;
                }

                else MessageBox.Show("One or more fields are incorrect! Try again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "guest_id";
            for (int i = 0; i < listaGostiju.Count; i++)
            {
                if (listaGostiju[i].Guest_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["guest_id"].Value))
                {
                    listaGostiju.RemoveAt(i);
                    MessageBox.Show("Guest Deleted");
                }

                
                BindingList<Guest> bindingList = new BindingList<Guest>(listaGostiju);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

                GuestSerilization();

                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmMain"];
            frm.Show();
            Close();
        }
    }
}
