using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceSafeEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] 
		[RED("safeAnimFeature")] 
		public CHandle<AnimFeature_SafeAction> SafeAnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SafeAction>>();
			set => SetPropertyValue<CHandle<AnimFeature_SafeAction>>(value);
		}

		[Ordinal(7)] 
		[RED("weaponObjectID")] 
		public TweakDBID WeaponObjectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ForceSafeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
