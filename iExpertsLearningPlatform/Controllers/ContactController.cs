using iExpertsLearningPlatform.DTOs;
using iExpertsLearningPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace iExpertsLearningPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController(IContactService service) : ControllerBase
{
    /// POST api/contact — Submit a contact form message
    [HttpPost]
    [ProducesResponseType(typeof(ContactResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Submit([FromBody] ContactRequestDto dto)
    {
        if (!ModelState.IsValid)
            return ValidationProblem(ModelState);

        var result = await service.SubmitContactAsync(dto);
        return CreatedAtAction(nameof(GetAll), new { id = result.Id }, result);
    }

    /// GET api/contact — Retrieve all messages (admin use)
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ContactResponseDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var messages = await service.GetAllContactsAsync();
        return Ok(messages);
    }
}