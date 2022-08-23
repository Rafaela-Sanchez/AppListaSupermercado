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
        public Task<int> Insert(Produto p)
        {
            return con.InsertAsync(p);
        }


        /** 
         * string SQL que vai fazer as atualizações nos seguintes campos da tabela (formulário)
         */

        public void Update(Produto p)
        {
            string sql = "UPDATE Produto SEt Descricao=?, Quantidade=?, Preco=? WHERE id =? ";

            con.QueryAsync<Produto>(sql, p.Descricao, p.Quantidade, p.Preco, p.Id);
        }


        /**
         * consulta o banco de dados e retorna uma lista de produtos (array de objetos)
         */

        public Task<List<Produto>> GetAll()
        {
            return con.Table<Produto>().ToListAsync();
            /** retorna todos os regsitros da tabela em forma de lista*/
        }


        public Task<int> Delete(int id)
        {
            return con.Table<Produto>().DeleteAsync(i => i.Id == id);
            /* Fazer um delete na tabela produto, para cada item da tabela onde 
             * o Id do item seja igual o Id recebido como parêmtro
             */
        }
    }
}
