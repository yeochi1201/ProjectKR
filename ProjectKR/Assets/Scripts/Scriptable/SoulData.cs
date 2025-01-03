using UnityEngine;

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

    public int AddHp { get { return _addHp; } }
    public float AddSpeed { get { return _addSpeed; } }
    public int AddDefense {  get { return _addDefense; } }
    public int AddAttack {  get { return _addAttack; } }
    public Elemental Elemental { get { return _elemental; } }
}
