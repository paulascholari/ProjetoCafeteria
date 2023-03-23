using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCafeteria.Classes
{
    internal class Login
    {
        // guarda o id do funcinario 
        private static int FuncionarioId { get; set; } = -1;
        // Salva id do funcionario 
        public static void SalvarFuncionarioId(int id) { 
            FuncionarioId = id;
        }
        //pega o id do funcionario salvo
        public static int PegarFuncinarioId() { return FuncionarioId; }
    }
}
