using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DungeonMap", menuName = "Data/Dungeon")]
public class DungeonMapData : ScriptableObject
{
    #region Attribute
    [SerializeField]
    Region region;
    [SerializeField]
    Elemental elemental;
    [SerializeField]
    string mapName;
    [SerializeField]
    List<int> monsters;
    [SerializeField]
    int boss;
    #endregion
    
    #region Getter
    public Region Region {  get { return region; } }
    public Elemental Elemental { get { return elemental; } }
    public string MapName { get { return mapName; } }
    public List<int> Monsters { get { return monsters; } }
    public int Boss { get { return boss; } }
    #endregion
}
