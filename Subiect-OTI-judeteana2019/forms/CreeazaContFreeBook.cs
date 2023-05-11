using Subiect_OTI_judeteana2019.controller;
using Subiect_OTI_judeteana2019.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_judeteana2019
{
    public partial class CreeazaContFreeBook : Form
    {
        private Label lblemail;
        private Label lblnume;
        private Label lblprenume;
        private Label lblparola;
        private Label lblconfirmare;
        private Button btninregistrare;
        private TextBox txtemail;
        private TextBox txtnume;
        private TextBox txtprenume;
        private TextBox txtparola;
        private TextBox txtconfirmare;
        public ControlUtilizator control=new ControlUtilizator();


        public CreeazaContFreeBook()
        {
            InitializeComponent();

            this.lblemail = new Label();
            this.Controls.Add(this.lblemail);
            this.lblemail.Location = new System.Drawing.Point(123, 60);
            this.lblemail.Size = new System.Drawing.Size(46, 20);
            this.lblemail.Text="Email";

            this.lblnume = new Label();
            this.Controls.Add(this.lblnume);
            this.lblnume.Location = new System.Drawing.Point(123, 110);
            this.lblnume.Size = new System.Drawing.Size(50, 20);
            this.lblnume.Text="Nume";

            this.lblprenume = new Label();
            this.Controls.Add(this.lblprenume);
            this.lblprenume.Location = new System.Drawing.Point(123, 160);
            this.lblprenume.Size = new System.Drawing.Size(69, 20);
            this.lblprenume.Text="Prenume";

            this.lblparola = new Label();
            this.Controls.Add(this.lblparola);
            this.lblparola.Location = new System.Drawing.Point(123, 210);
            this.lblparola.Size = new System.Drawing.Size(69, 20);
            this.lblparola.Text="Parola";

            this.lblconfirmare = new Label();
            this.Controls.Add(this.lblconfirmare);
            this.lblconfirmare.Location = new System.Drawing.Point(123, 270);
            this.lblconfirmare.Size = new System.Drawing.Size(130, 20);
            this.lblconfirmare.Text="Confirmare parola";

            this.txtemail=new TextBox();
            this.Controls.Add(this.txtemail);
            this.txtemail.Location = new System.Drawing.Point(269, 60);
            this.txtemail.Size = new System.Drawing.Size(344, 27);

            this.txtnume=new TextBox();
            this.Controls.Add(this.txtnume);
            this.txtnume.Location = new System.Drawing.Point(269, 110);
            this.txtnume.Size = new System.Drawing.Size(344, 27);

            this.txtprenume=new TextBox();
            this.Controls.Add(this.txtprenume);
            this.txtprenume.Location = new System.Drawing.Point(269, 160);
            this.txtprenume.Size = new System.Drawing.Size(344, 27);

            this.txtparola=new TextBox();
            this.Controls.Add(this.txtparola);
            this.txtparola.Location = new System.Drawing.Point(269, 210);
            this.txtparola.Size = new System.Drawing.Size(344, 27);
            this.txtparola.PasswordChar = '*';

            this.txtconfirmare=new TextBox();
            this.Controls.Add(this.txtconfirmare);
            this.txtconfirmare.Location = new System.Drawing.Point(269, 270);
            this.txtconfirmare.Size = new System.Drawing.Size(344, 27);
            this.txtconfirmare.PasswordChar = '*';

            this.btninregistrare=new Button();
            this.Controls.Add(this.btninregistrare);
            this.btninregistrare.Location = new System.Drawing.Point(269, 317);
            this.btninregistrare.Size = new System.Drawing.Size(172, 42);
            this.btninregistrare.Text="Inregistrare";
            this.btninregistrare.Click+=new EventHandler(this.inregistrare_Click);

        }

        public void inregistrare_Click(object sender,EventArgs e)
        {

            if (this.txtconfirmare.Text.Equals("")||this.txtemail.Text.Equals("")||this.txtnume.Text.Equals("")||this.txtparola.Text.Equals("")||this.txtprenume.Text.Equals("")){
                MessageBox.Show("exista camp necompletat");
            }
            else
            {
                Utilizator a=new Utilizator(this.txtemail.Text,this.txtparola.Text,this.txtnume.Text,this.txtprenume.Text);
                this.control.adaugare(a);
                this.control.salvareFisier();

                this.Hide();
                FreeBookHome freeBookHome = new FreeBookHome();
                freeBookHome.Closed+=(s, args) => this.Close();
                freeBookHome.Show();
            }

        }

        private void CreeazaContFreeBook_Load(object sender, EventArgs e)
        {

        }
    }



}
