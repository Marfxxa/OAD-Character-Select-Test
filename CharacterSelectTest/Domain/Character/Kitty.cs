using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Kitty : Entity.Character
{
    /*************************************************************************
     * funkcja: Kitty
     *
     * opis:
     * Tworzy nową postać klasy Kitty.
     *
     * parametry:
     * name, string, nazwa postaci
     *
     * zwraca:
     * brak
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

    /*************************************************************************
     * funkcja: Attack
     *
     * opis:
     * Oblicza wartość ataku postaci Kitty na podstawie jej inteligencji.
     *
     * parametry:
     * brak
     *
     * zwraca:
     * int, wartość ataku obliczona jako Intelligence * 3
     *************************************************************************/
    public int Attack()
    {
        return Intelligence * 3;
    }
}

