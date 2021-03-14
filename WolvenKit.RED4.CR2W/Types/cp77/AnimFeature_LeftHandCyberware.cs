using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LeftHandCyberware : animAnimFeature
	{
		private CFloat _actionDuration;
		private CInt32 _state;
		private CBool _isQuickAction;
		private CBool _isChargeAction;
		private CBool _isLoopAction;
		private CBool _isCatchAction;
		private CBool _isSafeAction;

		[Ordinal(0)] 
		[RED("actionDuration")] 
		public CFloat ActionDuration
		{
			get
			{
				if (_actionDuration == null)
				{
					_actionDuration = (CFloat) CR2WTypeManager.Create("Float", "actionDuration", cr2w, this);
				}
				return _actionDuration;
			}
			set
			{
				if (_actionDuration == value)
				{
					return;
				}
				_actionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isQuickAction")] 
		public CBool IsQuickAction
		{
			get
			{
				if (_isQuickAction == null)
				{
					_isQuickAction = (CBool) CR2WTypeManager.Create("Bool", "isQuickAction", cr2w, this);
				}
				return _isQuickAction;
			}
			set
			{
				if (_isQuickAction == value)
				{
					return;
				}
				_isQuickAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isChargeAction")] 
		public CBool IsChargeAction
		{
			get
			{
				if (_isChargeAction == null)
				{
					_isChargeAction = (CBool) CR2WTypeManager.Create("Bool", "isChargeAction", cr2w, this);
				}
				return _isChargeAction;
			}
			set
			{
				if (_isChargeAction == value)
				{
					return;
				}
				_isChargeAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isLoopAction")] 
		public CBool IsLoopAction
		{
			get
			{
				if (_isLoopAction == null)
				{
					_isLoopAction = (CBool) CR2WTypeManager.Create("Bool", "isLoopAction", cr2w, this);
				}
				return _isLoopAction;
			}
			set
			{
				if (_isLoopAction == value)
				{
					return;
				}
				_isLoopAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isCatchAction")] 
		public CBool IsCatchAction
		{
			get
			{
				if (_isCatchAction == null)
				{
					_isCatchAction = (CBool) CR2WTypeManager.Create("Bool", "isCatchAction", cr2w, this);
				}
				return _isCatchAction;
			}
			set
			{
				if (_isCatchAction == value)
				{
					return;
				}
				_isCatchAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isSafeAction")] 
		public CBool IsSafeAction
		{
			get
			{
				if (_isSafeAction == null)
				{
					_isSafeAction = (CBool) CR2WTypeManager.Create("Bool", "isSafeAction", cr2w, this);
				}
				return _isSafeAction;
			}
			set
			{
				if (_isSafeAction == value)
				{
					return;
				}
				_isSafeAction = value;
				PropertySet(this);
			}
		}

		public AnimFeature_LeftHandCyberware(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
