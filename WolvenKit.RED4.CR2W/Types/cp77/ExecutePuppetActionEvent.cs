using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExecutePuppetActionEvent : redEvent
	{
		private TweakDBID _actionID;
		private CHandle<PuppetAction> _action;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CHandle<PuppetAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<PuppetAction>) CR2WTypeManager.Create("handle:PuppetAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public ExecutePuppetActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
