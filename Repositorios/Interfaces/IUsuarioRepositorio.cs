using ApiTarefas.Models;

namespace ApiTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio // interface contem os contratos dos usuários
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarPorId(int id);

        Task<UsuarioModel> Adicionar(UsuarioModel usuario);

        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);

        Task<bool> Apagar(int id);

    }
}
