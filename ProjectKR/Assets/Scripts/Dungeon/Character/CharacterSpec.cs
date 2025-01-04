using UnityEngine;

public class CharacterSpec : MonoBehaviour
{
    CharacterSpecData data; // DataManager에서 받는 걸로 대체 예정
    #region Attribute
    protected int maxhp;
    int hp;
    protected int maxmp;
    int mp;
    protected float speed = 5f;
    protected int defense;
    protected int attack;

    Region region;
    Elemental elemental;
    #endregion
    #region Getter & Setter
    public int MaxHp {  get { return maxhp; } set { maxhp = value; } }
    public int Hp { get { return hp; } set { hp = value; } }

    public int MaxMp { get { return maxmp; } set {maxmp = value; } }
    public int Mp {  get { return mp; } set { mp = value; } }
    public float Speed { get { return speed; } set { speed = value; } }
    public int Defense { get { return defense; } set { defense = value; } }
    public int Attack { get { return attack; } set { attack = value; } }
    public Elemental Elemental { get { return elemental; } set { elemental = value; } }
    
    #endregion
    #region Setter
    public void SetHp(int hp)
    {
        this.hp = hp;
    }
    
    #endregion
    #region Function
    public void SetAttribute()
    {
        maxhp = data.MaxHp;
        hp = maxhp;
        maxmp = data.MaxMp;
        mp = maxmp;
        speed = data.Speed;
        defense = data.Defense;
        attack = data.Attack;
        region = data.Region;
        elemental = data.Elemental;
    }
    
    #endregion
    #region Unity
    public void Start()
    {
        //SetAttribute();
    }
    #endregion
}
