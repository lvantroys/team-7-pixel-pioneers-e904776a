
namespace levelup
{
    public class Character
    {
        public readonly string DEFAULT_CHARACTER_NAME = "ChatGPT";
        string name;

        public Character(){
            this.name = DEFAULT_CHARACTER_NAME;
        }
        public Character(string name){
            this.name = name;
        }
        public string getName(){
            return name;

        }
    }
}