using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FixedPoint : RedBaseClass
	{
		private CInt32 _bits;

		[Ordinal(0)] 
		[RED("Bits")] 
		public CInt32 Bits
		{
			get => GetProperty(ref _bits);
			set => SetProperty(ref _bits, value);
		}
	}
}
