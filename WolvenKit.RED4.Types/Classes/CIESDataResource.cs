using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CIESDataResource : CResource
	{
		private CArrayFixedSize<CUInt8> _samples;

		[Ordinal(1)] 
		[RED("samples", 128)] 
		public CArrayFixedSize<CUInt8> Samples
		{
			get => GetProperty(ref _samples);
			set => SetProperty(ref _samples, value);
		}
	}
}
