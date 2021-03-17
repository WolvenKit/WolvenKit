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
			get => GetProperty(ref _actionRecord);
			set => SetProperty(ref _actionRecord, value);
		}

		[Ordinal(1)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get => GetProperty(ref _actionDebugName);
			set => SetProperty(ref _actionDebugName, value);
		}

		public TweakAIActionConditionAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
