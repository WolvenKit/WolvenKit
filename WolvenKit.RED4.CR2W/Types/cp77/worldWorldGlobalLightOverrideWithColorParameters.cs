using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldGlobalLightOverrideWithColorParameters : CVariable
	{
		private GlobalLightingTrajectoryOverride _lightDirOverride;
		private HDRColor _lightColorOverride;

		[Ordinal(0)] 
		[RED("lightDirOverride")] 
		public GlobalLightingTrajectoryOverride LightDirOverride
		{
			get
			{
				if (_lightDirOverride == null)
				{
					_lightDirOverride = (GlobalLightingTrajectoryOverride) CR2WTypeManager.Create("GlobalLightingTrajectoryOverride", "lightDirOverride", cr2w, this);
				}
				return _lightDirOverride;
			}
			set
			{
				if (_lightDirOverride == value)
				{
					return;
				}
				_lightDirOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lightColorOverride")] 
		public HDRColor LightColorOverride
		{
			get
			{
				if (_lightColorOverride == null)
				{
					_lightColorOverride = (HDRColor) CR2WTypeManager.Create("HDRColor", "lightColorOverride", cr2w, this);
				}
				return _lightColorOverride;
			}
			set
			{
				if (_lightColorOverride == value)
				{
					return;
				}
				_lightColorOverride = value;
				PropertySet(this);
			}
		}

		public worldWorldGlobalLightOverrideWithColorParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
