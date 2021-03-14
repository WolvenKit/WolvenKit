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
			get
			{
				if (_mainQuest == null)
				{
					_mainQuest = (raRef<questQuestResource>) CR2WTypeManager.Create("raRef:questQuestResource", "mainQuest", cr2w, this);
				}
				return _mainQuest;
			}
			set
			{
				if (_mainQuest == value)
				{
					return;
				}
				_mainQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("world")] 
		public raRef<worldWorld> World
		{
			get
			{
				if (_world == null)
				{
					_world = (raRef<worldWorld>) CR2WTypeManager.Create("raRef:worldWorld", "world", cr2w, this);
				}
				return _world;
			}
			set
			{
				if (_world == value)
				{
					return;
				}
				_world = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("streamingWorld")] 
		public raRef<CResource> StreamingWorld
		{
			get
			{
				if (_streamingWorld == null)
				{
					_streamingWorld = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "streamingWorld", cr2w, this);
				}
				return _streamingWorld;
			}
			set
			{
				if (_streamingWorld == value)
				{
					return;
				}
				_streamingWorld = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get
			{
				if (_worldName == null)
				{
					_worldName = (CString) CR2WTypeManager.Create("String", "worldName", cr2w, this);
				}
				return _worldName;
			}
			set
			{
				if (_worldName == value)
				{
					return;
				}
				_worldName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("spawnPointTags")] 
		public redTagList SpawnPointTags
		{
			get
			{
				if (_spawnPointTags == null)
				{
					_spawnPointTags = (redTagList) CR2WTypeManager.Create("redTagList", "spawnPointTags", cr2w, this);
				}
				return _spawnPointTags;
			}
			set
			{
				if (_spawnPointTags == value)
				{
					return;
				}
				_spawnPointTags = value;
				PropertySet(this);
			}
		}

		public gsmGameDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
