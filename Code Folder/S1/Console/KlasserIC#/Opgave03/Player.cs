namespace Opgave03
{
    public class Player
    {
        public string Name;
        public int Score;

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"Navn: {Name}. Score: {Score}";
        }
    }
}
