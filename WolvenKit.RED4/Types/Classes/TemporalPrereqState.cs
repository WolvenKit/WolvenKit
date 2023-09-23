using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TemporalPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("delaySystem")] 
		public CHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CHandle<gameDelaySystem>>();
			set => SetPropertyValue<CHandle<gameDelaySystem>>(value);
		}

		[Ordinal(1)] 
		[RED("callback")] 
		public CHandle<TemporalPrereqDelayCallback> Callback
		{
			get => GetPropertyValue<CHandle<TemporalPrereqDelayCallback>>();
			set => SetPropertyValue<CHandle<TemporalPrereqDelayCallback>>(value);
		}

		[Ordinal(2)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public TemporalPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
