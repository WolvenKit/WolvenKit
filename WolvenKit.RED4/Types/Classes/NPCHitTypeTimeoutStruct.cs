using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCHitTypeTimeoutStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public NPCHitTypeTimeoutStruct()
		{
			DelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
