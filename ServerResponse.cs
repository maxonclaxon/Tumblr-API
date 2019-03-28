using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumblr.API
{
    /// <summary>
    /// Основной ответ от сервера
    /// </summary>
    public class ServerResponse<Response>
    {
        public Meta meta { get; set; }
        public Response response { get; set; }
    }
    
}
