using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Shark : Entity.Character
{
    public Shark(string name) : base(name, CharacterClass.Shark)
    {
        Health = 20;
        Strength = 20;
        Intelligence = 5;
        Agility = 15;
        Speed = 20;
        Cutie = 2;
    }
}
    public int Biting(int swimming)
    {
        return Biting * swimming;
    }
    /*************************************************************************
     * funkcja: plywanie
     *
     * opis:
     * wyskakuje z wody i gryzie
     *
     * parametry:
     * kiedy widzi wroga w wodzie gryzie go
     *
     * zwraca:
     * int, kosci innych wrogow
     *************************************************************************/
