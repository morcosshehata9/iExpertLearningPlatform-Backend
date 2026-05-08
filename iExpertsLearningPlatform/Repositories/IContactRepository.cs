using iExpertsLearningPlatform.Models;

namespace iExpertsLearningPlatform.Repositories;

public interface IContactRepository
{
    Task<ContactMessage> AddAsync(ContactMessage message);
    Task<IEnumerable<ContactMessage>> GetAllAsync();
}