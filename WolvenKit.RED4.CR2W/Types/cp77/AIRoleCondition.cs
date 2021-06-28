using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRoleCondition : AIbehaviorconditionScript
	{
		private CEnum<EAIRole> _role;

		[Ordinal(0)] 
		[RED("role")] 
		public CEnum<EAIRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		public AIRoleCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
