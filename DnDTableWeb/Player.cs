namespace table;

public class Player : Entity
{
    //public Dictionary<string, int> Money = new Dictionary<string, int>();
    public List<IActive> Actives = new();

    public Player(string name, int speed, int hp, List<Spell> spells, bool isAlive, int strength, int dexterity,
        int constitution, int intelligence, int wisdom, int charisma) : base(name, speed, hp, spells,
        isAlive, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
    }
}