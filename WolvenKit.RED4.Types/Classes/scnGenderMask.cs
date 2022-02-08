using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnGenderMask : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mask")] 
		public CUInt8 Mask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public scnGenderMask()
		{
			Mask = 128;
		}
	}
}
