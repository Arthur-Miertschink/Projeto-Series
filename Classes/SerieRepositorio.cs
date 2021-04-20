using System.Collections.Generic;
using Series.Interfaces;
using System;


namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Series>

    {
        private List<Series> listaSerie = new List<Series>();

        public void Atualiza(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }
        


    }
}