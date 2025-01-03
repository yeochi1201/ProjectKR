using System.Collections.Generic;
using UnityEngine;

public class EquipSoulList : MonoBehaviour
{
    #region Attribute
    List<BaseSoul> _soulList = new(3);
    int _index = 0;
    int _count = 0;
    #endregion
    #region Getter & Setter
    public List<BaseSoul> SoulList {  get { return _soulList; } }
    #endregion
    #region Function
    public BaseSoul GetNextSoul()
    {
        _index = (_index + 1)%_count;
        if (_soulList[_index] == null)
        {
            return GetNextSoul();
        }
        return _soulList[_index];
    }
    public void EquipSoul(int count,  BaseSoul soul)
    {
        _soulList[count] = soul;
        _count++;
    }
    public BaseSoul UnequipSoul(int count)
    {
        BaseSoul soul = _soulList[count];
        _soulList[count] = null;
        _count--;
        return soul;
    }
    #endregion
}
