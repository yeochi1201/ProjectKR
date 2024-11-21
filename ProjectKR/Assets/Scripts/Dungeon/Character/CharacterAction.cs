using UnityEngine;

public class CharacterAction : MonoBehaviour
{
    #region Attribute
    CharacterSpec spec;
    #endregion
    #region Function
    public void BasicAttack()
    {
        OnAttack();
        //타격 범위 판정
    }
    public void Damaged(int attack)
    {
        int defenseValue = spec.GetDefense()+100;
        int damage = attack * 100 / defenseValue;
        int remainHp = spec.GetHp() - damage;
        OnDamaged();
        if (remainHp > 0)
        {
            spec.SetHp(remainHp);
        }
        else
        {
            Dead();
        }
    }
    public void Heal(int heal)
    {
        int resultHp = spec.GetHp() + heal;
        OnHeal();
        if (resultHp > spec.GetMaxHp())
        {
            spec.SetHp(spec.GetMaxHp());
        }
        else
        {
            spec.SetHp(resultHp);
        }
    }
    public void Dead()
    {
        OnDead();
        Destroy(gameObject);
    }
    #endregion
    #region Virtual Function
    public virtual void OnAttack()
    {

    }
    public virtual void OnDamaged()
    {

    }
    public virtual void OnHeal()
    {

    }
    public virtual void OnDead()
    {

    }
    #endregion
    #region Unity
    private void Start()
    {
        spec = GetComponent<CharacterSpec>();
    }
    #endregion
}