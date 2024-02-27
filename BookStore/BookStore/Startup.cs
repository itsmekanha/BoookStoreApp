
internal class Startup
{
    private ConfigurationManager configuration;

    public Startup(ConfigurationManager configuration)
    {
        this.configuration = configuration;
    }
    public void ConfigureService(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }
}