using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CIESDataResource : CResource
	{
		[Ordinal(1)] 
		[RED("samples", 128)] 
		public CArrayFixedSize<CUInt16> Samples
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt16>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt16>>(value);
		}

		public CIESDataResource()
		{
			Samples = new(128);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
