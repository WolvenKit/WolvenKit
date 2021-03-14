using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnSet_NodeType : questSpawnManagerNodeType
	{
		private NodeRef _reference;
		private CName _entryName;
		private CName _phaseName;

		[Ordinal(1)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get
			{
				if (_reference == null)
				{
					_reference = (NodeRef) CR2WTypeManager.Create("NodeRef", "reference", cr2w, this);
				}
				return _reference;
			}
			set
			{
				if (_reference == value)
				{
					return;
				}
				_reference = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get
			{
				if (_phaseName == null)
				{
					_phaseName = (CName) CR2WTypeManager.Create("CName", "phaseName", cr2w, this);
				}
				return _phaseName;
			}
			set
			{
				if (_phaseName == value)
				{
					return;
				}
				_phaseName = value;
				PropertySet(this);
			}
		}

		public questSpawnSet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
