using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace INVENTORY
{
    public partial class Manages : Form
    {
        public Manages()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matto\OneDrive\Documentos\Inventario.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from Users"; 
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                usersgd.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matto\OneDrive\Documentos\Inventario.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES (@Name, @FullName, @Password, @PhoneNumber)", con))
                    {
                        cmd.Parameters.AddWithValue("@Name", nametx.Text);
                        cmd.Parameters.AddWithValue("@FullName", FullNametx.Text);
                        cmd.Parameters.AddWithValue("@Password", Passwordtx.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", TelePhonetx.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário adicionado com sucesso");

                        // Atualiza a exibição da tabela após a inserção
                        populate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            nametx.Text = string.Empty;
            FullNametx.Text = string.Empty;
            Passwordtx.Text = string.Empty;
            TelePhonetx.Text = string.Empty;
        }



        private void usersgd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // nametx.Text = usersgd.SelectedRows[0].Cells[0].Value.ToString();
           // FullNametx.Text = usersgd.SelectedRows[0].Cells[1].Value.ToString();
           // Passwordtx.Text = usersgd.SelectedRows[0].Cells[2].Value.ToString();
           // TelePhonetx.Text = usersgd.SelectedRows[0].Cells[3].Value.ToString();

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if ( TelePhonetx.Text == "")
            {
                MessageBox.Show("Enter a Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "Delete from Users where TelePhone= '" + TelePhonetx.Text + "';";
                SqlCommand cmd  = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfylly Deleted");
                Con.Close();
                populate();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Users set name ='" + nametx.Text + "', Fullname = '" + FullNametx.Text + "', PassWord =  '" + Passwordtx.Text + "' where TelePhone = '" + TelePhonetx.Text + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário atualizado com sucesso");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

