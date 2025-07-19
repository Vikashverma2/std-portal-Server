using System;
using MongoDB.Driver;

namespace TodoApp.Services.DbConnection;

public class MongodbConnection
{
 private readonly IMongoDatabase _database;

    public MongodbConnection()
    {
        var connectionString = "mongodb://localhost:27017";
        var databaseName = "StdPortel";

        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoDatabase GetDatabase()
    {
        return _database;
    }
}
