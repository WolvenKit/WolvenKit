using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_WeaponStats : animAnimFeature
	{
		private CInt32 _magazineCapacity;
		private CFloat _cycleTime;

		[Ordinal(0)] 
		[RED("magazineCapacity")] 
		public CInt32 MagazineCapacity
		{
			get => GetProperty(ref _magazineCapacity);
			set => SetProperty(ref _magazineCapacity, value);
		}

		[Ordinal(1)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetProperty(ref _cycleTime);
			set => SetProperty(ref _cycleTime, value);
		}
	}
}
