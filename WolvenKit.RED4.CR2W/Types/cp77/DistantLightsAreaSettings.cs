using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantLightsAreaSettings : IAreaSettings
	{
		private CFloat _distantLightStartDistance;
		private CFloat _distantLightFadeDistance;

		[Ordinal(2)] 
		[RED("distantLightStartDistance")] 
		public CFloat DistantLightStartDistance
		{
			get
			{
				if (_distantLightStartDistance == null)
				{
					_distantLightStartDistance = (CFloat) CR2WTypeManager.Create("Float", "distantLightStartDistance", cr2w, this);
				}
				return _distantLightStartDistance;
			}
			set
			{
				if (_distantLightStartDistance == value)
				{
					return;
				}
				_distantLightStartDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distantLightFadeDistance")] 
		public CFloat DistantLightFadeDistance
		{
			get
			{
				if (_distantLightFadeDistance == null)
				{
					_distantLightFadeDistance = (CFloat) CR2WTypeManager.Create("Float", "distantLightFadeDistance", cr2w, this);
				}
				return _distantLightFadeDistance;
			}
			set
			{
				if (_distantLightFadeDistance == value)
				{
					return;
				}
				_distantLightFadeDistance = value;
				PropertySet(this);
			}
		}

		public DistantLightsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
