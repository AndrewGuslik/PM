using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM
{
    public partial class Reg : Form
    {
        string LvlEd, Fio, SerNum, Phone, FioParent, FinEd, Pass;
        int Certif, Diplom;
        int EGE1, EGE2, EGE3, EGE4, EGE5;     

        string LesEg1, LesEg2, LesEg3, LesEg4, LesEg5;
        string Curs1, Curs2, Curs3, Curs4, Curs5;
        int idCl, idCur;
        Db db = new Db();
        public Reg()
        {
            InitializeComponent();          
        }

        public void cbxLvlEd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string LvlEd = cbxLvlEd.SelectedItem.ToString();

            switch (LvlEd)
            {
                case "СПО":
                    panel1.Hide();
                    lbSpo.Show();
                    lbBak.Hide();
                    lbSpec.Hide();
                    lbMag.Hide();

                    cbxEGE1.Hide();
                    cbxEGE2.Hide();
                    cbxEGE3.Hide();
                    cbxEGE4.Hide();
                    cbxEGE5.Hide();
                    tbEGE1.Hide();
                    tbEGE2.Hide();
                    tbEGE3.Hide();
                    tbEGE4.Hide();
                    tbEGE5.Hide();
                    tbDiplom.Hide();
                    tbCertif.Show();

                    cbxSpoCurs1.Show();
                    cbxSpoCurs2.Show();
                    cbxSpoCurs3.Show();
                    cbxSpoCurs4.Show();
                    cbxSpoCurs5.Show();

                    cbxBakCurs1.Hide();
                    cbxBakCurs2.Hide();
                    cbxBakCurs3.Hide();
                    cbxBakCurs4.Hide();
                    cbxBakCurs5.Hide();

                    cbxSpecCurs1.Hide();
                    cbxSpecCurs2.Hide();
                    cbxSpecCurs3.Hide();
                    cbxSpecCurs4.Hide();
                    cbxSpecCurs5.Hide();

                    cbxMagCurs1.Hide();
                    cbxMagCurs2.Hide();
                    cbxMagCurs3.Hide();
                    cbxMagCurs4.Hide();
                    cbxMagCurs5.Hide();
                    break;
                case "Бакалавриат":
                    panel1.Hide();
                    lbSpo.Hide();
                    lbBak.Show();
                    lbSpec.Hide();
                    lbMag.Hide();

                    tbCertif.Hide();
                    tbDiplom.Hide();
                    cbxEGE1.Show();
                    cbxEGE2.Show();
                    cbxEGE3.Show();
                    cbxEGE4.Show();
                    cbxEGE5.Show();
                    tbEGE1.Show();
                    tbEGE2.Show();
                    tbEGE3.Show();
                    tbEGE4.Show();
                    tbEGE5.Show();

                    cbxSpoCurs1.Hide();
                    cbxSpoCurs2.Hide();
                    cbxSpoCurs3.Hide();
                    cbxSpoCurs4.Hide();
                    cbxSpoCurs5.Hide();

                    cbxBakCurs1.Show();
                    cbxBakCurs2.Show();
                    cbxBakCurs3.Show();
                    cbxBakCurs4.Show();
                    cbxBakCurs5.Show();

                    cbxSpecCurs1.Hide();
                    cbxSpecCurs2.Hide();
                    cbxSpecCurs3.Hide();
                    cbxSpecCurs4.Hide();
                    cbxSpecCurs5.Hide();

                    cbxMagCurs1.Hide();
                    cbxMagCurs2.Hide();
                    cbxMagCurs3.Hide();
                    cbxMagCurs4.Hide();
                    cbxMagCurs5.Hide();
                    break;
                case "Специалитет":
                    panel1.Hide();
                    lbSpo.Hide();
                    lbBak.Hide();
                    lbSpec.Show();
                    lbMag.Hide();

                    tbCertif.Hide();
                    tbDiplom.Hide();
                    cbxEGE1.Show();
                    cbxEGE2.Show();
                    cbxEGE3.Show();
                    cbxEGE4.Show();
                    cbxEGE5.Show();
                    tbEGE1.Show();
                    tbEGE2.Show();
                    tbEGE3.Show();
                    tbEGE4.Show();
                    tbEGE5.Show();

                    cbxSpoCurs1.Hide();
                    cbxSpoCurs2.Hide();
                    cbxSpoCurs3.Hide();
                    cbxSpoCurs4.Hide();
                    cbxSpoCurs5.Hide();

                    cbxBakCurs1.Hide();
                    cbxBakCurs2.Hide();
                    cbxBakCurs3.Hide();
                    cbxBakCurs4.Hide();
                    cbxBakCurs5.Hide();

                    cbxSpecCurs1.Show();
                    cbxSpecCurs2.Show();
                    cbxSpecCurs3.Show();
                    cbxSpecCurs4.Show();
                    cbxSpecCurs5.Show();

                    cbxMagCurs1.Hide();
                    cbxMagCurs2.Hide();
                    cbxMagCurs3.Hide();
                    cbxMagCurs4.Hide();
                    cbxMagCurs5.Hide();
                    break;
                case "Магистратура":
                    panel1.Hide();
                    lbSpo.Hide();
                    lbBak.Hide();
                    lbSpec.Hide();
                    lbMag.Show();

                    cbxEGE1.Hide();
                    cbxEGE2.Hide();
                    cbxEGE3.Hide();
                    cbxEGE4.Hide();
                    cbxEGE5.Hide();
                    tbEGE1.Hide();
                    tbEGE2.Hide();
                    tbEGE3.Hide();
                    tbEGE4.Hide();
                    tbEGE5.Hide();
                    tbCertif.Hide();
                    tbDiplom.Show();

                    cbxSpoCurs1.Hide();
                    cbxSpoCurs2.Hide();
                    cbxSpoCurs3.Hide();
                    cbxSpoCurs4.Hide();
                    cbxSpoCurs5.Hide();

                    cbxBakCurs1.Hide();
                    cbxBakCurs2.Hide();
                    cbxBakCurs3.Hide();
                    cbxBakCurs4.Hide();
                    cbxBakCurs5.Hide();

                    cbxSpecCurs1.Hide();
                    cbxSpecCurs2.Hide();
                    cbxSpecCurs3.Hide();
                    cbxSpecCurs4.Hide();
                    cbxSpecCurs5.Hide();

                    cbxMagCurs1.Show();
                    cbxMagCurs2.Show();
                    cbxMagCurs3.Show();
                    cbxMagCurs4.Show();
                    cbxMagCurs5.Show();
                    break;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string LvlEdRg = cbxLvlEd.Text;
            Fio = tbFIO.Text;
            SerNum = tbSerNum.Text;
            Phone = tbPhone.Text;
            FioParent = tbFIOParent.Text;
            FinEd = tbFinEd.Text;
            Pass = tbPass.Text;

            //Random random = new Random();
            //int idCl = random.Next();

            if (!String.IsNullOrEmpty(LvlEdRg) && !String.IsNullOrEmpty(Fio)
                && !String.IsNullOrEmpty(SerNum) && !String.IsNullOrEmpty(Phone)
                && !String.IsNullOrEmpty(FioParent) && !String.IsNullOrEmpty(FinEd))
            {
                if (Phone.Length == 11)
                {
                    if (Phone.Remove(2, 9) == "89")
                    {
                        if (Pass.Length >= 5)
                        {
                            if ((LvlEdRg == "СПО") && !String.IsNullOrEmpty(tbCertif.Text))
                            {
                                Certif = Convert.ToInt32(tbCertif.Text);

                                db.openConnection();
                                NpgsqlCommand com = new NpgsqlCommand($"INSERT INTO clients(lvl_ed, fio, phone, password, serie, fio_parent, fin_ed, certif, diplom) " +
                                    $"VALUES('{LvlEdRg}', '{Fio}', '{Phone}', '{Pass}', '{SerNum}', '{FioParent}', '{FinEd}', {Certif}, '')", db.getConnection());
                                com.ExecuteNonQuery();
                                db.closeConnection();

                                db.openConnection();
                                NpgsqlCommand comGetid = new NpgsqlCommand($"SELECT id FROM clients WHERE phone = '{Phone}'", db.getConnection());
                                NpgsqlDataReader reader = comGetid.ExecuteReader();
                                if (reader.Read())
                                {
                                    int idCl = reader.GetInt32(0);
                                    this.idCl = idCl;
                                }

                                db.closeConnection();

                                if (!String.IsNullOrEmpty(cbxSpoCurs1.Text))
                                {
                                    Curs1 = cbxSpoCurs1.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs1}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpoCurs2.Text))
                                {
                                    Curs2 = cbxSpoCurs2.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs2}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpoCurs3.Text))
                                {
                                    Curs3 = cbxSpoCurs3.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs3}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpoCurs4.Text))
                                {
                                    Curs4 = cbxSpoCurs4.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs4}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpoCurs5.Text))
                                {
                                    Curs5 = cbxSpoCurs5.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs5}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                            }
                            else if ((LvlEdRg == "СПО") && String.IsNullOrEmpty(tbCertif.Text))
                            { MessageBox.Show("Введите средний балл аттестата"); }

                            if ((LvlEdRg == "Бакалавриат") && (!String.IsNullOrEmpty(tbEGE1.Text) && !String.IsNullOrEmpty(tbEGE2.Text)
                                && !String.IsNullOrEmpty(tbEGE3.Text)))
                            {
                                EGE1 = Convert.ToInt32(tbEGE1.Text);
                                LesEg1 = cbxEGE1.Text;

                                EGE2 = Convert.ToInt32(tbEGE2.Text);
                                LesEg2 = cbxEGE2.Text;

                                EGE3 = Convert.ToInt32(tbEGE3.Text);
                                LesEg3 = cbxEGE3.Text;

                                db.openConnection();
                                NpgsqlCommand comIsrt = new NpgsqlCommand($"INSERT INTO clients(lvl_ed, fio, phone, password, serie, fio_parent, fin_ed, certif, diplom) " +
                                    $"VALUES('{LvlEdRg}', '{Fio}', '{Phone}', '{Pass}', '{SerNum}', '{FioParent}', '{FinEd}', '', '')", db.getConnection());
                                comIsrt.ExecuteNonQuery();
                                db.closeConnection();

                                db.openConnection();
                                NpgsqlCommand comGetid = new NpgsqlCommand($"SELECT id FROM clients WHERE phone = '{Phone}'", db.getConnection());
                                NpgsqlDataReader reader = comGetid.ExecuteReader();
                                if (reader.Read())
                                {
                                    int idCl = reader.GetInt32(0);
                                    this.idCl = idCl;
                                }

                                db.closeConnection();

                                db.openConnection();
                                NpgsqlCommand comEge1 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                    $"VALUES({idCl}, {EGE1}, '{LesEg1}')", db.getConnection());
                                comEge1.ExecuteNonQuery();
                                db.closeConnection(); 
                                db.openConnection();
                                NpgsqlCommand comEge2 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                    $"VALUES({idCl}, {EGE2}, '{LesEg2}')", db.getConnection());
                                comEge2.ExecuteNonQuery();
                                db.closeConnection();
                                db.openConnection();
                                NpgsqlCommand comEge3 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                    $"VALUES({idCl}, {EGE3}, '{LesEg3}')", db.getConnection());
                                comEge3.ExecuteNonQuery();
                                db.closeConnection();

                                if (!String.IsNullOrEmpty(tbEGE4.Text))
                                {
                                    EGE4 = Convert.ToInt32(tbEGE4.Text);
                                    LesEg4 = cbxEGE4.Text;

                                    db.openConnection();
                                    NpgsqlCommand comEge4 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                        $"VALUES({idCl}, {EGE4}, '{LesEg4}')", db.getConnection());
                                    comEge4.ExecuteNonQuery();
                                    db.closeConnection();
                                }

                                if (!String.IsNullOrEmpty(tbEGE5.Text))
                                {
                                    EGE5 = Convert.ToInt32(tbEGE5.Text);
                                    LesEg5 = cbxEGE5.Text;

                                    db.openConnection();
                                    NpgsqlCommand comEge5 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                        $"VALUES({idCl}, {EGE5}, '{LesEg5}')", db.getConnection());
                                    comEge5.ExecuteNonQuery();
                                    db.closeConnection();
                                }

                                if (!String.IsNullOrEmpty(cbxBakCurs1.Text))
                                {
                                    Curs1 = cbxBakCurs1.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs1}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxBakCurs2.Text))
                                {
                                    Curs2 = cbxBakCurs2.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs2}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxBakCurs3.Text))
                                {
                                    Curs3 = cbxBakCurs3.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs3}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxBakCurs4.Text))
                                {
                                    Curs4 = cbxBakCurs4.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs4}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxBakCurs5.Text))
                                {
                                    Curs5 = cbxBakCurs5.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs5}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                            }
                            
                            else if ((LvlEdRg == "Бакалавриат") && (String.IsNullOrEmpty(tbEGE1.Text) || String.IsNullOrEmpty(tbEGE2.Text)
                                || String.IsNullOrEmpty(tbEGE3.Text))) 
                            { MessageBox.Show("Введите баллы ЕГЭ"); }

                            if ((LvlEdRg == "Специалитет") && (!String.IsNullOrEmpty(tbEGE1.Text) && !String.IsNullOrEmpty(tbEGE2.Text)
                                && !String.IsNullOrEmpty(tbEGE3.Text)))
                            {
                                EGE1 = Convert.ToInt32(tbEGE1.Text);
                                LesEg1 = cbxEGE1.Text;

                                EGE2 = Convert.ToInt32(tbEGE2.Text);
                                LesEg2 = cbxEGE2.Text;

                                EGE3 = Convert.ToInt32(tbEGE3.Text);
                                LesEg3 = cbxEGE3.Text;

                                db.openConnection();
                                NpgsqlCommand comIsrt = new NpgsqlCommand($"INSERT INTO clients(lvl_ed, fio, phone, password, serie, fio_parent, fin_ed, certif, diplom) " +
                                    $"VALUES('{LvlEdRg}', '{Fio}', '{Phone}', '{Pass}', '{SerNum}', '{FioParent}', '{FinEd}', '', '')", db.getConnection());
                                comIsrt.ExecuteNonQuery();
                                db.closeConnection();

                                db.openConnection();
                                NpgsqlCommand comGetid = new NpgsqlCommand($"SELECT id FROM clients WHERE phone = '{Phone}'", db.getConnection());
                                NpgsqlDataReader reader = comGetid.ExecuteReader();
                                if (reader.Read())
                                {
                                    int idCl = reader.GetInt32(0);
                                    this.idCl = idCl;
                                }

                                db.closeConnection();

                                db.openConnection();
                                NpgsqlCommand comEge1 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                    $"VALUES({idCl}, {EGE1}, '{LesEg1}')", db.getConnection());
                                comEge1.ExecuteNonQuery();
                                db.closeConnection();
                                db.openConnection();
                                NpgsqlCommand comEge2 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                    $"VALUES({idCl}, {EGE2}, '{LesEg2}')", db.getConnection());
                                comEge2.ExecuteNonQuery();
                                db.closeConnection();
                                db.openConnection();
                                NpgsqlCommand comEge3 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                    $"VALUES({idCl}, {EGE3}, '{LesEg3}')", db.getConnection());
                                comEge3.ExecuteNonQuery();
                                db.closeConnection();

                                if (!String.IsNullOrEmpty(tbEGE4.Text))
                                {
                                    EGE4 = Convert.ToInt32(tbEGE4.Text);
                                    LesEg4 = cbxEGE4.Text;

                                    db.openConnection();
                                    NpgsqlCommand comEge4 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                        $"VALUES({idCl}, {EGE4}, '{LesEg4}')", db.getConnection());
                                    comEge4.ExecuteNonQuery();
                                    db.closeConnection();
                                }

                                if (!String.IsNullOrEmpty(tbEGE5.Text))
                                {
                                    EGE5 = Convert.ToInt32(tbEGE5.Text);
                                    LesEg5 = cbxEGE5.Text;

                                    db.openConnection();
                                    NpgsqlCommand comEge5 = new NpgsqlCommand($"INSERT INTO results_ege(clients_id, points, lesson) " +
                                        $"VALUES({idCl}, {EGE5}, '{LesEg5}')", db.getConnection());
                                    comEge5.ExecuteNonQuery();
                                    db.closeConnection();
                                }

                                if (!String.IsNullOrEmpty(cbxSpecCurs1.Text))
                                {
                                    Curs1 = cbxSpecCurs1.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs1}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpecCurs2.Text))
                                {
                                    Curs2 = cbxSpecCurs2.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs2}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpecCurs3.Text))
                                {
                                    Curs3 = cbxSpecCurs3.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs3}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpecCurs4.Text))
                                {
                                    Curs4 = cbxSpecCurs4.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs4}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxSpecCurs5.Text))
                                {
                                    Curs5 = cbxSpecCurs5.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs5}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                            }
                            else if ((LvlEdRg == "Специалитет") && (String.IsNullOrEmpty(tbEGE1.Text) || String.IsNullOrEmpty(tbEGE2.Text)
                                || String.IsNullOrEmpty(tbEGE3.Text))) 
                            { MessageBox.Show("Введите баллы ЕГЭ"); }

                            if ((LvlEdRg == "Магистратура") && !String.IsNullOrEmpty(tbDiplom.Text))
                            {
                                Diplom = Convert.ToInt32(tbDiplom.Text);

                                db.openConnection();
                                NpgsqlCommand com = new NpgsqlCommand($"INSERT INTO clients(lvl_ed, fio, phone, password, serie, fio_parent, fin_ed, certif, diplom) " +
                                    $"VALUES('{LvlEdRg}', '{Fio}', '{Phone}', '{Pass}', '{SerNum}', '{FioParent}', '{FinEd}', '', {Diplom})", db.getConnection());
                                com.ExecuteNonQuery();
                                db.closeConnection();

                                db.openConnection();
                                NpgsqlCommand comGetid = new NpgsqlCommand($"SELECT id FROM clients WHERE phone = '{Phone}'", db.getConnection());
                                NpgsqlDataReader reader = comGetid.ExecuteReader();
                                if (reader.Read())
                                {
                                    int idCl = reader.GetInt32(0);
                                    this.idCl = idCl;
                                }

                                db.closeConnection();

                                if (!String.IsNullOrEmpty(cbxMagCurs1.Text))
                                {
                                    Curs1 = cbxMagCurs1.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs1}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxMagCurs2.Text))
                                {
                                    Curs2 = cbxMagCurs2.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs2}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxMagCurs3.Text))
                                {
                                    Curs3 = cbxMagCurs3.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs3}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxMagCurs4.Text))
                                {
                                    Curs4 = cbxMagCurs4.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs4}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }
                                if (!String.IsNullOrEmpty(cbxMagCurs5.Text))
                                {
                                    Curs5 = cbxMagCurs5.Text;

                                    db.openConnection();
                                    NpgsqlCommand comCur = new NpgsqlCommand($"INSERT INTO curses(clients_id, name_curs) " +
                                        $"VALUES({idCl}, '{Curs5}')", db.getConnection());
                                    comCur.ExecuteNonQuery();
                                    db.closeConnection();

                                    db.openConnection();
                                    NpgsqlCommand getIdCurp = new NpgsqlCommand($"SELECT id FROM curses WHERE clients_id = {idCl} AND name_curs = '{Curs1}'", db.getConnection());
                                    NpgsqlDataReader readCur = getIdCurp.ExecuteReader();
                                    if (readCur.Read())
                                    {
                                        int idCur = readCur.GetInt32(0);
                                        this.idCur = idCur;
                                    }

                                    db.closeConnection();

                                    CreateReq(idCur);
                                }                        
                            }
                            else if ((LvlEdRg == "Магистратура") && String.IsNullOrEmpty(tbCertif.Text))
                            { MessageBox.Show("Введите средний балл диплома"); }

                        }
                        else { MessageBox.Show("Введите пароль, больше 4 символов"); }
                    }
                    else { MessageBox.Show("Введите реальный номер"); }
                }
                else { MessageBox.Show("Введите номер, равный 11 символам"); }
            }
            else { MessageBox.Show("Все поля должны быть заполнены"); }
        }

        public void CreateReq(int idCur)
        {
            db.openConnection();
            NpgsqlCommand getId = new NpgsqlCommand("SELECT id FROM employes", db.getConnection());
            NpgsqlDataReader reader = getId.ExecuteReader();
            List<int> idList = new List<int>();
            while (reader.Read())
            {
                int idEmps = reader.GetInt32(0);
                idList.Add(idEmps);
            }

            db.closeConnection();

            Random rand = new Random();
            int randomIndex = rand.Next(0, idList.Count);
            int randomId = idList[randomIndex];

            db.openConnection();
            NpgsqlCommand crReq = new NpgsqlCommand($"INSERT INTO requests(clients_id, curses_id, employes_id, status)" +
                $"VALUES({idCl}, {idCur}, {randomId}, 'Подано')", db.getConnection());
            crReq.ExecuteNonQuery();
            db.closeConnection();

            this.Hide();
            Maincs main = new Maincs(idCl);
            main.Show();
        }
        private void lbEnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ent ent = new Ent();
            ent.Show();
        }

    }
}
