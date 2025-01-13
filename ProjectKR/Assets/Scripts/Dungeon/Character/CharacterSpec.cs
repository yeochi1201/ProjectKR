using UnityEngine;

public class CharacterSpec : MonoBehaviour
{
    [SerializeField]
    CharacterSpecData data; // DataManager에서 받는 걸로 대체 예정
    #region Attribute
    protected int _maxhp;
    int _hp;
    protected int _maxmp;
    int _mp;
    protected float _speed;
    protected int _defense;
    protected int _attack;

    ERA region;
    Elemental elemental;
    #endregion
    #region Getter & Setter
    public int MaxHp {  get { return _maxhp; } set { _maxhp = value; } }
    public int Hp { get { return _hp; } set { _hp = value; } }

    public int MaxMp { get { return _maxmp; } set {_maxmp = value; } }
    public int Mp {  get { return _mp; } set { _mp = value; } }
    public float Speed { get { return _speed; } set { _speed = value; } }
    public int Defense { get { return _defense; } set { _defense = value; } }
    public int Attack { get { return _attack; } set { _attack = value; } }
    public Elemental Elemental { get { return elemental; } set { elemental = value; } }
    
    #endregion
    #region Setter
    public void SetHp(int hp)
    {
        this._hp = hp;
    }
    
    #endregion
    #region Function
    public void SetAttribute()
    {
        _maxhp = data.MaxHp;
        _hp = _maxhp;
        _maxmp = data.MaxMp;
        _mp = _maxmp;
        _speed = data.Speed;
        _defense = data.Defense;
        _attack = data.Attack;
        elemental = data.Elemental;
    }
    
    #endregion
    #region Unity
    #endregion
}
