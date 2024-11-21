using UnityEngine;

[CreateAssetMenu(fileName ="CharacterSpec", menuName = "Data/CharacterSpec")]
public class CharacterSpecData : ScriptableObject
{
    #region Attribute
    int maxHp;
    int maxMp;
    float speed;
    int defense;
    int attack;
    Region region;
    Elemental elemental;
    #endregion

    #region Getter
    public int MaxHp { get { return maxHp; } }
    public int MaxMp { get { return maxMp; } }
    public float Speed { get { return speed; } }
    public int Defense { get { return defense; } }
    public int Attack { get { return attack; } }
    public Region Region { get { return region; } }
    public Elemental Elemental {  get { return elemental; } }
    #endregion
}
