using System;
using MongoDB.Driver;
using StdPortel.Models;
using TodoApp.Services.DbConnection;

namespace StdPortel.Services;

public class StdServices : IStdServices
{

    private readonly IMongoCollection<Students> _stdCollection;

    public StdServices()
    {
        var dbConnection = new MongodbConnection(); // object of monogbd connect class
        var database = dbConnection.GetDatabase();
        _stdCollection = database.GetCollection<Students>("StdPortel");
    }
    public async Task CreateStudent(Students student)
    {
        await _stdCollection.InsertOneAsync(student);
    }

    public async Task<List<Students>> GetSutdentData()
    {
        var studentsdata = await _stdCollection.Find(a => true).ToListAsync();
        return studentsdata;
    }
     public async Task<bool> DeleteStudent(string studentId)
    {
        await _stdCollection.DeleteOneAsync(a => a.Id == studentId);
        return true;
    }


}
