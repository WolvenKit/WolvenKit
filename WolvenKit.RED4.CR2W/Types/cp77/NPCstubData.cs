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
			get => GetProperty(ref _spawnerID);
			set => SetProperty(ref _spawnerID, value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CName EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		public NPCstubData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
