using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRootHudSaveData : ISerializable
	{
		private CArray<questHUDEntryVisibilityData> _entriesVisibility;

		[Ordinal(0)] 
		[RED("entriesVisibility")] 
		public CArray<questHUDEntryVisibilityData> EntriesVisibility
		{
			get => GetProperty(ref _entriesVisibility);
			set => SetProperty(ref _entriesVisibility, value);
		}

		public gameuiRootHudSaveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
