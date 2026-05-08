using Microsoft.EntityFrameworkCore;
using iExpertsLearningPlatform.Models;

namespace iExpertsLearningPlatform.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<ContactMessage> ContactMessages => Set<ContactMessage>();
}