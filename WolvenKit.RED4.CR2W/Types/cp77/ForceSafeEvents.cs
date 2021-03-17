using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceSafeEvents : UpperBodyEventsTransition
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

		public ForceSafeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
