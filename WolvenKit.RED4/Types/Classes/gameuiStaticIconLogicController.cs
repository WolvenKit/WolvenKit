using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiStaticIconLogicController : gameuiDynamicIconLogicController
	{
		[Ordinal(1)] 
		[RED("iconReference")] 
		public TweakDBID IconReference
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameuiStaticIconLogicController()
		{
			IconReference = 61952742650;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
