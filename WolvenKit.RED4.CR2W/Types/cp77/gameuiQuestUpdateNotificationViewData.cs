using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		private CString _questEntryId;
		private CBool _canBeMerged;
		private CName _animation;
		private CString _sMSText;
		private CBool _dontRemoveOnRequest;
		private CInt32 _entryHash;
		private CInt32 _rewardSC;
		private CInt32 _rewardXP;
		private CEnum<EGenericNotificationPriority> _priority;

		[Ordinal(5)] 
		[RED("questEntryId")] 
		public CString QuestEntryId
		{
			get => GetProperty(ref _questEntryId);
			set => SetProperty(ref _questEntryId, value);
		}

		[Ordinal(6)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		[Ordinal(7)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(8)] 
		[RED("SMSText")] 
		public CString SMSText
		{
			get => GetProperty(ref _sMSText);
			set => SetProperty(ref _sMSText, value);
		}

		[Ordinal(9)] 
		[RED("dontRemoveOnRequest")] 
		public CBool DontRemoveOnRequest
		{
			get => GetProperty(ref _dontRemoveOnRequest);
			set => SetProperty(ref _dontRemoveOnRequest, value);
		}

		[Ordinal(10)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetProperty(ref _entryHash);
			set => SetProperty(ref _entryHash, value);
		}

		[Ordinal(11)] 
		[RED("rewardSC")] 
		public CInt32 RewardSC
		{
			get => GetProperty(ref _rewardSC);
			set => SetProperty(ref _rewardSC, value);
		}

		[Ordinal(12)] 
		[RED("rewardXP")] 
		public CInt32 RewardXP
		{
			get => GetProperty(ref _rewardXP);
			set => SetProperty(ref _rewardXP, value);
		}

		[Ordinal(13)] 
		[RED("priority")] 
		public CEnum<EGenericNotificationPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		public gameuiQuestUpdateNotificationViewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
