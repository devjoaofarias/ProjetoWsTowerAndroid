using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WsTowerMobile
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
        }

        public Task<List<Usuario>> GetUserAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> SaveUserAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }
    }
}
