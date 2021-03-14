using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlobalLightOverrideAreaSettings : IAreaSettings
	{
		private curveData<HDRColor> _color;
		private CFloat _lightAzimuth;
		private CFloat _lightElevation;

		[Ordinal(2)] 
		[RED("color")] 
		public curveData<HDRColor> Color
		{
			get
			{
				if (_color == null)
				{
					_color = (curveData<HDRColor>) CR2WTypeManager.Create("curveData:HDRColor", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lightAzimuth")] 
		public CFloat LightAzimuth
		{
			get
			{
				if (_lightAzimuth == null)
				{
					_lightAzimuth = (CFloat) CR2WTypeManager.Create("Float", "lightAzimuth", cr2w, this);
				}
				return _lightAzimuth;
			}
			set
			{
				if (_lightAzimuth == value)
				{
					return;
				}
				_lightAzimuth = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lightElevation")] 
		public CFloat LightElevation
		{
			get
			{
				if (_lightElevation == null)
				{
					_lightElevation = (CFloat) CR2WTypeManager.Create("Float", "lightElevation", cr2w, this);
				}
				return _lightElevation;
			}
			set
			{
				if (_lightElevation == value)
				{
					return;
				}
				_lightElevation = value;
				PropertySet(this);
			}
		}

		public GlobalLightOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
