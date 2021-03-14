using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnerNotReady_ConditionType : questISpawnerConditionType
	{
		private NodeRef _spawnerReference;
		private CArray<CName> _communityEntryNames;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("communityEntryNames")] 
		public CArray<CName> CommunityEntryNames
		{
			get
			{
				if (_communityEntryNames == null)
				{
					_communityEntryNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "communityEntryNames", cr2w, this);
				}
				return _communityEntryNames;
			}
			set
			{
				if (_communityEntryNames == value)
				{
					return;
				}
				_communityEntryNames = value;
				PropertySet(this);
			}
		}

		public questSpawnerNotReady_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
