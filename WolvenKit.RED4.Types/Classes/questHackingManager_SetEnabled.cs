using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHackingManager_SetEnabled : questHackingManager_ActionType
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questHackingManager_SetEnabled()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
