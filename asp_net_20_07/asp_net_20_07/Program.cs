using System.Globalization;

namespace asp_net_20_07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = WebApplication.CreateBuilder(args).Build();

            app.MapGet("/customs_duty", (int price) => 
            {
                if (price > 200)
                {
                    return "—тоимость посылке превышает 200И, пошлина быдет составл€ть: " + (Convert.ToDouble(price) * 0.15) + "И";
                }
                return "—тоимость посылке не превышает 200И, пошлина не взимаетс€!";
            });

            app.MapGet("/", () => DateTime.Now.ToString(" HH:mm:ss\ndddd, dd MMM", new CultureInfo(CultureInfo.CurrentCulture.Name.ToString())));

            app.Run();
        }
    }
}