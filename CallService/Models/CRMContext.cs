using System.Data.Entity;

namespace CallService.Models
{
    /// <summary>
    /// Контекст данных, используемый для взаимодействия с базой данных
    /// </summary>
    public class CRMContext : DbContext
    {
        static CRMContext()
        {
            Database.SetInitializer<CRMContext>(new CallDbInitializer());
        }

        /// <summary>
        /// Информация о телефонных вызовах
        /// </summary>
        public DbSet<CallEvent> CallEvents { get; set; }
    }
}