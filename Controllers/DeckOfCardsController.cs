using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Deck_of_Cards_API.Models;

namespace Deck_of_Cards_API.Controllers
{
    public class DeckOfCardsController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Details");
        }



        public IActionResult Details(string deck_id)
        {
            string apiUrl = "https://deckofcardsapi.com/api/deck/new/shuffle";
            var apiTask = apiUrl.GetJsonAsync<GenerateDeck>();
            apiTask.Wait();
            GenerateDeck result = apiTask.Result;

             apiUrl = $"https://deckofcardsapi.com/api/deck/{result.deck_id}/draw/?count=5";
            var apiTaskCard = apiUrl.GetJsonAsync<DrawFiveApi>();
            apiTaskCard.Wait();
            DrawFiveApi resultCards = apiTaskCard.Result;

            return View("CardsDetails", resultCards.cards);

        }








    }
}
