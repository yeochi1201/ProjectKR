using UnityEngine;

public class CharacterAction : MonoBehaviour
{
    #region Attribute
    protected CharacterSpec _spec;
    #endregion
    #region Function
    public void BasicAttack()
    {
        OnAttack();
        //타격 범위 판정
    }
    public void Damaged(int attack)
    {
        int defenseValue = _spec.GetDefense()+100;
        int damage = attack * 100 / defenseValue;
        int remainHp = _spec.GetHp() - damage;
        OnDamaged();
        if (remainHp > 0)
        {
            _spec.SetHp(remainHp);
        }
        else
        {
            Dead();
        }
    }
    public void Heal(int heal)
    {
        int resultHp = _spec.GetHp() + heal;
        OnHeal();
        if (resultHp > _spec.GetMaxHp())
        {
            _spec.SetHp(_spec.GetMaxHp());
        }
        else
        {
            _spec.SetHp(resultHp);
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
        _spec = GetComponent<CharacterSpec>();
    }
    #endregion
}