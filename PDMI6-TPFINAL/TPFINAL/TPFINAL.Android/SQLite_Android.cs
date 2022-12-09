﻿
using System.IO;
using Xamarin.Forms;
using TPFINAL.Data;
using XF.LocalDB.Droid;

[assembly:
Dependency(typeof(SQLite_Android))]
namespace XF.LocalDB.Droid
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }
        public SQLite.SQLiteConnection
        GetConexao()
        {
            var arquivodb = "ifspdb1.db3";
            string caminho =
            System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);
            var local = Path.Combine(caminho,
            arquivodb);
            var conexao = new
            SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}