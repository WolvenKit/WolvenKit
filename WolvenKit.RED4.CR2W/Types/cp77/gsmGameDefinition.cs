using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmGameDefinition : CResource
	{
		private raRef<questQuestResource> _mainQuest;
		private raRef<worldWorld> _world;
		private raRef<CResource> _streamingWorld;
		private CString _worldName;
		private redTagList _spawnPointTags;

		[Ordinal(1)] 
		[RED("mainQuest")] 
		public raRef<questQuestResource> MainQuest
		{
			get => GetProperty(ref _mainQuest);
			set => SetProperty(ref _mainQuest, value);
		}

		[Ordinal(2)] 
		[RED("world")] 
		public raRef<worldWorld> World
		{
			get => GetProperty(ref _world);
			set => SetProperty(ref _world, value);
		}

		[Ordinal(3)] 
		[RED("streamingWorld")] 
		public raRef<CResource> StreamingWorld
		{
			get => GetProperty(ref _streamingWorld);
			set => SetProperty(ref _streamingWorld, value);
		}

		[Ordinal(4)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get => GetProperty(ref _worldName);
			set => SetProperty(ref _worldName, value);
		}

		[Ordinal(5)] 
		[RED("spawnPointTags")] 
		public redTagList SpawnPointTags
		{
			get => GetProperty(ref _spawnPointTags);
			set => SetProperty(ref _spawnPointTags, value);
		}

		public gsmGameDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
