using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_minimal_api.Dominio.Dtos;
public class VeiculoDto
{
    public string Nome { get; set; } = default!;
    public string Marca { get; set; } = default!;
    public int Ano { get; set; } = default!;
}
