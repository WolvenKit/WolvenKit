using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPatrolCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get => GetPropertyValue<CHandle<AIPatrolPathParameters>>();
			set => SetPropertyValue<CHandle<AIPatrolPathParameters>>(value);
		}

		[Ordinal(8)] 
		[RED("alertedPathParams")] 
		public CHandle<AIPatrolPathParameters> AlertedPathParams
		{
			get => GetPropertyValue<CHandle<AIPatrolPathParameters>>();
			set => SetPropertyValue<CHandle<AIPatrolPathParameters>>(value);
		}

		[Ordinal(9)] 
		[RED("alertedRadius")] 
		public CFloat AlertedRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("alertedSpots")] 
		public CArray<NodeRef> AlertedSpots
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(11)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("patrolAction")] 
		public TweakDBID PatrolAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AIPatrolCommand()
		{
			AlertedSpots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
