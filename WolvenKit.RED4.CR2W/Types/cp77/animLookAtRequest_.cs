using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtRequest_ : CVariable
	{
		private CFloat _transitionSpeed;
		private CBool _hasOutTransition;
		private CFloat _outTransitionSpeed;
		private CFloat _followingSpeedFactorOverride;
		private animLookAtLimits _limits;
		private CFloat _suppress;
		private CInt32 _mode;
		private CBool _calculatePositionInParentSpace;
		private CInt32 _priority;
		private CStatic<animLookAtPartRequest> _additionalParts;
		private CBool _invalid;

		[Ordinal(0)] 
		[RED("transitionSpeed")] 
		public CFloat TransitionSpeed
		{
			get
			{
				if (_transitionSpeed == null)
				{
					_transitionSpeed = (CFloat) CR2WTypeManager.Create("Float", "transitionSpeed", cr2w, this);
				}
				return _transitionSpeed;
			}
			set
			{
				if (_transitionSpeed == value)
				{
					return;
				}
				_transitionSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get
			{
				if (_outTransitionSpeed == null)
				{
					_outTransitionSpeed = (CFloat) CR2WTypeManager.Create("Float", "outTransitionSpeed", cr2w, this);
				}
				return _outTransitionSpeed;
			}
			set
			{
				if (_outTransitionSpeed == value)
				{
					return;
				}
				_outTransitionSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("followingSpeedFactorOverride")] 
		public CFloat FollowingSpeedFactorOverride
		{
			get
			{
				if (_followingSpeedFactorOverride == null)
				{
					_followingSpeedFactorOverride = (CFloat) CR2WTypeManager.Create("Float", "followingSpeedFactorOverride", cr2w, this);
				}
				return _followingSpeedFactorOverride;
			}
			set
			{
				if (_followingSpeedFactorOverride == value)
				{
					return;
				}
				_followingSpeedFactorOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get
			{
				if (_limits == null)
				{
					_limits = (animLookAtLimits) CR2WTypeManager.Create("animLookAtLimits", "limits", cr2w, this);
				}
				return _limits;
			}
			set
			{
				if (_limits == value)
				{
					return;
				}
				_limits = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get
			{
				if (_suppress == null)
				{
					_suppress = (CFloat) CR2WTypeManager.Create("Float", "suppress", cr2w, this);
				}
				return _suppress;
			}
			set
			{
				if (_suppress == value)
				{
					return;
				}
				_suppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CInt32) CR2WTypeManager.Create("Int32", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("calculatePositionInParentSpace")] 
		public CBool CalculatePositionInParentSpace
		{
			get
			{
				if (_calculatePositionInParentSpace == null)
				{
					_calculatePositionInParentSpace = (CBool) CR2WTypeManager.Create("Bool", "calculatePositionInParentSpace", cr2w, this);
				}
				return _calculatePositionInParentSpace;
			}
			set
			{
				if (_calculatePositionInParentSpace == value)
				{
					return;
				}
				_calculatePositionInParentSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("additionalParts", 2)] 
		public CStatic<animLookAtPartRequest> AdditionalParts
		{
			get
			{
				if (_additionalParts == null)
				{
					_additionalParts = (CStatic<animLookAtPartRequest>) CR2WTypeManager.Create("static:2,animLookAtPartRequest", "additionalParts", cr2w, this);
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

		[Ordinal(10)] 
		[RED("invalid")] 
		public CBool Invalid
		{
			get
			{
				if (_invalid == null)
				{
					_invalid = (CBool) CR2WTypeManager.Create("Bool", "invalid", cr2w, this);
				}
				return _invalid;
			}
			set
			{
				if (_invalid == value)
				{
					return;
				}
				_invalid = value;
				PropertySet(this);
			}
		}

		public animLookAtRequest_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
