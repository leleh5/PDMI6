using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using TPFINAL.Data;

namespace TPFINAL.Models {
    public class Mercadoria {
        private SQLiteConnection database;

        public Mercadoria() {
            database = DependencyService.Get<ISQLite>().GetConexao();
            database.CreateTable<Mercadoria>();
        }
        
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string NomeProdutor { get; set; }
        public string EmailProdutor { get; set; }

        [PrimaryKey]
        public int NCM { get; set; }

        static object locker = new object();

        public int SalvarMercadoria(Mercadoria mercadoria) {
            lock (locker) {
                if (GetMercadoria(mercadoria.NCM) != null) {
                    return database.Update(mercadoria);
                }
                return database.Insert(mercadoria);
            }
        }

        public IEnumerable<Mercadoria> GetMercadorias() {
            lock (locker) {
                return (from c in database.Table<Mercadoria>()
                        select c).ToList();
            }
        }

        public Mercadoria GetMercadoria(int NCM) {
            lock (locker)
            {
                return database.Table<Mercadoria>().Where(c => c.NCM == NCM).FirstOrDefault();
            }
        }

        public int RemoverMercadoria(int NCM) {
            lock (locker) {
                return database.Delete<Mercadoria>(NCM);
            }
        }
    }
}

