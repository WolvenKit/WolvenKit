using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraParamsEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private CFloat _fovValue;
		private CFloat _fovWeigh;
		private CFloat _dofIntensity;
		private CFloat _dofNearBlur;
		private CFloat _dofNearFocus;
		private CFloat _dofFarBlur;
		private CFloat _dofFarFocus;
		private CBool _useNearPlane;
		private CBool _useFarPlane;
		private CBool _isPlayerCamera;
		private scneventsCameraOverrideSettings _cameraOverrideSettings;
		private scnPerformerId _targetActor;
		private CName _targetSlot;

		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get
			{
				if (_cameraRef == null)
				{
					_cameraRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "cameraRef", cr2w, this);
				}
				return _cameraRef;
			}
			set
			{
				if (_cameraRef == value)
				{
					return;
				}
				_cameraRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fovValue")] 
		public CFloat FovValue
		{
			get
			{
				if (_fovValue == null)
				{
					_fovValue = (CFloat) CR2WTypeManager.Create("Float", "fovValue", cr2w, this);
				}
				return _fovValue;
			}
			set
			{
				if (_fovValue == value)
				{
					return;
				}
				_fovValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fovWeigh")] 
		public CFloat FovWeigh
		{
			get
			{
				if (_fovWeigh == null)
				{
					_fovWeigh = (CFloat) CR2WTypeManager.Create("Float", "fovWeigh", cr2w, this);
				}
				return _fovWeigh;
			}
			set
			{
				if (_fovWeigh == value)
				{
					return;
				}
				_fovWeigh = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get
			{
				if (_dofIntensity == null)
				{
					_dofIntensity = (CFloat) CR2WTypeManager.Create("Float", "dofIntensity", cr2w, this);
				}
				return _dofIntensity;
			}
			set
			{
				if (_dofIntensity == value)
				{
					return;
				}
				_dofIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get
			{
				if (_dofNearBlur == null)
				{
					_dofNearBlur = (CFloat) CR2WTypeManager.Create("Float", "dofNearBlur", cr2w, this);
				}
				return _dofNearBlur;
			}
			set
			{
				if (_dofNearBlur == value)
				{
					return;
				}
				_dofNearBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get
			{
				if (_dofNearFocus == null)
				{
					_dofNearFocus = (CFloat) CR2WTypeManager.Create("Float", "dofNearFocus", cr2w, this);
				}
				return _dofNearFocus;
			}
			set
			{
				if (_dofNearFocus == value)
				{
					return;
				}
				_dofNearFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get
			{
				if (_dofFarBlur == null)
				{
					_dofFarBlur = (CFloat) CR2WTypeManager.Create("Float", "dofFarBlur", cr2w, this);
				}
				return _dofFarBlur;
			}
			set
			{
				if (_dofFarBlur == value)
				{
					return;
				}
				_dofFarBlur = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get
			{
				if (_dofFarFocus == null)
				{
					_dofFarFocus = (CFloat) CR2WTypeManager.Create("Float", "dofFarFocus", cr2w, this);
				}
				return _dofFarFocus;
			}
			set
			{
				if (_dofFarFocus == value)
				{
					return;
				}
				_dofFarFocus = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useNearPlane")] 
		public CBool UseNearPlane
		{
			get
			{
				if (_useNearPlane == null)
				{
					_useNearPlane = (CBool) CR2WTypeManager.Create("Bool", "useNearPlane", cr2w, this);
				}
				return _useNearPlane;
			}
			set
			{
				if (_useNearPlane == value)
				{
					return;
				}
				_useNearPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("useFarPlane")] 
		public CBool UseFarPlane
		{
			get
			{
				if (_useFarPlane == null)
				{
					_useFarPlane = (CBool) CR2WTypeManager.Create("Bool", "useFarPlane", cr2w, this);
				}
				return _useFarPlane;
			}
			set
			{
				if (_useFarPlane == value)
				{
					return;
				}
				_useFarPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isPlayerCamera")] 
		public CBool IsPlayerCamera
		{
			get
			{
				if (_isPlayerCamera == null)
				{
					_isPlayerCamera = (CBool) CR2WTypeManager.Create("Bool", "isPlayerCamera", cr2w, this);
				}
				return _isPlayerCamera;
			}
			set
			{
				if (_isPlayerCamera == value)
				{
					return;
				}
				_isPlayerCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("cameraOverrideSettings")] 
		public scneventsCameraOverrideSettings CameraOverrideSettings
		{
			get
			{
				if (_cameraOverrideSettings == null)
				{
					_cameraOverrideSettings = (scneventsCameraOverrideSettings) CR2WTypeManager.Create("scneventsCameraOverrideSettings", "cameraOverrideSettings", cr2w, this);
				}
				return _cameraOverrideSettings;
			}
			set
			{
				if (_cameraOverrideSettings == value)
				{
					return;
				}
				_cameraOverrideSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("targetActor")] 
		public scnPerformerId TargetActor
		{
			get
			{
				if (_targetActor == null)
				{
					_targetActor = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "targetActor", cr2w, this);
				}
				return _targetActor;
			}
			set
			{
				if (_targetActor == value)
				{
					return;
				}
				_targetActor = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get
			{
				if (_targetSlot == null)
				{
					_targetSlot = (CName) CR2WTypeManager.Create("CName", "targetSlot", cr2w, this);
				}
				return _targetSlot;
			}
			set
			{
				if (_targetSlot == value)
				{
					return;
				}
				_targetSlot = value;
				PropertySet(this);
			}
		}

		public scneventsCameraParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
