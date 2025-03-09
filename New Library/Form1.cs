using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string path = "book list.txt";
        FileStream fl = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

        private void Form1_Load(object sender, EventArgs e)
        {
                AddNode("The Name of the Wind", "Patrick Rothfuss", "2005-2010", "4", "English", "1 name of the wind.jpg", "Fantasy", "https://www.goodreads.com/book/show/186074.The_Name_of_the_Wind?ref=nav_sb_ss_1_20");
                AddNode("Mistborn: The Final Empire", "Brandon Sanderson", "2005-2010", "4", "English", "2 Mistborn The Final Empire.jpg", "Fantasy", "https://www.goodreads.com/book/show/68428.The_Final_Empire?ref=nav_sb_ss_1_26");
                AddNode("The Graveyard Book", "Neil Gaiman", "2005-2010", "5", "English", "3 The Graveyard Book.jpg", "Fantasy", "https://www.goodreads.com/book/show/2213661.The_Graveyard_Book?ref=nav_sb_ss_1_18");
                AddNode("A Dance with Dragons", "George R.R. Martin", "2010-2015", "3", "English", "4 A Dance with Dragons.jpg", "Fantasy", "https://www.goodreads.com/book/show/10664113-a-dance-with-dragons?ref=nav_sb_ss_1_20");
                AddNode("The Ocean at the End of the Lane", "Neil Gaiman", "2010-2015", "4", "English", "5 The Ocean at the End of the Lane.jpg", "Fantasy", "https://www.goodreads.com/book/show/18505792-the-ocean-at-the-end-of-the-lane?ref=nav_sb_ss_1_32");
                AddNode("The Night Circus", "Erin Morgenstern", "2010-2015", "5", "English", "6 The Night Circus.jpg", "Fantasy", "https://www.goodreads.com/book/show/9361589-the-night-circus?ref=nav_sb_ss_1_16");
                AddNode("The Broken Empire Trilogy: Prince of Thorns", "Mark Lawrence", "2010-2015", "4", "English", "7 The Broken Empire Trilogy Prince of Thorns.jpg", "Fantasy", "https://www.goodreads.com/book/show/23814733-the-broken-empire-trilogy?ref=nav_sb_ss_1_43");
                AddNode("The Fifth Season", "N.K. Jemisin", "2015-2020", "3", "English", "8 The Fifth Season.jpg", "Fantasy", "https://www.goodreads.com/book/show/19161852-the-fifth-season?ref=nav_sb_ss_1_16");
                AddNode("A Gathering of Shadows", "V.E. Schwab", "2015-2020", "5", "English", "9 A Gathering of Shadows.jpg", "Fantasy", "https://www.goodreads.com/book/show/20764879-a-gathering-of-shadows?ref=nav_sb_ss_1_22");
                AddNode("Circe", "Madeline Miller", "2015-2020", "4", "English", "10 Circe.jpg", "Fantasy", "https://www.goodreads.com/book/show/35959740-circe?ref=nav_sb_ss_1_5");
                AddNode("The Time Traveler's Wife", "Audrey Niffenegger", "2005-2010", "3.5", "English", "11 The Time Traveler's Wife.jpg", "Romance", "https://www.goodreads.com/book/show/18619684-the-time-traveler-s-wife?ref=nav_sb_ss_1_24");
                AddNode("Atonement", "Ian McEwan", "2005-2010", "3", "English", "12 Atonement.jpg", "Romance", "https://www.goodreads.com/book/show/6867.Atonement?ref=nav_sb_ss_1_9");
                AddNode("The Guernsey Literary and Potato Peel Pie Society", "Mary Ann Shaffer and Annie Barrows", "2005-2010", "3", "English", "13 The Guernsey Literary and Potato Peel Pie Society.jpg", "Romance", "https://www.goodreads.com/book/show/39832183-the-guernsey-literary-and-potato-peel-pie-society?ref=nav_sb_ss_1_49");
                AddNode("Me Before You", "Jojo Moyes", "2010-2015", "4", "English", "14 Me Before You.jpg", "Romance", "https://www.goodreads.com/book/show/17347634-me-before-you?ref=nav_sb_ss_1_13");
                AddNode("The Fault in Our Stars", "John Green", "2010-2015", "4", "English", "15 The Fault in Our Stars.jpg", "Romance", "https://www.goodreads.com/book/show/11870085-the-fault-in-our-stars?ref=nav_sb_ss_1_22");
                AddNode("Eleanor Oliphant Is Completely Fine", "Gail Honeyman", "2010-2015", "4", "English", "16 Eleanor Oliphant Is Completely Fine.jpg", "Romance", "https://www.goodreads.com/book/show/35900387-eleanor-oliphant-is-completely-fine?ref=nav_sb_ss_1_35");
                AddNode("Beautiful Ruins", "Jess Walter", "2010-2015", "5", "English", "17 Beautiful Ruins.jpg", "Romance", "https://www.goodreads.com/book/show/11447921-beautiful-ruins?ref=nav_sb_ss_1_15");
                AddNode("The Hating Game", "Sally Thorne", "2015-2020", "5", "English", "18 The Hating Game.jpg", "Romance", "https://www.goodreads.com/book/show/27213238-the-hating-game?ref=nav_sb_ss_1_15");
                AddNode("The Kiss Quotient", "Helen Hoang", "2015-2020", "4", "English", "19 The Kiss Quotient.jpg", "Romance", "https://www.goodreads.com/book/show/36199084-the-kiss-quotient?ref=nav_sb_ss_1_17");
                AddNode("Red, White & Royal Blue", "Casey McQuiston", "2015-2020", "4", "English", "20 Red, White & Royal Blue.jpg", "Romance", "https://www.goodreads.com/book/show/41150487-red-white-royal-blue?ref=nav_sb_ss_1_23");
                //eriod: 2005-2010
                AddNode("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", "2005-2010", "5", "English", "21 The Immortal Life of Henrietta Lacks.jpg", "Science and Nature", "https://www.goodreads.com/book/show/6493208-the-immortal-life-of-henrietta-lacks?ac=1&from_search=true&qid=4j6fpTCXMy&rank=1");
                AddNode("The Emperor of All Maladies: A Biography of Cancer", "Siddhartha Mukherjee", "2005-2010", "3", "English", "22 The Emperor of All Maladies  A Biography of Cancer.jpg", "Science and Nature", "https://www.goodreads.com/book/show/7170627-the-emperor-of-all-maladies?ref=nav_sb_ss_1_50");
                AddNode("The Disappearing Spoon: And Other True Tales of Madness, Love, and the History of the World from the Periodic Table of the Elements", "Sam Kean", "2005-2010", "5", "English", "23The Disappearing Spoon And Other True Tales of Madness, Love, and the History of the World from the Periodic Table of the Elements.jpg", "Science and Nature", "https://www.goodreads.com/book/show/7247854-the-disappearing-spoon?ref=nav_sb_ss_1_131");
                //Period: 2010-2015
                AddNode("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "2010-2015", "4", "English", "24 Sapiens A Brief History of Humankind.jpg", "Science and Nature", "https://www.goodreads.com/book/show/23692271-sapiens?ref=nav_sb_ss_1_37");
                AddNode("The Sixth Extinction: An Unnatural History", "Elizabeth Kolbert", "2010-2015", "5", "English", "25 The Sixth Extinction An Unnatural History.jpg", "Science and Nature", "https://www.goodreads.com/book/show/17910054-the-sixth-extinction?ref=nav_sb_ss_1_42");
                AddNode("Astrophysics for Young People in a Hurry", "Neil deGrasse Tyson", "2010-2015", "4", "English", "26 Astrophysics for Young People in a Hurry.jpg", "Science and Nature", "https://www.goodreads.com/book/show/40614255-astrophysics-for-young-people-in-a-hurry?ref=nav_sb_ss_1_40");
                AddNode("The Hidden Life of Trees: What They Feel, How They Communicate – Discoveries from a Secret World", "Peter Wohlleben", "2010-2015", "5", "English", "27 The Hidden Life of Trees What They Feel, How They Communicate – Discoveries from a Secret World.jpg", "Science and Nature", "https://www.goodreads.com/book/show/28256439-the-hidden-life-of-trees?ref=nav_sb_ss_1_96");
                //Period: 2015-2020
                AddNode("Educated: A Memoir", "Tara Westover", "2015-2020", "4", "English", "28 Educated A Memoir .jpg", "Science and Nature", "https://www.goodreads.com/book/show/42616411-educated?ref=nav_sb_ss_1_18");
                AddNode("The Gene: An Intimate History", "Siddhartha Mukherjee", "2015-2020", "4", "English", "29 The Gene An Intimate History.jpg", "Science and Nature", "https://www.goodreads.com/book/show/27276428-the-gene?ref=nav_sb_ss_1_29");
                AddNode("The Overstory", "Richard Powers", "2015-2020", "3", "English", "30 The Overstory.jpg", "Science and Nature", "https://www.goodreads.com/book/show/40180098-the-overstory?ref=nav_sb_ss_1_13");
        }
        private void filter_Click1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            fl.Seek(0, SeekOrigin.Begin);
            StreamReader stt = new StreamReader(fl);
            string line = stt.ReadLine();
            int x = 70, y = 50;
            Label lab;
            while (line != null)
            {
                string yr = "", rt = "", ln = "", img = "", name = "", ath = "", tpc = "";
                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                {
                    int flag = 1;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '|') flag++;
                        else if (flag == 3) yr += line[i];
                        else if (flag == 4) rt += line[i];
                        else if (flag == 5) ln += line[i];
                        else if (flag == 7) tpc += line[i];
                        else if (flag == 1) name += line[i];
                        else if (flag == 2) ath += line[i];
                        else if (flag == 6) img += line[i];
                    }
                    if (comboBox1.SelectedItem.ToString() == ln && comboBox2.SelectedItem.ToString() == tpc &&
                        yr == comboBox3.SelectedItem.ToString() && rt == comboBox4.SelectedItem.ToString())
                    {
                        lab = new Label();
                        lab.Text = ath;
                        lab.Location = new Point(x, y + 200);
                        lab.Size = new Size(200, 50);
                        panel2.Controls.Add(lab);
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(150, 200);
                        //pic.BackColor = Color.Red;
                        pic.Image = Image.FromFile(img);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Location = new Point(x, y);
                        panel2.Controls.Add(pic);
                        x = x + 200;
                    }
                }
                line = stt.ReadLine();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            PictureBox pic;
            panel2.Controls.Clear();
            fl.Seek(0, SeekOrigin.Begin);
            StreamReader stt = new StreamReader(fl);
            string line = stt.ReadLine();
            Label lb;
            int a = 70, b = 50;
            while (line != null)
            {
                string name = "", ath = "", img = "";
                if (!string.IsNullOrEmpty(search_bx.Text))
                {
                    int flag = 1;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '|') flag++;
                        else if (flag == 1) name += line[i];
                        else if (flag == 2) ath += line[i];
                        else if (flag == 6) img += line[i];
                    }
                    if (search_bx.Text == name || search_bx.Text == ath)
                    {
                        lb = new Label();
                        lb.Text = ath;
                        lb.Location = new Point(a, b + 200);
                        lb.Size = new Size(200, 50);
                        panel2.Controls.Add(lb);
                        pic = new PictureBox();
                        pic.Size = new Size(150, 200);
                        pic.Image = Image.FromFile(img);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Location = new Point(a, b);
                        panel2.Controls.Add(pic);
                        a = a + 200;
                        break;
                    }
                    line = stt.ReadLine();
                }
            }
        }
        public void AddNode(string title, string author, string year, string rating, string language, string imgPath, string topic, string goodreadsLink)
        {
            string book = $"{title}|{author}|{year}|{rating}|{language}|{imgPath}|{topic}|{goodreadsLink}";
            fl.Seek(0, SeekOrigin.End);
            StreamWriter streamWriter = new StreamWriter(fl);
            streamWriter.WriteLine(book);
            streamWriter.Flush();
        }
    }
}