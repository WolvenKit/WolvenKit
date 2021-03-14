using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWeatherAreaNotifier : worldITriggerAreaNotifer
	{
		private CFloat _horizontalFadeDistance;
		private CFloat _verticalFadeDistance;
		private CArray<CName> _weatherStateNames;
		private CArray<CFloat> _weatherStateValues;

		[Ordinal(3)] 
		[RED("horizontalFadeDistance")] 
		public CFloat HorizontalFadeDistance
		{
			get
			{
				if (_horizontalFadeDistance == null)
				{
					_horizontalFadeDistance = (CFloat) CR2WTypeManager.Create("Float", "horizontalFadeDistance", cr2w, this);
				}
				return _horizontalFadeDistance;
			}
			set
			{
				if (_horizontalFadeDistance == value)
				{
					return;
				}
				_horizontalFadeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("verticalFadeDistance")] 
		public CFloat VerticalFadeDistance
		{
			get
			{
				if (_verticalFadeDistance == null)
				{
					_verticalFadeDistance = (CFloat) CR2WTypeManager.Create("Float", "verticalFadeDistance", cr2w, this);
				}
				return _verticalFadeDistance;
			}
			set
			{
				if (_verticalFadeDistance == value)
				{
					return;
				}
				_verticalFadeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("weatherStateNames")] 
		public CArray<CName> WeatherStateNames
		{
			get
			{
				if (_weatherStateNames == null)
				{
					_weatherStateNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "weatherStateNames", cr2w, this);
				}
				return _weatherStateNames;
			}
			set
			{
				if (_weatherStateNames == value)
				{
					return;
				}
				_weatherStateNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("weatherStateValues")] 
		public CArray<CFloat> WeatherStateValues
		{
			get
			{
				if (_weatherStateValues == null)
				{
					_weatherStateValues = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "weatherStateValues", cr2w, this);
				}
				return _weatherStateValues;
			}
			set
			{
				if (_weatherStateValues == value)
				{
					return;
				}
				_weatherStateValues = value;
				PropertySet(this);
			}
		}

		public worldWeatherAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
