using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StealthStimThreshold : AIbehaviorconditionScript
	{
		private CInt32 _stealthThresholdNumber;

		[Ordinal(0)] 
		[RED("stealthThresholdNumber")] 
		public CInt32 StealthThresholdNumber
		{
			get => GetProperty(ref _stealthThresholdNumber);
			set => SetProperty(ref _stealthThresholdNumber, value);
		}
	}
}
