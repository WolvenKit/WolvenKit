using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workCoverTypeCondition : workIWorkspotCondition
	{
		private CBool _isHighCover;

		[Ordinal(2)] 
		[RED("isHighCover")] 
		public CBool IsHighCover
		{
			get => GetProperty(ref _isHighCover);
			set => SetProperty(ref _isHighCover, value);
		}
	}
}
