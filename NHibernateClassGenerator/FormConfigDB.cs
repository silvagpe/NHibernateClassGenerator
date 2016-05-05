using NHibernateClassGenerator.Databases;
using NHibernateClassGenerator.Config;
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

namespace NHibernateClassGenerator
{
    public partial class FormConfigDB : Form
    {
        public FormConfigDB()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarConfig()
        {
            try
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                path = Path.GetDirectoryName(path);

                ConfigHelper configHelper = new ConfigHelper(path);
                configHelper.Load();

                if (!configHelper.ConfigEmpty)
                {

                    cbImp_TipoBanco.SelectedIndex = configHelper.Config.TipoDoServidor - 1;
                    txtImp_Ip.Text = configHelper.Config.IP_Imp;
                    txtImp_Banco.Text = configHelper.Config.Banco_Imp;
                    txtImp_Usuario.Text = configHelper.Config.Usuario_Imp;
                    txtImp_Senha.Text = configHelper.Config.Senha_Imp;
                    txtImp_Porta.Text = configHelper.Config.Porta_Imp;

                }


            }
            catch (Exception exp)
            {
                string msg = string.Format("Can't load configurations. Erro: {0}", exp.Message);
                MessageBox.Show(msg);
            }

        }

        private void SalvarConfig()
        {
            try
            {
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                path = Path.GetDirectoryName(path);

                ConfigHelper configHelper = new ConfigHelper(path);
                configHelper.Config = new ConfigXml();


                configHelper.Config.TipoDoServidor = (cbImp_TipoBanco.SelectedIndex == -1)
                    ? cbImp_TipoBanco.SelectedIndex
                    : cbImp_TipoBanco.SelectedIndex + 1;

                configHelper.Config.IP_Imp = txtImp_Ip.Text;
                configHelper.Config.Banco_Imp = txtImp_Banco.Text;
                configHelper.Config.Usuario_Imp = txtImp_Usuario.Text;
                configHelper.Config.Senha_Imp = txtImp_Senha.Text;
                configHelper.Config.Porta_Imp = txtImp_Porta.Text;


                configHelper.Save();

                lblStatus.Text = string.Format("Save - {0}", DateTime.Now);

            }
            catch (Exception exp)
            {
                string msg = string.Format("Can't load configuration. Erro: {0}", exp.Message);
                MessageBox.Show(msg);
            }

        }

        private void FormConfigDB_Load(object sender, EventArgs e)
        {
            CarregarConfig();
        }

        private void btnImp_TestarConexao_Click(object sender, EventArgs e)
        {
            BgBancoImp.RunWorkerAsync();
        }

        private void BgBancoImp_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                IDatabase db = DatabaseFacoty.CreateDatabase();
                db.OpenConnection();
                db.CloseConnection();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        private void BgBancoImp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(String.Format("Error to open connection. Erro:{0}", e.Error.Message), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Success!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarConfig();
        }
    }
}
