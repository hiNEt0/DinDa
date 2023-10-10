using System.Drawing;

namespace table
{
    class Entity
    {
        public string name;
        
        public bool isAlive;
        
        private int Hp;
        public int hp
        {
            get { return Hp; }
            set
            {
                if (value <= 0)
                {
                    isAlive = false;
                    Hp = 0;
                }
                else Hp = value;
            }
        }

        public List<Spell> spells;
        //public Image;

        public Entity(string name, int hp, List<Spell> spells, bool isAlive)
        {
            this.name = name;
            this.hp = hp;
            this.spells = spells;
            this.isAlive = isAlive;
        }
    }

    class  Spell
    {
        public string name;
        public int damage;
        public int area;

        public Spell(string name, int damage, int area)
        {
            this.name = name;
            this.damage = damage;
            this.area = area;
        }
    }

    public interface IActive
    {
        public void DoDamage();

        public void TakeDamage();
    }
}

