using Microsoft.EntityFrameworkCore;
using TakeAwayProject.Comment.DAL.Entities;

namespace TakeAwayProject.Comment.DAL.Context
{
    public class CommentContext : DbContext
    {
        public CommentContext(DbContextOptions<CommentContext> options) : base(options)
        {
            
        }
        public DbSet<UserComment> UserComments { get; set; }
    }
}
