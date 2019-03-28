using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumblr.API
{
    public static class Helpers
    {
        /// <summary>
        /// Получить C# объект из JSON строки
        /// </summary>
        /// <typeparam name="T">Тип ответа сервера</typeparam>
        /// <returns>Возвращает объект типа <see cref="ServerResponse{T}"/></returns>
        public static ServerResponse<T> getObject<T> ( this string response)=>JsonConvert.DeserializeObject<ServerResponse<T>>(response);
               
        
    }
}
