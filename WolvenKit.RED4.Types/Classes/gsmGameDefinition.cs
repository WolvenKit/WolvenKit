using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gsmGameDefinition : CResource
	{
		[Ordinal(1)] 
		[RED("mainQuest")] 
		public CResourceAsyncReference<questQuestResource> MainQuest
		{
			get => GetPropertyValue<CResourceAsyncReference<questQuestResource>>();
			set => SetPropertyValue<CResourceAsyncReference<questQuestResource>>(value);
		}

		[Ordinal(2)] 
		[RED("world")] 
		public CResourceAsyncReference<worldWorld> World
		{
			get => GetPropertyValue<CResourceAsyncReference<worldWorld>>();
			set => SetPropertyValue<CResourceAsyncReference<worldWorld>>(value);
		}

		[Ordinal(3)] 
		[RED("streamingWorld")] 
		public CResourceAsyncReference<CResource> StreamingWorld
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(4)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("spawnPointTags")] 
		public redTagList SpawnPointTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public gsmGameDefinition()
		{
			SpawnPointTags = new() { Tags = new() };
		}
	}
}
