using Microsoft.EntityFrameworkCore;

namespace csarp_back_00_01_01_backend_study.Contexts
{
    public class KretaContext : DbContext
    {
        public KretaContext(DbContextOptions options) : base(options)
        {
        }
    }
}
