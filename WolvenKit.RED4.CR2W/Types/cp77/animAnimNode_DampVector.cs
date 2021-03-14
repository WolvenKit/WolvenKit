using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampVector : animAnimNode_VectorValue
	{
		private Vector4 _defaultIncreaseSpeed;
		private Vector4 _defaultDecreaseSpeed;
		private CBool _startFromDefaultValue;
		private Vector4 _defaultInitialValue;
		private animVectorLink _inputNode;
		private animVectorLink _increaseSpeedNode;
		private animVectorLink _decreaseSpeedNode;

		[Ordinal(11)] 
		[RED("defaultIncreaseSpeed")] 
		public Vector4 DefaultIncreaseSpeed
		{
			get
			{
				if (_defaultIncreaseSpeed == null)
				{
					_defaultIncreaseSpeed = (Vector4) CR2WTypeManager.Create("Vector4", "defaultIncreaseSpeed", cr2w, this);
				}
				return _defaultIncreaseSpeed;
			}
			set
			{
				if (_defaultIncreaseSpeed == value)
				{
					return;
				}
				_defaultIncreaseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("defaultDecreaseSpeed")] 
		public Vector4 DefaultDecreaseSpeed
		{
			get
			{
				if (_defaultDecreaseSpeed == null)
				{
					_defaultDecreaseSpeed = (Vector4) CR2WTypeManager.Create("Vector4", "defaultDecreaseSpeed", cr2w, this);
				}
				return _defaultDecreaseSpeed;
			}
			set
			{
				if (_defaultDecreaseSpeed == value)
				{
					return;
				}
				_defaultDecreaseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get
			{
				if (_startFromDefaultValue == null)
				{
					_startFromDefaultValue = (CBool) CR2WTypeManager.Create("Bool", "startFromDefaultValue", cr2w, this);
				}
				return _startFromDefaultValue;
			}
			set
			{
				if (_startFromDefaultValue == value)
				{
					return;
				}
				_startFromDefaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("defaultInitialValue")] 
		public Vector4 DefaultInitialValue
		{
			get
			{
				if (_defaultInitialValue == null)
				{
					_defaultInitialValue = (Vector4) CR2WTypeManager.Create("Vector4", "defaultInitialValue", cr2w, this);
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

		[Ordinal(15)] 
		[RED("inputNode")] 
		public animVectorLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "inputNode", cr2w, this);
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

		[Ordinal(16)] 
		[RED("increaseSpeedNode")] 
		public animVectorLink IncreaseSpeedNode
		{
			get
			{
				if (_increaseSpeedNode == null)
				{
					_increaseSpeedNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "increaseSpeedNode", cr2w, this);
				}
				return _increaseSpeedNode;
			}
			set
			{
				if (_increaseSpeedNode == value)
				{
					return;
				}
				_increaseSpeedNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("decreaseSpeedNode")] 
		public animVectorLink DecreaseSpeedNode
		{
			get
			{
				if (_decreaseSpeedNode == null)
				{
					_decreaseSpeedNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "decreaseSpeedNode", cr2w, this);
				}
				return _decreaseSpeedNode;
			}
			set
			{
				if (_decreaseSpeedNode == value)
				{
					return;
				}
				_decreaseSpeedNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_DampVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
