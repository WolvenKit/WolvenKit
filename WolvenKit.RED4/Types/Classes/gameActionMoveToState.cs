using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionMoveToState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("rotateEntity")] 
		public CBool RotateEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("moveStyle")] 
		public CUInt32 MoveStyle
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameActionMoveToState()
		{
			TargetPos = new Vector3 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
