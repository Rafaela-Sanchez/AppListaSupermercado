using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppListaSupermercado.Helper;
using System.IO;

namespace AppListaSupermercado
{
    public partial class App : Application
    {

        /*Definir um campo que vai armazenar o local do arquivo db3
         */

        static SQLiteDatabaseHelper database;

        /* Quando utilizada a propriedade database, teremos acesso ao arquivo do SQLite
         * por meio da classe SQLiteDatabaseHelper que fornece os métodos
         */

        public static SQLiteDatabaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    /* Definição de uma string que vai ser o caminho; 
                     * O caminho vai identificar o ambiente que o app esta instalado para guardar o arquivo 
                     */

                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        "arquivo.db3");

                    database = new SQLiteDatabaseHelper(path);
                }

                /* retorna o campo database
                 */
                return database;
            }

        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ListaProdutos());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
