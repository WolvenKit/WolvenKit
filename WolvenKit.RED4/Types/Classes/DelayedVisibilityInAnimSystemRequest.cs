using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<ForcedVisibilityInAnimSystemData> Data
		{
			get => GetPropertyValue<CHandle<ForcedVisibilityInAnimSystemData>>();
			set => SetPropertyValue<CHandle<ForcedVisibilityInAnimSystemData>>(value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public DelayedVisibilityInAnimSystemRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
