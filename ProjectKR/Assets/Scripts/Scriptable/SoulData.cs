using UnityEngine;

[CreateAssetMenu(fileName = "SoulData", menuName = "Data/SoulData")]
public class SoulData : ScriptableObject
{
    [SerializeField]
    int _addHp;
    [SerializeField]
    float _addSpeed;
    [SerializeField]
    int _addDefense;
    [SerializeField]
    int _addAttack;
    [SerializeField]
    Elemental _elemental;
    [SerializeField]
    string _name;
    [SerializeField]
    string _grade;
    [SerializeField]
    Sprite _sprite;

    public int AddHp { get { return _addHp; } }
    public float AddSpeed { get { return _addSpeed; } }
    public int AddDefense {  get { return _addDefense; } }
    public int AddAttack {  get { return _addAttack; } }
    public Elemental Elemental { get { return _elemental; } }
    public string Name { get { return _name; } }
    public string Grade { get { return _grade; } }
    public Sprite Sprite { get { return _sprite; } }
}
