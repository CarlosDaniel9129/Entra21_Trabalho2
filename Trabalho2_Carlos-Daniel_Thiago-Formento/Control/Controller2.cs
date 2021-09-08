using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho2_Carlos_Daniel_Thiago_Formento.Model;
using Trabalho2_Carlos_Daniel_Thiago_Formento.Control;

namespace Trabalho2_Carlos_Daniel_Thiago_Formento.Control
{
    class Controller2
    {

        public static List<string> palavras = new List<string>();

        public static string[] GeraTabela()
        {
            return Functions.GeraLista();
        }

        public static string Verifica(string[][] matriz, string text)
        {
            bool possui = false;

            foreach (var item in palavras)
            {
                if (text == item.ToString())
                {
                    possui = true;
                }
            }

            if (possui)
            {
                return "POSSUI";
            }
            else
            {
                palavras.Add(text);
                return Functions.Verificar(matriz, text);
            }
        }

    }
}
