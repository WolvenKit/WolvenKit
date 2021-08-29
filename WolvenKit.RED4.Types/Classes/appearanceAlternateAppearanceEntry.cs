using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceAlternateAppearanceEntry : RedBaseClass
	{
		private CName _original;
		private CName _alternate;
		private CUInt8 _alternateAppearanceIndex;

		[Ordinal(0)] 
		[RED("Original")] 
		public CName Original
		{
			get => GetProperty(ref _original);
			set => SetProperty(ref _original, value);
		}

		[Ordinal(1)] 
		[RED("Alternate")] 
		public CName Alternate
		{
			get => GetProperty(ref _alternate);
			set => SetProperty(ref _alternate, value);
		}

		[Ordinal(2)] 
		[RED("AlternateAppearanceIndex")] 
		public CUInt8 AlternateAppearanceIndex
		{
			get => GetProperty(ref _alternateAppearanceIndex);
			set => SetProperty(ref _alternateAppearanceIndex, value);
		}
	}
}
