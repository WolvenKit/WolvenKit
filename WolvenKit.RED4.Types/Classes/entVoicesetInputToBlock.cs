using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVoicesetInputToBlock : RedBaseClass
	{
		private CName _input;
		private CBool _blockSpecificVariation;
		private CUInt32 _variationNumber;

		[Ordinal(0)] 
		[RED("input")] 
		public CName Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		[Ordinal(1)] 
		[RED("blockSpecificVariation")] 
		public CBool BlockSpecificVariation
		{
			get => GetProperty(ref _blockSpecificVariation);
			set => SetProperty(ref _blockSpecificVariation, value);
		}

		[Ordinal(2)] 
		[RED("variationNumber")] 
		public CUInt32 VariationNumber
		{
			get => GetProperty(ref _variationNumber);
			set => SetProperty(ref _variationNumber, value);
		}
	}
}
