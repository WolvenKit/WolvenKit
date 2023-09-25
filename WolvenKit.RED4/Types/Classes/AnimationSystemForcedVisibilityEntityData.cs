using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimationSystemForcedVisibilityEntityData : IScriptable
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<AnimationSystemForcedVisibilityManager> Owner
		{
			get => GetPropertyValue<CWeakHandle<AnimationSystemForcedVisibilityManager>>();
			set => SetPropertyValue<CWeakHandle<AnimationSystemForcedVisibilityManager>>(value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("forcedVisibilityInAnimSystemRequests")] 
		public CArray<CHandle<ForcedVisibilityInAnimSystemData>> ForcedVisibilityInAnimSystemRequests
		{
			get => GetPropertyValue<CArray<CHandle<ForcedVisibilityInAnimSystemData>>>();
			set => SetPropertyValue<CArray<CHandle<ForcedVisibilityInAnimSystemData>>>(value);
		}

		[Ordinal(3)] 
		[RED("delayedForcedVisibilityInAnimSystemRequests")] 
		public CArray<CHandle<ForcedVisibilityInAnimSystemData>> DelayedForcedVisibilityInAnimSystemRequests
		{
			get => GetPropertyValue<CArray<CHandle<ForcedVisibilityInAnimSystemData>>>();
			set => SetPropertyValue<CArray<CHandle<ForcedVisibilityInAnimSystemData>>>(value);
		}

		[Ordinal(4)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hasVisibilityForcedOnlyInFrustumInAnimSystem")] 
		public CBool HasVisibilityForcedOnlyInFrustumInAnimSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimationSystemForcedVisibilityEntityData()
		{
			EntityID = new entEntityID();
			ForcedVisibilityInAnimSystemRequests = new();
			DelayedForcedVisibilityInAnimSystemRequests = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
