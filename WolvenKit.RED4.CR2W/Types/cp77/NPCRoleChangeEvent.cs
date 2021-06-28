using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRoleChangeEvent : redEvent
	{
		private CHandle<AIRole> _newRole;

		[Ordinal(0)] 
		[RED("newRole")] 
		public CHandle<AIRole> NewRole
		{
			get => GetProperty(ref _newRole);
			set => SetProperty(ref _newRole, value);
		}

		public NPCRoleChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
