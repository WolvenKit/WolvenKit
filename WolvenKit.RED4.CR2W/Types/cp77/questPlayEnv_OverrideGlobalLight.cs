using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_OverrideGlobalLight : questIEnvironmentManagerNodeType
	{
		private worldWorldGlobalLightOverrideWithColorParameters _params;

		[Ordinal(0)] 
		[RED("params")] 
		public worldWorldGlobalLightOverrideWithColorParameters Params
		{
			get
			{
				if (_params == null)
				{
					_params = (worldWorldGlobalLightOverrideWithColorParameters) CR2WTypeManager.Create("worldWorldGlobalLightOverrideWithColorParameters", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questPlayEnv_OverrideGlobalLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
