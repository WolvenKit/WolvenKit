using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporalPrereqDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<TemporalPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<TemporalPrereqState>>();
			set => SetPropertyValue<CWeakHandle<TemporalPrereqState>>(value);
		}
	}
}
