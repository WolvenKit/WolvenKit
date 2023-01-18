using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CombatGadget : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isQuickthrow")] 
		public CBool IsQuickthrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isChargedThrow")] 
		public CBool IsChargedThrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isDetonated")] 
		public CBool IsDetonated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_CombatGadget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
