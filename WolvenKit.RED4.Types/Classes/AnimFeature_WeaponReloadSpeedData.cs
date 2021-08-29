using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_WeaponReloadSpeedData : animAnimFeature
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
	}
}
