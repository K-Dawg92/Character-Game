using Character_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Game
{
    public class Character
    {
        private string _name;
        private int _pointDeVie;
        private int _forceDattaq;
        private int _forceDefence;

        // constructeur

        public Character(string name, int pointDeVie, int forceDattaq, int forceDefence)
        {
            _name = name;
            _forceDattaq = forceDattaq;
            _forceDefence = forceDefence;
            _pointDeVie = pointDeVie;
        }  
        public bool isAlive()
        {
            return _pointDeVie > 0;
        }
        public void Attack(Character target)
        {
            target._pointDeVie =( target._pointDeVie) - (_forceDattaq - target._forceDefence);
        }

        public string GetName() 
        { 
            return _name; 
        
       }
    }
}

