using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionLookatParams : CVariable
	{
		private CBool _useLookat;
		private CBool _useLeftHand;
		private CBool _useRightHand;
		private CBool _attachRightHandtoLeftHand;
		private CBool _attachLeftHandtoRightHand;
		private CName _slotName;
		private CEnum<animLookAtStyle> _lookatStyle;
		private CBool _hasOutTransition;
		private CEnum<animLookAtStyle> _outTransitionStyle;
		private CEnum<animLookAtLimitDegreesType> _softLimitDegrees;
		private CEnum<animLookAtLimitDegreesType> _hardLimitDegrees;
		private CEnum<animLookAtLimitDistanceType> _hardLimitDistance;
		private CEnum<animLookAtLimitDegreesType> _backLimitDegrees;
		private CArray<animLookAtPartRequest> _additionalParts;

		[Ordinal(0)] 
		[RED("useLookat")] 
		public CBool UseLookat
		{
			get
			{
				if (_useLookat == null)
				{
					_useLookat = (CBool) CR2WTypeManager.Create("Bool", "useLookat", cr2w, this);
				}
				return _useLookat;
			}
			set
			{
				if (_useLookat == value)
				{
					return;
				}
				_useLookat = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useLeftHand")] 
		public CBool UseLeftHand
		{
			get
			{
				if (_useLeftHand == null)
				{
					_useLeftHand = (CBool) CR2WTypeManager.Create("Bool", "useLeftHand", cr2w, this);
				}
				return _useLeftHand;
			}
			set
			{
				if (_useLeftHand == value)
				{
					return;
				}
				_useLeftHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useRightHand")] 
		public CBool UseRightHand
		{
			get
			{
				if (_useRightHand == null)
				{
					_useRightHand = (CBool) CR2WTypeManager.Create("Bool", "useRightHand", cr2w, this);
				}
				return _useRightHand;
			}
			set
			{
				if (_useRightHand == value)
				{
					return;
				}
				_useRightHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attachRightHandtoLeftHand")] 
		public CBool AttachRightHandtoLeftHand
		{
			get
			{
				if (_attachRightHandtoLeftHand == null)
				{
					_attachRightHandtoLeftHand = (CBool) CR2WTypeManager.Create("Bool", "attachRightHandtoLeftHand", cr2w, this);
				}
				return _attachRightHandtoLeftHand;
			}
			set
			{
				if (_attachRightHandtoLeftHand == value)
				{
					return;
				}
				_attachRightHandtoLeftHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attachLeftHandtoRightHand")] 
		public CBool AttachLeftHandtoRightHand
		{
			get
			{
				if (_attachLeftHandtoRightHand == null)
				{
					_attachLeftHandtoRightHand = (CBool) CR2WTypeManager.Create("Bool", "attachLeftHandtoRightHand", cr2w, this);
				}
				return _attachLeftHandtoRightHand;
			}
			set
			{
				if (_attachLeftHandtoRightHand == value)
				{
					return;
				}
				_attachLeftHandtoRightHand = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lookatStyle")] 
		public CEnum<animLookAtStyle> LookatStyle
		{
			get
			{
				if (_lookatStyle == null)
				{
					_lookatStyle = (CEnum<animLookAtStyle>) CR2WTypeManager.Create("animLookAtStyle", "lookatStyle", cr2w, this);
				}
				return _lookatStyle;
			}
			set
			{
				if (_lookatStyle == value)
				{
					return;
				}
				_lookatStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get
			{
				if (_hasOutTransition == null)
				{
					_hasOutTransition = (CBool) CR2WTypeManager.Create("Bool", "hasOutTransition", cr2w, this);
				}
				return _hasOutTransition;
			}
			set
			{
				if (_hasOutTransition == value)
				{
					return;
				}
				_hasOutTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("outTransitionStyle")] 
		public CEnum<animLookAtStyle> OutTransitionStyle
		{
			get
			{
				if (_outTransitionStyle == null)
				{
					_outTransitionStyle = (CEnum<animLookAtStyle>) CR2WTypeManager.Create("animLookAtStyle", "outTransitionStyle", cr2w, this);
				}
				return _outTransitionStyle;
			}
			set
			{
				if (_outTransitionStyle == value)
				{
					return;
				}
				_outTransitionStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("softLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> SoftLimitDegrees
		{
			get
			{
				if (_softLimitDegrees == null)
				{
					_softLimitDegrees = (CEnum<animLookAtLimitDegreesType>) CR2WTypeManager.Create("animLookAtLimitDegreesType", "softLimitDegrees", cr2w, this);
				}
				return _softLimitDegrees;
			}
			set
			{
				if (_softLimitDegrees == value)
				{
					return;
				}
				_softLimitDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hardLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> HardLimitDegrees
		{
			get
			{
				if (_hardLimitDegrees == null)
				{
					_hardLimitDegrees = (CEnum<animLookAtLimitDegreesType>) CR2WTypeManager.Create("animLookAtLimitDegreesType", "hardLimitDegrees", cr2w, this);
				}
				return _hardLimitDegrees;
			}
			set
			{
				if (_hardLimitDegrees == value)
				{
					return;
				}
				_hardLimitDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hardLimitDistance")] 
		public CEnum<animLookAtLimitDistanceType> HardLimitDistance
		{
			get
			{
				if (_hardLimitDistance == null)
				{
					_hardLimitDistance = (CEnum<animLookAtLimitDistanceType>) CR2WTypeManager.Create("animLookAtLimitDistanceType", "hardLimitDistance", cr2w, this);
				}
				return _hardLimitDistance;
			}
			set
			{
				if (_hardLimitDistance == value)
				{
					return;
				}
				_hardLimitDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("backLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> BackLimitDegrees
		{
			get
			{
				if (_backLimitDegrees == null)
				{
					_backLimitDegrees = (CEnum<animLookAtLimitDegreesType>) CR2WTypeManager.Create("animLookAtLimitDegreesType", "backLimitDegrees", cr2w, this);
				}
				return _backLimitDegrees;
			}
			set
			{
				if (_backLimitDegrees == value)
				{
					return;
				}
				_backLimitDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("additionalParts")] 
		public CArray<animLookAtPartRequest> AdditionalParts
		{
			get
			{
				if (_additionalParts == null)
				{
					_additionalParts = (CArray<animLookAtPartRequest>) CR2WTypeManager.Create("array:animLookAtPartRequest", "additionalParts", cr2w, this);
				}
				return _additionalParts;
			}
			set
			{
				if (_additionalParts == value)
				{
					return;
				}
				_additionalParts = value;
				PropertySet(this);
			}
		}

		public AIActionLookatParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
