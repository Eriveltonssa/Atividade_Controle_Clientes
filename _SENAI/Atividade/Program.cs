﻿using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {
                // Pessoa Física 
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Nome = var_nome;
                pf.Endereço = var_endereco;
                Console.WriteLine("Informe CPF:");
                pf.CPF = Console.ReadLine();
                Console.WriteLine("Informe RG:");
                pf.RG = Console.ReadLine();
                Console.WriteLine("Informe Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("--------Pessoa Física---------");

                Console.WriteLine("Nome ........:" + pf.Nome);
                Console.WriteLine("Endereço ........:" + pf.Endereço);
                Console.WriteLine("CPF ........:" + pf.CPF);
                Console.WriteLine("RG ........:" + pf.RG);
                Console.WriteLine("Valor de Compra ........:" + val_pag.ToString("C"));
                Console.WriteLine("Imposto ........:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar ........:" + pf.total.ToString("C"));
            }
            else if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_nome;
                pj.Endereço = var_endereco;
                Console.WriteLine("Informe CNPJ:");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine("Informe IE:");
                pj.IE = Console.ReadLine();
                Console.WriteLine("Informe Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("--------Pessoa Jurídica---------");

                Console.WriteLine("Nome ........:" + pj.Nome);
                Console.WriteLine("Endereço ........:" + pj.Endereço);
                Console.WriteLine("CNPJ ........:" + pj.CNPJ);
                Console.WriteLine("IE ........:" + pj.IE);
                Console.WriteLine("Valor de Compra ........:" + val_pag.ToString("C"));
                Console.WriteLine("Imposto ........:" + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar ........:" + pj.total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }


}