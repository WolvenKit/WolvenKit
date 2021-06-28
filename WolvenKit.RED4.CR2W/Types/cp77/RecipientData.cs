using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RecipientData : CVariable
	{
		private CInt32 _fuseID;
		private CInt32 _entryID;

		[Ordinal(0)] 
		[RED("fuseID")] 
		public CInt32 FuseID
		{
			get => GetProperty(ref _fuseID);
			set => SetProperty(ref _fuseID, value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CInt32 EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		public RecipientData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
