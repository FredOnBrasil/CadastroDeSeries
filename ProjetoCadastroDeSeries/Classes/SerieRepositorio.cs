using ProjetoCadastroDeSeries.Interfaces;
using System.Collections.Generic;

namespace ProjetoCadastroDeSeries.Classes
{
    public class SerieRepositorio : IRepositorio<Serie> //classe repositorio implementa um repositorio da classe series
    {
        //implementacao da lista que contem todas as series
        private List<Serie> listaSerie = new List<Serie>();

        //implementação dos metodos:
        public void Atualiza(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public void exclui(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}