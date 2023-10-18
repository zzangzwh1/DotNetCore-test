namespace DotNetCore_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container Rager Page
            builder.Services.AddRazorPages();


            var app = builder.Build();

            //Configure the HTTP request pipeline

            app.UseStaticFiles(); //add for wwrooot
            app.UseRouting();
            app.MapRazorPages();

            

           

        //    app.MapGet("/", () => "Hello World Mike Cho!");

            app.Run();
        }

     
    }
}