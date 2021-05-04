using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponStats : animAnimFeature
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

		public AnimFeature_WeaponStats(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
