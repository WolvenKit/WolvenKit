using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHackingManager_SetHacked : questHackingManager_ActionType
	{
		[Ordinal(0)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
