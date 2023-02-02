using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SHitStatusEffect : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SHitStatusEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
