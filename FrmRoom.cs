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
    public partial class FrmRoom : Form
    {
        List<Room> listaSoba = new List<Room>();
        string imeDatoteke = "soba";
        public int roomID;

        public FrmRoom()
        {

            InitializeComponent();

            //pokrecemo samo prvi put za serijalizaciju
            //Room soba = new Room();
            //soba.Room_Beds = "5";
            //soba.Room_Type = "pansion";
            //listaSoba.Add(soba);
            //RoomSerilization();
            //RoomIdSerialization();
            numPrice.Controls[0].Visible = false;
            numPriceOff.Controls[0].Visible = false;

            FileStream tok = File.Open(imeDatoteke, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            listaSoba = bf.Deserialize(tok) as List<Room>;
            tok.Dispose();

            numRoomNumber.Value = decimal.Parse(listaSoba[listaSoba.Count-1].Room_Number);

            //listaSoba[0].Room_Id = 5;
            //listaSoba[0].Room_Price = "200";
            //listaSoba[0].Room_Price_Off = "20";
            //listaSoba[0].Room_Min_Days = "5";
            //Console.WriteLine(listaSoba[0].Room_Number);
            dataGridView1.DataSource = listaSoba;

            FileStream tok2 = File.Open("RoomId", FileMode.OpenOrCreate);
            BinaryFormatter bf2 = new BinaryFormatter();
            string temp = bf2.Deserialize(tok2) as string;
            Console.WriteLine(temp);
            tok2.Dispose();
            roomID = int.Parse(temp);
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room soba = new Room();


            foreach (Room sobe in listaSoba)
            {

                if (int.Parse(sobe.Room_Number) == numRoomNumber.Value)
                {
                    MessageBox.Show("Room with that number already exist");
                    return;

                }
            }
                    
                    
            if (numBeds.Value > 0 && numBeds.Value < 6 && cbRoomType.SelectedItem != null && numPrice.Value > 0 &&
                numPriceOff.Value < 100 && numDays.Value > 0 && numDays.Value < 30)
            {
              soba.Room_Beds = numBeds.Value.ToString();
              soba.Room_Type = cbRoomType.SelectedItem.ToString();
              soba.Room_Price = numPrice.Value.ToString();
              soba.Room_Price_Off = numPriceOff.Value.ToString();
              soba.Room_Min_Days = numDays.Value.ToString();

              soba.Room_Number = numRoomNumber.Value.ToString();
              soba.Room_Id = roomID++;
              listaSoba.Add(soba);

              RoomSerilization();
              RoomIdSerialization();

              BindingList<Room> bindingList = new BindingList<Room>(listaSoba);
              var source = new BindingSource(bindingList, null);
              dataGridView1.DataSource = source;
              numRoomNumber.Value = decimal.Parse(listaSoba[listaSoba.Count - 1].Room_Number) + 1;

              MessageBox.Show("Room added!");
            }
                    

                
   }

        public void RoomSerilization()
        {
            FileStream tok = File.Open(imeDatoteke, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(tok, listaSoba);

            tok.Dispose();
        }

        public void RoomIdSerialization()
        {
            
            FileStream tok = File.Open("RoomId", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(tok, roomID.ToString());

            tok.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "Room_id";
            var filteredGuest = listaSoba.Where(room => room.Room_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Room_id"].Value));

            foreach (var room in filteredGuest)
            {


                if (numBeds.Value > 0 && numBeds.Value < 6 && cbRoomType.SelectedItem != null && numPrice.Value > 0 &&
               numPriceOff.Value < 100 && numDays.Value > 0 && numDays.Value < 30)
                {
                    room.Room_Beds = numBeds.Value.ToString();
                    room.Room_Type = cbRoomType.SelectedItem.ToString();
                    room.Room_Price = numPrice.Value.ToString();
                    room.Room_Price_Off = numPriceOff.Value.ToString();
                    room.Room_Min_Days = numDays.Value.ToString();

                    room.Room_Number = numRoomNumber.Value.ToString();
                    
                    

                    RoomSerilization();
                    RoomIdSerialization();

                    BindingList<Room> bindingList = new BindingList<Room>(listaSoba);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                  

                    MessageBox.Show("Room added!");

                    btnAdd.Visible = true;
                    btnDelete.Visible = false;

                    btnUpdate.Visible = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].Name = "Room_id";
            foreach (Room soba in listaSoba)
            {
                if (dataGridView1.CurrentRow.Index != -1
                    && soba.Room_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Room_id"].Value))
                {
                    numRoomNumber.Value = decimal.Parse(soba.Room_Number);
                    numBeds.Value = decimal.Parse(soba.Room_Beds);
                    cbRoomType.SelectedItem = soba.Room_Type;
                    numPrice.Value = decimal.Parse(soba.Room_Price);
                    numPriceOff.Value = decimal.Parse(soba.Room_Price_Off);
                    numDays.Value = decimal.Parse(soba.Room_Min_Days);



                }
            }

            btnAdd.Visible = false;
            btnDelete.Visible = true;

            btnUpdate.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "Room_id";
            for (int i = 0; i < listaSoba.Count; i++)
            {
                if (listaSoba[i].Room_Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells["Room_id"].Value))
                {
                    listaSoba.RemoveAt(i);
                    MessageBox.Show("Room Deleted");
                }


                BindingList<Room> bindingList = new BindingList<Room>(listaSoba);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

                RoomSerilization();

                btnAdd.Visible = true;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FrmMain"];
            frm.Show();
            Close();
        }
    }
    }

