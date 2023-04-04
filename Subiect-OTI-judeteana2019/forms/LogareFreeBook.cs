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
    public partial class LogareFreeBook : Form
    {
        private Label lblemail;
        private Label lblparola;
        private TextBox txtemail;
        private TextBox txtparola;
        private Button btnlogare;
        private ControlUtilizator control=new ControlUtilizator();

        public LogareFreeBook()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(664, 286);

            this.lblemail = new Label();
            this.Controls.Add(this.lblemail);
            this.lblemail.Location = new System.Drawing.Point(71, 53);
            this.lblemail.Size = new System.Drawing.Size(46, 20);
            this.lblemail.Text="Email";

            this.lblemail = new Label();
            this.Controls.Add(this.lblemail);
            this.lblemail.Location = new System.Drawing.Point(71, 106);
            this.lblemail.Size = new System.Drawing.Size(65, 20);
            this.lblemail.Text="Parola";

            this.txtemail = new TextBox();
            this.Controls.Add(this.txtemail);
            this.txtemail.Location = new System.Drawing.Point(159, 50);
            this.txtemail.Size = new System.Drawing.Size(344, 27);

            this.txtparola = new TextBox();
            this.Controls.Add(this.txtparola);
            this.txtparola.Location = new System.Drawing.Point(159, 106);
            this.txtparola.Size = new System.Drawing.Size(344, 27);
            this.txtparola.PasswordChar='*';

            this.btnlogare=new Button();
            this.Controls.Add(this.btnlogare);
            this.btnlogare.Location = new System.Drawing.Point(159, 154);
            this.btnlogare.Size = new System.Drawing.Size(204, 48);
            this.btnlogare.Text="Logare";
            this.btnlogare.Click+=new EventHandler(logare_Click);

        }

        public void logare_Click(object sender,EventArgs e)
        {
            if (this.txtemail.Text.Equals("")||this.txtparola.Text.Equals(""))
            {
                MessageBox.Show("Exista camp necompletat");
            }
            else if (this.control.isUtilizator(this.txtemail.Text, this.txtparola.Text)==false)
            {
                MessageBox.Show("Emailul sau parola nu coincid");
            }
            else
            {
                this.Hide();

                Utilizator utilizator = this.control.getUtilizator(this.txtemail.Text, this.txtparola.Text);

                MeniuFreeBook a=new MeniuFreeBook(utilizator);
                a.Closed+=(s, args) => this.Close();
                a.Show();

            }

        }

        private void LogareFreeBook_Load(object sender, EventArgs e)
        {

        }
    }
}
