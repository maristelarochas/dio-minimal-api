using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_minimal_api.Dominio.Dtos;
public class LoginDto
{
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}