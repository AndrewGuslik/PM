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
    public partial class Maincs : Form
    {
        int idCl;
        Db db = new Db();
        public Maincs(int idCl)
        {
            InitializeComponent();

            this.idCl = idCl;

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(shCard().ToArray());
        }
        public List<ClientsReqscs> shCard()
        {
            List<ClientsReqscs> reqs = new List<ClientsReqscs>();

            db.openConnection();

            NpgsqlCommand getReq = new NpgsqlCommand($"SELECT id, curses_id, " +
                $"employes_id, status, comment FROM requests " +
                $"WHERE clients_id = '{idCl}'", db.getConnection());
            NpgsqlDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                ClientsReqscs addReq = new ClientsReqscs(reader.GetInt32(0), reader.GetInt32(1),
                    reader.GetInt32(2), reader.GetString(3), reader.GetString(3), idCl);
                reqs.Add(addReq);
            }

            db.closeConnection();

            return reqs;
        }
    }   
}
