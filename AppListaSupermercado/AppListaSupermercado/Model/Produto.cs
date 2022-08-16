﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppListaSupermercado.Model
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string Descricao { get; set; }

        public double Preco { get; set; }

        public double Quantidade { get; set; }

    }
}
