using TakeAwayProject.WebUI.Dtos.CatalogDtos;

namespace TakeAwayProject.WebUI.Services.CatalogServices.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
    }
}
