using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TweakAIActionConditionAbstract : AIbehaviorconditionScript
	{
		private CWeakHandle<gamedataAIAction_Record> _actionRecord;
		private CString _actionDebugName;

		[Ordinal(0)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataAIAction_Record> ActionRecord
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
	}
}
