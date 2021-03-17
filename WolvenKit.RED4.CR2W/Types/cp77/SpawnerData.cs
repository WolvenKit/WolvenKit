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
			get => GetProperty(ref _spawnerID);
			set => SetProperty(ref _spawnerID, value);
		}

		[Ordinal(1)] 
		[RED("entryNames")] 
		public CArray<CName> EntryNames
		{
			get => GetProperty(ref _entryNames);
			set => SetProperty(ref _entryNames, value);
		}

		public SpawnerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
