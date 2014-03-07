using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GPS.Xadres
{
    public class PossibilidadeMovimento
    {
        
        public static void Peao(PecaXadres peca, ref List<PecaXadres> ListaLugaresValidos, ref ObservableCollection<PecaXadres> Pecas)
        {
            double xValido = -1;
            double yValido = -1;

            if (peca.Jogador == Jogador.Branco)
            {
                yValido = peca.Pos.Y - 1;
            }
            else
            {
                yValido = peca.Pos.Y + 1;
            }
            PecaXadres vPeao = new PecaXadres();
            vPeao.Tipo = TipoPeca.LugarValido;
            vPeao.Jogador = Jogador.GM;
            vPeao.Pos = new Point(peca.Pos.X, yValido);
            Pecas.Add(vPeao);
            ListaLugaresValidos.Add(vPeao);

            

        }

        public static void Torre(PecaXadres peca, ref List<PecaXadres> ListaLugaresValidos, ref ObservableCollection<PecaXadres> Pecas)
        {
            

            for (double i = peca.Pos.Y; i < 8; i++)
            {
                PecaXadres vTorre = new PecaXadres();
                vTorre.Tipo = TipoPeca.LugarValido;
                vTorre.Jogador = Jogador.GM;
                vTorre.Pos = new Point(peca.Pos.X, i);
                bool pecaAmiga =
                    Pecas.Any(item => item.Pos.Equals(new Point(peca.Pos.X, i)) && item.Jogador.Equals(peca.Jogador));
                if (pecaAmiga && !vTorre.Pos.Equals(peca.Pos))
                {
                    break;
                }
                if (!vTorre.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vTorre);
                    ListaLugaresValidos.Add(vTorre);
                    
                }
                

            }
            for (double i = peca.Pos.Y; i >= 0; i--)
            {
                PecaXadres vTorre = new PecaXadres();
                vTorre.Tipo = TipoPeca.LugarValido;
                vTorre.Jogador = Jogador.GM;
                vTorre.Pos = new Point(peca.Pos.X, i);
                bool pecaAmiga =
                    Pecas.Any(item => item.Pos.Equals(new Point(peca.Pos.X, i)) && item.Jogador.Equals(peca.Jogador));
                if (pecaAmiga && !vTorre.Pos.Equals(peca.Pos))
                {
                    break;
                }
                if (!vTorre.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vTorre);
                    ListaLugaresValidos.Add(vTorre);
                    
                }


            }
            for (double i = peca.Pos.X; i < 8; i++)
            {
                PecaXadres vTorre = new PecaXadres();
                vTorre.Tipo = TipoPeca.LugarValido;
                vTorre.Jogador = Jogador.GM;
                vTorre.Pos = new Point(i, peca.Pos.Y);

                bool pecaAmiga = Pecas.Any(item => item.Pos.Equals(new Point(i, peca.Pos.Y)) && item.Jogador.Equals(peca.Jogador));

                if (pecaAmiga && !vTorre.Pos.Equals(peca.Pos))
                {
                    break;
                }
                if (!vTorre.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vTorre);
                    ListaLugaresValidos.Add(vTorre);
                    
                }

            }
            for (double i = peca.Pos.X; i >= 0; i--)
            {
                PecaXadres vTorre = new PecaXadres();
                vTorre.Tipo = TipoPeca.LugarValido;
                vTorre.Jogador = Jogador.GM;
                vTorre.Pos = new Point(i, peca.Pos.Y);

                bool pecaAmiga = Pecas.Any(item => item.Pos.Equals(new Point(i, peca.Pos.Y)) && item.Jogador.Equals(peca.Jogador));

                if (pecaAmiga && !vTorre.Pos.Equals(peca.Pos))
                {
                    break;
                }
                if (!vTorre.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vTorre);
                    ListaLugaresValidos.Add(vTorre);
                    
                }
            }

            

        }

        public static void Bispo(PecaXadres peca, ref List<PecaXadres> ListaLugaresValidos, ref ObservableCollection<PecaXadres> Pecas)
        {

            double bPosX = peca.Pos.X;
            double bPosY = peca.Pos.Y;

            double bPosX2 = peca.Pos.X;
            double bPosY2 = peca.Pos.Y;

            double bPosX3 = peca.Pos.X;
            double bPosY3 = peca.Pos.Y;

            double bPosX4 = peca.Pos.X;
            double bPosY4 = peca.Pos.Y;

            for (int i = 0; i < 8; i++)
            {
                PecaXadres vBispo = new PecaXadres();
                vBispo.Tipo = TipoPeca.LugarValido;
                vBispo.Jogador = Jogador.GM;
                vBispo.Pos = new Point(bPosX++, bPosY++);
                bool pecaAmiga =
                    Pecas.Any(item => item.Pos.Equals(new Point(bPosX, bPosY)) && item.Jogador.Equals(peca.Jogador));
                if (pecaAmiga)
                {
                    break;
                }
                if (!vBispo.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vBispo);
                    ListaLugaresValidos.Add(vBispo);

                }
            }
            for (int i = 0; i < 8; i++)
            {

                PecaXadres vBispo = new PecaXadres();
                vBispo.Tipo = TipoPeca.LugarValido;
                vBispo.Jogador = Jogador.GM;
                vBispo.Pos = new Point(bPosX2--, bPosY2--);
                bool pecaAmiga = Pecas.Any(item => item.Pos.Equals(new Point(bPosX2, bPosY2)) && item.Jogador.Equals(peca.Jogador));
                if (pecaAmiga)
                {
                    break;
                }
                if (!vBispo.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vBispo);
                    ListaLugaresValidos.Add(vBispo);
                }

            }
            for (int i = 0; i < 8; i++)
            {
                PecaXadres vBispo = new PecaXadres();
                vBispo.Tipo = TipoPeca.LugarValido;
                vBispo.Jogador = Jogador.GM;
                vBispo.Pos = new Point(bPosX3++, bPosY3--);
                bool pecaAmiga = Pecas.Any(item => item.Pos.Equals(new Point(bPosX3, bPosY3)) && item.Jogador.Equals(peca.Jogador));
                if (pecaAmiga)
                {
                    break;
                }
                if (!vBispo.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vBispo);
                    ListaLugaresValidos.Add(vBispo);
                }

            }
            for (int i = 0; i < 8; i++)
            {
                PecaXadres vBispo = new PecaXadres();
                vBispo.Tipo = TipoPeca.LugarValido;
                vBispo.Jogador = Jogador.GM;
                vBispo.Pos = new Point(bPosX4--, bPosY4++);
                bool pecaAmiga = Pecas.Any(item => item.Pos.Equals(new Point(bPosX4, bPosY4)) && item.Jogador.Equals(peca.Jogador));
                if (pecaAmiga)
                {
                    break;
                }
                if (!vBispo.Pos.Equals(peca.Pos))
                {
                    Pecas.Add(vBispo);
                    ListaLugaresValidos.Add(vBispo);
                }

            }

            


        }

        public static void Cavalo(PecaXadres peca, ref List<PecaXadres> ListaLugaresValidos, ref ObservableCollection<PecaXadres> Pecas)
        {
            
            double cPosX = peca.Pos.X;
            double cPosY = peca.Pos.Y;

            PecaXadres vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX + 1, cPosY + 2);

            bool pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }
            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX + 2, cPosY + 1);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }

            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX + 2, cPosY - 1);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }


            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX + 1, cPosY - 2);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }


            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX - 1, cPosY - 2);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }


            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX - 2, cPosY - 1);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }


            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX - 2, cPosY + 1);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }


            vCavalo = new PecaXadres();
            vCavalo.Tipo = TipoPeca.LugarValido;
            vCavalo.Jogador = Jogador.GM;
            vCavalo.Pos = new Point(cPosX - 1, cPosY + 2);
            pecaAmiga = Pecas.Any(item => item.Pos.Equals(vCavalo.Pos) && item.Jogador.Equals(peca.Jogador));
            if (!pecaAmiga)
            {
                Pecas.Add(vCavalo);
                ListaLugaresValidos.Add(vCavalo);
            }

            

        }
        public static void Rei(PecaXadres peca, ref List<PecaXadres> ListaLugaresValidos, ref ObservableCollection<PecaXadres> Pecas)
        {

            

            for (int i =0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {


                    PecaXadres vRei = new PecaXadres();
                    vRei.Tipo = TipoPeca.LugarValido;
                    vRei.Jogador = Jogador.GM;
                    vRei.Pos = new Point(peca.Pos.X + i, peca.Pos.Y+j);
                    if (!peca.Pos.Equals(vRei.Pos))
                    {
                        Pecas.Add(vRei);
                        ListaLugaresValidos.Add(vRei);
                    }
                    
                    vRei = new PecaXadres();
                    vRei.Tipo = TipoPeca.LugarValido;
                    vRei.Jogador = Jogador.GM;
                    vRei.Pos = new Point(peca.Pos.X - i, peca.Pos.Y - j);
                    if (!peca.Pos.Equals(vRei.Pos))
                    {
                        Pecas.Add(vRei);
                        ListaLugaresValidos.Add(vRei);
                    }


                    vRei = new PecaXadres();
                    vRei.Tipo = TipoPeca.LugarValido;
                    vRei.Jogador = Jogador.GM;
                    vRei.Pos = new Point(peca.Pos.X + i, peca.Pos.Y - j);
                    if (!peca.Pos.Equals(vRei.Pos))
                    {
                        Pecas.Add(vRei);
                        ListaLugaresValidos.Add(vRei);
                    }


                    vRei = new PecaXadres();
                    vRei.Tipo = TipoPeca.LugarValido;
                    vRei.Jogador = Jogador.GM;
                    vRei.Pos = new Point(peca.Pos.X - i, peca.Pos.Y + j);
                    if (!peca.Pos.Equals(vRei.Pos))
                    {
                        Pecas.Add(vRei);
                        ListaLugaresValidos.Add(vRei);
                    }

                }
            }

            
        }

    }
}
