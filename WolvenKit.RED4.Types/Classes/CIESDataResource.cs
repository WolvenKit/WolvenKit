using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CIESDataResource : CResource
	{
		[Ordinal(1)] 
		[RED("samples", 128)] 
		public CArrayFixedSize<CUInt8> Samples
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt8>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt8>>(value);
		}

		public CIESDataResource()
		{
			Samples = new(128);
		}
	}
}
