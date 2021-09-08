using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2_Carlos_Daniel_Thiago_Formento.Model
{
    class Functions
    {
        public static string[] GeraLista()
        {
            string[] letras = new string[9];

            Random ran = new Random();

            for (int i = 0; i < 9; i++)
            {

                if (i == 0)
                {
                    if (ran.Next(1, 3) == 1)
                    {
                        letras[0] = "A";
                    }
                    else
                    {
                        letras[0] = "D";
                    }
                }
                if (i == 1)
                {
                    if (ran.Next(1, 3) == 1)
                    {
                        letras[1] = "E";
                    }
                    else
                    {
                        letras[1] = "F";
                    }
                }
                if (i == 2)
                {
                    if (ran.Next(1, 3) == 1)
                    {
                        letras[2] = "B";
                    }
                    else
                    {
                        letras[2] = "C";
                    }
                }
                if (i == 3)
                {
                    int valor = ran.Next(1, 4);

                    if (valor == 1)
                    {
                        letras[3] = "G";
                    }
                    else if (valor == 2)
                    {
                        letras[3] = "I";
                    }
                    else
                    {
                        letras[3] = "U";
                    }
                }
                if (i == 4)
                {
                    int valor = ran.Next(1, 4);

                    if (valor == 1)
                    {
                        letras[4] = "H";
                    }
                    else if (valor == 2)
                    {
                        letras[4] = "J";
                    }
                    else
                    {
                        letras[4] = "V";
                    }
                }
                if (i == 5)
                {
                    if (ran.Next(1, 3) == 1)
                    {
                        letras[5] = "K";
                    }
                    else
                    {
                        letras[5] = "L";
                    }
                }
                if (i == 6)
                {
                    int valor = ran.Next(1, 4);

                    if (valor == 1)
                    {
                        letras[6] = "M";
                    }
                    else if (valor == 2)
                    {
                        letras[6] = "O";
                    }
                    else
                    {
                        letras[6] = "Q";
                    }
                }
                if (i == 7)
                {
                    int valor = ran.Next(1, 4);

                    if (valor == 1)
                    {
                        letras[7] = "N";
                    }
                    else if (valor == 2)
                    {
                        letras[7] = "T";
                    }
                    else
                    {
                        letras[7] = "P";
                    }
                }
                if (i == 8)
                {
                    int valor = ran.Next(1, 4);

                    if (valor == 1)
                    {
                        letras[8] = "R";
                    }
                    else if (valor == 2)
                    {
                        letras[8] = "S";
                    }
                    else
                    {
                        letras[8] = "Z";
                    }
                }
            }

            return letras;

        } //Gambiarra Forte

        /*Basicamente, cria-se uma matriz com 4 linhas, 4 colunas, onde ela so terá valores a partir do indice 1,1 e irá até o indice 3,3.
        *É feito desta forma, pois como o sistema pega um indice e verifica todas as possibilidades ao seu redor, se a verificação comessase 
        *do indice 0,0, e quando fosse verificar ao seu redor, iria dar erro de (Range), então por isso ao redor dos elementos possui indices 
        *nulos.
        */

        public static string Verificar(string[][] matriz, string text)
        {
            int indice = 0;
            int pontos = 0;
            bool possui = false;

            List<Indices> indicesUsados = new List<Indices>();

            for (int l = 1; l < 4; l++)
            {
                for (int c = 1; c < 4; c++)
                {

                    if (indice < text.Length && matriz[l][c] == Convert.ToString(text[indice]))
                    {
                        var indices = new Indices(l, c);
                        indicesUsados.Add(indices);

                        indice++;
                        pontos++;

                        if (indice < text.Length && matriz[l][c - 1] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l && item.coluna == c - 1)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4; //para sair for's
                                c = 4; //para sair for's
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                c -= 2; //diminui 2 pois o for incrementa, ou seja, vai para a posição desejada de automático
                            }

                        }
                        else if (indice < text.Length && matriz[l - 1][c - 1] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l - 1 && item.coluna == c - 1)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                l--;
                                c -= 2;
                            }
                        }
                        else if (indice < text.Length && matriz[l - 1][c] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l - 1 && item.coluna == c)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                c--;
                                l--;
                            }

                        }
                        else if (indice < text.Length && matriz[l - 1][c + 1] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l - 1 && item.coluna == c + 1)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                l--;
                            }
                        }
                        else if (indice < text.Length && matriz[l][c + 1] == Convert.ToString(text[indice]))
                        {
                            //veficação somente para nao cair no else

                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l && item.coluna == c + 1)
                                {
                                    possui = true;
                                }
                            }

                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }
                        }
                        else if (indice < text.Length && matriz[l + 1][c + 1] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l + 1 && item.coluna == c + 1)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                l++;
                            }
                        }
                        else if (indice < text.Length && matriz[l + 1][c] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l + 1 && item.coluna == c + 1)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                l++;
                                c--;
                            }

                        }
                        else if (indice < text.Length && matriz[l + 1][c - 1] == Convert.ToString(text[indice]))
                        {
                            foreach (var item in indicesUsados)
                            {
                                if (item.linha == l + 1 && item.coluna == c - 1)
                                {
                                    possui = true;
                                }
                            }
                            if (possui)
                            {
                                l = 4;
                                c = 4;
                            }

                            //operações feitas, para que vá a posição deseja, levando em conta o incremento dos for's, como por exemplo:
                            else
                            {
                                l++;
                                c -= 2;
                            }
                        }
                        else
                        {
                            l = 4; //para sair for's
                            c = 4; //para sair for's

                        }
                    }
                }
            }

            return pontos.ToString();

        }
    }
}
