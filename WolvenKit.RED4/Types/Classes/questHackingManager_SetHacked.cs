using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHackingManager_SetHacked : questHackingManager_ActionType
	{
		[Ordinal(0)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questHackingManager_SetHacked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
