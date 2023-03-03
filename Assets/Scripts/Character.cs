using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Character
    {
        public string Name { get; private set; }

        public Character(string name)
        {
            Name = name;

            Debug.Log($"Hola soy {name}.");
        }

        ~Character()
        {
            Debug.Log($"El character {Name} ha sido destruido.");
        }
    }

    public class Enemy : Character
    {
        public Enemy(string name) : base(name)
        {
            
        }

        
    }

    public class Player : Character
    {
        public Player(string name) : base(name)
        {

        }
    }
}
