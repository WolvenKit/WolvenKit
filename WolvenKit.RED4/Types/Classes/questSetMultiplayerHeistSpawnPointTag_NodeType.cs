using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetMultiplayerHeistSpawnPointTag_NodeType : questIMultiplayerHeistNodeType
	{
		[Ordinal(0)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetMultiplayerHeistSpawnPointTag_NodeType()
		{
			SpawnPointTag = "heist";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
