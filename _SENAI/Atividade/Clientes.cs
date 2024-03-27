namespace Atividade
{
    class Clientes
    {
        // Properties
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }

        // Method to calculate and set tax and total
        public virtual void PagarImposto(float valor, float taxaImposto)
        {
            Valor = valor;
            ValorImposto = Valor * taxaImposto;
            Total = Valor + ValorImposto;
        }
    }
}