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
			get
			{
				if (_enableLookAt == null)
				{
					_enableLookAt = (CInt32) CR2WTypeManager.Create("Int32", "enableLookAt", cr2w, this);
				}
				return _enableLookAt;
			}
			set
			{
				if (_enableLookAt == value)
				{
					return;
				}
				_enableLookAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enableLookAtChest")] 
		public CInt32 EnableLookAtChest
		{
			get
			{
				if (_enableLookAtChest == null)
				{
					_enableLookAtChest = (CInt32) CR2WTypeManager.Create("Int32", "enableLookAtChest", cr2w, this);
				}
				return _enableLookAtChest;
			}
			set
			{
				if (_enableLookAtChest == value)
				{
					return;
				}
				_enableLookAtChest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enableLookAtHead")] 
		public CInt32 EnableLookAtHead
		{
			get
			{
				if (_enableLookAtHead == null)
				{
					_enableLookAtHead = (CInt32) CR2WTypeManager.Create("Int32", "enableLookAtHead", cr2w, this);
				}
				return _enableLookAtHead;
			}
			set
			{
				if (_enableLookAtHead == value)
				{
					return;
				}
				_enableLookAtHead = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enableLookAtLeftHanded")] 
		public CInt32 EnableLookAtLeftHanded
		{
			get
			{
				if (_enableLookAtLeftHanded == null)
				{
					_enableLookAtLeftHanded = (CInt32) CR2WTypeManager.Create("Int32", "enableLookAtLeftHanded", cr2w, this);
				}
				return _enableLookAtLeftHanded;
			}
			set
			{
				if (_enableLookAtLeftHanded == value)
				{
					return;
				}
				_enableLookAtLeftHanded = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("enableLookAtRightHanded")] 
		public CInt32 EnableLookAtRightHanded
		{
			get
			{
				if (_enableLookAtRightHanded == null)
				{
					_enableLookAtRightHanded = (CInt32) CR2WTypeManager.Create("Int32", "enableLookAtRightHanded", cr2w, this);
				}
				return _enableLookAtRightHanded;
			}
			set
			{
				if (_enableLookAtRightHanded == value)
				{
					return;
				}
				_enableLookAtRightHanded = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("enableLookAtTwoHanded")] 
		public CInt32 EnableLookAtTwoHanded
		{
			get
			{
				if (_enableLookAtTwoHanded == null)
				{
					_enableLookAtTwoHanded = (CInt32) CR2WTypeManager.Create("Int32", "enableLookAtTwoHanded", cr2w, this);
				}
				return _enableLookAtTwoHanded;
			}
			set
			{
				if (_enableLookAtTwoHanded == value)
				{
					return;
				}
				_enableLookAtTwoHanded = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gpLookAtTargetBlend")] 
		public CFloat GpLookAtTargetBlend
		{
			get
			{
				if (_gpLookAtTargetBlend == null)
				{
					_gpLookAtTargetBlend = (CFloat) CR2WTypeManager.Create("Float", "gpLookAtTargetBlend", cr2w, this);
				}
				return _gpLookAtTargetBlend;
			}
			set
			{
				if (_gpLookAtTargetBlend == value)
				{
					return;
				}
				_gpLookAtTargetBlend = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gpLookAtUpBlend")] 
		public CFloat GpLookAtUpBlend
		{
			get
			{
				if (_gpLookAtUpBlend == null)
				{
					_gpLookAtUpBlend = (CFloat) CR2WTypeManager.Create("Float", "gpLookAtUpBlend", cr2w, this);
				}
				return _gpLookAtUpBlend;
			}
			set
			{
				if (_gpLookAtUpBlend == value)
				{
					return;
				}
				_gpLookAtUpBlend = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gpLookAtTarget")] 
		public Vector4 GpLookAtTarget
		{
			get
			{
				if (_gpLookAtTarget == null)
				{
					_gpLookAtTarget = (Vector4) CR2WTypeManager.Create("Vector4", "gpLookAtTarget", cr2w, this);
				}
				return _gpLookAtTarget;
			}
			set
			{
				if (_gpLookAtTarget == value)
				{
					return;
				}
				_gpLookAtTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gpLookAtUp")] 
		public Vector4 GpLookAtUp
		{
			get
			{
				if (_gpLookAtUp == null)
				{
					_gpLookAtUp = (Vector4) CR2WTypeManager.Create("Vector4", "gpLookAtUp", cr2w, this);
				}
				return _gpLookAtUp;
			}
			set
			{
				if (_gpLookAtUp == value)
				{
					return;
				}
				_gpLookAtUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lookAtChestMode")] 
		public CInt32 LookAtChestMode
		{
			get
			{
				if (_lookAtChestMode == null)
				{
					_lookAtChestMode = (CInt32) CR2WTypeManager.Create("Int32", "lookAtChestMode", cr2w, this);
				}
				return _lookAtChestMode;
			}
			set
			{
				if (_lookAtChestMode == value)
				{
					return;
				}
				_lookAtChestMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lookAtChestOverride")] 
		public CFloat LookAtChestOverride
		{
			get
			{
				if (_lookAtChestOverride == null)
				{
					_lookAtChestOverride = (CFloat) CR2WTypeManager.Create("Float", "lookAtChestOverride", cr2w, this);
				}
				return _lookAtChestOverride;
			}
			set
			{
				if (_lookAtChestOverride == value)
				{
					return;
				}
				_lookAtChestOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lookAtHeadMode")] 
		public CInt32 LookAtHeadMode
		{
			get
			{
				if (_lookAtHeadMode == null)
				{
					_lookAtHeadMode = (CInt32) CR2WTypeManager.Create("Int32", "lookAtHeadMode", cr2w, this);
				}
				return _lookAtHeadMode;
			}
			set
			{
				if (_lookAtHeadMode == value)
				{
					return;
				}
				_lookAtHeadMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("lookAtHeadOverride")] 
		public CFloat LookAtHeadOverride
		{
			get
			{
				if (_lookAtHeadOverride == null)
				{
					_lookAtHeadOverride = (CFloat) CR2WTypeManager.Create("Float", "lookAtHeadOverride", cr2w, this);
				}
				return _lookAtHeadOverride;
			}
			set
			{
				if (_lookAtHeadOverride == value)
				{
					return;
				}
				_lookAtHeadOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lookAtLeftHandedMode")] 
		public CInt32 LookAtLeftHandedMode
		{
			get
			{
				if (_lookAtLeftHandedMode == null)
				{
					_lookAtLeftHandedMode = (CInt32) CR2WTypeManager.Create("Int32", "lookAtLeftHandedMode", cr2w, this);
				}
				return _lookAtLeftHandedMode;
			}
			set
			{
				if (_lookAtLeftHandedMode == value)
				{
					return;
				}
				_lookAtLeftHandedMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lookAtLeftHandedOverride")] 
		public CFloat LookAtLeftHandedOverride
		{
			get
			{
				if (_lookAtLeftHandedOverride == null)
				{
					_lookAtLeftHandedOverride = (CFloat) CR2WTypeManager.Create("Float", "lookAtLeftHandedOverride", cr2w, this);
				}
				return _lookAtLeftHandedOverride;
			}
			set
			{
				if (_lookAtLeftHandedOverride == value)
				{
					return;
				}
				_lookAtLeftHandedOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lookAtRightHandedMode")] 
		public CInt32 LookAtRightHandedMode
		{
			get
			{
				if (_lookAtRightHandedMode == null)
				{
					_lookAtRightHandedMode = (CInt32) CR2WTypeManager.Create("Int32", "lookAtRightHandedMode", cr2w, this);
				}
				return _lookAtRightHandedMode;
			}
			set
			{
				if (_lookAtRightHandedMode == value)
				{
					return;
				}
				_lookAtRightHandedMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lookAtRightHandedOverride")] 
		public CFloat LookAtRightHandedOverride
		{
			get
			{
				if (_lookAtRightHandedOverride == null)
				{
					_lookAtRightHandedOverride = (CFloat) CR2WTypeManager.Create("Float", "lookAtRightHandedOverride", cr2w, this);
				}
				return _lookAtRightHandedOverride;
			}
			set
			{
				if (_lookAtRightHandedOverride == value)
				{
					return;
				}
				_lookAtRightHandedOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("lookAtTwoHandedMode")] 
		public CInt32 LookAtTwoHandedMode
		{
			get
			{
				if (_lookAtTwoHandedMode == null)
				{
					_lookAtTwoHandedMode = (CInt32) CR2WTypeManager.Create("Int32", "lookAtTwoHandedMode", cr2w, this);
				}
				return _lookAtTwoHandedMode;
			}
			set
			{
				if (_lookAtTwoHandedMode == value)
				{
					return;
				}
				_lookAtTwoHandedMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lookAtTwoHandedOverride")] 
		public CFloat LookAtTwoHandedOverride
		{
			get
			{
				if (_lookAtTwoHandedOverride == null)
				{
					_lookAtTwoHandedOverride = (CFloat) CR2WTypeManager.Create("Float", "lookAtTwoHandedOverride", cr2w, this);
				}
				return _lookAtTwoHandedOverride;
			}
			set
			{
				if (_lookAtTwoHandedOverride == value)
				{
					return;
				}
				_lookAtTwoHandedOverride = value;
				PropertySet(this);
			}
		}

		public AnimFeature_LookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
