using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StdPortel.Models;

public class Students
{
    [BsonId] // Mark as document ID
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string Name { get; set; }
    public string RollNumber { get; set; }
    public string Branch { get; set; }
    public string Courses { get; set; }
    public string EmailID { get; set; }

}
