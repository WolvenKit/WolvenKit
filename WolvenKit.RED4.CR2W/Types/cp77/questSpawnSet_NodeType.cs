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
			get => GetProperty(ref _reference);
			set => SetProperty(ref _reference, value);
		}

		[Ordinal(2)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(3)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get => GetProperty(ref _phaseName);
			set => SetProperty(ref _phaseName, value);
		}

		public questSpawnSet_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
