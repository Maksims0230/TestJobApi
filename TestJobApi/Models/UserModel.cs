using Newtonsoft.Json;
using TestJobApi.Models.Abstracts;

namespace TestJobApi.Models;

public class UserModel : ModelAbstract
{
    [JsonIgnore] public sealed override string Path { get; set; }

    public UserModel()
    {
        Path = "Users";
        Id = 0;
    }

    [JsonProperty("UserId")] public sealed override int Id { get; set; }

    [JsonProperty("Login")] public string? Login { get; set; }

    [JsonProperty("Password")] public string? Password { get; set; }

    [JsonProperty("RoleId")] public int RoleId { get; set; }

    public override string ToString() => 
        $"Номер: {Id}; \nЛогин: {Login}; \nПароль: {Password}; \nНомер роли: {RoleId}";
}