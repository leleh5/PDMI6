using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPFINAL.Models;

namespace TPFINAL.ViewModels
{
    public class MercadoriaViewModel
    {
        public MercadoriaViewModel() { }
        #region Propriedades
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string NomeProdutor { get; set; }
        public string EmailProdutor { get; set; }

        public int NCM { get; set; }
        public List<Mercadoria> Mercadorias
        {
            get
            {
                return App.MercadoriaModel.GetMercadorias().ToList();
                
            }
        }

        public void DeletarMercadoria(Mercadoria mercadoria)
        {
            App.MercadoriaModel.RemoverMercadoria(mercadoria.NCM);
        }
        #endregion
    }
}
