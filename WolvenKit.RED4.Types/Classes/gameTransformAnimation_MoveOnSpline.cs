using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_MoveOnSpline : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] 
		[RED("splineNode")] 
		public NodeRef SplineNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("to")] 
		public CFloat To
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("rotationMode")] 
		public CEnum<gameTransformAnimation_MoveOnSplineRotationMode> RotationMode
		{
			get => GetPropertyValue<CEnum<gameTransformAnimation_MoveOnSplineRotationMode>>();
			set => SetPropertyValue<CEnum<gameTransformAnimation_MoveOnSplineRotationMode>>(value);
		}

		[Ordinal(4)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Movement>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Movement>>(value);
		}

		public gameTransformAnimation_MoveOnSpline()
		{
			RotationMode = Enums.gameTransformAnimation_MoveOnSplineRotationMode.Yaw;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
