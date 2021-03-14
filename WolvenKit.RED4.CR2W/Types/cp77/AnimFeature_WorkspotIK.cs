using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WorkspotIK : animAnimFeature
	{
		private Vector4 _rightHandPosition;
		private Vector4 _leftHandPosition;
		private Vector4 _cameraPosition;
		private Quaternion _rightHandRotation;
		private Quaternion _leftHandRotation;
		private Quaternion _cameraRotation;
		private CBool _shouldCrouch;
		private CBool _isInteractingWithDevice;

		[Ordinal(0)] 
		[RED("rightHandPosition")] 
		public Vector4 RightHandPosition
		{
			get
			{
				if (_rightHandPosition == null)
				{
					_rightHandPosition = (Vector4) CR2WTypeManager.Create("Vector4", "rightHandPosition", cr2w, this);
				}
				return _rightHandPosition;
			}
			set
			{
				if (_rightHandPosition == value)
				{
					return;
				}
				_rightHandPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("leftHandPosition")] 
		public Vector4 LeftHandPosition
		{
			get
			{
				if (_leftHandPosition == null)
				{
					_leftHandPosition = (Vector4) CR2WTypeManager.Create("Vector4", "leftHandPosition", cr2w, this);
				}
				return _leftHandPosition;
			}
			set
			{
				if (_leftHandPosition == value)
				{
					return;
				}
				_leftHandPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cameraPosition")] 
		public Vector4 CameraPosition
		{
			get
			{
				if (_cameraPosition == null)
				{
					_cameraPosition = (Vector4) CR2WTypeManager.Create("Vector4", "cameraPosition", cr2w, this);
				}
				return _cameraPosition;
			}
			set
			{
				if (_cameraPosition == value)
				{
					return;
				}
				_cameraPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rightHandRotation")] 
		public Quaternion RightHandRotation
		{
			get
			{
				if (_rightHandRotation == null)
				{
					_rightHandRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rightHandRotation", cr2w, this);
				}
				return _rightHandRotation;
			}
			set
			{
				if (_rightHandRotation == value)
				{
					return;
				}
				_rightHandRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("leftHandRotation")] 
		public Quaternion LeftHandRotation
		{
			get
			{
				if (_leftHandRotation == null)
				{
					_leftHandRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "leftHandRotation", cr2w, this);
				}
				return _leftHandRotation;
			}
			set
			{
				if (_leftHandRotation == value)
				{
					return;
				}
				_leftHandRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cameraRotation")] 
		public Quaternion CameraRotation
		{
			get
			{
				if (_cameraRotation == null)
				{
					_cameraRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "cameraRotation", cr2w, this);
				}
				return _cameraRotation;
			}
			set
			{
				if (_cameraRotation == value)
				{
					return;
				}
				_cameraRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("shouldCrouch")] 
		public CBool ShouldCrouch
		{
			get
			{
				if (_shouldCrouch == null)
				{
					_shouldCrouch = (CBool) CR2WTypeManager.Create("Bool", "shouldCrouch", cr2w, this);
				}
				return _shouldCrouch;
			}
			set
			{
				if (_shouldCrouch == value)
				{
					return;
				}
				_shouldCrouch = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isInteractingWithDevice")] 
		public CBool IsInteractingWithDevice
		{
			get
			{
				if (_isInteractingWithDevice == null)
				{
					_isInteractingWithDevice = (CBool) CR2WTypeManager.Create("Bool", "isInteractingWithDevice", cr2w, this);
				}
				return _isInteractingWithDevice;
			}
			set
			{
				if (_isInteractingWithDevice == value)
				{
					return;
				}
				_isInteractingWithDevice = value;
				PropertySet(this);
			}
		}

		public AnimFeature_WorkspotIK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
