using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentDebris : CResource
	{
		private CArray<entdismembermentDebrisResourceItem> _items;

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<entdismembermentDebrisResourceItem> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
