using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		private CFloat _zoomLevel;
		private CFloat _aimInTime;
		private CFloat _aimOutTime;

		[Ordinal(2)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(3)] 
		[RED("aimInTime")] 
		public CFloat AimInTime
		{
			get => GetProperty(ref _aimInTime);
			set => SetProperty(ref _aimInTime, value);
		}

		[Ordinal(4)] 
		[RED("aimOutTime")] 
		public CFloat AimOutTime
		{
			get => GetProperty(ref _aimOutTime);
			set => SetProperty(ref _aimOutTime, value);
		}

		public gameweaponAnimFeature_AimPlayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
