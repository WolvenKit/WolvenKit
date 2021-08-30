using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetMultiplayerHeistSpawnPointTag_NodeType : questIMultiplayerHeistNodeType
	{
		private CName _spawnPointTag;

		[Ordinal(0)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get => GetProperty(ref _spawnPointTag);
			set => SetProperty(ref _spawnPointTag, value);
		}

		public questSetMultiplayerHeistSpawnPointTag_NodeType()
		{
			_spawnPointTag = "heist";
		}
	}
}
