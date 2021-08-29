using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workUnequipPropAction : workIWorkspotItemAction
	{
		private CName _itemId;

		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}
	}
}
