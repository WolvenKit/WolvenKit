using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnGenderMask : RedBaseClass
	{
		private CUInt8 _mask;

		[Ordinal(0)] 
		[RED("mask")] 
		public CUInt8 Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}
	}
}
