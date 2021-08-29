using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workAnimClipWithItem : workAnimClip
	{
		private CArray<CHandle<workIWorkspotItemAction>> _itemActions;

		[Ordinal(4)] 
		[RED("itemActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> ItemActions
		{
			get => GetProperty(ref _itemActions);
			set => SetProperty(ref _itemActions, value);
		}
	}
}
