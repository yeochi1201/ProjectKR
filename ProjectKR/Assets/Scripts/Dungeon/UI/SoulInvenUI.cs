using UnityEngine;

public class SoulInvenUI : UIBase
{
    enum EquipedSoulUIs
    {
        EquipedSoulUI1, 
        EquipedSoulUI2, 
        EquipedSoulUI3,
    }
    #region Attribute

    #endregion
    #region Bind Function

    #endregion
    #region UnityFunction
    public void OnStart()
    {
        Bind<EquipedSoulUI>(typeof(EquipedSoulUIs));
    }
    #endregion
}
