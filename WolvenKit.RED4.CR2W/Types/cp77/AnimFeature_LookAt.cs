using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LookAt : animAnimFeature
	{
		private CInt32 _enableLookAt;
		private CInt32 _enableLookAtChest;
		private CInt32 _enableLookAtHead;
		private CInt32 _enableLookAtLeftHanded;
		private CInt32 _enableLookAtRightHanded;
		private CInt32 _enableLookAtTwoHanded;
		private CFloat _gpLookAtTargetBlend;
		private CFloat _gpLookAtUpBlend;
		private Vector4 _gpLookAtTarget;
		private Vector4 _gpLookAtUp;
		private CInt32 _lookAtChestMode;
		private CFloat _lookAtChestOverride;
		private CInt32 _lookAtHeadMode;
		private CFloat _lookAtHeadOverride;
		private CInt32 _lookAtLeftHandedMode;
		private CFloat _lookAtLeftHandedOverride;
		private CInt32 _lookAtRightHandedMode;
		private CFloat _lookAtRightHandedOverride;
		private CInt32 _lookAtTwoHandedMode;
		private CFloat _lookAtTwoHandedOverride;

		[Ordinal(0)] 
		[RED("enableLookAt")] 
		public CInt32 EnableLookAt
		{
			get => GetProperty(ref _enableLookAt);
			set => SetProperty(ref _enableLookAt, value);
		}

		[Ordinal(1)] 
		[RED("enableLookAtChest")] 
		public CInt32 EnableLookAtChest
		{
			get => GetProperty(ref _enableLookAtChest);
			set => SetProperty(ref _enableLookAtChest, value);
		}

		[Ordinal(2)] 
		[RED("enableLookAtHead")] 
		public CInt32 EnableLookAtHead
		{
			get => GetProperty(ref _enableLookAtHead);
			set => SetProperty(ref _enableLookAtHead, value);
		}

		[Ordinal(3)] 
		[RED("enableLookAtLeftHanded")] 
		public CInt32 EnableLookAtLeftHanded
		{
			get => GetProperty(ref _enableLookAtLeftHanded);
			set => SetProperty(ref _enableLookAtLeftHanded, value);
		}

		[Ordinal(4)] 
		[RED("enableLookAtRightHanded")] 
		public CInt32 EnableLookAtRightHanded
		{
			get => GetProperty(ref _enableLookAtRightHanded);
			set => SetProperty(ref _enableLookAtRightHanded, value);
		}

		[Ordinal(5)] 
		[RED("enableLookAtTwoHanded")] 
		public CInt32 EnableLookAtTwoHanded
		{
			get => GetProperty(ref _enableLookAtTwoHanded);
			set => SetProperty(ref _enableLookAtTwoHanded, value);
		}

		[Ordinal(6)] 
		[RED("gpLookAtTargetBlend")] 
		public CFloat GpLookAtTargetBlend
		{
			get => GetProperty(ref _gpLookAtTargetBlend);
			set => SetProperty(ref _gpLookAtTargetBlend, value);
		}

		[Ordinal(7)] 
		[RED("gpLookAtUpBlend")] 
		public CFloat GpLookAtUpBlend
		{
			get => GetProperty(ref _gpLookAtUpBlend);
			set => SetProperty(ref _gpLookAtUpBlend, value);
		}

		[Ordinal(8)] 
		[RED("gpLookAtTarget")] 
		public Vector4 GpLookAtTarget
		{
			get => GetProperty(ref _gpLookAtTarget);
			set => SetProperty(ref _gpLookAtTarget, value);
		}

		[Ordinal(9)] 
		[RED("gpLookAtUp")] 
		public Vector4 GpLookAtUp
		{
			get => GetProperty(ref _gpLookAtUp);
			set => SetProperty(ref _gpLookAtUp, value);
		}

		[Ordinal(10)] 
		[RED("lookAtChestMode")] 
		public CInt32 LookAtChestMode
		{
			get => GetProperty(ref _lookAtChestMode);
			set => SetProperty(ref _lookAtChestMode, value);
		}

		[Ordinal(11)] 
		[RED("lookAtChestOverride")] 
		public CFloat LookAtChestOverride
		{
			get => GetProperty(ref _lookAtChestOverride);
			set => SetProperty(ref _lookAtChestOverride, value);
		}

		[Ordinal(12)] 
		[RED("lookAtHeadMode")] 
		public CInt32 LookAtHeadMode
		{
			get => GetProperty(ref _lookAtHeadMode);
			set => SetProperty(ref _lookAtHeadMode, value);
		}

		[Ordinal(13)] 
		[RED("lookAtHeadOverride")] 
		public CFloat LookAtHeadOverride
		{
			get => GetProperty(ref _lookAtHeadOverride);
			set => SetProperty(ref _lookAtHeadOverride, value);
		}

		[Ordinal(14)] 
		[RED("lookAtLeftHandedMode")] 
		public CInt32 LookAtLeftHandedMode
		{
			get => GetProperty(ref _lookAtLeftHandedMode);
			set => SetProperty(ref _lookAtLeftHandedMode, value);
		}

		[Ordinal(15)] 
		[RED("lookAtLeftHandedOverride")] 
		public CFloat LookAtLeftHandedOverride
		{
			get => GetProperty(ref _lookAtLeftHandedOverride);
			set => SetProperty(ref _lookAtLeftHandedOverride, value);
		}

		[Ordinal(16)] 
		[RED("lookAtRightHandedMode")] 
		public CInt32 LookAtRightHandedMode
		{
			get => GetProperty(ref _lookAtRightHandedMode);
			set => SetProperty(ref _lookAtRightHandedMode, value);
		}

		[Ordinal(17)] 
		[RED("lookAtRightHandedOverride")] 
		public CFloat LookAtRightHandedOverride
		{
			get => GetProperty(ref _lookAtRightHandedOverride);
			set => SetProperty(ref _lookAtRightHandedOverride, value);
		}

		[Ordinal(18)] 
		[RED("lookAtTwoHandedMode")] 
		public CInt32 LookAtTwoHandedMode
		{
			get => GetProperty(ref _lookAtTwoHandedMode);
			set => SetProperty(ref _lookAtTwoHandedMode, value);
		}

		[Ordinal(19)] 
		[RED("lookAtTwoHandedOverride")] 
		public CFloat LookAtTwoHandedOverride
		{
			get => GetProperty(ref _lookAtTwoHandedOverride);
			set => SetProperty(ref _lookAtTwoHandedOverride, value);
		}

		public AnimFeature_LookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
