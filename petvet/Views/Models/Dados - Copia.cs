namespace petvet.Models
{
    public static class Dados
    {
        public static InfoAgenda ConsutaAtual { get; set; }
        
        static Dados()
        {
            ConsutaAtual = new InfoAgenda();
        }
    }
}