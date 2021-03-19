using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAssignRoleCommandParams : questScriptedAICommandParams
	{
		private CHandle<AIRole> _role;

		[Ordinal(0)] 
		[RED("role")] 
		public CHandle<AIRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		public AIAssignRoleCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
