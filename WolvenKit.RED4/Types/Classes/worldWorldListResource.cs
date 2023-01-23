using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWorldListResource : CResource
	{
		[Ordinal(1)] 
		[RED("worlds")] 
		public CArray<worldWorldListResourceEntry> Worlds
		{
			get => GetPropertyValue<CArray<worldWorldListResourceEntry>>();
			set => SetPropertyValue<CArray<worldWorldListResourceEntry>>(value);
		}

		public worldWorldListResource()
		{
			Worlds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
