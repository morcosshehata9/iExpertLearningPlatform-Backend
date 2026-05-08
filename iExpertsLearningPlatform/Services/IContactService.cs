using iExpertsLearningPlatform.DTOs;

namespace iExpertsLearningPlatform.Services;

public interface IContactService
{
    Task<ContactResponseDto> SubmitContactAsync(ContactRequestDto dto);
    Task<IEnumerable<ContactResponseDto>> GetAllContactsAsync();
}