// classe define metodos e atributos
// objeto e uma istancia de um classe
// encapsulamente diz respeito ao nivel de acesso de um membro de uma classe
namespace Heranca
{
    public class Monster
    {
        public string Type {get; set;} = "";
        public static int Count {get; set;} = 0;
        public int Health {get; set;} = 100;
        protected int Attack {get; set;} = 0;
        protected int Defense {get; set;} = 0;
        protected int Mana {get; set;} = 0;

        public Monster(string type, int health, int attack, int defense, int mana)
        {
            Type = type;
            Health = health;
            Attack = attack;
            Defense = defense;
            Mana = mana;
            Count++;
        }

        public virtual void AttackMonster(Monster target)
        {
            target.Health -= Attack;
        }
    }
    public class Ogre: Monster
    {
        public Ogre(): base("Ogre", 200, 100, 50, 0)
        {
        }
    }
    public class Goblin: Monster
    {
        public Goblin(): base("Goblin", 100, 50, 25, 0)
        {
        }
        public override void AttackMonster(Monster target)
        {
            target.Health -= Attack * 2;
        }
    }

}

// override sobrescrever
// virtual pode ser sobrescrito
// abstract nao pode ser instanciado
// static nao pode ser instanciado, nao pode ser sobrescrito, e chamado diretamente