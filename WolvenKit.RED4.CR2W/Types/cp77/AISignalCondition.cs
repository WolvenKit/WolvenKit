using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISignalCondition : AIbehaviorconditionScript
	{
		private CArray<CEnum<AISignalFlags>> _requiredFlags;
		private CBool _consumesSignal;
		private CBool _activated;
		private AIGateSignal _executingSignal;
		private CUInt32 _executingSignalId;

		[Ordinal(0)] 
		[RED("requiredFlags")] 
		public CArray<CEnum<AISignalFlags>> RequiredFlags
		{
			get
			{
				if (_requiredFlags == null)
				{
					_requiredFlags = (CArray<CEnum<AISignalFlags>>) CR2WTypeManager.Create("array:AISignalFlags", "requiredFlags", cr2w, this);
				}
				return _requiredFlags;
			}
			set
			{
				if (_requiredFlags == value)
				{
					return;
				}
				_requiredFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("consumesSignal")] 
		public CBool ConsumesSignal
		{
			get
			{
				if (_consumesSignal == null)
				{
					_consumesSignal = (CBool) CR2WTypeManager.Create("Bool", "consumesSignal", cr2w, this);
				}
				return _consumesSignal;
			}
			set
			{
				if (_consumesSignal == value)
				{
					return;
				}
				_consumesSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get
			{
				if (_activated == null)
				{
					_activated = (CBool) CR2WTypeManager.Create("Bool", "activated", cr2w, this);
				}
				return _activated;
			}
			set
			{
				if (_activated == value)
				{
					return;
				}
				_activated = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("executingSignal")] 
		public AIGateSignal ExecutingSignal
		{
			get
			{
				if (_executingSignal == null)
				{
					_executingSignal = (AIGateSignal) CR2WTypeManager.Create("AIGateSignal", "executingSignal", cr2w, this);
				}
				return _executingSignal;
			}
			set
			{
				if (_executingSignal == value)
				{
					return;
				}
				_executingSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("executingSignalId")] 
		public CUInt32 ExecutingSignalId
		{
			get
			{
				if (_executingSignalId == null)
				{
					_executingSignalId = (CUInt32) CR2WTypeManager.Create("Uint32", "executingSignalId", cr2w, this);
				}
				return _executingSignalId;
			}
			set
			{
				if (_executingSignalId == value)
				{
					return;
				}
				_executingSignalId = value;
				PropertySet(this);
			}
		}

		public AISignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
