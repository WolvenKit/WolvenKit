using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CoopIrritationDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("companion")] 
		public CWeakHandle<gameObject> Companion
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CoopIrritationDelayCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
