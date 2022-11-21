using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz
{
    public class Questao
    {
        public Pergunta Pergunta { get; set; }
        public IEnumerable<Resposta> Respostas { get; set; }

        public Questao(Pergunta pergunta, IEnumerable<Resposta> respostas)
        {
            Pergunta = pergunta;
            Respostas = respostas;
        }

        public string DevolveRespostaCerta(Pergunta pergunta)
        {
            return pergunta.RespostaCerta.EnunciadoResposta;
        }
        public string VerificaAcertou(Pergunta pergunta, Resposta resposta)
        {
            if(resposta.RespostaId == pergunta.RespostaCerta.RespostaId)
            {
                return "certo";
            }
            else
            {
                return "errado";
            }
        }

    }
}
