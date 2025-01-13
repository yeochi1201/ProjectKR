using UnityEngine;

public class PlayerState : MonoBehaviour
{
    #region Attribute
    static PlayerSpec _spec;
    static PlayerAction _action;
    static SoulSkillList _skills;
    static EquipSoulList _souls;
    static GameObject _player;
    #endregion
    #region Getter & Setter
    public static PlayerSpec PlayerSpec {  get { return _spec; } }
    public static SoulSkillList Skills { get { return _skills; } set { _skills = value; } }
    public static EquipSoulList SoulList { get { return _souls; } }
    public static PlayerAction Action { get { return _action; } set { _action = value; } }
    public static GameObject Player { get { return _player; } }
    #endregion
    #region Function
    #endregion
    #region Unity Function
    private void Awake()
    {
        _player = this.gameObject;
        _spec = this.GetComponent<PlayerSpec>();
        _spec.SetAttribute();
        _action = this.GetComponent<PlayerAction>();
    }
    #endregion
}
