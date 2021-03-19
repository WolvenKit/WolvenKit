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
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}

		[Ordinal(1)] 
		[RED("cmdCbId")] 
		public CUInt32 CmdCbId
		{
			get => GetProperty(ref _cmdCbId);
			set => SetProperty(ref _cmdCbId, value);
		}

		public PassivePatrolConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
