using ApiTarefas.Models;

namespace ApiTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarPorId(int id);

        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
    }
}
