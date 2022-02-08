using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFinalBoardsEnableSkipCredits_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("enableSkipping")] 
		public CBool EnableSkipping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questFinalBoardsEnableSkipCredits_NodeType()
		{
			EnableSkipping = true;
		}
	}
}
