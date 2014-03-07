using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GPS.Xadres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<PecaXadres> Pecas;
        private PecaXadres PecaSelecionada;
        private Grid GridDaPecaSelecionada;
        private List<PecaXadres> ListaLugaresValidos = new List<PecaXadres>();

        public MainWindow()
        {
            InitializeComponent();


            this.Pecas = new ObservableCollection<PecaXadres>()
                                {
                                    new PecaXadres
                                        {Pos = new Point(0, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(1, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(2, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(3, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(4, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(5, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(6, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(7, 6), Tipo = TipoPeca.Peao, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(0, 7), Tipo = TipoPeca.Torre, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(1, 7), Tipo = TipoPeca.Cavalo, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(2, 7), Tipo = TipoPeca.Bispo, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(3, 7), Tipo = TipoPeca.Rei, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(4, 7), Tipo = TipoPeca.Rainha, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(5, 7), Tipo = TipoPeca.Bispo, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(6, 7), Tipo = TipoPeca.Cavalo, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(7, 7), Tipo = TipoPeca.Torre, Jogador = Jogador.Branco},
                                    new PecaXadres
                                        {Pos = new Point(0, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(1, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(2, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(3, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(4, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(5, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(6, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(7, 1), Tipo = TipoPeca.Peao, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(0, 0), Tipo = TipoPeca.Torre, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(1, 0), Tipo = TipoPeca.Cavalo, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(2, 0), Tipo = TipoPeca.Bispo, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(3, 0), Tipo = TipoPeca.Rei, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(4, 0), Tipo = TipoPeca.Rainha, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(5, 0), Tipo = TipoPeca.Bispo, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(6, 0), Tipo = TipoPeca.Cavalo, Jogador = Jogador.Preto},
                                    new PecaXadres
                                        {Pos = new Point(7, 0), Tipo = TipoPeca.Torre, Jogador = Jogador.Preto} 
                                };

            this.ChessBoard.ItemsSource = this.Pecas;

        }



        private void GridMouseDown1(object sender, MouseButtonEventArgs e)
        {
           
            Grid grid = (Grid)sender;
            PecaXadres peca = (PecaXadres)grid.DataContext;

            if (peca.Tipo == TipoPeca.LugarValido)
            {
                
                if (!PecaSelecionada.Pos.Equals(peca.Pos))
                {
                    PecaSelecionada.Pos = new Point(peca.Pos.X, peca.Pos.Y);
                    PecaSelecionada = null;
                    EliminarLugaresValidos();
                    GridDaPecaSelecionada.Background = null;
                }
            }
            else
            {
                    if (GridDaPecaSelecionada != null)
                    {
                        GridDaPecaSelecionada.Background = null;
                        EliminarLugaresValidos();
                    }
                
                    PecaSelecionada = peca;
                    MarcarLocaisValidos(peca);
                    
                    grid.Background = Brushes.Yellow;
                    GridDaPecaSelecionada = grid;     
                    
                
            }
            
        }

        private void MarcarLocaisValidos(PecaXadres peca)                                                                       
        {

            
            switch (peca.Tipo)
            {
                case TipoPeca.Peao:
                    
                    PossibilidadeMovimento.Peao(peca, ref ListaLugaresValidos, ref Pecas);
                    
                    break;
                case TipoPeca.Torre:

                    PossibilidadeMovimento.Torre(peca, ref ListaLugaresValidos, ref Pecas);

                    break;
                case TipoPeca.Bispo:

                    PossibilidadeMovimento.Bispo(peca, ref ListaLugaresValidos, ref Pecas);

                    break;
                case TipoPeca.Cavalo:

                    PossibilidadeMovimento.Cavalo(peca, ref ListaLugaresValidos, ref Pecas);    

                    break;
                case TipoPeca.Rainha:

                    PossibilidadeMovimento.Bispo(peca, ref ListaLugaresValidos, ref Pecas);
                    PossibilidadeMovimento.Torre(peca, ref ListaLugaresValidos, ref Pecas);

                    break;
                case TipoPeca.Rei:

                    PossibilidadeMovimento.Rei(peca, ref ListaLugaresValidos, ref Pecas);
                    break;
            }


        }

        private void Canvas_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

            Canvas canvas = (Canvas)sender;

            Point pontoEscolhido = Mouse.GetPosition(canvas);
            double pontoX = Math.Truncate(pontoEscolhido.X);
            double pontoY = Math.Truncate(pontoEscolhido.Y);

        }

        private void VerificarTudo()
        {

            //foreach (FrameworkElement fe in this.CanvasXadres.Children)
            //{

            //    // example 0
            //    double top = (double)fe.GetValue(Canvas.TopProperty);
            //    double left = (double)fe.GetValue(Canvas.LeftProperty);

            //    // example 1
            //    double top1 = Canvas.GetTop(fe);
            //    double left1 = Canvas.GetLeft(fe);

            //}
        }

        private void EliminarLugaresValidos()
        {
            foreach (PecaXadres px in ListaLugaresValidos)
            {
                Pecas.Remove(px);
            }

        }




    }
}
