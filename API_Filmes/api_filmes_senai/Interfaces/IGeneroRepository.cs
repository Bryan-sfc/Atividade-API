
using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    ///<summary>
    ///Interface para genero : contrato 
    ///Toda classe que herdar precisara implementar todos metodos definidos aqui dentro
    ///</summary>
    public interface IGeneroRepository
    {
        //crud : Métodos
        //c : cadastrar objetos
        //r : read :  : listar objetos
        //u : update : alterar um objeto
        //d : Delete: deletar objetos

        void Cadastrar(Genero novoGenero);
        
        List<Genero> Listar();

        void Atualizar(Guid id, Genero genero);
        void Deletar(Guid id);

        Genero BuscarPorId(Guid id);
    }
}