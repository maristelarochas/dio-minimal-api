using dio_minimal_api.Dominio.Interfaces;
using dio_minimal_api.Dominio.Entidades;
using dio_minimal_api.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;

namespace dio_minimal_api.Dominio.Servicos;
public class VeiculoServico(DbContexto contexto) : IVeiculoServico
{
    public void Apagar(Veiculo veiculo)
    {
        contexto.Veiculos.Remove(veiculo);
        contexto.SaveChanges();
    }

    public void Atualizar(Veiculo veiculo)
    {
        contexto.Veiculos.Update(veiculo);
        contexto.SaveChanges();
    }

    public Veiculo? BuscaPorId(int id)
    {
        return contexto.Veiculos.Where(v => v.Id == id).FirstOrDefault();
    }

    public void Incluir(Veiculo veiculo)
    {
        contexto.Veiculos.Add(veiculo);
        contexto.SaveChanges();
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        var query = contexto.Veiculos.AsQueryable();
        if(!string.IsNullOrEmpty(nome))
        {
            query = query.Where(v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome}%"));
        }

        int itensPorPagina = 10;

        if(pagina != null)
            query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);

        return query.ToList();
    }
}