using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Comercial___Marine_Center
{
    class Produto
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private double _preco_venda;

        public double Preco_venda
        {
            get { return _preco_venda; }
            set { _preco_venda = value; }
        }
        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private int _quantidade;

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        private double _preco_custo;

        public double Preco_custo
        {
            get { return _preco_custo; }
            set { _preco_custo = value; }
        }

        private string _partNumber;

        public string PartNumber
        {
            get { return _partNumber; }
            set { _partNumber = value; }
        }

        private int quantidaAnterior;

        public int QuantidaAnterior
        {
            get { return quantidaAnterior; }
            set { quantidaAnterior = value; }
        }

    }
}
