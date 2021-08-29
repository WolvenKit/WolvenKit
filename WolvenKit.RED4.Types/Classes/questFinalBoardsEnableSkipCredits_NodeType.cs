using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFinalBoardsEnableSkipCredits_NodeType : questIUIManagerNodeType
	{
		private CBool _enableSkipping;

		[Ordinal(0)] 
		[RED("enableSkipping")] 
		public CBool EnableSkipping
		{
			get => GetProperty(ref _enableSkipping);
			set => SetProperty(ref _enableSkipping, value);
		}
	}
}
