using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintData : CVariable
	{
		private CName _action;
		private CName _source;
		private CName _groupId;
		private CName _tutorialAction;
		private CString _localizedLabel;
		private CInt32 _queuePriority;
		private CInt32 _sortingPriority;
		private CInt32 _tutorialActionCount;
		private CEnum<inkInputHintHoldIndicationType> _holdIndicationType;
		private CBool _enableHoldAnimation;

		[Ordinal(0)] 
		[RED("action")] 
		public CName Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(2)] 
		[RED("groupId")] 
		public CName GroupId
		{
			get => GetProperty(ref _groupId);
			set => SetProperty(ref _groupId, value);
		}

		[Ordinal(3)] 
		[RED("tutorialAction")] 
		public CName TutorialAction
		{
			get => GetProperty(ref _tutorialAction);
			set => SetProperty(ref _tutorialAction, value);
		}

		[Ordinal(4)] 
		[RED("localizedLabel")] 
		public CString LocalizedLabel
		{
			get => GetProperty(ref _localizedLabel);
			set => SetProperty(ref _localizedLabel, value);
		}

		[Ordinal(5)] 
		[RED("queuePriority")] 
		public CInt32 QueuePriority
		{
			get => GetProperty(ref _queuePriority);
			set => SetProperty(ref _queuePriority, value);
		}

		[Ordinal(6)] 
		[RED("sortingPriority")] 
		public CInt32 SortingPriority
		{
			get => GetProperty(ref _sortingPriority);
			set => SetProperty(ref _sortingPriority, value);
		}

		[Ordinal(7)] 
		[RED("tutorialActionCount")] 
		public CInt32 TutorialActionCount
		{
			get => GetProperty(ref _tutorialActionCount);
			set => SetProperty(ref _tutorialActionCount, value);
		}

		[Ordinal(8)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get => GetProperty(ref _holdIndicationType);
			set => SetProperty(ref _holdIndicationType, value);
		}

		[Ordinal(9)] 
		[RED("enableHoldAnimation")] 
		public CBool EnableHoldAnimation
		{
			get => GetProperty(ref _enableHoldAnimation);
			set => SetProperty(ref _enableHoldAnimation, value);
		}

		public gameuiInputHintData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
