using UnityEngine;

[CreateAssetMenu(fileName ="CharacterSpec", menuName = "Data/CharacterSpec")]
public class CharacterSpecData : ScriptableObject
{
    #region Attribute
    [SerializeField]
    int maxHp;
    [SerializeField]
    int maxMp;
    [SerializeField]
    float speed;
    [SerializeField]
    int defense;
    [SerializeField]
    int attack;
    [SerializeField]
    ERA region;
    [SerializeField]
    Elemental elemental;
    #endregion

    #region Getter
    public int MaxHp { get { return maxHp; } }
    public int MaxMp { get { return maxMp; } }
    public float Speed { get { return speed; } }
    public int Defense { get { return defense; } }
    public int Attack { get { return attack; } }
    public ERA Region { get { return region; } }
    public Elemental Elemental {  get { return elemental; } }
    #endregion
}
