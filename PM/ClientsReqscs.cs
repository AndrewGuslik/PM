using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM
{
    public partial class ClientsReqscs : UserControl
    {
        int idReq { get; set; } 
        int idCur { get; set; }
        int idEmp{ get; set; }
        int idCl { get; set; }
        string status { get; set; }
        string comment { get; set; }
        string lvlEd { get; set; }
        string fio { get; set; }
        string phone { get; set; }
        string serie { get; set; }
        string fioPar { get; set; }
        string finEd { get; set; }
        string fioEmp { get; set; }
        string curs1 { get; set; }
        string curs2 { get; set; }
        string curs3 { get; set; }
        string curs4 { get; set; }
        string curs5 { get; set; }

        string certif { get; set; }
        string diplom { get; set; }
        int ege1 { get; set; }
        int ege2 { get; set; }
        int ege3 { get; set; }
        int ege4 { get; set; }
        int ege5 { get; set; }
        Db db = new Db();
        public ClientsReqscs(int idReq, int idCur, int idEmp, string status, string comment, int idCl)
        {
            InitializeComponent();


            this.idReq = idReq;
            this.idCur = idCur;
            this.idEmp = idEmp;
            this.idCl = idCl;
            this.status = status;
            this.comment = comment;
            getInfCl();
            getFioEmp();
           // getResEge();
           // getCurses();

            lbFio.Text = "ФИО: " + fio;
            lblvlEd.Text = "Уровень образования: " + lvlEd;
            lbPhone.Text = "Телефон: " + phone;
            lbSernum.Text = "Паспортные данные: " + serie;
            lbFioPar.Text = "ФИО родителя: " + fioPar;
            lbFinEd.Text = "Законченное учреждение: " + finEd;
            lbFioEmp.Text = "ФИО исполнителя: " + fioEmp;
            lbCurs1.Text = "Направление подготовки: " + curs1;
            lbCurs2.Text = "Направление подготовки: " + curs2;
            lbCurs3.Text = "Направление подготовки: " + curs3;
            lbCurs4.Text = "Направление подготовки: " + curs4;
            lbCurs5.Text = "Направление подготовки: " + curs5;
            lbCertif.Text = "Балл аттестата: " + certif;
            lbDiplom.Text = "Балл диплома: " + diplom;
            lbEge1.Text = "Балл егэ1: " + ege1;
            lbEge2.Text = "Балл егэ2: " + ege2;
            lbEge3.Text = "Балл егэ3: " + ege3;
            lbEge4.Text = "Балл егэ4: " + ege4;
            lbEge5.Text = "Балл егэ5: " + ege5;

            tbComm.Text = comment;
            cbxStatus.Text = status;
        }

        //public void getCurses()
        //{
        //    string curs1 = null, curs2 = null, curs3 = null, curs4 = null, curs5 = null;
        //    db.openConnection();
        //    NpgsqlCommand command = new NpgsqlCommand($"SELECT name_curs FROM curses WHERE clients_id = {idCl}", db.getConnection());
        //    NpgsqlDataReader reader = command.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        curs1 = reader.GetString(0);
        //        curs2 = reader.GetString(1);
        //        curs3 = reader.GetString(2);
        //        curs4 = reader.GetString(3);
        //        curs5 = reader.GetString(4);
        //    }

        //    db.closeConnection();

        //    this.curs1 = curs1;
        //    this.curs2 = curs2;
        //    this.curs3 = curs3;
        //    this.curs4 = curs4;
        //    this.curs5 = curs5;
        //}

        //public void getResEge()
        //{
        //    int ege1 = 0, ege2 = 0, ege3 = 0, ege4 = 0, ege5 = 0;
        //    db.openConnection();
        //    NpgsqlCommand command = new NpgsqlCommand($"SELECT points FROM results_ege WHERE clients_id = {idCl}", db.getConnection());
        //    NpgsqlDataReader reader = command.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        ege1 = reader.GetInt32(0);
        //        ege2 = reader.GetInt32(1);
        //        ege3 = reader.GetInt32(2);
        //        ege4 = reader.GetInt32(3);
        //        ege5 = reader.GetInt32(4);
        //    }

        //    db.closeConnection();

        //    this.ege1 = ege1;
        //    this.ege2 = ege2;
        //    this.ege3 = ege3;
        //    this.ege4 = ege4;
        //    this.ege5 = ege5;
        //}

        public void getFioEmp()
        {
            string fioEmp = null;
            db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT employes_id FROM requests WHERE clients_id = {idCl}", db.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                idEmp = reader.GetInt32(0);
            }

            db.closeConnection();

            db.openConnection();
            NpgsqlCommand commandFio = new NpgsqlCommand($"SELECT fio FROM employes WHERE id = {idEmp}", db.getConnection());
            NpgsqlDataReader readerFio = commandFio.ExecuteReader();

            if (readerFio.Read())
            {
                fioEmp = readerFio.GetString(0);
            }

            db.closeConnection();

            this.fioEmp = fioEmp;
        }

        public void getInfCl()
        {
            string lvlEd = null, fio = null, phone = null, serie = null, fioPar = null, finEd = null;
            string certif = null, diplom = null;
            db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT lvl_ed, fio, phone, serie, fio_parent, fin_ed, certif, diplom FROM clients WHERE id = {idCl}", db.getConnection());
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                lvlEd = reader.GetString(0);
                fio = reader.GetString(1);
                phone = reader.GetString(2);
                serie = reader.GetString(3);
                fioPar = reader.GetString(4);
                finEd = reader.GetString(5);
                certif = reader.GetString(6);
                diplom = reader.GetString(7);
            }

            db.closeConnection();
            this.lvlEd = lvlEd;
            this.fio = fio;
            this.phone = phone;
            this.serie = serie;
            this.fioPar = fioPar;
            this.finEd = finEd;
            this.certif = certif;
            this.diplom = diplom;

        }
    }
}
