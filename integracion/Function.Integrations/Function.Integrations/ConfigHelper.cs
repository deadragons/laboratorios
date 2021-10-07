namespace Function.Integrations
{
    public static class ConfigHelper
    {
        private static Settings settings;

        public static Settings Settings
        {
            get
            {
                if(settings != null)
                {
                    return settings;
                }
                var config = new ConfigurationBuilder()
                    .AddJsonFile("local.settings.json")
                    .AddEvironmentVariables()
                    .Build();
                settings = new Settings();
                config.Bind(settings);
                return settings;
            }
        }
    }
}
