using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Account_Control.DAL;
using Account_Control.DTO;

namespace Account_Control.BLL
{
    class ClasseBLL
    {
        ClasseDAL dal = null;

        // MÉTODOS DA CONTAS

        // ===============================================

            // MÉTODO PARA LISTAR AS CONTAS NO DATA GRID

        public DataTable ListaContaDal()
        {
            try
            {
                dal = new ClasseDAL();

                DataTable Dt = new DataTable();

                Dt = dal.ListaConta();

                return Dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        // ===============================================

        // MÉTODO PARA LISTAR AS EMPRESAS NO COMBO BOX

        public DataTable ListaEmpresaComboDal()
        {
            try
            {
                dal = new ClasseDAL();

                DataTable Dt = new DataTable();

                Dt = dal.ListaEmpresa();

                return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // ===============================================

        // MÉTODO PARA SALVAR AS CONTAS

        public void SalvarContaDal(ClasseDTO conta)
        {
            try
            {
                dal = new ClasseDAL();

                dal.SalvarConta(conta);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

        // MÉTODO PARA ATUALIZAR AS CONTAS

        public void AtualizarContaDal(ClasseDTO conta)
        {
            try
            {
                dal = new ClasseDAL();

                dal.AtualizaConta(conta);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================
        
            // MÉTODO PARA EXCLUIR AS CONTAS

        public void ExcluirContasDal(ClasseDTO conta)
        {
            try
            {
                dal = new ClasseDAL();

                dal.ExcluirContas(conta);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        /*=================================================================================================================*/

        // MÉTODOS DAS EMPRESAS

        // ===============================================

        // MÉTODO PARA LISTAR AS EMPRESAS NO DATA GRID

        public DataTable ListaEmpresaDal()
        {
            try
            {
                dal = new ClasseDAL();

                DataTable Dt = new DataTable();

                Dt = dal.ListaEmpresa();

                return Dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        // ===============================================

        // MÉTODO PARA SALVAR AS EMPRESAS
        
        public void SalvarEmpresaDal(ClasseDTO empresa)
        {
            try
            {
                dal = new ClasseDAL();

                dal.SalvarEmpresa(empresa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

            // MÉTODO PARA ATUALIZAR AS EMPRESA

        public void AtualizarEmpresaDal(ClasseDTO empresa)
        {
            try
            {
                dal = new ClasseDAL();

                dal.AtualizarEmpresa(empresa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

            // MÉTODO PARA EXCLUIR AS EMPRESAS

        public void ExcluirEmpresaDal(ClasseDTO empresa)
        {
            try
            {
                dal = new ClasseDAL();

                dal.ExcluirEmpresa(empresa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

    }
}
