using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Attribute
    static GameManager _instance;
    #endregion
    #region Getter & Setter
    public static GameManager Game { get {return _instance;} }
    #endregion
    #region Unity Function
    public void Start()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

}
