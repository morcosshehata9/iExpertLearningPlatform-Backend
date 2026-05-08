using Microsoft.EntityFrameworkCore;
using iExpertsLearningPlatform.Data;
using iExpertsLearningPlatform.Models;

namespace iExpertsLearningPlatform.Repositories;

public class ContactRepository(AppDbContext context) : IContactRepository
{
    public async Task<ContactMessage> AddAsync(ContactMessage message)
    {
        context.ContactMessages.Add(message);
        await context.SaveChangesAsync();
        return message;
    }

    public async Task<IEnumerable<ContactMessage>> GetAllAsync() =>
        await context.ContactMessages
            .AsNoTracking()
            .OrderByDescending(m => m.CreatedAt)
            .ToListAsync();
}