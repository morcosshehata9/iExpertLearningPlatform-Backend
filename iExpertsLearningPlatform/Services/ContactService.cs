using iExpertsLearningPlatform.DTOs;
using iExpertsLearningPlatform.Models;
using iExpertsLearningPlatform.Repositories;

namespace iExpertsLearningPlatform.Services;

public class ContactService(IContactRepository repo) : IContactService
{
    /// Maps DTO → Model, persists, returns response DTO
    public async Task<ContactResponseDto> SubmitContactAsync(ContactRequestDto dto)
    {
        var entity = new ContactMessage
        {
            Name = dto.Name.Trim(),
            Email = dto.Email.Trim().ToLower(),
            Message = dto.Message.Trim()
        };

        var saved = await repo.AddAsync(entity);
        return MapToResponse(saved);
    }

    public async Task<IEnumerable<ContactResponseDto>> GetAllContactsAsync()
    {
        var messages = await repo.GetAllAsync();
        return messages.Select(MapToResponse);
    }

    private static ContactResponseDto MapToResponse(ContactMessage m) => new()
    {
        Id = m.Id,
        Name = m.Name,
        Email = m.Email,
        Message = m.Message,
        CreatedAt = m.CreatedAt,
        Status = "Received"
    };
}
