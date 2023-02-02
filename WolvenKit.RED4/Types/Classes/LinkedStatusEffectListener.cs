using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LinkedStatusEffectListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("instigatorObject")] 
		public CWeakHandle<gameObject> InstigatorObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("linkedEffect")] 
		public TweakDBID LinkedEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("evt")] 
		public CHandle<RemoveLinkedStatusEffectsEvent> Evt
		{
			get => GetPropertyValue<CHandle<RemoveLinkedStatusEffectsEvent>>();
			set => SetPropertyValue<CHandle<RemoveLinkedStatusEffectsEvent>>(value);
		}

		public LinkedStatusEffectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
