using TakeAwayProject.Comment.DTO;

namespace TakeAwayProject.Comment.Services
{
    public interface ICommentService
    {
        Task<List<ResultUserCommentDto>> GetAllUserCommentAsync();
        Task CreateUserCommentAsync(CreateUserCommmnetDto createUserCommmnetDto);
        Task UpdateUserCommentAsync(UpdateUserCommmnetDto updateUserCommmnetDto);
        Task DeleteUserCommentAsync(int id);
        Task<GetByIdUserCommmnetDto> GetByIdUserCommmnetAsync(int id);
        Task<List<GetByProductIdUserCommmnetDto>>GetByProductIdUserCommmnetAsync(string id); 
    }
}
