using System.ComponentModel.DataAnnotations;

namespace MVC.Controllers
{
    public class VMOperador
    {

        public List<VMOperador> ListaOperadores;

        public VMOperador()
        {
            ListaOperadores = new List<VMOperador>();
        }
        public byte[] ByteArray { get; set; }
        public int CD_USUARIO { get; set; }
        public int CD_LOG_USUARIO { get; set; }

        [Required]
        public string NM_NOME { get; set; }
        public string t { get; set; }

        public DateTime DT_INICIO { get; set; }
        public DateTime DT_FIM { get; set; }
        [Required]
        public string CPF { get; set; }
        public string NM_SENHA { get; set; }
        public bool FL_OPERADOR { get; set; }
        public bool FL_ADMINISTRADOR { get; set; }
        public bool FL_ATIVO { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DT_CRIACAO { get; set; }
        public bool Cadastrado { get; set; }
        public bool Autorizado { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }

        public bool KeepLoggedIn { get; set; }

        public bool FL_MUDA_SENHA { get; set; }

    }
}