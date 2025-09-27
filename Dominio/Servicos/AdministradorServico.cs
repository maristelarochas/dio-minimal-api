using dio_minimal_api.Dominio.Dtos;
using dio_minimal_api.Dominio.Entidades;
using dio_minimal_api.Infraestrutura.Db;
using dio_minimal_api.Interfaces;

namespace dio_minimal_api.Dominio.Servicos;

public class AdministradorServico(DbContexto contexto) : IAdministradorServico
{
    public Administrador? BuscaPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Administrador Incluir(Administrador administrador)
    {
        throw new NotImplementedException();
    }

    public Administrador? Login(LoginDto loginDto)
    {
        var adm = contexto.Administradores.Where(a => a.Email == loginDto.Email && a.Senha == loginDto.Senha).FirstOrDefault();
        return adm;
    }

    public List<Administrador> Todos(int? pagina)
    {
        throw new NotImplementedException();
    }
}
