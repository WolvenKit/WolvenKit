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
			get => GetProperty(ref _spawnerRef);
			set => SetProperty(ref _spawnerRef, value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CName EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		public StimTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
