using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeCompleteImmediatelyDefinition : AICTreeNodeAtomicDefinition
	{
		private CBool _completeWithSuccess;

		[Ordinal(0)] 
		[RED("completeWithSuccess")] 
		public CBool CompleteWithSuccess
		{
			get => GetProperty(ref _completeWithSuccess);
			set => SetProperty(ref _completeWithSuccess, value);
		}
	}
}
