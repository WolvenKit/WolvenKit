using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityCommunityTemplateData : ISerializable
	{
		private CArray<CHandle<communitySpawnEntry>> _entries;
		private CArray<gameCrowdTemplateEntry> _crowdEntries;
		private CName _spawnSetReference;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CHandle<communitySpawnEntry>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(1)] 
		[RED("crowdEntries")] 
		public CArray<gameCrowdTemplateEntry> CrowdEntries
		{
			get => GetProperty(ref _crowdEntries);
			set => SetProperty(ref _crowdEntries, value);
		}

		[Ordinal(2)] 
		[RED("spawnSetReference")] 
		public CName SpawnSetReference
		{
			get => GetProperty(ref _spawnSetReference);
			set => SetProperty(ref _spawnSetReference, value);
		}

		public communityCommunityTemplateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
