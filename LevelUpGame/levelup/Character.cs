
namespace levelup
{
    public class Character
    {
        public readonly string DEFAULT_CHARACTER_NAME = "ChatGPT";
        string name;

        public Character(){
            this.name = DEFAULT_CHARACTER_NAME;
        }
        public string getName(){
            return name;

        }
    }
}