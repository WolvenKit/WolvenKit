using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetMortalPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CWeakHandle<PuppetMortalityListener> Listener
		{
			get => GetPropertyValue<CWeakHandle<PuppetMortalityListener>>();
			set => SetPropertyValue<CWeakHandle<PuppetMortalityListener>>(value);
		}

		public PuppetMortalPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
