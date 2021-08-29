using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAssignRoleCommand : AICommand
	{
		private CHandle<AIRole> _role;

		[Ordinal(4)] 
		[RED("role")] 
		public CHandle<AIRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}
	}
}
