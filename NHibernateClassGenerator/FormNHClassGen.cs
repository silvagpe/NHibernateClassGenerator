using NHibernateClassGenerator.BLL;
using NHibernateClassGenerator.Config;
using NHibernateClassGenerator.Helpers;
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
    public partial class FormNHClassGen : Form
    {
        public FormNHClassGen()
        {
            InitializeComponent();
        }

        private void bancosDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigDB formConfig = new FormConfigDB();
            formConfig.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tables tables = TablesFactory.CreateTables();
            if (tables == null)
            {
                MessageBox.Show("Database type is not defined.");
                return;
            }

            treeViewTables.Nodes.Clear();
            DataTable dbTables = tables.LoadTables();

            foreach (DataRow row in dbTables.Rows)
            {

                string tableName = row[Tables.TABLE_NAME].ToString();
                treeViewTables.Nodes.Add(tableName, tableName);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                ClassGenerator classGenerator = ClassGeneratorFactory.CreateClassGenerator();
                if (classGenerator == null)
                {
                    MessageBox.Show("Database type is not defined.");
                    return;
                }

                Tables tables = TablesFactory.CreateTables();
                if (tables == null)
                {
                    MessageBox.Show("Database type is not defined.");
                    return;
                }

                //Save Config
                Save();

                IList<ColumnModel> columns = new List<ColumnModel>();
                txtStatus.Clear();
                foreach (TreeNode node in treeViewTables.Nodes)
                {
                    if (node.Checked)
                    {
                        columns.Clear();
                        StringBuilder sb = new StringBuilder(txtStatus.Text);

                        //string tableName = TextHelper.FirstLetterUp(node.Text);
                        string tableName = node.Text;

                        DataTable dtColumns = tables.LoadColumn(node.Text);

                        foreach (DataRow row in dtColumns.Rows)
                        {
                            ColumnModel cModel = new ColumnModel();
                            cModel.ColumnName = row[Tables.COLUMN_NAME].ToString();
                            cModel.DataType = row[Tables.DATA_TYPE].ToString();
                            cModel.Length = row[Tables.CHARACTER_MAXIMUM_LENGTH].ToString();
                            cModel.Precison = row[Tables.NUMERIC_PRECISION].ToString();
                            cModel.Scale = row[Tables.NUMERIC_SCALE].ToString();
                            cModel.IsNullable = row[Tables.IS_NULLABLE].ToString();

                            columns.Add(cModel);
                        }

                        sb.AppendLine(string.Format("Generating Entity: {0}", tableName));
                        classGenerator.EntityClass(tableName, columns, txtClassPrefix.Text, txtNamespaceEntities.Text, txtInterface.Text);

                        sb.AppendLine(string.Format("Generating Mapping: {0}", tableName));
                        classGenerator.MapClass(tableName, columns, txtClassPrefix.Text, txtNamespaceMapping.Text, txtNamespaceEntities.Text);

                        txtStatus.Text = sb.ToString();
                        this.Refresh();
                    }
                }

                MessageBox.Show("Generate completed has successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar a classe: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtStatus_VisibleChanged(object sender, EventArgs e)
        {
            if (txtStatus.Visible)
            {
                txtStatus.SelectionStart = txtStatus.TextLength;
                txtStatus.ScrollToCaret();
            }
        }

        private void FormNHClassGen_Load(object sender, EventArgs e)
        {
            ConfigHelper confHelper = new ConfigHelper();
            confHelper.Load();

            txtClassPrefix.Text = confHelper.Config.PrefixClas;
            txtNamespaceEntities.Text = confHelper.Config.NS_Entity;
            txtNamespaceMapping.Text = confHelper.Config.NS_Map;
            txtInterface.Text = confHelper.Config.StrInterface;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            ConfigHelper confHelper = new ConfigHelper();
            confHelper.Load();

            confHelper.Config.PrefixClas = txtClassPrefix.Text;
            confHelper.Config.NS_Entity = txtNamespaceEntities.Text;
            confHelper.Config.NS_Map = txtNamespaceMapping.Text;
            confHelper.Config.StrInterface = txtInterface.Text;

            confHelper.Save();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string diretorio = Path.GetDirectoryName(Application.ExecutablePath);
            string windir = Environment.GetEnvironmentVariable("WINDIR");
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = windir + @"\explorer.exe";
            prc.StartInfo.Arguments = diretorio;
            prc.Start();
        }
    }
}
