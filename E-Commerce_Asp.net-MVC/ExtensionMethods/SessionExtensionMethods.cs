using Newtonsoft.Json;

namespace ECommerce_UI.ExtensionMethods
{
    public static class SessionExtensionMethods
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key,JsonConvert.SerializeObject(value));//veriyi json formatında stringe çevirip sessiona ekliyoruz
        }
        public static T? GetJson<T>(this ISession session, string key) where T : class
        {
            var data = session.GetString(key);//sessiondan string olarak veriyi alıyoruz

            return data == null ? default(T) : JsonConvert.DeserializeObject<T>(data);//eğer veri null ise default(T) döner, değilse json formatındaki stringi T tipine deserialize ederiz
        }
    }
}
