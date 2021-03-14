using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatCumulative : animAnimNode_FloatValue
	{
		private CBool _clamp;
		private CBool _resetOnActivation;
		private CBool _normalize180;
		private CFloat _defaultValue;
		private CName _resetExternalEventName;
		private animFloatLink _inputNode;
		private animFloatLink _minValue;
		private animFloatLink _maxValue;
		private animFloatLink _resetSpeed;
		private animBoolLink _override;
		private animFloatLink _curValue;
		private animBoolLink _normalize180Input;

		[Ordinal(11)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get
			{
				if (_clamp == null)
				{
					_clamp = (CBool) CR2WTypeManager.Create("Bool", "clamp", cr2w, this);
				}
				return _clamp;
			}
			set
			{
				if (_clamp == value)
				{
					return;
				}
				_clamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get
			{
				if (_resetOnActivation == null)
				{
					_resetOnActivation = (CBool) CR2WTypeManager.Create("Bool", "resetOnActivation", cr2w, this);
				}
				return _resetOnActivation;
			}
			set
			{
				if (_resetOnActivation == value)
				{
					return;
				}
				_resetOnActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("normalize180")] 
		public CBool Normalize180
		{
			get
			{
				if (_normalize180 == null)
				{
					_normalize180 = (CBool) CR2WTypeManager.Create("Bool", "normalize180", cr2w, this);
				}
				return _normalize180;
			}
			set
			{
				if (_normalize180 == value)
				{
					return;
				}
				_normalize180 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CFloat) CR2WTypeManager.Create("Float", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("resetExternalEventName")] 
		public CName ResetExternalEventName
		{
			get
			{
				if (_resetExternalEventName == null)
				{
					_resetExternalEventName = (CName) CR2WTypeManager.Create("CName", "resetExternalEventName", cr2w, this);
				}
				return _resetExternalEventName;
			}
			set
			{
				if (_resetExternalEventName == value)
				{
					return;
				}
				_resetExternalEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "inputNode", cr2w, this);
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

		[Ordinal(17)] 
		[RED("minValue")] 
		public animFloatLink MinValue
		{
			get
			{
				if (_minValue == null)
				{
					_minValue = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "minValue", cr2w, this);
				}
				return _minValue;
			}
			set
			{
				if (_minValue == value)
				{
					return;
				}
				_minValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("maxValue")] 
		public animFloatLink MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("resetSpeed")] 
		public animFloatLink ResetSpeed
		{
			get
			{
				if (_resetSpeed == null)
				{
					_resetSpeed = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "resetSpeed", cr2w, this);
				}
				return _resetSpeed;
			}
			set
			{
				if (_resetSpeed == value)
				{
					return;
				}
				_resetSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("override")] 
		public animBoolLink Override
		{
			get
			{
				if (_override == null)
				{
					_override = (animBoolLink) CR2WTypeManager.Create("animBoolLink", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("curValue")] 
		public animFloatLink CurValue
		{
			get
			{
				if (_curValue == null)
				{
					_curValue = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "curValue", cr2w, this);
				}
				return _curValue;
			}
			set
			{
				if (_curValue == value)
				{
					return;
				}
				_curValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("normalize180Input")] 
		public animBoolLink Normalize180Input
		{
			get
			{
				if (_normalize180Input == null)
				{
					_normalize180Input = (animBoolLink) CR2WTypeManager.Create("animBoolLink", "normalize180Input", cr2w, this);
				}
				return _normalize180Input;
			}
			set
			{
				if (_normalize180Input == value)
				{
					return;
				}
				_normalize180Input = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatCumulative(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
