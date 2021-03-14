using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldEnvironmentAreaParameters : CVariable
	{
		private CBool _enable;
		private worldWorldGlobalLightParameters _globalLight;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("globalLight")] 
		public worldWorldGlobalLightParameters GlobalLight
		{
			get
			{
				if (_globalLight == null)
				{
					_globalLight = (worldWorldGlobalLightParameters) CR2WTypeManager.Create("worldWorldGlobalLightParameters", "globalLight", cr2w, this);
				}
				return _globalLight;
			}
			set
			{
				if (_globalLight == value)
				{
					return;
				}
				_globalLight = value;
				PropertySet(this);
			}
		}

		public worldWorldEnvironmentAreaParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
