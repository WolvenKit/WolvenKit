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
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<CHandle<communitySpawnEntry>>) CR2WTypeManager.Create("array:handle:communitySpawnEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("crowdEntries")] 
		public CArray<gameCrowdTemplateEntry> CrowdEntries
		{
			get
			{
				if (_crowdEntries == null)
				{
					_crowdEntries = (CArray<gameCrowdTemplateEntry>) CR2WTypeManager.Create("array:gameCrowdTemplateEntry", "crowdEntries", cr2w, this);
				}
				return _crowdEntries;
			}
			set
			{
				if (_crowdEntries == value)
				{
					return;
				}
				_crowdEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnSetReference")] 
		public CName SpawnSetReference
		{
			get
			{
				if (_spawnSetReference == null)
				{
					_spawnSetReference = (CName) CR2WTypeManager.Create("CName", "spawnSetReference", cr2w, this);
				}
				return _spawnSetReference;
			}
			set
			{
				if (_spawnSetReference == value)
				{
					return;
				}
				_spawnSetReference = value;
				PropertySet(this);
			}
		}

		public communityCommunityTemplateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
