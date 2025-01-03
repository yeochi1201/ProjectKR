public class PlayerAction : CharacterAction
{
    #region Attribute
    #endregion
    #region Function
    public void SwitchSoul()
    {
        BaseSoul soul = PlayerState.SoulList.GetNextSoul();
        PlayerState.PlayerSpec.CurrentSoul = soul;
        PlayerState.Skills = soul.Skills;
    }
    #endregion
    #region Virtual Function
    public override void OnAttack()
    {

    }
    public override void OnDamaged()
    {

    }
    public override void OnHeal()
    {

    }
    public override void OnDead()
    {

    }
    #endregion
    #region Unity
    #endregion
}