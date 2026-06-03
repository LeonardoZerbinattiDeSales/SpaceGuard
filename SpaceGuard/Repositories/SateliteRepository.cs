using SpaceGuard.Interfaces;
using SpaceGuard.Models;

namespace SpaceGuard.Repositories;

public class SateliteRepository : ISateliteRepository
{
    private readonly List<Satelite> _satelites = [];

    public IEnumerable<Satelite> ObterTodos()
    {
        return _satelites;
    }

    public Satelite? ObterPorId(int id)
    {
        return _satelites.FirstOrDefault(s => s.Id == id);
    }

    public void Adicionar(Satelite satelite)
    {
        _satelites.Add(satelite);
    }

    public void Atualizar(Satelite satelite)
    {
        var existente = ObterPorId(satelite.Id);

        if (existente != null)
        {
            existente.Nome = satelite.Nome;
            existente.PaisOrigem = satelite.PaisOrigem;
            existente.DataLancamento = satelite.DataLancamento;
        }
    }

    public void Remover(int id)
    {
        var satelite = ObterPorId(id);

        if (satelite != null)
        {
            _satelites.Remove(satelite);
        }
    }
}