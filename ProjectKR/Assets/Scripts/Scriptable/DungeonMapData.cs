using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DungeonMapData", menuName = "Data/Dungeon")]
public class DungeonMapData : ScriptableObject
{
    #region Attribute
    [SerializeField]
    ERA _era;
    [SerializeField]
    Elemental _elemental;
    [SerializeField]
    string _mapName;
    [SerializeField]
    List<int> _monsters;
    [SerializeField]
    int _bossID;
    #endregion
    
    #region Getter
    public ERA Region {  get { return _era; } }
    public Elemental Elemental { get { return _elemental; } }
    public string MapName { get { return _mapName; } }
    public List<int> Monsters { get { return _monsters; } }
    public int BossID { get { return _bossID; } }
    #endregion
}
