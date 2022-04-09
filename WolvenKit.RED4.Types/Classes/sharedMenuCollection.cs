using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sharedMenuCollection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<sharedMenuItem> Items
		{
			get => GetPropertyValue<CArray<sharedMenuItem>>();
			set => SetPropertyValue<CArray<sharedMenuItem>>(value);
		}

		public sharedMenuCollection()
		{
			Items = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
