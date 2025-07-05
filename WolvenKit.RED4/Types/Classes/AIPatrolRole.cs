using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPatrolRole : AIRole
	{
		[Ordinal(0)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get => GetPropertyValue<CHandle<AIPatrolPathParameters>>();
			set => SetPropertyValue<CHandle<AIPatrolPathParameters>>(value);
		}

		[Ordinal(1)] 
		[RED("alertedPathParams")] 
		public CHandle<AIPatrolPathParameters> AlertedPathParams
		{
			get => GetPropertyValue<CHandle<AIPatrolPathParameters>>();
			set => SetPropertyValue<CHandle<AIPatrolPathParameters>>(value);
		}

		[Ordinal(2)] 
		[RED("alertedRadius")] 
		public CFloat AlertedRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("alertedSpots")] 
		public CHandle<AIbehaviorWorkspotList> AlertedSpots
		{
			get => GetPropertyValue<CHandle<AIbehaviorWorkspotList>>();
			set => SetPropertyValue<CHandle<AIbehaviorWorkspotList>>(value);
		}

		[Ordinal(4)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIPatrolRole()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
