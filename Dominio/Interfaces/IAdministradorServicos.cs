using dio_minimal_api.Dominio.Dtos;
using dio_minimal_api.Dominio.Entidades;

namespace dio_minimal_api.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDto loginDto);
    Administrador Incluir(Administrador administrador);
    Administrador? BuscaPorId(int id);
    List<Administrador> Todos(int? pagina);
}