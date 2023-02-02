using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGINode : worldNode
	{
		[Ordinal(4)] 
		[RED("data")] 
		public CResourceAsyncReference<CGIDataResource> Data
		{
			get => GetPropertyValue<CResourceAsyncReference<CGIDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CGIDataResource>>(value);
		}

		[Ordinal(5)] 
		[RED("location", 3)] 
		public CArrayFixedSize<CInt16> Location
		{
			get => GetPropertyValue<CArrayFixedSize<CInt16>>();
			set => SetPropertyValue<CArrayFixedSize<CInt16>>(value);
		}

		public worldGINode()
		{
			Location = new(3);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
