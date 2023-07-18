namespace Deck_of_Cards_API.Models
{
    public class GenerateDeck
    {
        public bool success { get; set; }

        public string deck_id { get; set; }

        public int remaining { get; set; }
        
        public bool shuffled { get; set; }

    }
}
