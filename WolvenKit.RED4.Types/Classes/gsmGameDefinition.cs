using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmGameDefinition : CResource
	{
		private CResourceAsyncReference<questQuestResource> _mainQuest;
		private CResourceAsyncReference<worldWorld> _world;
		private CResourceAsyncReference<CResource> _streamingWorld;
		private CString _worldName;
		private redTagList _spawnPointTags;

		[Ordinal(1)] 
		[RED("mainQuest")] 
		public CResourceAsyncReference<questQuestResource> MainQuest
		{
			get => GetProperty(ref _mainQuest);
			set => SetProperty(ref _mainQuest, value);
		}

		[Ordinal(2)] 
		[RED("world")] 
		public CResourceAsyncReference<worldWorld> World
		{
			get => GetProperty(ref _world);
			set => SetProperty(ref _world, value);
		}

		[Ordinal(3)] 
		[RED("streamingWorld")] 
		public CResourceAsyncReference<CResource> StreamingWorld
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
	}
}
