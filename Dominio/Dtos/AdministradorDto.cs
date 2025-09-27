using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_minimal_api.Dominio.Enuns;

namespace dio_minimal_api.Dominio.Dtos;
public class AdministradorDto
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public Perfil? Perfil { get; set; } = default!;
}
