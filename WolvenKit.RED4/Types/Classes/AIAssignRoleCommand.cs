using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIAssignRoleCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("role")] 
		public CHandle<AIRole> Role
		{
			get => GetPropertyValue<CHandle<AIRole>>();
			set => SetPropertyValue<CHandle<AIRole>>(value);
		}

		public AIAssignRoleCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
