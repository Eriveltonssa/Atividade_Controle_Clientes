 class Pessoa_Fisica
    {
        public string Nome;
        public string Endereço;
        public string CPF;
        public string RG;
        public float valor_imposto;
        public float total;

        public void Pagar_Imposto(float valor)
        {
            valor_imposto = valor * 0.1f; // Assuming 10% tax rate for simplicity
            total = valor + valor_imposto;
        }
    }