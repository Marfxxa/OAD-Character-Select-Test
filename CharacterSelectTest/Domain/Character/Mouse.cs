using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Mouse : Entity.Character
{
    public Mouse(string name) : base(name, CharacterClass.Mouse)
    {
        Health = 20;
        Strength = 1;
        Intelligence = 20;
        Agility = 17;
        Speed = 20;
        Cutie = 8;
    }
}
public int Hiding(int CaveDigging)
    {
        return Hiding * CaveDigging;
    }
    /*************************************************************************
     * funkcja: ukrywanie się
     *
     * opis:
     * ukrywa się w małych norkach
     *
     * parametry:
     * kiedy widzi przeciwnika to chowa sie w norkach i wyskakuje,kiedy jest gotowa do ataku
     *
     * zwraca:
     * int,slabe miejsca innych przeciwnikow
     *************************************************************************/
