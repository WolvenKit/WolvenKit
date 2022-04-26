using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class resResourceSnapshot : CResource
	{
		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<CResourceAsyncReference<CResource>> Resources
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		public resResourceSnapshot()
		{
			Resources = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
