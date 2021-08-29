using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sharedMenuCollection : RedBaseClass
	{
		private CArray<sharedMenuItem> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<sharedMenuItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
