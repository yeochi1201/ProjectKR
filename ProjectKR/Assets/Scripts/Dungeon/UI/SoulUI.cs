using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulUI : MonoBehaviour
{
    #region Attribute
    #endregion

    #region Function
    private void EquipSoul(int count, BaseSoul soul)
    {
        BaseSoul prev = PlayerState.SoulList.UnequipSoul(count);
        PlayerState.SoulList.EquipSoul(count, soul);
        if (prev != null)
        {
            PlayerState.PlayerSpec.MinusSoulAttribute(prev);
        }
        PlayerState.PlayerSpec.AddSoulAttribute(soul);
    }
    #endregion
    #region Button Function

    #endregion
}
