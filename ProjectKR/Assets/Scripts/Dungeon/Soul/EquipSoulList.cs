using System.Collections.Generic;
using UnityEngine;

public class EquipSoulList : MonoBehaviour
{
    #region Attribute
    List<BaseSoul> _soulList = new(3);
    int _index;
    int _count = 0;
    int _maxCount = 3;
    #endregion
    #region Getter
    public List<BaseSoul> GetSoulList()
    {
        return _soulList;
    }
    #endregion
    #region Setter
    #endregion
    #region Function
    public BaseSoul GetNextSoul()
    {
        _index = (_index + 1)%_count;
        return _soulList[_index];
    }
    public void EquipSoul(int count,  BaseSoul soul)
    {
        _soulList[count] = soul;
    }
    public void UnequipSoul(int count)
    {
        _soulList[count] = null;
    }
    #endregion
}
