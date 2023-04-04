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
    public partial class FreeBookHome : Form
    {
        private PictureBox pic;
        private Button btnlogare;
        private Button btninregistrare;
        private ListBox listbox;

        public FreeBookHome()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(907, 603);
            
            this.pic = new PictureBox();
            this.Controls.Add(this.pic);
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Size = new System.Drawing.Size(865, 325);
            this.pic.Image=Image.FromFile(Application.StartupPath+@"data\sigla_Biblioteca_Alexandria_2.jpg");
            this.pic.SizeMode=PictureBoxSizeMode.StretchImage;

            this.listbox = new ListBox();
            this.Controls.Add(this.listbox);
            this.listbox.Location = new System.Drawing.Point(12, 354);
            this.listbox.Size = new System.Drawing.Size(865, 124);
            this.listbox.Items.AddRange(new object[] { "FreeBook este o platforma care faciliteaza imprumutul de carti","\n",
              "Fiecare utilizator are la dispozitie un numar de 3 carti pe care le poate imprumuta simultan","\n",
              "Fiecare carte poate fi citita in cursul a 30 de zile" });
            this.listbox.Enabled = false;

            this.btnlogare = new Button();
            this.Controls.Add(this.btnlogare);
            this.btnlogare.Location = new System.Drawing.Point(266, 484);
            this.btnlogare.Size = new System.Drawing.Size(165, 60);
            this.btnlogare.Text="Logare";
            this.btnlogare.Click+=new EventHandler(logare_Click);

            this.btninregistrare = new Button();
            this.Controls.Add(this.btninregistrare);
            this.btninregistrare.Location = new System.Drawing.Point(447, 484);
            this.btninregistrare.Size = new System.Drawing.Size(165, 60);
            this.btninregistrare.Text="Inregistrare";
            this.btninregistrare.Click+=new EventHandler(inregistrare_Click);

        }

        public void logare_Click(object sender,EventArgs e)
        {

            this.Hide();
            LogareFreeBook a=new LogareFreeBook();
            a.Closed+=(s, args) => this.Close();
            a.Show();

        }

        public void inregistrare_Click(object sender, EventArgs e)
        {

            this.Hide();
            CreeazaContFreeBook a = new CreeazaContFreeBook();
            a.Closed+=(s, args) => this.Close();
            a.Show();

        }

        private void FreeBookHome_Load(object sender, EventArgs e)
        {

        }
    }
}
