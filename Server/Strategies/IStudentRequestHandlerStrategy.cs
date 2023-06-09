using Common.Models;

namespace Server.Strategies;

public interface IStudentRequestHandlerStrategy
{
    IEnumerable<Student> HandleRequest(string request);
}