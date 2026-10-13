using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Mouse : Entity.Character
{
    /*************************************************************************
     * funkcja: Mouse
     *
     * opis:
     * Tworzy nową postać klasy Mouse.
     *
     * parametry:
     * name, string, nazwa myszy
     *
     * zwraca:
     * brak
     *************************************************************************/
    public Mouse(string name) : base(name, CharacterClass.Mouse)
    {
        Health = 20;
        Strength = 1;
        Intelligence = 20;
        Agility = 17;
        Speed = 20;
        Cutie = 8;
    }

    /*************************************************************************
     * funkcja: Attack
     *
     * opis:
     * Oblicza wartość ataku postaci Mouse na podstawie jej inteligencji.
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

