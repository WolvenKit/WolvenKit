using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questChangeGameDifficulty_NodeSubType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] 
		[RED("difficulty")] 
		public CEnum<gameDifficulty> Difficulty
		{
			get => GetPropertyValue<CEnum<gameDifficulty>>();
			set => SetPropertyValue<CEnum<gameDifficulty>>(value);
		}

		public questChangeGameDifficulty_NodeSubType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
