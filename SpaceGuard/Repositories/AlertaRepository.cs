using SpaceGuard.Interfaces;
using SpaceGuard.Models;

namespace SpaceGuard.Repositories;

public class AlertaRepository : IAlertaRepository
{
    private readonly List<AlertaAmbiental> _alertas = [];

    public IEnumerable<AlertaAmbiental> ObterTodos()
    {
        return _alertas;
    }

    public AlertaAmbiental? ObterPorId(int id)
    {
        return _alertas.FirstOrDefault(a => a.Id == id);
    }

    public void Adicionar(AlertaAmbiental alerta)
    {
        _alertas.Add(alerta);
    }

    public void Atualizar(AlertaAmbiental alerta)
    {
        var existente = ObterPorId(alerta.Id);

        if (existente != null)
        {
            existente.Titulo = alerta.Titulo;
            existente.Descricao = alerta.Descricao;
            existente.NivelRisco = alerta.NivelRisco;
            existente.DataCriacao = alerta.DataCriacao;
        }
    }

    public void Remover(int id)
    {
        var alerta = ObterPorId(id);

        if (alerta != null)
        {
            _alertas.Remove(alerta);
        }
    }
}