using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetTopThreatToCombatTarget : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("refreshTimer")] 
		public CFloat RefreshTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("previousChecktime")] 
		public CFloat PreviousChecktime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("targetTrackerComponent")] 
		public CHandle<TargetTrackingExtension> TargetTrackerComponent
		{
			get => GetPropertyValue<CHandle<TargetTrackingExtension>>();
			set => SetPropertyValue<CHandle<TargetTrackingExtension>>(value);
		}

		[Ordinal(3)] 
		[RED("movePoliciesComponent")] 
		public CHandle<movePoliciesComponent> MovePoliciesComponent
		{
			get => GetPropertyValue<CHandle<movePoliciesComponent>>();
			set => SetPropertyValue<CHandle<movePoliciesComponent>>(value);
		}

		[Ordinal(4)] 
		[RED("targetChangeTime")] 
		public CFloat TargetChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SetTopThreatToCombatTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
