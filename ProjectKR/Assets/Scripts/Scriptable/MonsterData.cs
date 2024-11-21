using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "MonsterData", menuName = "Data/MonsterData")]
public class MonsterData : CharacterSpecData
{
    #region Attribute
    [SerializeField]
    int monsterID;
    [SerializeField]
    string monsterName;
    [SerializeField]
    List<int> skills;
    #endregion

    #region Getter
    public int MonsterID { get { return monsterID; } }
    public string MonsterName { get { return monsterName; } }
    public List<int> Skills { get { return skills; } }
    #endregion
}
