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

		[Ordinal(4)] 
		[RED("invertHitFlag")] 
		public CBool InvertHitFlag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HitFlagHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
