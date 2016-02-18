using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Face_Race_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            NBA_Players = new league();
            NBA_Players.ReadPlayers();
            Update_List_View(lsv_Players);
        }

        public void Update_List_View(ListView List_View)
        {
            List_View.Items.Clear();
            foreach (player p in NBA_Players.Players)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.name;
                item.SubItems.Add(p.face);
                item.SubItems.Add(p.race);
                List_View.Items.Add(item);
            }
            List_View.Refresh();
        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            NBA_Players.EditPlayer(index, face, race);
            NBA_Players.WritePlayers();
            Update_List_View(lsv_Players);
        }

        private void lsv_Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Players.SelectedItems.Count > 0)
            {
                index = NBA_Players.Find_Index(lsv_Players.SelectedItems[0].Text);
                name = NBA_Players.Players[index].name;
                face = NBA_Players.Players[index].face;
                race = NBA_Players.Players[index].race;
                Change_Name(name);
                Change_Face(face);
                Change_Race(race);
            }              
        }

        private void Change_Name(string name)
        {
            lbl_name.Text = name;
        }

        private void Change_Face(string face)
        {
            btn_face.Image = System.Drawing.Image.FromFile(face + ".png");
            lbl_face_num.Text = face;
        }
        private void Change_Race(string race)
        {
            btn_race.Image = System.Drawing.Image.FromFile(race + "_R.png");
            lbl_race_num.Text = race;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        int index = -1;
        string name;
        string face;
        string race;
        league NBA_Players;

        private void btn_00_Click(object sender, EventArgs e)
        {
            face = "00";
            Change_Face(face);
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            face = "01";
            Change_Face(face);
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            face = "02";
            Change_Face(face);
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            face = "03";
            Change_Face(face);
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            face = "04";
            Change_Face(face);
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            face = "05";
            Change_Face(face);
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            face = "06";
            Change_Face(face);
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            face = "07";
            Change_Face(face);
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            face = "08";
            Change_Face(face);
        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            face = "09";
            Change_Face(face);
        }

        private void btn_0A_Click(object sender, EventArgs e)
        {
            face = "0A";
            Change_Face(face);
        }

        private void btn_0B_Click(object sender, EventArgs e)
        {
            face = "0B";
            Change_Face(face);
        }

        private void btn_0C_Click(object sender, EventArgs e)
        {
            face = "0C";
            Change_Face(face);
        }

        private void btn_0D_Click(object sender, EventArgs e)
        {
            face = "0D";
            Change_Face(face);
        }

        private void btn_0E_Click(object sender, EventArgs e)
        {
            face = "0E";
            Change_Face(face);
        }

        private void btn_0F_Click(object sender, EventArgs e)
        {
            face = "0F";
            Change_Face(face);
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            face = "10";
            Change_Face(face);
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            face = "11";
            Change_Face(face);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            face = "12";
            Change_Face(face);
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            face = "13";
            Change_Face(face);
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            face = "14";
            Change_Face(face);
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            face = "15";
            Change_Face(face);
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            face = "16";
            Change_Face(face);
        }

        private void btn_17_Click(object sender, EventArgs e)
        {
            face = "17";
            Change_Face(face);
        }

        private void btn_18_Click(object sender, EventArgs e)
        {
            face = "18";
            Change_Face(face);
        }

        private void btn_19_Click(object sender, EventArgs e)
        {
            face = "19";
            Change_Face(face);
        }

        private void btn_1A_Click(object sender, EventArgs e)
        {
            face = "1A";
            Change_Face(face);
        }

        private void btn_1B_Click(object sender, EventArgs e)
        {
            face = "1B";
            Change_Face(face);
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            face = "20";
            Change_Face(face);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            face = "21";
            Change_Face(face);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            face = "22";
            Change_Face(face);
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            face = "23";
            Change_Face(face);
        }

        private void btn_24_Click(object sender, EventArgs e)
        {
            face = "24";
            Change_Face(face);
        }

        private void btn_25_Click(object sender, EventArgs e)
        {
            face = "25";
            Change_Face(face);
        }

        private void btn_26_Click(object sender, EventArgs e)
        {
            face = "26";
            Change_Face(face);
        }

        private void btn_27_Click(object sender, EventArgs e)
        {
            //face = "27";
            //Change_Face(face);
        }

        private void btn_00_R_Click(object sender, EventArgs e)
        {
            race = "00";
            Change_Race(race);
        }

        private void btn_01_R_Click(object sender, EventArgs e)
        {
            race = "01";
            Change_Race(race);
        }

        private void btn_02_R_Click(object sender, EventArgs e)
        {
            race = "02";
            Change_Race(race);
        }

        private void btn_03_R_Click(object sender, EventArgs e)
        {
            race = "03";
            Change_Race(race);
        }

        private void lbl_race_Click(object sender, EventArgs e)
        {

        }

        private void lbl_race_num_Click(object sender, EventArgs e)
        {

        }

        private void lbl_face_Click(object sender, EventArgs e)
        {

        }

        private void lbl_face_num_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        
    }
}
