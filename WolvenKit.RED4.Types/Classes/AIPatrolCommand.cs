using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIPatrolCommand : AIMoveCommand
	{
		private CHandle<AIPatrolPathParameters> _pathParams;
		private CHandle<AIPatrolPathParameters> _alertedPathParams;
		private CFloat _alertedRadius;
		private CArray<NodeRef> _alertedSpots;
		private CBool _patrolWithWeapon;
		private TweakDBID _patrolAction;

		[Ordinal(7)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get => GetProperty(ref _pathParams);
			set => SetProperty(ref _pathParams, value);
		}

		[Ordinal(8)] 
		[RED("alertedPathParams")] 
		public CHandle<AIPatrolPathParameters> AlertedPathParams
		{
			get => GetProperty(ref _alertedPathParams);
			set => SetProperty(ref _alertedPathParams, value);
		}

		[Ordinal(9)] 
		[RED("alertedRadius")] 
		public CFloat AlertedRadius
		{
			get => GetProperty(ref _alertedRadius);
			set => SetProperty(ref _alertedRadius, value);
		}

		[Ordinal(10)] 
		[RED("alertedSpots")] 
		public CArray<NodeRef> AlertedSpots
		{
			get => GetProperty(ref _alertedSpots);
			set => SetProperty(ref _alertedSpots, value);
		}

		[Ordinal(11)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetProperty(ref _patrolWithWeapon);
			set => SetProperty(ref _patrolWithWeapon, value);
		}

		[Ordinal(12)] 
		[RED("patrolAction")] 
		public TweakDBID PatrolAction
		{
			get => GetProperty(ref _patrolAction);
			set => SetProperty(ref _patrolAction, value);
		}
	}
}
