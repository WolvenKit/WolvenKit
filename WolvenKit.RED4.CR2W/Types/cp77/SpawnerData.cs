using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnerData : CVariable
	{
		private entEntityID _spawnerID;
		private CArray<CName> _entryNames;

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
		[RED("entryNames")] 
		public CArray<CName> EntryNames
		{
			get
			{
				if (_entryNames == null)
				{
					_entryNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "entryNames", cr2w, this);
				}
				return _entryNames;
			}
			set
			{
				if (_entryNames == value)
				{
					return;
				}
				_entryNames = value;
				PropertySet(this);
			}
		}

		public SpawnerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
