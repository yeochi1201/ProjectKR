using System.Collections;
using System.Collections.Generic;
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
