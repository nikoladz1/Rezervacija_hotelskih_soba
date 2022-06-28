using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using TVP_projekat1.Models;

namespace TVP_projekat1
{
    public partial class FrmLogIn : Form
    {
        List<User> listOfUsers = new List<User>();
        public static bool UserSuccessfullyAuthenticatedAsAdmin = false;
        public static bool UserSuccessfullyAuthenticatedAsKorisnik = false;

        public FrmLogIn()
        {
            InitializeComponent();
            FileStream tok = File.Open(FrmMain.fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            listOfUsers = bf.Deserialize(tok) as List<User>;

            //for (int i = 0; i < listOfUsers.Count; i++)
            //{
            //    Console.WriteLine( listOfUsers[i].Username);
            //    Console.WriteLine(listOfUsers[i].Password);
            //}
            tok.Dispose();
            txtUsername.Focus();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = TxtPassword.Text.Trim();
            int brojac = 0;
            for (int i = 0; i < listOfUsers.Count; i++)
            {
                if (listOfUsers[i].Username == username && listOfUsers[i].Password == password)
                {
                    if (listOfUsers[i].Type == "admin")
                    {
                        brojac++;
                        UserSuccessfullyAuthenticatedAsAdmin = true;
                        Close();
                        
                    }




                    if (listOfUsers[i].Type == "korisnik")
                    {
                        brojac++;
                       UserSuccessfullyAuthenticatedAsKorisnik = true;
                        Close();
                    }   

                }


            }

            if (brojac == 0)
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
