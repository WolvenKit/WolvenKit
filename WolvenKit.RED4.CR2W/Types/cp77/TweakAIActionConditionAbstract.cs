using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionConditionAbstract : AIbehaviorconditionScript
	{
		private wCHandle<gamedataAIAction_Record> _actionRecord;
		private CString _actionDebugName;

		[Ordinal(0)] 
		[RED("actionRecord")] 
		public wCHandle<gamedataAIAction_Record> ActionRecord
		{
			get
			{
				if (_actionRecord == null)
				{
					_actionRecord = (wCHandle<gamedataAIAction_Record>) CR2WTypeManager.Create("whandle:gamedataAIAction_Record", "actionRecord", cr2w, this);
				}
				return _actionRecord;
			}
			set
			{
				if (_actionRecord == value)
				{
					return;
				}
				_actionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get
			{
				if (_actionDebugName == null)
				{
					_actionDebugName = (CString) CR2WTypeManager.Create("String", "actionDebugName", cr2w, this);
				}
				return _actionDebugName;
			}
			set
			{
				if (_actionDebugName == value)
				{
					return;
				}
				_actionDebugName = value;
				PropertySet(this);
			}
		}

		public TweakAIActionConditionAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
