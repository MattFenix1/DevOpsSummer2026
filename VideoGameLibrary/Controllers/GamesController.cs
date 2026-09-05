using Microsoft.AspNetCore.Mvc;
using VideoGameLibrary.Models;
namespace VideoGameLibrary.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            var games = new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Title = "Elden Ring",
                    Genre = "Action RPG",
                    Developer = "FromSoftware",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2022, 2, 25),
                    Description = "An open-world action RPG."
                },
                new Game
                {
                    Id = 2,
                    Title = "Sekiro: Shadows Die Twice",
                    Genre = "Action",
                    Developer = "FromSoftware",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2019, 3, 22),
                    Description = "A challenging action game focused on sword combat."
                },
                new Game
                {
                    Id = 3,
                    Title = "Mass Effect 2",
                    Genre = "Action RPG",
                    Developer = "BioWare",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2010, 1, 26),
                    Description = "A science-fiction action RPG."
                }
            };
            return View(games);
        }
        public IActionResult Details(int id)
        {
            var games = new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Title = "Elden Ring",
                    Genre = "Action RPG",
                    Developer = "FromSoftware",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2022, 2, 25),
                    Description = "An open-world action RPG."
                },
                new Game
                {
                    Id = 2,
                    Title = "Sekiro: Shadows Die Twice",
                    Genre = "Action",
                    Developer = "FromSoftware",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2019, 3, 22),
                    Description = "A challenging action game focused on sword combat."
                },
                new Game
                {
                    Id = 3,
                    Title = "Mass Effect 2",
                    Genre = "Action RPG",
                    Developer = "BioWare",
                    Platform = "PC",
                    ReleaseDate = new DateTime(2010, 1, 26),
                    Description = "A science-fiction action RPG."
                }
            };
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }
        public IActionResult Edit(int id)
        {
            var game = new Game
            {
                Id = id,
                Title = "Elden Ring",
                Genre = "Action RPG",
                Developer = "FromSoftware",
                Platform = "PC",
                ReleaseDate = new DateTime(2022, 2, 25),
                Description = "An open-world action RPG."
            };

            return View(game);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Game game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var game = new Game
            {
                Id = id,
                Title = "Elden Ring",
                Genre = "Action RPG",
                Developer = "FromSoftware",
                Platform = "PC",
                ReleaseDate = new DateTime(2022, 2, 25),
                Description = "An open-world action RPG."
            };
            return View(game);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}