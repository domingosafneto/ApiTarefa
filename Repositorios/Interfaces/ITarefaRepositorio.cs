﻿using ApiTarefas.Models;

namespace ApiTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio // interface contem os contratos dos usuários
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();

        Task<TarefaModel> BuscarPorId(int id);

        Task<TarefaModel> Adicionar(TarefaModel tarefa);

        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id);

        Task<bool> Apagar(int id);

    }
}
