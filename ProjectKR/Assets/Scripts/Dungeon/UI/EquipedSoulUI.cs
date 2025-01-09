using UnityEngine;
using UnityEngine.UI;

public class EquipedSoulUI : UIBase
{
    enum Buttons { UnequipButton }
    enum Images { SoulImage }
    enum Texts { SoulNameText, SoulGradeText}
    #region Event Function
    #endregion
    #region BindEvent
    #endregion
    #region Function
    public void ChangeSoul(SoulData soul)
    {
        Image image = Get<Image>((int)Images.SoulImage);
        Text nameText = Get<Text>((int)Texts.SoulNameText);
        Text gradeText = Get<Text>((int)Texts.SoulGradeText);

        image.sprite = soul.Sprite;
        nameText.text = soul.Name;
        gradeText.text = soul.Grade;
    }
    #endregion
    #region Unity
    private void Start()
    {
        Bind<GameObject>(typeof(Buttons));
        Bind<Image>(typeof(Images));
        Bind<Text>(typeof(Texts));
    }
    #endregion
}