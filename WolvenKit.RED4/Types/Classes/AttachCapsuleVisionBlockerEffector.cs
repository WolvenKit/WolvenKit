using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttachCapsuleVisionBlockerEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("visionBlockerRegistrar")] 
		public CHandle<senseVisionBlockersRegistrar> VisionBlockerRegistrar
		{
			get => GetPropertyValue<CHandle<senseVisionBlockersRegistrar>>();
			set => SetPropertyValue<CHandle<senseVisionBlockersRegistrar>>(value);
		}

		[Ordinal(1)] 
		[RED("visionBlockerType")] 
		public CEnum<EVisionBlockerType> VisionBlockerType
		{
			get => GetPropertyValue<CEnum<EVisionBlockerType>>();
			set => SetPropertyValue<CEnum<EVisionBlockerType>>(value);
		}

		[Ordinal(2)] 
		[RED("visionBlockerId")] 
		public CUInt32 VisionBlockerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("visionBlockerOffset")] 
		public Vector3 VisionBlockerOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("visionBlockerRadius")] 
		public CFloat VisionBlockerRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("visionBlockerHeight")] 
		public CFloat VisionBlockerHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("visionBlockerDetectionModifier")] 
		public CFloat VisionBlockerDetectionModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("visionBlockerTBHModifier")] 
		public CFloat VisionBlockerTBHModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("isBlockingCompletely")] 
		public CBool IsBlockingCompletely
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("blocksParent")] 
		public CBool BlocksParent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AttachCapsuleVisionBlockerEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
