using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApp.Data
{
    public class BibliotecaService
    {

        private readonly List<Libro> _libros;

        public BibliotecaService()
        {
            _libros = new List<Libro>();
        }

        public Task<List<Libro>> GetLibrosAsync()
        {
            return Task.FromResult(_libros);
        }

        public Task AddLibroAsync(Libro libro)
        {
            _libros.Add(libro);
            return Task.CompletedTask;
        }

        public Task<List<Revista>> GetRevistasAsync()
        {
            return Task.FromResult(_libros.OfType<Revista>().ToList());
        }

        public Task AddRevistaAsync(Revista revista)
        {
            _libros.Add(revista);
            return Task.CompletedTask;
        }

        public Task<List<LibroElectronico>> GetLibrosElectronicosAsync()
        {
            return Task.FromResult(_libros.OfType<LibroElectronico>().ToList());
        }

        public Task AddLibroElectronicoAsync(LibroElectronico libroElectronico)
        {
            _libros.Add(libroElectronico);
            return Task.CompletedTask;
        }
    }
}
