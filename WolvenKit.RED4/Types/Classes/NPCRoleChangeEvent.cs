using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCRoleChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newRole")] 
		public CHandle<AIRole> NewRole
		{
			get => GetPropertyValue<CHandle<AIRole>>();
			set => SetPropertyValue<CHandle<AIRole>>(value);
		}

		public NPCRoleChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
