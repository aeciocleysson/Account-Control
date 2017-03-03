using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account_Control.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Account_Control.DAL
{
    class ClasseDAL
    {
        // MÉTODOS DAS CONTAS

        // ===============================================

            // MÉTODO PARA LISTAR AS CONTAS

        string conecta = "SERVER=localhost; DATABASE=sisconta; UID=root; PWD=leticia3103";
        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable ListaConta()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT * FROM conta", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();

                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);

                return Dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }


        // ===============================================

        // MÉTODO PARA LISTAR A EMPRESA NO COMBO BOX DA JANELA CONTA

        public DataTable ListaEmpresaCombo()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT idEmpresa and nome FROM empresa", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);

                return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        // ===============================================

        // MÉTODO PARA SALVAR AS CONTAS

        public void SalvarConta(ClasseDTO conta)
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("INSERT INTO conta (idConta, valor, data, descricao, empresa) VALUES (@idConta, @valor, @data, @descricao, @empresa)", conexao);

                comando.Parameters.AddWithValue("@idConta", conta.IdConta);
                comando.Parameters.AddWithValue("@valor", conta.Valor);
                comando.Parameters.AddWithValue("@data", conta.Vencimento);
                comando.Parameters.AddWithValue("@descricao", conta.DescConta);
                comando.Parameters.AddWithValue("@empresa", conta.Empresa);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // ===============================================

        // MÉTODO PARA ATUALIZAR AS CONTAS

        public void AtualizaConta(ClasseDTO conta)
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("UPDATE conta SET valor = @valor, data = @data, descricao = @descricao, empresa = @empresa WHERE idConta = @idConta", conexao);

                comando.Parameters.AddWithValue("@idConta", conta.IdConta);
                comando.Parameters.AddWithValue("@valor", conta.Valor);
                comando.Parameters.AddWithValue("@data", conta.Vencimento);
                comando.Parameters.AddWithValue("@descricao", conta.DescConta);
                comando.Parameters.AddWithValue("@empresa", conta.Empresa);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

            // MÉTODO PARA EXCLUIR AS CONTAS

        public void ExcluirContas(ClasseDTO conta)
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("DELETE FROM conta WHERE idConta = @idConta", conexao);

                comando.Parameters.AddWithValue("@idConta", conta.IdConta);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }





/*==================================================================================================================*/


        // MÉTODOS DAS EMPRESAS

        // ===============================================

        // MÉTODO PARA LISTAR AS EMPRESA

        public DataTable ListaEmpresa()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("SELECT * FROM empresa", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);

                return Dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        // ===============================================

            // MÉTODO PARA SALVAR AS EMPRESAS

        public void SalvarEmpresa(ClasseDTO empresa)
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("INSERT INTO empresa (idEmpresa, nome, telefone, descricao) VALUES (@idEmpresa, @nome, @telefone, @descricao)", conexao);

                comando.Parameters.AddWithValue("@idEmpresa", empresa.IdEmpresa);
                comando.Parameters.AddWithValue("@nome", empresa.Nome);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@descricao", empresa.DescEmpresa);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

            // MÉTODO PARA ATUALIZAR AS EMPRESA

        public void AtualizarEmpresa(ClasseDTO empresa)
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("UPDATE empresa SET nome = @nome, telefone = @telefone, descricao = @descricao WHERE idEmpresa = @idEmpresa", conexao);

                comando.Parameters.AddWithValue("@idEmpresa", empresa.IdEmpresa);
                comando.Parameters.AddWithValue("@nome", empresa.Nome);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@descricao", empresa.DescEmpresa);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================


            // MÉTODO PARA EXCLUIR AS EMPRESAS

        public void ExcluirEmpresa(ClasseDTO empresa)
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                comando = new MySqlCommand("DELETE FROM  empresa WHERE idEmpresa = @idEmpresa", conexao);

                comando.Parameters.AddWithValue("@idEmpresa", empresa.IdEmpresa);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }



    }
}
