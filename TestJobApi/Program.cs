using TestJobApi.Helpers;
using TestJobApi.Models;

var user = new UserModel
{
    Login = "Aleop",
    Password = "1234",
    RoleId = 1
};

user = await user.Add();

Console.WriteLine(user?.ToJson());

var users = new AllModel<UserModel>("Users");
users.Objs.ForEach(Console.WriteLine);
