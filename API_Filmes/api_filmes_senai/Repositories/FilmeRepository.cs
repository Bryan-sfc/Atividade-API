using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly Filmes_Context _context;

        public FilmeRepository(Filmes_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid Id, Filme filme)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(Id)!;

                if (filmeBuscado != null)
                {
                    filmeBuscado.Titulo = filme.Titulo;
                    filmeBuscado.IdGenero = filme.IdGenero;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Filme BuscarPorId(Guid Id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(Id)!;

                return filmeBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Filme novoFilme)
        {
            try
            {
                _context.Filme.Add(novoFilme);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id)!;

                if (filmeBuscado != null)
                {
                    _context.Filme.Remove(filmeBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Filme> ListarPorGenero(Guid idGenero)
        {
            try
            {
                List<Filme> listaDeFilmes = _context.Filme

                .Include(g => g.Genero)
                .Where(f == f.idGenero == idGenero)
                .ToList();

                return listaDeFilmes;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
