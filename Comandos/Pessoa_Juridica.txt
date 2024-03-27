class Pessoa_Juridica
    {
        public string Nome;
        public string Endereço;
        public string CNPJ;
        public string IE;
        public float valor_imposto;
        public float total;

        public void Pagar_Imposto(float valor)
        {
            valor_imposto = valor * 0.15f; 
            total = valor + valor_imposto;
        }
    }