using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetTier3Params_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("yawLeftLimit")] 
		public CFloat YawLeftLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("yawRightLimit")] 
		public CFloat YawRightLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("pitchUpLimit")] 
		public CFloat PitchUpLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("pitchDownLimit")] 
		public CFloat PitchDownLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("yawSpeedMultiplier")] 
		public CFloat YawSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("pitchSpeedMultiplier")] 
		public CFloat PitchSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("offsetPos")] 
		public Vector3 OffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("rotationTime")] 
		public CFloat RotationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("rotateHeadOnly")] 
		public CBool RotateHeadOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetTier3Params_NodeType()
		{
			YawLeftLimit = 30.000000F;
			YawRightLimit = 30.000000F;
			PitchUpLimit = 30.000000F;
			PitchDownLimit = 30.000000F;
			YawSpeedMultiplier = 1.000000F;
			PitchSpeedMultiplier = 1.000000F;
			ObjectRef = new gameEntityReference { Names = new() };
			OffsetPos = new Vector3();
			RotationTime = 0.500000F;
			UsePlayerWorkspot = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
