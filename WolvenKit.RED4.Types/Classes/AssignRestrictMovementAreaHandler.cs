using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AssignRestrictMovementAreaHandler : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private CEnum<AIbehaviorCompletionStatus> _resultOnNoChange;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		[Ordinal(1)] 
		[RED("resultOnNoChange")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnNoChange
		{
			get => GetProperty(ref _resultOnNoChange);
			set => SetProperty(ref _resultOnNoChange, value);
		}
	}
}
