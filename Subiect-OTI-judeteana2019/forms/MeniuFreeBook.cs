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
    public partial class MeniuFreeBook : Form
    {
        private DataGridView datagridview;
        private DataGridView datagridview2;
        private Label lblutilizator;
        private TabControl tabcontrol;
        private ControlCarte controlCarte=new ControlCarte();
        private Utilizator utilizator;
        private Label lblpersoanalogata;
        private ControlImprumut controlImprumut=new ControlImprumut();

        public MeniuFreeBook(Utilizator utilizatorlogat)
        {
            InitializeComponent();
            this.utilizator = utilizatorlogat;
            this.Size = new System.Drawing.Size(1008, 617);

            this.lblutilizator = new Label();
            this.Controls.Add(this.lblutilizator);
            this.lblutilizator.Location = new System.Drawing.Point(26, 23);
            this.lblutilizator.Size = new System.Drawing.Size(112, 20);
            this.lblutilizator.Text="Email utilizator:";

            this.tabcontrol = new TabControl();
            this.Controls.Add(this.tabcontrol);
            this.tabcontrol.Location = new System.Drawing.Point(0, 73);
            this.tabcontrol.Size = new System.Drawing.Size(1000, 504);

            this.lblpersoanalogata=new Label();
            this.Controls.Add(this.lblpersoanalogata);
            this.lblpersoanalogata.Location = new System.Drawing.Point(144, 23);
            this.lblpersoanalogata.Size = new System.Drawing.Size(150, 20);
            this.lblpersoanalogata.Text=this.utilizator.Email.ToString();

            TabPage tab1 = new TabPage("Carri disponibile");
            TabPage tab2 = new TabPage("Carti Impurmutate");
            TabPage tab3 = new TabPage("Statistici biblioteca");
            this.tabcontrol.Controls.Add(tab1);
            this.tabcontrol.Controls.Add(tab2);
            this.tabcontrol.Controls.Add(tab3);

            this.datagridview=new DataGridView();
            tab1.Controls.Add(this.datagridview);
            this.datagridview.Location = new System.Drawing.Point(0, 0);
            this.datagridview.Size = new System.Drawing.Size(992, 468);
            populateTab1();

            this.datagridview2=new DataGridView();
            tab2.Controls.Add(this.datagridview2);
            this.datagridview2.Location = new System.Drawing.Point(0, 0);
            this.datagridview2.Size = new System.Drawing.Size(992, 468);
            populateTab2();

            
        }

        public void populateTab1()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Titlu", typeof(string));
            dt.Columns.Add("Autor", typeof(string));
            dt.Columns.Add("Gen", typeof(string));
            dt.Columns.Add("Imprumuta carte", typeof(Button));

            List<Carte> lista = this.controlCarte.getList();

            foreach (Carte carte in lista)
            {
                dt.Rows.Add(carte.Titlu,carte.Autor,carte.Gen);
            }

            datagridview.DataSource = dt;
        }

        public void populateTab2()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Index", typeof(int));
            dt.Columns.Add("Titlu", typeof(string));
            dt.Columns.Add("Autor", typeof(string));
            dt.Columns.Add("Data Imprumut", typeof(DateTime));
            dt.Columns.Add("Data Disponibilitate", typeof(DateTime));

            List<Imprumut> impurmuturi = this.controlImprumut.getList();
            int i = 1;

            foreach (Imprumut x in impurmuturi)
            {
                if (x.Email.Equals(utilizator.Email))
                {
                    DateTime data = x.Data.AddDays(30);
                    dt.Rows.Add(i, this.controlCarte.getTitleById(x.Id_carte), this.controlCarte.getAutorById(x.Id_carte), x.Data, data);
                    i++;
                }
            }
            datagridview2.DataSource = dt;

            
        }

        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {

        }
    }
}
