using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiGenericNotificationReceiverGameController : gameuiWidgetGameController
	{
		private inkEmptyCallback _itemChanged;

		[Ordinal(2)] 
		[RED("ItemChanged")] 
		public inkEmptyCallback ItemChanged
		{
			get => GetProperty(ref _itemChanged);
			set => SetProperty(ref _itemChanged, value);
		}
	}
}
