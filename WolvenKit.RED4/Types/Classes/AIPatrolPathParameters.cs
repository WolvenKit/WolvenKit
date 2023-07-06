using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPatrolPathParameters : IScriptable
	{
		[Ordinal(0)] 
		[RED("path")] 
		public NodeRef Path
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(2)] 
		[RED("enterClosest")] 
		public CBool EnterClosest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isBackAndForth")] 
		public CBool IsBackAndForth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isInfinite")] 
		public CBool IsInfinite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("numberOfLoops")] 
		public CUInt32 NumberOfLoops
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("sortPatrolPoints")] 
		public CBool SortPatrolPoints
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("patrolAction")] 
		public TweakDBID PatrolAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AIPatrolPathParameters()
		{
			EnterClosest = true;
			IsInfinite = true;
			NumberOfLoops = 1;
			SortPatrolPoints = true;
			PatrolAction = "PatrolActions.DefaultPatrolAction";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
