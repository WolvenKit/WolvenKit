using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		private inkWidgetReference _ownedBackground;
		private inkWidgetReference _ownedSign;

		[Ordinal(80)] 
		[RED("ownedBackground")] 
		public inkWidgetReference OwnedBackground
		{
			get => GetProperty(ref _ownedBackground);
			set => SetProperty(ref _ownedBackground, value);
		}

		[Ordinal(81)] 
		[RED("ownedSign")] 
		public inkWidgetReference OwnedSign
		{
			get => GetProperty(ref _ownedSign);
			set => SetProperty(ref _ownedSign, value);
		}
	}
}
