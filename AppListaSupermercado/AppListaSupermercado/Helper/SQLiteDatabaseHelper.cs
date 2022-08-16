using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using AppListaSupermercado.Model;


namespace AppListaSupermercado.Helper
{
    public class SQLiteDatabaseHelper
    {
        /** Arquivo somente leitura, que abre uma conexão assíncrona, sem interferir no fluxo
         * principal do aplicativo
         */

        readonly SQLite.SQLiteAsyncConnection con;

        /** método construtor que abre uma conexão com o banco de forma assíncrona.
         * Path = caminho -> onde o arquivo se encontra
         */

        public SQLiteDatabaseHelper (string path)
        {
            con = new SQLite.SQLiteAsyncConnection (path);

            /** criando uma tabela de forma assíncrona, baseada no model produto
             */

            con.CreateTableAsync<Produto>().Wait();

        }


        /**
         * O método insert espera receber um modelo preenchido 
         * para que ele seja garavdo no banco de dados :)
         * Pega o que o usuário digitou na interface gráfica e preenche os campos da classe.
         * Uma vez que preenchido, pode ser transportado de lugar (I.G para Helper- gravar no sqlite)
         */
        public void insert(Produto p)
        {

        }

        public void update(Produto p)
        {

        }

        public Task<Produto> GetById(int id)
        {
            return new Produto();
        }

        public Task<List<Produto>> getAll()
        {

        }

        public void delete(int id)
        {

        }
    }
}
