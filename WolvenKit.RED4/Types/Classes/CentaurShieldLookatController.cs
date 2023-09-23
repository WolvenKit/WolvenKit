using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CentaurShieldLookatController : AILookatTask
	{
		[Ordinal(0)] 
		[RED("mainShieldLookat")] 
		public CHandle<entLookAtAddEvent> MainShieldLookat
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("mainShieldlookatActive")] 
		public CBool MainShieldlookatActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("currentLookatTarget")] 
		public CWeakHandle<gameObject> CurrentLookatTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("shieldTarget")] 
		public CWeakHandle<gameObject> ShieldTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("centaurBlackboard")] 
		public CWeakHandle<gameIBlackboard> CentaurBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(5)] 
		[RED("shieldTargetTimeStamp")] 
		public CFloat ShieldTargetTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CentaurShieldLookatController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
