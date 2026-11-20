using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFianl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private OleDbDataReader reader = null;

        private string CadenaConexion =
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
            
            + Application.StartupPath + @"\Movimientos.mdb";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Movimientos";

                adaptador.SelectCommand = comando;

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgvTabla.DataSource = dt;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal monto;

                if (!decimal.TryParse(txtMontos.Text, out monto))
                {
                    MessageBox.Show("Ingresá un monto válido.");
                    txtMontos.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingresá un nombre.");
                    txtNombre.Focus();
                    return;
                }

                using (OleDbConnection cn =
                    new OleDbConnection(CadenaConexion))
                {
                    cn.Open();

                    string sql = "";
                    sql = "INSERT INTO [Movimientos] ";
                    sql = sql + "([Monto], [Nombre], [Tipo]) ";
                    sql = sql + "VALUES (?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        cmd.Parameters.Add("?", OleDbType.Currency)
                            .Value = monto;

                        cmd.Parameters.Add("?", OleDbType.VarWChar)
                            .Value = txtNombre.Text.Trim();

                        cmd.Parameters.Add("?", OleDbType.Boolean)
                            .Value = optIngreso.Checked;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movimiento agregado correctamente.");

                txtMontos.Clear();
                txtNombre.Clear();


                try
                {
                    using (OleDbConnection cn =
                        new OleDbConnection(CadenaConexion))
                    {
                        cn.Open();

                        string consulta =
                            "SELECT * FROM [Movimientos]";

                        using (OleDbDataAdapter adaptador =
                            new OleDbDataAdapter(consulta, cn))
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);

                            dgvTabla.AutoGenerateColumns = true;
                            dgvTabla.DataSource = tabla;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Se guardó, pero no se pudo actualizar la grilla: "
                        + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void txtMontos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {

            try
            {
                using (OleDbConnection cn =
                    new OleDbConnection(CadenaConexion))
                {
                    cn.Open();

                    string sql = "SELECT * FROM [Movimientos]";

                    using (OleDbDataAdapter adaptador =
                        new OleDbDataAdapter(sql, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        if (optEgresoF.Checked)
                        {
                            DataView vista = new DataView(tabla);
                            vista.RowFilter = "Tipo = false";
                            dgvTabla.DataSource = vista;
                        }
                        else
                        {
                            DataView vista = new DataView(tabla);
                            vista.RowFilter = "Tipo = true";
                            dgvTabla.DataSource = vista;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection cn =
                    new OleDbConnection(CadenaConexion))
                {
                    cn.Open();

                    string sql = "SELECT * FROM [Movimientos]";

                    using (OleDbDataAdapter adaptador =
                        new OleDbDataAdapter(sql, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        dgvTabla.DataSource = tabla;

                        if (optEgresoF.Checked)
                        {
                            DataView vista = new DataView(tabla);
                            vista.RowFilter = "Tipo = false";
                            dgvTabla.DataSource = vista;
                        }
                        else
                        {
                            dgvTabla.DataSource = tabla;
                        }
                    }
                }

                optEgreso.Checked = false;
                optEgresoF.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }
    }
}