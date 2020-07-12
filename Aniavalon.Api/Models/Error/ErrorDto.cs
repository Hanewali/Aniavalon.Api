using Newtonsoft.Json;

namespace Aniavalon.Api.Models.Error
{
    public class ErrorDto
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}