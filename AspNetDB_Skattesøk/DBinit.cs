using AspNetDB_Skattesøk.Models;

namespace AspNetDB_Skattesøk
{
    public class DBinit
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<Database>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var p = new Person()
                {
                    firstname = "Kjell",
                    lastname = "Hansen",
                    salary = 555990,
                    wealth = 12500333,
                    taxes = 145000
                };
                context.personer.Add(p);
                context.SaveChanges();
          
            }
        }

    }
}
