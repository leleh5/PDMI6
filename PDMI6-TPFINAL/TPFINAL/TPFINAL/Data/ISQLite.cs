using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TPFINAL.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
