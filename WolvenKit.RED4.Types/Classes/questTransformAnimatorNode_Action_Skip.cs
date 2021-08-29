using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTransformAnimatorNode_Action_Skip : questTransformAnimatorNode_ActionType
	{
		private CFloat _skipTo;
		private CBool _skipToEnd;

		[Ordinal(0)] 
		[RED("skipTo")] 
		public CFloat SkipTo
		{
			get => GetProperty(ref _skipTo);
			set => SetProperty(ref _skipTo, value);
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetProperty(ref _skipToEnd);
			set => SetProperty(ref _skipToEnd, value);
		}
	}
}
