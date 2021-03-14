using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldEnvironmentParameters : CVariable
	{
		private GlobalLightingTrajectory _globalLightingTrajectory;

		[Ordinal(0)] 
		[RED("globalLightingTrajectory")] 
		public GlobalLightingTrajectory GlobalLightingTrajectory
		{
			get
			{
				if (_globalLightingTrajectory == null)
				{
					_globalLightingTrajectory = (GlobalLightingTrajectory) CR2WTypeManager.Create("GlobalLightingTrajectory", "globalLightingTrajectory", cr2w, this);
				}
				return _globalLightingTrajectory;
			}
			set
			{
				if (_globalLightingTrajectory == value)
				{
					return;
				}
				_globalLightingTrajectory = value;
				PropertySet(this);
			}
		}

		public worldWorldEnvironmentParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
