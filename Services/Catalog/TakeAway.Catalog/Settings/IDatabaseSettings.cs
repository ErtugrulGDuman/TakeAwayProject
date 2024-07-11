namespace TakeAway.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionNeme { get; set; }
        public string SliderCollectionNeme { get; set; }
        public string FeatureCollectionNeme { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
