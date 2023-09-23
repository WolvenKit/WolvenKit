using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<ModifyStatusEffectDurationEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<ModifyStatusEffectDurationEffector>>();
			set => SetPropertyValue<CWeakHandle<ModifyStatusEffectDurationEffector>>(value);
		}

		[Ordinal(1)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public OnStatusEffectAppliedListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
