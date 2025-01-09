using UnityEngine;

public abstract class BaseSkill : MonoBehaviour
{
    #region Attribute
    float _coolTime;
    float weight;
    #endregion
    #region Function
    public abstract void SkillAction();
    #endregion
}
