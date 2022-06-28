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
    public partial class FrmReservation : Form
    {
        List<Reservation> listaRezervacija = new List<Reservation>();
        List<Guest> listaGostiju = new List<Guest>();
        List<Room> listaSoba = new List<Room>();
        int selecteditem = 0;
        List<Reservation> Rez2 = new List<Reservation>();
        List<Reservation> Rez3 = new List<Reservation>();
        List<Room> filter = new List<Room>();


        public FrmReservation()
        {
            InitializeComponent();


            dateTimePickerStart.MinDate = DateTime.Today;
            dateTimePickerEnd.MinDate = DateTime.Today;
            FileStream tokic = File.Open("rezervacija", FileMode.OpenOrCreate);
            BinaryFormatter bfic = new BinaryFormatter();
            listaRezervacija = bfic.Deserialize(tokic) as List<Reservation>;
            tokic.Dispose();
            dataGridView1.DataSource = listaRezervacija;


            FileStream tok = File.Open("soba", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            listaSoba = bf.Deserialize(tok) as List<Room>;
            tok.Dispose();

            FileStream tok1 = File.Open("gost", FileMode.OpenOrCreate);
            BinaryFormatter bf1 = new BinaryFormatter();
            listaGostiju = bf1.Deserialize(tok1) as List<Guest>;
            tok1.Dispose();
            int counter=0;

            
            for (int i = 0; i < listaSoba.Count(); i++)
            {
                    
                    var filteredRes = listaRezervacija.Where(rez => rez.Room_Id == listaSoba[i].Room_Id);
                foreach (Reservation rez in filteredRes)
                {
                    Rez2.Add(rez);
                }

            }

            dataGridView1.DataSource = Rez2 ;

            foreach (Room soba in listaSoba)
            {
                cbRoom.Items.Add(soba.Room_Id.ToString());
            }

            foreach (Room soba in listaSoba)
            {
                comboBox1.Items.Add(soba.Room_Type.ToString());
            }

            foreach (Guest gost in listaGostiju)
            {
                cbGuest.Items.Add(gost.Guest_Id.ToString());
            }

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            Console.WriteLine(FrmMain.formisOn);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //dupli klik na dgv za izmenu unesenih podataka
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].Name = "res_id";
            foreach (Reservation rez in listaRezervacija)
            {
                if (dataGridView1.CurrentRow.Index != -1
                    && rez.Res_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["res_id"].Value))
                {
                    cbRoom.SelectedItem = rez.Room_Id.ToString();
                    cbGuest.SelectedItem = rez.Guest_Id.ToString();
                    txtDayStart.Text = rez.Res_Start;
                    txtDayEnd.Text = rez.Res_End;
                    cbResType.SelectedItem = rez.Res_Type;
                    txtTotalPrice.Text = rez.Res_Total_Price;

                    btnAdd.Visible = false;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;

                }
            }
        }

        //info o gostima u veliki txtbox
        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredRoom = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
            foreach (Room room in filteredRoom)
            {
                textBox1.Text = room.ToString();
            }
        }

        //informacije o gostu u veliki tekstbox
        private void cbGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredGuest = listaGostiju.Where(gost => gost.Guest_Id == int.Parse(cbGuest.SelectedItem.ToString()));
            foreach (Guest gost in filteredGuest)
            {
                textBox2.Text = gost.ToString();
            }
        }

        //iz dtp u textbox
        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            txtDayStart.Text = dateTimePickerStart.Text;
        }

        //iz dtp u textbox
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            txtDayEnd.Text = dateTimePickerEnd.Text;
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        //dodavanje cene u textbox na klik
        //private void cbResType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int cenaSobe = 0;
        //    int popust = 0;
        //    try
        //    {
        //        if (cbRoom.SelectedItem == null)
        //        {

        //            MessageBox.Show("Chose room first1");
        //            return;
        //        }

        //        var filteredRoom = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
        //        foreach (Room room in filteredRoom)
        //        {
        //            cenaSobe = int.Parse(room.Room_Price);
        //            popust = int.Parse(room.Room_Price_Off);
        //        }
        //        DateTime d1 = dateTimePickerStart.Value;
        //        DateTime d2 = dateTimePickerEnd.Value;
        //        double brojDana = (d2 - d1).TotalDays;
        //        int tipCena = 0;
        //        if (cbResType.SelectedItem.ToString() == "Pansion") tipCena = 1000;
        //        if (cbResType.SelectedItem.ToString() == "Polu-pansion") tipCena = 700;
        //        if (cbResType.SelectedItem.ToString() == "Samo Dorucak") tipCena = 500;

        //        double ukupnaCena = ((cenaSobe + tipCena) * brojDana) * (1 - (popust / 100));

                

        //        selecteditem++;
        //    }

        //    catch (NullReferenceException)
        //    {

        //        MessageBox.Show("Error");
        //        return;
        //    }


        //}

        //Dodavanje cene
        //private void FrmReservation_Click(object sender, EventArgs e)
        //{
        //    if (selecteditem > 0)
        //    {
        //        int cenaSobe = 0;
        //        int popust = 0;
        //        var filteredRoom = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
        //        foreach (Room room in filteredRoom)
        //        {
        //            cenaSobe = int.Parse(room.Room_Price);
        //            popust = int.Parse(room.Room_Price_Off);
        //        }
        //        DateTime d1 = dateTimePickerStart.Value;
        //        DateTime d2 = dateTimePickerEnd.Value;
        //        double brojDana = (d2 - d1).TotalDays;
        //        int tipCena = 0;
        //        if (cbResType.SelectedItem.ToString() == "Pansion") tipCena = 1000;
        //        if (cbResType.SelectedItem.ToString() == "Polu-pansion") tipCena = 700;
        //        if (cbResType.SelectedItem.ToString() == "Samo Dorucak") tipCena = 500;

        //        double ukupnaCena = ((cenaSobe + tipCena) * brojDana) * (1 - (popust / 100));

        //        txtTotalPrice.Text = ukupnaCena.ToString();

        //    }
        //}

        //DODAVANJE
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ///USLOVI
            if (cbRoom.SelectedItem == null)
            {
                MessageBox.Show("Choose room ID first!");
                return;
            }
            //broj kreveta provera
            int brojRezervisanih = 0;
            int brojKreveta = 0;

            var filteredRoom2 = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
            foreach (Room room in filteredRoom2) brojKreveta = int.Parse(room.Room_Beds);

            var filteredRes = listaRezervacija.Where(rez => rez.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
            foreach (Reservation rez in filteredRes) brojRezervisanih++;
            if (brojRezervisanih >= brojKreveta)
            {
                MessageBox.Show("No more beds in this room");
                return;
            }

            if (cbGuest.SelectedItem == null)
            {
                MessageBox.Show("Enter guest ID");
                return;
            }

            if (txtDayStart.Text == "")
            {
                MessageBox.Show("Enter Start Day");
                return;
            }


            if (txtDayEnd.Text == "")
            {
                MessageBox.Show("Enter End Day");
                return;
            }

            DateTime d1 = dateTimePickerStart.Value;
            DateTime d2 = dateTimePickerEnd.Value;

            if (d1 >= d2)
            {
                MessageBox.Show("Incorrect Dates");
                return;
            }

            var filteredRoom = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
            foreach (Room room in filteredRoom)
            {
                double brojDana1 = (d2 - d1).TotalDays;
                if (brojDana1 < double.Parse(room.Room_Min_Days))
                {
                    MessageBox.Show("Number of days chosen is less than minimum");
                    return;
                }
            }

            if (cbResType.SelectedItem == null)
            {
                MessageBox.Show("Chose Reservation Type");
                return;
            }

            ////KRAJ USLOVA
            ///
            int cenaSobe = 0;
            int popust = 0;
            var filteredRoom3 = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
            foreach (Room room in filteredRoom3)
            {
                cenaSobe = int.Parse(room.Room_Price);
                popust = int.Parse(room.Room_Price_Off);
            }
            DateTime d11 = dateTimePickerStart.Value;
            DateTime d22 = dateTimePickerEnd.Value;
            double brojDana = (d22 - d11).TotalDays;
            int tipCena = 0;
            if (cbResType.SelectedItem.ToString() == "Pansion") tipCena = 1000;
            if (cbResType.SelectedItem.ToString() == "Polu-pansion") tipCena = 700;
            if (cbResType.SelectedItem.ToString() == "Samo Dorucak") tipCena = 500;

            double ukupnaCena = ((cenaSobe + tipCena) * brojDana) * (1 - (popust / 100));

            txtTotalPrice.Text = ukupnaCena.ToString();

            Reservation rzv = new Reservation();
            rzv.Res_Id = listaRezervacija[listaRezervacija.Count - 1].Res_Id + 1;
            rzv.Room_Id = int.Parse(cbRoom.SelectedItem.ToString());
            rzv.Guest_Id = int.Parse(cbGuest.SelectedItem.ToString());
            rzv.Res_Start = txtDayStart.Text;
            rzv.Res_End = txtDayEnd.Text;
            rzv.Res_Type = cbResType.SelectedItem.ToString();
            rzv.Res_Total_Price = ((decimal)ukupnaCena).ToString();

            listaRezervacija.Add(rzv);

            FileStream tokic = File.Open("rezervacija", FileMode.OpenOrCreate);
            BinaryFormatter bfic = new BinaryFormatter();
            bfic.Serialize(tokic, listaRezervacija);

            tokic.Dispose();

            //dodaje u dgv
            BindingList<Reservation> bindingList = new BindingList<Reservation>(Rez2);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            MessageBox.Show("Reservation Added");



        }


        //UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "res_id";
            var filteredRes = listaRezervacija.Where(rez => rez.Res_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["res_id"].Value));
            foreach (Reservation rzv in filteredRes)
            {
                ///USLOVI
                if (cbRoom.SelectedItem == null)
                {
                    MessageBox.Show("Choose room ID first!");
                    return;
                }
                //broj kreveta provera
                int brojRezervisanih = 0;
                int brojKreveta = 0;

                var filteredRoom2 = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
                foreach (Room room in filteredRoom2) brojKreveta = int.Parse(room.Room_Beds);

                var filteredRes1 = listaRezervacija.Where(rez => rez.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
                foreach (Reservation rez in filteredRes1) brojRezervisanih++;
                if (brojRezervisanih >= brojKreveta +1)
                {
                    MessageBox.Show("No more beds in this room");
                    return;
                }

                if (cbGuest.SelectedItem == null)
                {
                    MessageBox.Show("Enter guest ID");
                    return;
                }

                if (txtDayStart.Text == "")
                {
                    MessageBox.Show("Enter Start Day");
                    return;
                }


                if (txtDayEnd.Text == "")
                {
                    MessageBox.Show("Enter End Day");
                    return;
                }

                DateTime d1 = dateTimePickerStart.Value;
                DateTime d2 = dateTimePickerEnd.Value;

                if (d1.Date >= d2.Date)
                {
                    MessageBox.Show("Incorrect Dates");
                    return;
                }

                var filteredRoom = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
                foreach (Room room in filteredRoom)
                {
                    double brojDana1 = (d2 - d1).TotalDays;
                    if (brojDana1 < double.Parse(room.Room_Min_Days))
                    {
                        MessageBox.Show("Number of days chosen is less than minimum");
                        return;
                    }
                }

                if (cbResType.SelectedItem == null)
                {
                    MessageBox.Show("Chose Reservation Type");
                    return;
                }

                ////KRAJ USLOVA
                ///
                int cenaSobe = 0;
                int popust = 0;
                var filteredRoom3 = listaSoba.Where(soba => soba.Room_Id == int.Parse(cbRoom.SelectedItem.ToString()));
                foreach (Room room in filteredRoom3)
                {
                    cenaSobe = int.Parse(room.Room_Price);
                    popust = int.Parse(room.Room_Price_Off);
                }
                DateTime d11 = dateTimePickerStart.Value;
                DateTime d22 = dateTimePickerEnd.Value;
                double brojDana = (d22 - d11).TotalDays;
                int tipCena = 0;
                if (cbResType.SelectedItem.ToString() == "Pansion") tipCena = 1000;
                if (cbResType.SelectedItem.ToString() == "Polu-pansion") tipCena = 700;
                if (cbResType.SelectedItem.ToString() == "Samo Dorucak") tipCena = 500;

                double ukupnaCena = ((cenaSobe + tipCena) * brojDana) * (1 - (popust / 100));

                txtTotalPrice.Text = ukupnaCena.ToString();



                rzv.Room_Id = int.Parse(cbRoom.SelectedItem.ToString());
                rzv.Guest_Id = int.Parse(cbGuest.SelectedItem.ToString());
                rzv.Res_Start = txtDayStart.Text;
                rzv.Res_End = txtDayEnd.Text;
                rzv.Res_Type = cbResType.SelectedItem.ToString();
                rzv.Res_Total_Price = ((decimal)ukupnaCena).ToString();

                FileStream tokic = File.Open("rezervacija", FileMode.OpenOrCreate);
                BinaryFormatter bfic = new BinaryFormatter();
                bfic.Serialize(tokic, listaRezervacija);

                tokic.Dispose();

                //dodaje u dgv
                BindingList<Reservation> bindingList = new BindingList<Reservation>(Rez2);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

                MessageBox.Show("Reservation Updated");

                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        //BRISANJE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "res_id";
            for (int i = 0; i < listaRezervacija.Count; i++)
            {
                if (listaRezervacija[i].Res_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["res_id"].Value))
                {
                    listaRezervacija.RemoveAt(i);
                    MessageBox.Show("Reservation Deleted");
                }



            }
            BindingList<Reservation> bindingList = new BindingList<Reservation>(listaRezervacija);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            FileStream tokic = File.Open("rezervacija", FileMode.OpenOrCreate);
            BinaryFormatter bfic = new BinaryFormatter();
            bfic.Serialize(tokic, listaRezervacija);

            tokic.Dispose();

            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;


        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            if (FrmMain.formisOn)
            {
                Button btn = new Button();
                btn.Text = "Back";
                btn.Width = 50;
                btn.Height = 20;
                btn.Left = ClientSize.Width - 70;
                btn.Top = 20;
                Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmMain"];
            frm.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var filteredrez = Rez2.Where(soba => soba.Res_Type == comboBox1.SelectedItem.ToString());
           
            foreach (Reservation rt in filteredrez)
            {
                Rez3.Add(rt);

            }

            dataGridView1.DataSource = Rez3;

            Rez3.Clear();
        }
    }
}
