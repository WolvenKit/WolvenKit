using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DispenseFreeSpecificItem : redEvent
	{
		private TweakDBID _item;

		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}
	}
}
