using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetAssessmentRequest : ScriptableDeviceAction
	{
		[Ordinal(38)] 
		[RED("targetToAssess")] 
		public CWeakHandle<gameObject> TargetToAssess
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TargetAssessmentRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
