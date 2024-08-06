using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayProject.Comment.DTO;
using TakeAwayProject.Comment.Services;

namespace TakeAwayProject.Comment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public UserCommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUserComment()
        {
            var values = await _commentService.GetAllUserCommentAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserComment(CreateUserCommmnetDto createUserCommmnetDto)
        {
            await _commentService.CreateUserCommentAsync(createUserCommmnetDto);
            return Ok("Ekleme işlemi başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUserComment(int id)
        {
            await _commentService.DeleteUserCommentAsync(id);
            return Ok("Silme işlemi başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUserComment(UpdateUserCommmnetDto updateUserCommmnetDto)
        {
            await _commentService.UpdateUserCommentAsync(updateUserCommmnetDto);
            return Ok("Yorum Güncellendi");
        }
        [HttpGet("UserCommentByProductId")]
        public async Task<IActionResult> UserCommentByProductId(string id)
        {
            var values = await _commentService.GetByProductIdUserCommmnetAsync(id);
            return Ok(values);
        }
        [HttpGet("GetUserComment")]
        public async Task<IActionResult> GetUserComment(int id)
        {
            var values = await _commentService.GetByIdUserCommmnetAsync(id);
            return Ok(values);
        }
    }
}
