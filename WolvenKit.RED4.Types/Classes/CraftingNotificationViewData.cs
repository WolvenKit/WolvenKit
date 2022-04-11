using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
