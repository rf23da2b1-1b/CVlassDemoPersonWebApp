using CVlassDemoPersonWebApp.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddSingleton<PersonRepository>(new PersonRepository(true));


/*
 * herover setup
 */

var app = builder.Build();

/*
 * herunder brug
 */



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
