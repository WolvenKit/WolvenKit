using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _latitude;
		private CEnum<ETimeOfYearSeason> _season;
		private curveData<CFloat> _sunRotationOffset;
		private curveData<HDRColor> _sunColor;
		private curveData<CFloat> _sunSize;
		private curveData<CFloat> _moonRotationOffset;
		private curveData<HDRColor> _moonColor;
		private curveData<CFloat> _moonSize;
		private curveData<HDRColor> _specularTint;

		[Ordinal(2)] 
		[RED("latitude")] 
		public curveData<CFloat> Latitude
		{
			get
			{
				if (_latitude == null)
				{
					_latitude = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "latitude", cr2w, this);
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

		[Ordinal(3)] 
		[RED("season")] 
		public CEnum<ETimeOfYearSeason> Season
		{
			get
			{
				if (_season == null)
				{
					_season = (CEnum<ETimeOfYearSeason>) CR2WTypeManager.Create("ETimeOfYearSeason", "season", cr2w, this);
				}
				return _season;
			}
			set
			{
				if (_season == value)
				{
					return;
				}
				_season = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sunRotationOffset")] 
		public curveData<CFloat> SunRotationOffset
		{
			get
			{
				if (_sunRotationOffset == null)
				{
					_sunRotationOffset = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "sunRotationOffset", cr2w, this);
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

		[Ordinal(5)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get
			{
				if (_sunColor == null)
				{
					_sunColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "sunColor", cr2w, this);
				}
				return _sunColor;
			}
			set
			{
				if (_sunColor == value)
				{
					return;
				}
				_sunColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sunSize")] 
		public curveData<CFloat> SunSize
		{
			get
			{
				if (_sunSize == null)
				{
					_sunSize = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "sunSize", cr2w, this);
				}
				return _sunSize;
			}
			set
			{
				if (_sunSize == value)
				{
					return;
				}
				_sunSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("moonRotationOffset")] 
		public curveData<CFloat> MoonRotationOffset
		{
			get
			{
				if (_moonRotationOffset == null)
				{
					_moonRotationOffset = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "moonRotationOffset", cr2w, this);
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

		[Ordinal(8)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get
			{
				if (_moonColor == null)
				{
					_moonColor = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "moonColor", cr2w, this);
				}
				return _moonColor;
			}
			set
			{
				if (_moonColor == value)
				{
					return;
				}
				_moonColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("moonSize")] 
		public curveData<CFloat> MoonSize
		{
			get
			{
				if (_moonSize == null)
				{
					_moonSize = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "moonSize", cr2w, this);
				}
				return _moonSize;
			}
			set
			{
				if (_moonSize == value)
				{
					return;
				}
				_moonSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("specularTint")] 
		public curveData<HDRColor> SpecularTint
		{
			get
			{
				if (_specularTint == null)
				{
					_specularTint = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "specularTint", cr2w, this);
				}
				return _specularTint;
			}
			set
			{
				if (_specularTint == value)
				{
					return;
				}
				_specularTint = value;
				PropertySet(this);
			}
		}

		public LightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
