using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampQuaternion : animAnimNode_QuaternionValue
	{
		private CFloat _defaultRotationSpeed;
		private EulerAngles _defaultInitialValue;
		private animQuaternionLink _inputNode;
		private animQuaternionLink _initialValueNode;
		private animFloatLink _rotationSpeedNode;

		[Ordinal(11)] 
		[RED("defaultRotationSpeed")] 
		public CFloat DefaultRotationSpeed
		{
			get
			{
				if (_defaultRotationSpeed == null)
				{
					_defaultRotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "defaultRotationSpeed", cr2w, this);
				}
				return _defaultRotationSpeed;
			}
			set
			{
				if (_defaultRotationSpeed == value)
				{
					return;
				}
				_defaultRotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("defaultInitialValue")] 
		public EulerAngles DefaultInitialValue
		{
			get
			{
				if (_defaultInitialValue == null)
				{
					_defaultInitialValue = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "defaultInitialValue", cr2w, this);
				}
				return _defaultInitialValue;
			}
			set
			{
				if (_defaultInitialValue == value)
				{
					return;
				}
				_defaultInitialValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inputNode")] 
		public animQuaternionLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("initialValueNode")] 
		public animQuaternionLink InitialValueNode
		{
			get
			{
				if (_initialValueNode == null)
				{
					_initialValueNode = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "initialValueNode", cr2w, this);
				}
				return _initialValueNode;
			}
			set
			{
				if (_initialValueNode == value)
				{
					return;
				}
				_initialValueNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rotationSpeedNode")] 
		public animFloatLink RotationSpeedNode
		{
			get
			{
				if (_rotationSpeedNode == null)
				{
					_rotationSpeedNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "rotationSpeedNode", cr2w, this);
				}
				return _rotationSpeedNode;
			}
			set
			{
				if (_rotationSpeedNode == value)
				{
					return;
				}
				_rotationSpeedNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_DampQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
