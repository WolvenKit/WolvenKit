using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StealthStimThreshold : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("stealthThresholdNumber")] 
		public CInt32 StealthThresholdNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
