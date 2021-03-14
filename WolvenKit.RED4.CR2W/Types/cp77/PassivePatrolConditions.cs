using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassivePatrolConditions : PassiveAutonomousCondition
	{
		private CUInt32 _roleCbId;
		private CUInt32 _cmdCbId;

		[Ordinal(0)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get
			{
				if (_roleCbId == null)
				{
					_roleCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "roleCbId", cr2w, this);
				}
				return _roleCbId;
			}
			set
			{
				if (_roleCbId == value)
				{
					return;
				}
				_roleCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get
			{
				if (_cmdCbId == null)
				{
					_cmdCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "cmdCbId", cr2w, this);
				}
				return _cmdCbId;
			}
			set
			{
				if (_cmdCbId == value)
				{
					return;
				}
				_cmdCbId = value;
				PropertySet(this);
			}
		}

		public PassivePatrolConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
