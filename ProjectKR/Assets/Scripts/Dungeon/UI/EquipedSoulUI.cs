using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EquipedSoulUI : UIBase
{
    enum Buttons { UnequipButton }
    enum Images { SoulImage }
    enum Texts { SoulNameText, SoulGradeText}
    #region Attribute
    Image _soulImage;
    Text _soulNameText;
    Text _soulGradeText;
    int _idx;

    public int Idx { get { return _idx; } set { _idx = value; } }
    #endregion
    #region Event Function
    private void ChangeNull()
    {
        _soulImage.sprite = null;
        _soulNameText.text = "";
        _soulGradeText.text = "";
    }
    private void UnequipSoul(PointerEventData data)
    {
        PlayerState.SoulList.UnequipSoul(_idx);
        ChangeNull();
    }
    #endregion
    #region BindEvent
    private void BindUnEquipButton()
    {
        GameObject button = Get<Button>((int)Buttons.UnequipButton).gameObject;
        AddEvent(button, UnequipSoul, UIEvent.CLICK);
    }
    #endregion
    #region Function
    private void AllocateObject()
    {
        _soulImage = Get<Image>((int)Images.SoulImage);
        _soulNameText = Get<Text>((int)Texts.SoulNameText);
        _soulGradeText = Get<Text>((int)Texts.SoulGradeText);
    }
    public void ChangeSoulUI(SoulData soul)
    {
        _soulImage.sprite = soul.Sprite;
        _soulNameText.text = soul.Name;
        _soulGradeText.text = soul.Grade;
    }
    #endregion
    #region Unity
    private void OnStart()
    {
        Bind<GameObject>(typeof(Buttons));
        Bind<Image>(typeof(Images));
        Bind<Text>(typeof(Texts));
        AllocateObject();
    }
    #endregion
}