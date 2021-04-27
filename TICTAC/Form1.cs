using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTAC
{
    public partial class TICTACTOE : Form
    {
        bool rand=true; //variabila care ne ajuta sa ne dam seama ce va aparea pe buton la apasarea lui 
        int ture = 0; // contorul pentru a teremina numarul de miscari si a stabili daca este remiza sau nuS
        int b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0, b6 = 0, b7 = 0, b8 = 0, b9 = 0; //variabile folosite la determinarea utilizarii pozitiilor (0 pozitie libera / 1 pozitie ocupata)
        int Check = 0; //variabila care devine 1 cand un jucator castiga
        int scorf = 0; //scorul primului jucator (stanga)
        int scors = 0; //scorul jucatorului doi (dreapta)
        int rem = 0; //numarul de remize
        public TICTACTOE()
        {
            InitializeComponent();
        }

        private void TICTACTOE_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //butonul de exit
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor Dologa Razvan 06/04/2021");//butonul about
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Game(); //buton pentru joc nou
        }
        private void button1_Click(object sender, EventArgs e)
        {
           if(b1==0) //verificam daca butonul a fost apasata (Adica daca pozitia respectiva a fost deja folosita de unul din jucatori)
            {
                if (rand) 
                {
                    button1.Text = "X"; //in cazul in care este randul primului jucator si pozitia nu este ocupata aceasta o sa fie marcata cu un X
                    Randul.Text = tag2.Text; //Se precizeaza ca este randul jucatorului doi
                }
                else
                {
                    button1.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand; //variabila devine false ,marcand trecerea la jucatorul doi
                b1 = 1; //marcam butonul ca fiind apasat (pozitia este ocupata)
                ture++; //contorizam miscarea
            }
            Castigator(); //verificam daca miscarea este una "castigatoare"
            
        }
        //idem pentru celelalte 8 butoane
        private void button2_Click(object sender, EventArgs e)
        {
            if (b2 == 0)
            {
                if (rand)
                {
                    button2.Text = "X";
                    Randul.Text = tag2.Text;
                }
                else
                {
                    button2.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b2 = 1;
                ture++;
            }
            Castigator();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The object of Tic Tac Toe is to get three in a row. You play on a three by three game board. The first player is known as X and the second is O. Players alternate placing Xs and Os on the game board until either oppent has three in a row or all nine squares are filled. X always goes first, and in the event that no one has three in a row, the stalemate is called a cat game.");
            //butonul pentru instructiuni
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            if (b3 == 0)
            {
                if (rand)
                {
                    button3.Text = "X";
                    Randul.Text = tag2.Text;

                }
                else
                {
                    button3.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b3 = 1;
                ture++;
            }
            Castigator();
        }

        

        
        private void button4_Click(object sender, EventArgs e)
        {
            if (b4 == 0)
            {
                if (rand)
                {
                    button4.Text = "X";
                    Randul.Text = tag2.Text;
                }
                else
                {
                    button4.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b4 = 1;
                ture++;
            }
            Castigator();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (b5 == 0)
            {
                if (rand)
                {
                    button5.Text = "X";
                    Randul.Text = tag2.Text;
                }
                else
                {
                    button5.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b5 = 1;
                ture++;
            }
            Castigator();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (b6 == 0)
            {
                if (rand)
                {
                    button6.Text = "X";
                    Randul.Text = tag2.Text;
                }
                else
                {
                    button6.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b6 = 1;
                ture++;
            }
            Castigator();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (b7 == 0)
            {
                if (rand)
                {
                    button7.Text = "X";
                    Randul.Text = tag2.Text;
                }
                else
                {
                    button7.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b7 = 1;
                ture++;
            }
            Castigator();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (b8 == 0)
            {
                if (rand)
                {
                    button8.Text = "X";
                    Randul.Text = tag2.Text;

                }
                else
                {
                    Randul.Text = tag1.Text;
                    button8.Text = "O";
                }
                rand = !rand;
                b8 = 1;
                ture++;
            }
            Castigator();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (b9 == 0)
            {
                if (rand)
                {
                    button9.Text = "X";
                    Randul.Text = tag2.Text;
                }
                else
                {
                    button9.Text = "O";
                    Randul.Text = tag1.Text;
                }
                rand = !rand;
                b9 = 1;
                ture++;
            }
            Castigator();
        }
        public void Castigator()
        {
           //toate combinatiile posibile lini/diagonale (Verificam daca pe butoane se gaseste acelasi semn (0 sau X) si daca toate au fost apasate)
            if (button1.Text == button2.Text && button2.Text == button3.Text && b1 == 1 && b2==1   && b3 == 1)
                Check = 1;
            if (button1.Text == button4.Text && button4.Text == button7.Text && b1 == 1 && b4 == 1 && b7 == 1)
                Check = 1;
            if (button1.Text == button5.Text && button5.Text == button9.Text && b1 == 1 && b5 == 1 && b9 == 1)
                Check = 1;
            if (button2.Text == button5.Text && button5.Text == button8.Text && b2 == 1 && b5 == 1 && b8 == 1)
                Check = 1;
            if (button3.Text == button6.Text && button6.Text == button9.Text && b3 == 1 && b6 == 1 && b9 == 1)
                Check = 1;
            if (button4.Text == button5.Text && button5.Text == button6.Text && b4 == 1 && b5 == 1 && b6 == 1)
                Check = 1;
            if (button7.Text == button8.Text && button8.Text == button9.Text && b7 == 1 && b8 == 1 && b9 == 1)
                Check = 1;
            if (button3.Text == button5.Text && button5.Text == button7.Text && b3 == 1 && b5 == 1 && b3 == 1)
                Check = 1;
            if (Check == 1) //daca avem o linie sau o diagonala mentionam castigatorul
            {
                if(!rand) //determinam a cui a fost ultima miscare 
                {   if(tag1.Text!="")
                    {
                        string first = Convert.ToString(tag1.Text);
                        MessageBox.Show(first + " a castigat!"); //preluam numele castigatorului din caseta text 
                    }
                    else
                    {
                        MessageBox.Show("Primul jucator a castigat!");//daca nu exista niciun nume il numim simplu primul jucator
                    }
                    b1 = 1; b2 = 1; b3 = 1; b4 = 1; b5 = 1; b6 = 1; b7 = 1; b8 = 1; b9 = 1;//dezactivam toate butoanele pana la inceperea unui joc nou
                    scorf++; //primul jucator (cel care are caseta text din stanga primeste un punct)
                    Scor_First.Text = Convert.ToString(scorf);//afisam scorul sau pe eticheta
                    
                    New_Game(); //incepem un joc nou
                }
                else //daca a castigat al doilea jucator se aplica aceleasi principi dar pe caseta text si eticheta din dreapta
                {
                    if(tag2.Text!="")
                    {
                        string second = Convert.ToString(tag2.Text);
                        MessageBox.Show(second + " a castigat!");
                    }
                    else
                    {
                        MessageBox.Show("Al doilea jucator a castigat!");
                    }
                    b1 = 1; b2 = 1; b3 = 1; b4 = 1; b5 = 1; b6 = 1; b7 = 1; b8 = 1; b9 = 1;
                    scors++;
                    Score_Second.Text = Convert.ToString(scors);
                    New_Game();

                }
            
            }
            else if(ture==9) //daca toate pozitiile au fost ocupate si nimeni nu a castigat inseamna ca avem o remiza
            {
                rem++;
                Remize.Text = Convert.ToString(rem);//contorizam remiza si trecem la un joc nou
                MessageBox.Show("Remiza!");
                New_Game();
            }
        }
        public void New_Game() //reinitializarea elementelor pentru un joc nou
        {
            b1 = 0; b2 = 0; b3 = 0; b4 = 0; b5 = 0; b6 = 0; b7 = 0; b8 = 0; b9 = 0;
            Check = 0;
            rand = true;
            ture = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Randul.Text = Convert.ToString(tag1.Text);
        }

    }
}
