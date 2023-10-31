namespace table;

public class Spell
{
    public int area;
    public int damage;
    public string name;
    public List<Effect> effects;
    
    public Spell(string name, int damage, int area, List<Effect> effects)
    {
        this.name = name;
        this.damage = damage;
        this.area = area;
        this.effects = effects;
    }
}