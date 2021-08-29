using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCRoleChangeEvent : redEvent
	{
		private CHandle<AIRole> _newRole;

		[Ordinal(0)] 
		[RED("newRole")] 
		public CHandle<AIRole> NewRole
		{
			get => GetProperty(ref _newRole);
			set => SetProperty(ref _newRole, value);
		}
	}
}
