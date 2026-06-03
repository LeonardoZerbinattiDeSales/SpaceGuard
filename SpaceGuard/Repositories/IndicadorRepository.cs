using SpaceGuard.Interfaces;
using SpaceGuard.Models;

namespace SpaceGuard.Repositories;

public class IndicadorRepository : IIndicadorRepository
{
    private readonly List<IndicadorAmbiental> _indicadores = [];

    public IEnumerable<IndicadorAmbiental> ObterTodos()
    {
        return _indicadores;
    }

    public IndicadorAmbiental? ObterPorId(int id)
    {
        return _indicadores.FirstOrDefault(i => i.Id == id);
    }

    public void Adicionar(IndicadorAmbiental indicador)
    {
        _indicadores.Add(indicador);
    }

    public void Atualizar(IndicadorAmbiental indicador)
    {
        var existente = ObterPorId(indicador.Id);

        if (existente != null)
        {
            existente.Nome = indicador.Nome;
            existente.Valor = indicador.Valor;
            existente.DataLeitura = indicador.DataLeitura;
        }
    }

    public void Remover(int id)
    {
        var indicador = ObterPorId(id);

        if (indicador != null)
        {
            _indicadores.Remove(indicador);
        }
    }
}