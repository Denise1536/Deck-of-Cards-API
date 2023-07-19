namespace Deck_of_Cards_API.Models
{
    public class DrawFiveApi
    {
        public bool success { get; set; }

        public string deck_id { get; set; }

     //   public CardsApi cards { get; set; } 

        public List<CardsApi> cards_drawn { get; set; }
    }
}
