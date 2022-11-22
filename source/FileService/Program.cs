using FileService;

var builder = WebApplication.CreateBuilder();

var appSettings = new AppSettings();
builder.Configuration.Bind(appSettings);
builder.Services.AddSingleton(appSettings);
builder.Services.AddSingleton<IFileService, FileService.FileService>();
builder.Services.AddResponseCompression();
builder.Services.AddControllers();

var application = builder.Build();

application.UseDeveloperExceptionPage();
application.UseHsts();
application.UseHttpsRedirection();
application.UseRouting();
application.UseResponseCompression();
application.UseEndpoints(endpoints => endpoints.MapControllers());

application.Run();
