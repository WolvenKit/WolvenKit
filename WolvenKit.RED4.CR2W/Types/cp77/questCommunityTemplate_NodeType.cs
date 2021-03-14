using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCommunityTemplate_NodeType : questSpawnManagerNodeType
	{
		private NodeRef _spawnerReference;
		private CName _communityEntryName;
		private CName _communityEntryPhaseName;

		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get
			{
				if (_spawnerReference == null)
				{
					_spawnerReference = (NodeRef) CR2WTypeManager.Create("NodeRef", "spawnerReference", cr2w, this);
				}
				return _spawnerReference;
			}
			set
			{
				if (_spawnerReference == value)
				{
					return;
				}
				_spawnerReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("communityEntryName")] 
		public CName CommunityEntryName
		{
			get
			{
				if (_communityEntryName == null)
				{
					_communityEntryName = (CName) CR2WTypeManager.Create("CName", "communityEntryName", cr2w, this);
				}
				return _communityEntryName;
			}
			set
			{
				if (_communityEntryName == value)
				{
					return;
				}
				_communityEntryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("communityEntryPhaseName")] 
		public CName CommunityEntryPhaseName
		{
			get
			{
				if (_communityEntryPhaseName == null)
				{
					_communityEntryPhaseName = (CName) CR2WTypeManager.Create("CName", "communityEntryPhaseName", cr2w, this);
				}
				return _communityEntryPhaseName;
			}
			set
			{
				if (_communityEntryPhaseName == value)
				{
					return;
				}
				_communityEntryPhaseName = value;
				PropertySet(this);
			}
		}

		public questCommunityTemplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
