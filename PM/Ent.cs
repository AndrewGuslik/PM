using Npgsql;

namespace PM
{
    public partial class Ent : Form
    {
        string phone, pass;
        Db db = new Db();
        public Ent()
        {
            InitializeComponent();
        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            phone = TbPhone.Text;
            pass = TbPass.Text;

            if ((!String.IsNullOrEmpty(phone)) && (!String.IsNullOrEmpty(pass))) 
            {
                if (phone.Length == 11) 
                {
                    if (phone.Remove(2, 9) == "89")
                    {
                        if (pass.Length >= 5) 
                        {
                            CheckUs(phone, pass);
                        }
                        else { MessageBox.Show("Введите пароль, больше 4 символов"); }
                    }
                    else { MessageBox.Show("Введите реальный номер"); }
                }
                else { MessageBox.Show("Введите номер, равный 11 символам"); }
            }
            else { MessageBox.Show("Введите все данные"); }
        }

        private void lbReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();           
            reg.Show();
        }

        private void CheckUs(string phone, string pass) 
        {
            int idCl = 0;
            db.openConnection();

            NpgsqlCommand chckCl = new NpgsqlCommand($"SELECT fio, id FROM clients WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());
            NpgsqlDataReader readerCl = chckCl.ExecuteReader();

            if (readerCl.Read()) 
            {
                string fioCl = readerCl.GetString(0);
                idCl = readerCl.GetInt32(1);
                MessageBox.Show("Добро пожаловать");

                this.Hide();
                Maincs main = new Maincs(idCl);
                main.Show();
            }
            else { MessageBox.Show("Такого пользователя нет"); }

            db.closeConnection();

            if (idCl == 0)
            {
                db.openConnection();
                NpgsqlCommand chckEmp = new NpgsqlCommand($"SELECT fio, id FROM employes WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());
                NpgsqlDataReader readerEmp = chckEmp.ExecuteReader();

                if (readerEmp.Read())
                {
                    string fioEmp = readerEmp.GetString(0);
                    int idEmp = readerCl.GetInt32(1);
                    MessageBox.Show("Добро пожаловать");

                    this.Hide();
                    Maincs main = new Maincs(idEmp);
                    main.Show();
                }
                else { MessageBox.Show("Такого пользователя нет"); }
                db.closeConnection();
            }                       
        }
    }
}