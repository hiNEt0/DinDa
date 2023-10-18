namespace table;

public class Entity // takes hp, status, spells, img, name, etc
{
    public string name;
    public int speed;
    public bool isAlive;
    
    private int Hp;
    public int hp
    {
        get => Hp;
        set
        {
            if (value <= 0)
            {
                isAlive = false;
                Hp = 0;
            }
            else
            {
                Hp = value;
            }
        }
    }

    public int strength; //сила
    public int dexterity; //ловкость
    public int constitution; //телосложение
    public int intelligence; //интеллект
    public int wisdom; //мудрость
    public int charisma; //харизма
    
    public List<Spell> spells;
    //public Image;

    //мильон параметров ахуеть
    public Entity(string name, int speed, int hp, List<Spell> spells, bool isAlive, int strength, int dexterity,
        int constitution, int intelligence, int wisdom, int charisma)
    {
        this.name = name;
        this.speed = speed;
        this.hp = hp;
        this.spells = spells;
        this.isAlive = isAlive;

        this.strength = strength;
        this.dexterity = dexterity;
        this.constitution = constitution;
        this.intelligence = intelligence;
        this.wisdom = wisdom;
        this.charisma = charisma;
    }
}