namespace At_Gerenciamento_de_Eletrodomésticos.Models
{
    public class Televisor : Eletrodomestico
    {
        public int TamanhoTela { get; set; }

        public bool EhSmart { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Tela: {TamanhoTela}, EhSmart: {(EhSmart? "Sim" : "Não")}";

        }
    }
}
