using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveRoleCondition : AIbehaviorexpressionScript
	{
		private CEnum<EAIRole> _role;
		private CUInt32 _roleCbId;

		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}

		public PassiveRoleCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
