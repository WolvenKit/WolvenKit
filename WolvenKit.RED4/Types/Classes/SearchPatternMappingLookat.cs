using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SearchPatternMappingLookat : AISearchingLookat
	{
		[Ordinal(14)] 
		[RED("targetObjectMapping")] 
		public CHandle<AIArgumentMapping> TargetObjectMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(15)] 
		[RED("lookatTargetObject")] 
		public CWeakHandle<gameObject> LookatTargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SearchPatternMappingLookat()
		{
			LookatTarget = new();
			CurrentLookatTarget = new();
			CurrentTarget = new();
			LastTarget = new();
			SideHorizontal = 1;
			SideVertical = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
