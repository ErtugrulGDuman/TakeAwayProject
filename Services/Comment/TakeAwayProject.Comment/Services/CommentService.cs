using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TakeAwayProject.Comment.DAL.Context;
using TakeAwayProject.Comment.DAL.Entities;
using TakeAwayProject.Comment.DTO;

namespace TakeAwayProject.Comment.Services
{
    public class CommentService : ICommentService
    {
        private readonly CommentContext _commentContext;
        private readonly IMapper _mapper;

        public CommentService(CommentContext commentContext, IMapper mapper)
        {
            _commentContext = commentContext;
            _mapper = mapper;
        }

        public async Task CreateUserCommentAsync(CreateUserCommmnetDto createUserCommmnetDto)
        {
            var value = _mapper.Map<UserComment>(createUserCommmnetDto);
            await _commentContext.UserComments.AddAsync(value);
            await _commentContext.SaveChangesAsync();
        }

        public async Task DeleteUserCommentAsync(int id)
        {
            var values = await _commentContext.UserComments.FindAsync(id);
            _commentContext.UserComments.Remove(values);
            await _commentContext.SaveChangesAsync();
        }

        public async Task<List<ResultUserCommentDto>> GetAllUserCommentAsync()
        {
            var values = await _commentContext.UserComments.ToListAsync();
            return _mapper.Map<List<ResultUserCommentDto>>(values);
        }

        public async Task<GetByIdUserCommmnetDto> GetByIdUserCommmnetAsync(int id)
        {
            var values = await _commentContext.UserComments.FindAsync(id);
            return _mapper.Map<GetByIdUserCommmnetDto>(values);
        }

        public async Task<List<GetByProductIdUserCommmnetDto>> GetByProductIdUserCommmnetAsync(string id)
        {
            var values = await _commentContext.UserComments.Where(x => x.ProductId == id).ToListAsync();
            return _mapper.Map<List<GetByProductIdUserCommmnetDto>>(values);
        }

        public async Task UpdateUserCommentAsync(UpdateUserCommmnetDto updateUserCommmnetDto)
        {
            var values = _mapper.Map<UserComment>(updateUserCommmnetDto);
            _commentContext.UserComments.Update(values);
            await _commentContext.SaveChangesAsync();
        }
    }
}
