using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObjectInspectEvent : redEvent
	{
		private CBool _showItem;

		[Ordinal(0)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get => GetProperty(ref _showItem);
			set => SetProperty(ref _showItem, value);
		}
	}
}
