using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Shark : Entity.Character
{
    /*************************************************************************
     * funkcja: Shark
     *
     * opis:
     * Tworzy nową postać klasy Shark.
     *
     * parametry:
     * name, string, nazwa rekina
     *
     * zwraca:
     * brak
     *************************************************************************/
    public Shark(string name) : base(name, CharacterClass.Shark)
    {
        Health = 20;
        Strength = 20;
        Intelligence = 5;
        Agility = 15;
        Speed = 20;
        Cutie = 2;
    }

    /*************************************************************************
     * funkcja: Attack
     *
     * opis:
     * Oblicza wartość ataku postaci Shark na podstawie jej siły.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * int, wartość ataku obliczona jako Strength * 3
     *************************************************************************/
    public int Attack()
    {
        return Strength * 3;
    }
}

