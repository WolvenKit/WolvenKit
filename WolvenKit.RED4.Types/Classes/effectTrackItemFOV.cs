using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemFOV : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("FOV")] 
		public effectEffectParameterEvaluatorFloat FOV
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		public effectTrackItemFOV()
		{
			TimeDuration = 1.000000F;
			FOV = new();
		}
	}
}
