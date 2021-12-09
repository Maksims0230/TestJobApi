using Newtonsoft.Json;
using TestJobApi.Models.Abstracts;

namespace TestJobApi.Models;

public class AllModel<TObj> where TObj : ModelAbstract
{
    private string Path { get; set; }

    public AllModel(string path)
    {
        Path = path;
        Objs = Get().GetAwaiter().GetResult();
    }

    public List<TObj> Objs { get; set; }

    private async Task<List<TObj>> Get()
    {
        using var client = new HttpClient();
        using var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"http://localhost:5079/api/{Path}/"),
        };
        var response = await client.SendAsync(request);
        return JsonConvert.DeserializeObject<List<TObj>>(response.Content.ReadAsStringAsync().Result) ??
               new List<TObj>();
    }
}