using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{
    public class Pergunta
    {
        //public int PerguntaId { get; set; }
        public string EnunciadoPergunta { get; set; }

        public Resposta RespostaCerta { get; set; }

        public Pergunta(string enunciadoPergunta, Resposta respostaCerta)
        {
            EnunciadoPergunta = enunciadoPergunta;
            RespostaCerta = respostaCerta;
        }
        //public string Materia { get; set; }
    }
}
