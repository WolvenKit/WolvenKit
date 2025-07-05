using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckThreat : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("targetObjectMapping")] 
		public CHandle<AIArgumentMapping> TargetObjectMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("targetThreat")] 
		public CWeakHandle<gameObject> TargetThreat
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CheckThreat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
