using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBehaviorCallbackExpression : AIbehaviorexpressionScript
	{
		private CName _callbackName;
		private CBool _initialValue;
		private CEnum<ECallbackExpressionActions> _callbackAction;
		private CUInt32 _callbackId;
		private CBool _value;

		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get
			{
				if (_callbackName == null)
				{
					_callbackName = (CName) CR2WTypeManager.Create("CName", "callbackName", cr2w, this);
				}
				return _callbackName;
			}
			set
			{
				if (_callbackName == value)
				{
					return;
				}
				_callbackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("initialValue")] 
		public CBool InitialValue
		{
			get
			{
				if (_initialValue == null)
				{
					_initialValue = (CBool) CR2WTypeManager.Create("Bool", "initialValue", cr2w, this);
				}
				return _initialValue;
			}
			set
			{
				if (_initialValue == value)
				{
					return;
				}
				_initialValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("callbackAction")] 
		public CEnum<ECallbackExpressionActions> CallbackAction
		{
			get
			{
				if (_callbackAction == null)
				{
					_callbackAction = (CEnum<ECallbackExpressionActions>) CR2WTypeManager.Create("ECallbackExpressionActions", "callbackAction", cr2w, this);
				}
				return _callbackAction;
			}
			set
			{
				if (_callbackAction == value)
				{
					return;
				}
				_callbackAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get
			{
				if (_callbackId == null)
				{
					_callbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackId", cr2w, this);
				}
				return _callbackId;
			}
			set
			{
				if (_callbackId == value)
				{
					return;
				}
				_callbackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("value")] 
		public CBool Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CBool) CR2WTypeManager.Create("Bool", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public AIBehaviorCallbackExpression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
