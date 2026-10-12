using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Kitty : Entity.Character
{
    /*************************************************************************
    * funkcja: Kitty
    *
    * opis:
    * Wytwarzanie nowej klasy postaci
    *
    * parametry:
    * name,string,nazwa postaci
    *
    * zwraca:
    * characterClass,nowa klasa postaci
    *************************************************************************/
    public Kitty(string name) : base(name, CharacterClass.Kitty)
    {
        Health = 10;
        Strength = 2;
        Intelligence = 20;
        Agility = 10;
        Speed = 10;
        Cutie = 20;
    }
}
   
