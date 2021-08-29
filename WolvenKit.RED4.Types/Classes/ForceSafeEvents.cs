using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceSafeEvents : UpperBodyEventsTransition
	{
		private CHandle<AnimFeature_SafeAction> _safeAnimFeature;
		private TweakDBID _weaponObjectID;

		[Ordinal(6)] 
		[RED("safeAnimFeature")] 
		public CHandle<AnimFeature_SafeAction> SafeAnimFeature
		{
			get => GetProperty(ref _safeAnimFeature);
			set => SetProperty(ref _safeAnimFeature, value);
		}

		[Ordinal(7)] 
		[RED("weaponObjectID")] 
		public TweakDBID WeaponObjectID
		{
			get => GetProperty(ref _weaponObjectID);
			set => SetProperty(ref _weaponObjectID, value);
		}
	}
}
