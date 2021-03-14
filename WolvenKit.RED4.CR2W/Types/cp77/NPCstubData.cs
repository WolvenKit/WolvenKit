using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCstubData : CVariable
	{
		private entEntityID _spawnerID;
		private CName _entryID;

		[Ordinal(0)] 
		[RED("spawnerID")] 
		public entEntityID SpawnerID
		{
			get
			{
				if (_spawnerID == null)
				{
					_spawnerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "spawnerID", cr2w, this);
				}
				return _spawnerID;
			}
			set
			{
				if (_spawnerID == value)
				{
					return;
				}
				_spawnerID = value;
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

		public NPCstubData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
