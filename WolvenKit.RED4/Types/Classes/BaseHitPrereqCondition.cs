using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseHitPrereqCondition : IScriptable
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("onlyOncePerShot")] 
		public CBool OnlyOncePerShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("lastAttackTime")] 
		public CFloat LastAttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BaseHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
