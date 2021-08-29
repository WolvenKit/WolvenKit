using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MoveToCoverCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private CBool _releaseSignalOnCoverEnter;
		private CBool _useSpecialAction;
		private CBool _useHigh;
		private CBool _useLeft;
		private CBool _useRight;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		[Ordinal(1)] 
		[RED("releaseSignalOnCoverEnter")] 
		public CBool ReleaseSignalOnCoverEnter
		{
			get => GetProperty(ref _releaseSignalOnCoverEnter);
			set => SetProperty(ref _releaseSignalOnCoverEnter, value);
		}

		[Ordinal(2)] 
		[RED("useSpecialAction")] 
		public CBool UseSpecialAction
		{
			get => GetProperty(ref _useSpecialAction);
			set => SetProperty(ref _useSpecialAction, value);
		}

		[Ordinal(3)] 
		[RED("useHigh")] 
		public CBool UseHigh
		{
			get => GetProperty(ref _useHigh);
			set => SetProperty(ref _useHigh, value);
		}

		[Ordinal(4)] 
		[RED("useLeft")] 
		public CBool UseLeft
		{
			get => GetProperty(ref _useLeft);
			set => SetProperty(ref _useLeft, value);
		}

		[Ordinal(5)] 
		[RED("useRight")] 
		public CBool UseRight
		{
			get => GetProperty(ref _useRight);
			set => SetProperty(ref _useRight, value);
		}
	}
}
