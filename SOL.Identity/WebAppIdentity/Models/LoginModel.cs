using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppIdentity.Models
{
    public class LoginModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)] // Importar o DataAnnotations
        public string Password { get; set; }
    }
}
