namespace ASP_Restaurant.Models
{
    public static class MenuDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();
            var context = services.ServiceProvider.GetRequiredService<RestaurantDbContext>();
            if (!context.menuNames.Any())
            {

                context.menuNames.Add(new MenuName { Name = "BreakFast" });
                context.menuNames.Add(new MenuName { Name = "Lanch" });
                context.menuNames.Add(new MenuName { Name = "Dinner" });             
                context.SaveChanges();
            }
            if (!context.menuPositions.Any())
            {
                for (int i = 0; i < 12; i++)
                {

                }
                context.SaveChanges();
            }
        }
    }
}
