using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_LookAt : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("enableLookAt")] 
		public CInt32 EnableLookAt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("enableLookAtChest")] 
		public CInt32 EnableLookAtChest
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("enableLookAtHead")] 
		public CInt32 EnableLookAtHead
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("enableLookAtLeftHanded")] 
		public CInt32 EnableLookAtLeftHanded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("enableLookAtRightHanded")] 
		public CInt32 EnableLookAtRightHanded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("enableLookAtTwoHanded")] 
		public CInt32 EnableLookAtTwoHanded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("gpLookAtTargetBlend")] 
		public CFloat GpLookAtTargetBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("gpLookAtUpBlend")] 
		public CFloat GpLookAtUpBlend
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("gpLookAtTarget")] 
		public Vector4 GpLookAtTarget
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("gpLookAtUp")] 
		public Vector4 GpLookAtUp
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(10)] 
		[RED("lookAtChestMode")] 
		public CInt32 LookAtChestMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("lookAtChestOverride")] 
		public CFloat LookAtChestOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("lookAtHeadMode")] 
		public CInt32 LookAtHeadMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("lookAtHeadOverride")] 
		public CFloat LookAtHeadOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("lookAtLeftHandedMode")] 
		public CInt32 LookAtLeftHandedMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("lookAtLeftHandedOverride")] 
		public CFloat LookAtLeftHandedOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("lookAtRightHandedMode")] 
		public CInt32 LookAtRightHandedMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("lookAtRightHandedOverride")] 
		public CFloat LookAtRightHandedOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("lookAtTwoHandedMode")] 
		public CInt32 LookAtTwoHandedMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("lookAtTwoHandedOverride")] 
		public CFloat LookAtTwoHandedOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_LookAt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
