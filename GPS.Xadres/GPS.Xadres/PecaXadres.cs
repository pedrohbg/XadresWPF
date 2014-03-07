using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;

namespace GPS.Xadres
{
    public class PecaXadres : ViewModelBase
    {
        private Point _Pos;
        public Point Pos
        {
            get { return this._Pos; }
            set { this._Pos = value; RaisePropertyChanged(() => this.Pos); }
        }

        private TipoPeca _Tipo;
        public TipoPeca Tipo
        {
            get { return this._Tipo; }
            set { this._Tipo = value; RaisePropertyChanged(() => this.Tipo); }
        }

        private Jogador _Jogador;
        public Jogador Jogador
        {
            get { return this._Jogador; }
            set { this._Jogador = value; RaisePropertyChanged(() => this.Jogador); }
        }
    }
}
