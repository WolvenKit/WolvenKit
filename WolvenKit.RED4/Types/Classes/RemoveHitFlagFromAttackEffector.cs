using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveHitFlagFromAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get => GetPropertyValue<CEnum<hitFlag>>();
			set => SetPropertyValue<CEnum<hitFlag>>(value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RemoveHitFlagFromAttackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
