using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitFlagHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get => GetPropertyValue<CEnum<hitFlag>>();
			set => SetPropertyValue<CEnum<hitFlag>>(value);
		}

		public HitFlagHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
