var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapGet("/api/games", () =>
{
    var games = new []
    {
        new
        {
            Id = 1,
            Title = "The Legend of Zelda: Breath of the Wild",
            Genre = "Action-adventure",
            Developer = "Nintendo",
            Publisher = "Nintendo",
            ReleaseDate = new DateTime(2017, 3, 3),
            Description = "An open-world action-adventure game set in the kingdom of Hyrule."
        },

        new
        {
            Id = 2,
            Title = "God of War",
            Genre = "Action-adventure",
            Developer = "Santa Monica Studio",
            Publisher = "Sony Interactive Entertainment",
            ReleaseDate = new DateTime(2018, 4, 20),
            Description = "A third-person action-adventure game based on Norse mythology."
        },

        new
        {
            Id = 3,
            Title = "Red Dead Redemption 2",
            Genre = "Action-adventure",
            Developer = "Rockstar Games",
            Publisher = "Rockstar Games",
            ReleaseDate = new DateTime(2018, 10, 26),
            Description = "An open-world action-adventure game set in the American Wild West."
        }
    };

    return Results.Ok(games);
});

app.Run();