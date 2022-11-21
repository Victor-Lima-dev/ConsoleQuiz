namespace ConsoleQuiz
{
    public class Resposta
    {

        public string EnunciadoResposta { get; set; }
        public int RespostaId { get; set; }

        public Resposta(string enunciadoResposta, int respostaId)
        {
            EnunciadoResposta = enunciadoResposta;
            RespostaId = respostaId;
         
        }
    }
}