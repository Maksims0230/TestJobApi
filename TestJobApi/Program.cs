using TestJobApi.Models;

var users = new AllModel<UserModel>("Users");
// Console.WriteLine(users.Objs.First().ToJson());

users.Objs.ForEach(Console.WriteLine);