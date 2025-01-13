using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpec : CharacterSpec
{
    #region Attribute
    BaseSoul _currentSoul;
    #endregion
    #region Getter & Setter
    public BaseSoul CurrentSoul { get { return _currentSoul; } set { _currentSoul = value; } }
    #endregion
    #region Function
    public void AddSoulAttribute(BaseSoul soul)
    {
        SoulData soulData = soul.SoulData;
        _maxhp += soulData.AddHp;
        _speed += soulData.AddSpeed;
        _defense += soulData.AddDefense;
        _attack += soulData.AddAttack;
    }
    public void MinusSoulAttribute(BaseSoul soul)
    {
        SoulData soulData = soul.SoulData;
        _maxhp -= soulData.AddHp;
        _speed -= soulData.AddSpeed;
        _defense -= soulData.AddDefense;
        _attack -= soulData.AddAttack;
    }
    #endregion
}
