using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TVP_projekat1.Models;
using System.Json;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace TVP_projekat1
{
    public partial class FrmMain : Form
    {
        List<User> listOfUsers = new List<User>();
        public static bool formisOn = false;

        int userid;
        public static string fileName = "Usersjson";


        //deserializacija i punjenje dgv
        public FrmMain()
        {
            
            
            
            // Deserializacija userjson
            InitializeComponent();
            FileStream tok = File.Open(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            listOfUsers = bf.Deserialize(tok) as List<User>;

            tok.Dispose();

            //Punjenje dgv-a
            dgvUpdate();

           // Deserializacija userid-ja

            FileStream tok2 = File.Open("UserId", FileMode.OpenOrCreate);
            BinaryFormatter bf2 = new BinaryFormatter();
            string temp = bf2.Deserialize(tok2) as string;
            Console.WriteLine(temp);
            tok2.Dispose();
            userid = int.Parse(temp);


        }


        //
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //trebalo samo prvi put da ucita
            //userid = 100;
            //FileStream tok = File.Open("UserId", FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(tok, userid.ToString());

            //tok.Dispose();

        }

        //Klik na dugme Add, odradjuje proveru tacnosti unetih podataka i dodaje ih u dvg,cuvanje u datoteku se radi odvojeno
        private void button1_Click(object sender, EventArgs e)
        {
            //kreira objekat i dodaje ga u listu ako su svi uslovi ispunjenji
            User user = new User();

            //Name
            if (txtUserName.Text != "" && txtUserName.Text.Trim().Length > 2 && Regex.IsMatch(txtUserName.Text, @"\d") == false)
            {
                user.Name = txtUserName.Text.Trim();
            }

            else 
            {
                
                txtUserName.Text = "";
                txtUserName.Focus();
                return;
            }

            //Surname
            if (txtUserSurname.Text != "" && txtUserSurname.Text.Trim().Length > 2 && Regex.IsMatch(txtUserSurname.Text, @"\d") == false)
            {
                user.Surname = txtUserSurname.Text.Trim();
            }

            else
            {
                txtUserSurname.Text = "";
                txtUserName.Focus();
                return;
            }

            //username
            if (txtUserUsername.Text.Trim() != "" && txtUserUsername.Text.Trim().Length > 6)
            {
                user.Username = txtUserUsername.Text.Trim();
            }

            else
            {
                txtUserUsername.Text = "";
                txtUserName.Focus();
                return;
            }

            //password
            if (txtUserPassword.Text.Trim() != "" && txtUserPassword.Text.Trim().Length > 6)
            {
                user.Password = txtUserPassword.Text.Trim();
            }

            else
            {
                txtUserPassword.Text = "";
                txtUserName.Focus();
                return;
            }

            //tip

            if (txtUserType.Text.Trim().ToLower() == "admin" || txtUserType.Text.Trim().ToLower() == "korisnik")
            {
                user.Type = txtUserType.Text.Trim().ToLower();
            }

            else
            {
                txtUserType.Text = "";
                txtUserName.Focus();
                return;
            }
            
            //User ID
            user.User_Id = userid;

            userid += 1;

            //dodajemo u listu
            listOfUsers.Add(user);

            // da se updajtuje dgv
            dgvUpdate();

            //poruka za korisnika
            MessageBox.Show("Korisnik " + user.ToString() + " je dodat u tabelu");
            txtUserName.Text = txtUserSurname.Text = txtUserUsername.Text = txtUserPassword.Text = txtUserType.Text = "";
            txtUserName.Focus();

        }


        //serijalizacija i cuvanje u datoteku na klik dugmeta Save
        private void button1_Click_1(object sender, EventArgs e)
        {
            Serijalizacija();
            MessageBox.Show("All changes are saved!");

        }


        //Za Update, prebacuje sve podatke o useru u textbox i postavlja vidljivost dugmica
        private void dgvUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (User user in listOfUsers)
            {
                // proverava Id i popunjava textboxove
                if (dgvUser.CurrentRow.Index !=-1 
                    && user.User_Id == Convert.ToInt32(dgvUser.CurrentRow.Cells["userIdDataGridViewTextBoxColumn"].Value))
                {
                    txtUserName.Text = user.Name;
                    txtUserSurname.Text = user.Surname;
                    txtUserUsername.Text = user.Username;
                    txtUserPassword.Text = user.Password;
                    txtUserType.Text = user.Type;

                    txtUserName.Focus();
                } 
                //vidljivost dugmica
                btnAddUser.Visible = false;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //cuva id u datoteci
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream tok = File.Open("UserId", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(tok, userid.ToString()) ;

            tok.Dispose();
        }

        //Na klik dugmeta za update cuva sve izmenjene podatke ako su korektni
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var filteredUsers = listOfUsers.Where(user => user.User_Id == Convert.ToInt32(dgvUser.CurrentRow.Cells["userIdDataGridViewTextBoxColumn"].Value));
            foreach (User user in filteredUsers)
            {
                //Name
                if (txtUserName.Text != "" && txtUserName.Text.Trim().Length > 2 && Regex.IsMatch(txtUserName.Text, @"\d") == false)
                {
                    user.Name = txtUserName.Text.Trim();
                }

                else
                {

                    txtUserName.Text = "";
                    txtUserName.Focus();
                    return;
                }

                //Surname
                if (txtUserSurname.Text != "" && txtUserSurname.Text.Trim().Length > 2 && Regex.IsMatch(txtUserSurname.Text, @"\d") == false)
                {
                    user.Surname = txtUserSurname.Text.Trim();
                }

                else
                {
                    txtUserSurname.Text = "";
                    txtUserName.Focus();
                    return;
                }

                //username
                if (txtUserUsername.Text.Trim() != "" && txtUserUsername.Text.Trim().Length > 6)
                {
                    user.Username = txtUserUsername.Text.Trim();
                }

                else
                {
                    txtUserUsername.Text = "";
                    txtUserName.Focus();
                    return;
                }

                //password
                if (txtUserPassword.Text.Trim() != "" && txtUserPassword.Text.Trim().Length > 6)
                {
                    user.Password = txtUserPassword.Text.Trim();
                }

                else
                {
                    txtUserPassword.Text = "";
                    txtUserName.Focus();
                    return;
                }

                //tip

                if (txtUserType.Text.Trim().ToLower() == "admin" || txtUserType.Text.Trim().ToLower() == "korisnik")
                {
                    user.Type = txtUserType.Text.Trim().ToLower();
                }

                else
                {
                    txtUserType.Text = "";
                    txtUserName.Focus();
                    return;
                }
            }//end for each

            Serijalizacija();

            MessageBox.Show("Updated!");
            //resetuje textbox
            
           txtUserName.Text = txtUserSurname.Text = txtUserUsername.Text = txtUserPassword.Text = txtUserType.Text = "";

            //vidljivost dugmica
            btnVisibilitySet();
            txtUserName.Focus();


            dgvUpdate();


        }

        // brise izabranog user-a;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //prolazi kroz petlju da nadje sta brisemo
            for (int i = 0; i < listOfUsers.Count; i++)
            {
                if (listOfUsers[i].User_Id == Convert.ToInt32(dgvUser.CurrentRow.Cells["userIdDataGridViewTextBoxColumn"].Value))
                {
                    listOfUsers.RemoveAt(i);
                }
            }

            dgvUpdate();
            btnVisibilitySet();
            MessageBox.Show("User deleted!");

        }

        // updajtuje dgv
        public void dgvUpdate()
        {
            BindingList<User> bindingList = new BindingList<User>(listOfUsers);
            var source = new BindingSource(bindingList, null);
            dgvUser.DataSource = source;
        }

        //postavlja vidljivost dugmeta
        public void btnVisibilitySet()
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAddUser.Visible = true;
            btnSave.Visible = true;
        }

        // user serilizacija
        public void Serijalizacija()
        {
            FileStream tok = File.Open(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(tok, listOfUsers);
            
            tok.Dispose();
        }

        private void btnGuestOpen_Click(object sender, EventArgs e)
        {
            
            
            FrmGuest formguest = new FrmGuest();
            formguest.Show();
            Hide();
        }

        private void btnRoomOpen_Click(object sender, EventArgs e)
        {
            FrmRoom rm = new FrmRoom();
            rm.Show();
            Hide();
        }

        private void btnReservationOpen_Click(object sender, EventArgs e)
        {
            formisOn = true;
            FrmReservation fr = new FrmReservation();
            fr.Show();
            
            Hide();
        }
    }
}
