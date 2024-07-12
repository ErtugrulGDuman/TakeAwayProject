using AutoMapper;
using MongoDB.Driver;
using TakeAway.Catalog.Dtos.SliderDtos;
using TakeAway.Catalog.Entities;
using TakeAway.Catalog.Settings;

namespace TakeAway.Catalog.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMongoCollection<Slider> _sliderCollection;
        private readonly IMapper _mapper;

        public SliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            await _sliderCollection.InsertOneAsync(value);
        }

        public async Task DeleteSliderAsync(string id)
        {
            await _sliderCollection.DeleteOneAsync(x => x.SliderId == id);
        }

        public async Task<List<ResultSliderDto>> GetAllCategories()
        {
            var values = await _sliderCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(values);
        }

        public Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<GetByIdSliderDto> GetByIdSliderAsync(string id)
        {
            var values = await _sliderCollection.Find(x => x.SliderId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdSliderDto>(values);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            var values = _mapper.Map<Slider>(updateSliderDto);
            await _sliderCollection.FindOneAndReplaceAsync(x => x.SliderId == updateSliderDto.SliderId, values);
        }
    }
}
