using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_NodeTypeParams : CVariable
	{
		private CBool _enable;
		private rRef<worldEnvironmentAreaParameters> _envParams;
		private CFloat _blendTime;

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
		[RED("envParams")] 
		public rRef<worldEnvironmentAreaParameters> EnvParams
		{
			get
			{
				if (_envParams == null)
				{
					_envParams = (rRef<worldEnvironmentAreaParameters>) CR2WTypeManager.Create("rRef:worldEnvironmentAreaParameters", "envParams", cr2w, this);
				}
				return _envParams;
			}
			set
			{
				if (_envParams == value)
				{
					return;
				}
				_envParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		public questPlayEnv_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
