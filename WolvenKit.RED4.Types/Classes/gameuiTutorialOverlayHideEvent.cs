using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTutorialOverlayHideEvent : redEvent
	{
		private CName _itemName;

		[Ordinal(0)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}
	}
}
