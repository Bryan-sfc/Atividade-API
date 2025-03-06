using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme novoFilme);

        List<Filme> Listar();

        void Atualizar(Guid Id, Filme filme);

        void Deletar(Guid Id);

        Filme BuscarPorId(Guid Id);

        List<Filme> ListarPorGenero(Guid idGenero);
    }
}
