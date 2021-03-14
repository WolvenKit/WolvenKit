using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimTargetData : CVariable
	{
		private NodeRef _spawnerRef;
		private CName _entryID;

		[Ordinal(0)] 
		[RED("spawnerRef")] 
		public NodeRef SpawnerRef
		{
			get
			{
				if (_spawnerRef == null)
				{
					_spawnerRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "spawnerRef", cr2w, this);
				}
				return _spawnerRef;
			}
			set
			{
				if (_spawnerRef == value)
				{
					return;
				}
				_spawnerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CName EntryID
		{
			get
			{
				if (_entryID == null)
				{
					_entryID = (CName) CR2WTypeManager.Create("CName", "entryID", cr2w, this);
				}
				return _entryID;
			}
			set
			{
				if (_entryID == value)
				{
					return;
				}
				_entryID = value;
				PropertySet(this);
			}
		}

		public StimTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
