using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReloadSpeedData : animAnimFeature
	{
		private CFloat _reloadSpeed;
		private CFloat _emptyReloadSpeed;

		[Ordinal(0)] 
		[RED("reloadSpeed")] 
		public CFloat ReloadSpeed
		{
			get => GetProperty(ref _reloadSpeed);
			set => SetProperty(ref _reloadSpeed, value);
		}

		[Ordinal(1)] 
		[RED("emptyReloadSpeed")] 
		public CFloat EmptyReloadSpeed
		{
			get => GetProperty(ref _emptyReloadSpeed);
			set => SetProperty(ref _emptyReloadSpeed, value);
		}

		public AnimFeature_WeaponReloadSpeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
