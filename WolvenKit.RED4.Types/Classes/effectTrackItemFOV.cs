using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemFOV : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _fOV;

		[Ordinal(3)] 
		[RED("FOV")] 
		public effectEffectParameterEvaluatorFloat FOV
		{
			get => GetProperty(ref _fOV);
			set => SetProperty(ref _fOV, value);
		}
	}
}
