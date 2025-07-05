using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFinalBoardsLoadPonRSave_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("loadPointOfNoReturnSave")] 
		public CBool LoadPointOfNoReturnSave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questFinalBoardsLoadPonRSave_NodeType()
		{
			LoadPointOfNoReturnSave = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
