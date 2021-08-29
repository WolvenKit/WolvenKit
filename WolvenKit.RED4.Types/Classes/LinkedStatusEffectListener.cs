using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LinkedStatusEffectListener : gameScriptStatusEffectListener
	{
		private CWeakHandle<gameObject> _instigatorObject;
		private TweakDBID _linkedEffect;
		private CHandle<RemoveLinkedStatusEffectsEvent> _evt;

		[Ordinal(0)] 
		[RED("instigatorObject")] 
		public CWeakHandle<gameObject> InstigatorObject
		{
			get => GetProperty(ref _instigatorObject);
			set => SetProperty(ref _instigatorObject, value);
		}

		[Ordinal(1)] 
		[RED("linkedEffect")] 
		public TweakDBID LinkedEffect
		{
			get => GetProperty(ref _linkedEffect);
			set => SetProperty(ref _linkedEffect, value);
		}

		[Ordinal(2)] 
		[RED("evt")] 
		public CHandle<RemoveLinkedStatusEffectsEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}
	}
}
