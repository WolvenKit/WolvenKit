using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetMultiplayerHeistSpawnPointTag_NodeType : questIMultiplayerHeistNodeType
	{
		private CName _spawnPointTag;

		[Ordinal(0)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get => GetProperty(ref _spawnPointTag);
			set => SetProperty(ref _spawnPointTag, value);
		}

		public questSetMultiplayerHeistSpawnPointTag_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
