using UnityEngine;

public class CharacterSpec : MonoBehaviour
{
    CharacterSpecData data; // DataManager에서 받는 걸로 대체 예정
    #region Attribute
    int maxhp;
    int hp;
    int maxmp;
    int mp;
    float speed;
    int defense;
    int attack;

    Region region;
    Elemental elemental;
    #endregion
    #region Getter
    public int GetMaxHp()
    {
        return maxhp;
    }
    public int GetHp()
    {
        return hp;
    }
    public int GetMaxMp()
    {
        return maxmp;
    }
    public int GetMp()
    {
        return mp;
    }
    public float GetSpeed()
    {
        return speed;
    }
    public int GetDefense()
    {
        return defense;
    }
    public int GetAttack()
    {
        return attack;
    }
    public Region GetRegion()
    {
        return region;
    }
    public Elemental GetElemental()
    {
        return elemental;
    }
    #endregion
    #region Setter
    public void SetHp(int hp)
    {
        this.hp = hp;
    }
    public void SetMp(int mp)
    {
        this.mp = mp;
    }
    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
    public void SetDefense(int defense)
    {
        this.defense = defense;
    }
    public void SetAttack(int attack)
    { 
        this.attack = attack;
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
        SetAttribute();
    }
    #endregion
}
