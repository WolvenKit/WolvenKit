using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class previewTargetStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentlyTrackedTarget")] 
		public CWeakHandle<gameObject> CurrentlyTrackedTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("currentBodyPart")] 
		public CEnum<EHitReactionZone> CurrentBodyPart
		{
			get => GetPropertyValue<CEnum<EHitReactionZone>>();
			set => SetPropertyValue<CEnum<EHitReactionZone>>(value);
		}

		public previewTargetStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
