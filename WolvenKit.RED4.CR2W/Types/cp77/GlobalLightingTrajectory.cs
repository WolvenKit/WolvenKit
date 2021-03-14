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
			get
			{
				if (_latitude == null)
				{
					_latitude = (CFloat) CR2WTypeManager.Create("Float", "latitude", cr2w, this);
				}
				return _latitude;
			}
			set
			{
				if (_latitude == value)
				{
					return;
				}
				_latitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sunRotationOffset")] 
		public CFloat SunRotationOffset
		{
			get
			{
				if (_sunRotationOffset == null)
				{
					_sunRotationOffset = (CFloat) CR2WTypeManager.Create("Float", "sunRotationOffset", cr2w, this);
				}
				return _sunRotationOffset;
			}
			set
			{
				if (_sunRotationOffset == value)
				{
					return;
				}
				_sunRotationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("moonRotationOffset")] 
		public CFloat MoonRotationOffset
		{
			get
			{
				if (_moonRotationOffset == null)
				{
					_moonRotationOffset = (CFloat) CR2WTypeManager.Create("Float", "moonRotationOffset", cr2w, this);
				}
				return _moonRotationOffset;
			}
			set
			{
				if (_moonRotationOffset == value)
				{
					return;
				}
				_moonRotationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeOfYearSeason")] 
		public CEnum<ETimeOfYearSeason> TimeOfYearSeason
		{
			get
			{
				if (_timeOfYearSeason == null)
				{
					_timeOfYearSeason = (CEnum<ETimeOfYearSeason>) CR2WTypeManager.Create("ETimeOfYearSeason", "timeOfYearSeason", cr2w, this);
				}
				return _timeOfYearSeason;
			}
			set
			{
				if (_timeOfYearSeason == value)
				{
					return;
				}
				_timeOfYearSeason = value;
				PropertySet(this);
			}
		}

		public GlobalLightingTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
