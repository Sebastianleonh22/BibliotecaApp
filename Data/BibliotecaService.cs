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

        public Task UpdateLibroAsync(Libro libro)
        {
            var libroExistente = _libros.FirstOrDefault(l => l.Id == libro.Id);
            if (libroExistente != null)
            {
                _libros.Remove(libroExistente);
                _libros.Add(libro);
            }
            return Task.CompletedTask;
        }

        public Task DeleteLibroAsync(int id)
        {
            var libro = _libros.FirstOrDefault(l => l.Id == id);
            if (libro != null)
            {
                _libros.Remove(libro);
            }
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

        public Task UpdateRevistaAsync(Revista revista)
        {
            var revistaExistente = _libros.OfType<Revista>().FirstOrDefault(r => r.Id == revista.Id);
            if (revistaExistente != null)
            {
                _libros.Remove(revistaExistente);
                _libros.Add(revista);
            }
            return Task.CompletedTask;
        }

        public Task DeleteRevistaAsync(int id)
        {
            var revista = _libros.OfType<Revista>().FirstOrDefault(r => r.Id == id);
            if (revista != null)
            {
                _libros.Remove(revista);
            }
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

        public Task UpdateLibroElectronicoAsync(LibroElectronico libroElectronico)
        {
            var libroElectronicoExistente = _libros.OfType<LibroElectronico>().FirstOrDefault(le => le.Id == libroElectronico.Id);
            if (libroElectronicoExistente != null)
            {
                _libros.Remove(libroElectronicoExistente);
                _libros.Add(libroElectronico);
            }
            return Task.CompletedTask;
        }

        public Task DeleteLibroElectronicoAsync(int id)
        {
            var libroElectronico = _libros.OfType<LibroElectronico>().FirstOrDefault(le => le.Id == id);
            if (libroElectronico != null)
            {
                _libros.Remove(libroElectronico);
            }
            return Task.CompletedTask;
        }
    }
}

