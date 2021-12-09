using Newtonsoft.Json;

namespace TestJobApi.Models.Abstracts;

public abstract class ModelAbstract
{
    public abstract int Id { get; set; }
    public abstract string Path { get; set; }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this);
    }
}