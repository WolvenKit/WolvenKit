using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTweakDBIconReference : inkIconReference
	{
		[Ordinal(0)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameuiTweakDBIconReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
