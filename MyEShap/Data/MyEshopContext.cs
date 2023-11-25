

using Microsoft.EntityFrameworkCore;

namespace MyEShap.Data
{
    public class MyEshopContext:DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options):base(options)
        {

        }

    }
}
