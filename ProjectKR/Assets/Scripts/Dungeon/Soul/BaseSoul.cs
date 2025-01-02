using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSoul : MonoBehaviour
{
    #region Attribute
    int _addHp;
    float _addSpeed;
    int _addDefense;
    int _addAttack;
    Elemental _elemental;
    #endregion
    #region Getter
    public int GetAddHp()
    {
        return _addHp;
    }
    public float GetAddSpeed()
    {
        return _addSpeed;
    }
    public int GetAddDefense()
    {
        return _addDefense;
    }
    public int GetAddAttack()
    {
        return _addAttack;
    }
    #endregion
    #region Setter
    public void SetAddHp(int hp)
    {
        _addHp = hp;
    }
    public void SetAddSpeed(float speed)
    {
        _addSpeed = speed;
    }
    public void SetAddDefense(int defense)
    {
        _addDefense = defense;
    }
    public void SetAddAttack(int attack)
    {
        _addAttack = attack;
    }
    
    #endregion
    #region Function
    #endregion
}
