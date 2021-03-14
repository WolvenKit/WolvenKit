using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCReference : CVariable
	{
		private NodeRef _communitySpawner;
		private CName _entryName;

		[Ordinal(0)] 
		[RED("communitySpawner")] 
		public NodeRef CommunitySpawner
		{
			get
			{
				if (_communitySpawner == null)
				{
					_communitySpawner = (NodeRef) CR2WTypeManager.Create("NodeRef", "communitySpawner", cr2w, this);
				}
				return _communitySpawner;
			}
			set
			{
				if (_communitySpawner == value)
				{
					return;
				}
				_communitySpawner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (CName) CR2WTypeManager.Create("CName", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		public NPCReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
