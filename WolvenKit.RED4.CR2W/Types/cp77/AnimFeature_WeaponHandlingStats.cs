using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponHandlingStats : animAnimFeature
	{
		private CFloat _weaponRecoil;
		private CFloat _weaponSpread;

		[Ordinal(0)] 
		[RED("weaponRecoil")] 
		public CFloat WeaponRecoil
		{
			get => GetProperty(ref _weaponRecoil);
			set => SetProperty(ref _weaponRecoil, value);
		}

		[Ordinal(1)] 
		[RED("weaponSpread")] 
		public CFloat WeaponSpread
		{
			get => GetProperty(ref _weaponSpread);
			set => SetProperty(ref _weaponSpread, value);
		}

		public AnimFeature_WeaponHandlingStats(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
