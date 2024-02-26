using System.Text;

namespace restaurantApi.URL
{
    public class UrlGenerator
    {
        private static Random random = new Random();

        public static string GenerateRandomUrl(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var urlBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                urlBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return urlBuilder.ToString();
        }
    }
}
