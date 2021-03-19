using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlobalLightingTrajectory : CVariable
	{
		private CFloat _latitude;
		private CFloat _sunRotationOffset;
		private CFloat _moonRotationOffset;
		private CEnum<ETimeOfYearSeason> _timeOfYearSeason;

		[Ordinal(0)] 
		[RED("latitude")] 
		public CFloat Latitude
		{
			get => GetProperty(ref _latitude);
			set => SetProperty(ref _latitude, value);
		}

		[Ordinal(1)] 
		[RED("sunRotationOffset")] 
		public CFloat SunRotationOffset
		{
			get => GetProperty(ref _sunRotationOffset);
			set => SetProperty(ref _sunRotationOffset, value);
		}

		[Ordinal(2)] 
		[RED("moonRotationOffset")] 
		public CFloat MoonRotationOffset
		{
			get => GetProperty(ref _moonRotationOffset);
			set => SetProperty(ref _moonRotationOffset, value);
		}

		[Ordinal(3)] 
		[RED("timeOfYearSeason")] 
		public CEnum<ETimeOfYearSeason> TimeOfYearSeason
		{
			get => GetProperty(ref _timeOfYearSeason);
			set => SetProperty(ref _timeOfYearSeason, value);
		}

		public GlobalLightingTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
