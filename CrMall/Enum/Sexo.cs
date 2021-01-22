using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CrMall.Enum
{
    public enum Sexo
    {
        [Display(Name = "Selecione")]
        Selecione,
        [Display(Name = "Masculino")]
        Masculino,
        [Display(Name = "Feminino")]
        Feminino 
    }


}
