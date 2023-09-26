using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IntervalCaller : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("preventionSystem")] 
		public CWeakHandle<PreventionSystem> PreventionSystem
		{
			get => GetPropertyValue<CWeakHandle<PreventionSystem>>();
			set => SetPropertyValue<CWeakHandle<PreventionSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("request")] 
		public CHandle<gameScriptableSystemRequest> Request
		{
			get => GetPropertyValue<CHandle<gameScriptableSystemRequest>>();
			set => SetPropertyValue<CHandle<gameScriptableSystemRequest>>(value);
		}

		[Ordinal(2)] 
		[RED("intervalSeconds")] 
		public CFloat IntervalSeconds
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("selfDelayID")] 
		public gameDelayID SelfDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public IntervalCaller()
		{
			SelfDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
